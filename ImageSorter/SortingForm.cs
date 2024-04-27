using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace ImageSorter
{
    public partial class SortingForm : Form
    {
        List<string> extensions;

        List<string> paths;

        private int currentIndex;
        private string currentPath => (currentIndex >= 0 && currentIndex < paths.Count) ? paths[currentIndex] : "";

        private string rootFolderPath => RootFolderTextBox.Text;
        private string destinationFolderPath = "";
        private string destinationFilePath => Path.Combine(destinationFolderPath, Path.GetFileName(currentPath));

        readonly Form parentForm;

        public SortingForm(Form parent, string directoryPath, string[] extensionsToSearchFor)
        {
            InitializeComponent();

            parentForm = parent;

            extensions = new List<string>(extensionsToSearchFor.Length * 2);
            foreach (string extension in extensionsToSearchFor)
            {
                if (string.IsNullOrWhiteSpace(extension))
                {
                    continue;
                }

                // add upper and lower variants of extension
                extensions.Add(extension.ToLower());
                extensions.Add(extension.ToUpper());
            }

            paths = new List<string>();

            // generate paths
            CollectImagePaths(directoryPath);

            LoadImage(0);

            // default directory to sort is Pictures
            RootFolderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void SetDestination(string path)
        {
            destinationFolderPath = path;
            DestinationLabel.Text = $"Destination: {destinationFolderPath}";

            bool validDestination = !string.IsNullOrWhiteSpace(destinationFolderPath);

            MoveButton.Enabled = validDestination;
            CopyButton.Enabled = validDestination;
        }

        private void SetTitle(string path)
        {
            // set form title
            Text = $"Sorting: {path}";

            // set image title
            if (currentIndex >= 0 && currentIndex <= paths.Count)
            {
                ImageGroupBox.Text = $"{Path.GetFileName(path)} ({currentIndex}/{paths.Count})";
            }
            else
            {
                ImageGroupBox.Text = $"{Path.GetFileName(path)}";
            }
        }

        private void LoadImage(int index)
        {
            currentIndex = index;

            PreviewPictureBox.ImageLocation = currentPath;

            SetTitle(currentPath);
        }

        public void RenameCurrentImage(string name)
        {
            string path = Path.Combine(new FileInfo(currentPath).Directory?.FullName ?? "", name + Path.GetExtension(currentPath));

            paths.RemoveAt(currentIndex);
            paths.Insert(currentIndex, path);
        }

        public void MoveCurrentImage()
        {
            if (!File.Exists(currentPath) || !Directory.Exists(destinationFolderPath))
            {
                // no file or no destination
                return;
            }

            if (CheckForDuplicate())
            {
                return;
            }

            try
            {
                File.Move(currentPath, destinationFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The system failed to move the file.\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DoneWithCurrentImage();
        }

        public void CopyCurrentImage()
        {
            if (!File.Exists(currentPath) || !Directory.Exists(destinationFolderPath))
            {
                // no file or no destination
                return;
            }

            if (CheckForDuplicate())
            {
                return;
            }

            try
            {
                File.Copy(currentPath, Path.Combine(destinationFolderPath, Path.GetFileName(currentPath)));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The system failed to copy the file.\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DoneWithCurrentImage();
        }

        public void DeleteCurrentImage()
        {
            if (!File.Exists(currentPath))
            {
                // no file or no destination
                return;
            }

            try
            {
                File.Delete(currentPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The system failed to delete the file.\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DoneWithCurrentImage();
        }

        public void IgnoreCurrentImage()
        {
            DoneWithCurrentImage();
        }

        private void DoneWithCurrentImage()
        {
            // done with file
            paths.RemoveAt(currentIndex);

            // if no more paths, all done
            if (paths.Count > 0)
            {
                // not done
                LoadImage(currentIndex % paths.Count);
                return;
            }
            else
            {
                LoadImage(-1);
            }

            // done
            MessageBox.Show("All images have been sorted.");

            Close();
        }

        /// <summary>
        /// Checks for a duplicate.
        /// </summary>
        /// <returns></returns>
        private bool CheckForDuplicate()
        {
            if (File.Exists(currentPath) && File.Exists(destinationFilePath))
            {
                // destination exists, and source
                DuplicateForm form = new DuplicateForm(this, currentPath, destinationFilePath);
                DialogResult result = form.ShowDialog();

                // if OK, there is no problem, so do not worry about duplicate anymore
                return result != DialogResult.OK;
            }

            // no duplicate, so continue
            return false;
        }

        private void CollectImagePaths(string directoryPath)
        {
            // get files in this directory
            foreach (string path in Directory.GetFiles(directoryPath))
            {
                foreach (string extension in extensions)
                {
                    if (Path.GetExtension(path) == extension)
                    {
                        // valid extension for this file, add it
                        paths.Add(path);
                    }
                }
            }

            foreach (string path in Directory.GetDirectories(directoryPath))
            {
                CollectImagePaths(path);
            }
        }

        private void GenerateFolderTree()
        {
            // remove old data
            FolderTreeView.Nodes.Clear();
            SetDestination("");

            if (!Directory.Exists(rootFolderPath))
            {
                // no directory at path
                return;
            }

            // directory, so load all into nodes
            TreeNode root = new TreeNode(Path.GetFileNameWithoutExtension(rootFolderPath));

            GenerateFolderTreeNode(root, rootFolderPath);

            FolderTreeView.Nodes.Add(root);
        }

        private void GenerateFolderTreeNode(TreeNode parent, string path)
        {
            foreach (string p in Directory.GetDirectories(path))
            {
                // create node for folder
                TreeNode node = new TreeNode(Path.GetFileNameWithoutExtension(p));

                // add to parent
                parent.Nodes.Add(node);

                // get child folders
                GenerateFolderTreeNode(node, p);
            }
        }

        private void SelectRootFolderButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new()
            {
                IsFolderPicker = true,
                Title = "Select the root folder to sort images into.",
                InitialDirectory = rootFolderPath,
            };

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(cofd.FileName))
            {
                RootFolderTextBox.Text = cofd.FileName;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            CopyCurrentImage();
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            MoveCurrentImage();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteCurrentImage();
        }

        private void IgnoreButton_Click(object sender, EventArgs e)
        {
            IgnoreCurrentImage();
        }

        private void PreviousImageButton_Click(object sender, EventArgs e)
        {
            LoadImage((currentIndex + paths.Count - 1) % paths.Count);
        }

        private void NextImageButton_Click(object sender, EventArgs e)
        {
            LoadImage((currentIndex + 1) % paths.Count);
        }

        private void NewFolderButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(destinationFolderPath))
            {
                // get name of folder
                TextDialog dialog = new TextDialog("New Folder", "Enter a name for a new folder.");

                // if Done clicked, and good result
                if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.TextResult))
                {
                    // create folder
                    Directory.CreateDirectory(Path.Combine(destinationFolderPath, dialog.TextResult));

                    // update node
                    // get parent
                    TreeNode node = FolderTreeView.SelectedNode;

                    // add self
                    node.Nodes.Add(new TreeNode(dialog.TextResult));
                }
            }
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(destinationFolderPath))
            {
                using (Process p = new Process())
                {
                    p.StartInfo = new ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        Verb = "open",
                        FileName = destinationFolderPath
                    };

                    p.Start();
                }
            }
        }

        private void PreviewPictureBox_Click(object sender, EventArgs e)
        {
            if (File.Exists(currentPath))
            {
                using (Process p = new Process())
                {
                    p.StartInfo = new ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        Verb = "open",
                        FileName = currentPath
                    };

                    p.Start();
                }
            }
        }

        private void RootFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateFolderTree();
        }

        private void FolderTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // select destination path based on node

            TreeNode node = FolderTreeView.SelectedNode;

            if (node == null)
            {
                // no node selected, do nothing
                return;
            }

            SetDestination(Path.Combine(Directory.GetParent(rootFolderPath)?.FullName ?? "", node.FullPath));
        }

        private void FolderTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // if node is selected, move file
            MoveCurrentImage();
        }

        private void SortingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // when this form closes, open parent
            if (parentForm.WindowState == FormWindowState.Minimized)
            {
                parentForm.WindowState = FormWindowState.Normal;
            }
        }

        //https://stackoverflow.com/questions/1249312/disable-expanding-after-doubleclick#:~:text=You%20can%20take%20a%20boolean,work%20via%20%2B%20and%20-%20icons.
        private bool _preventExpandOrCollapse = false;

        private void FolderTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            // cancel if told to
            if(e.Action == TreeViewAction.Expand)
            {
                e.Cancel = _preventExpandOrCollapse;
                _preventExpandOrCollapse = false;
            }
        }

        private void FolderTreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            if(e.Action == TreeViewAction.Collapse)
            {
                e.Cancel = _preventExpandOrCollapse;
                _preventExpandOrCollapse = false;
            }
        }

        private void FolderTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            _preventExpandOrCollapse = e.Button == MouseButtons.Left && e.Clicks == 2;
        }
    }
}
