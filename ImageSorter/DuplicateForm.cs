using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;

namespace ImageSorter
{
    public partial class DuplicateForm : Form
    {
        readonly SortingForm parent;

        readonly string source;
        readonly string destination;

        public DuplicateForm(SortingForm form, string sourcePath, string destinationPath)
        {
            InitializeComponent();

            parent = form;
            source = sourcePath;
            destination = destinationPath;

            // get name
            string fileName = Path.GetFileName(source);

            // set title
            Text = $"Duplication of {fileName}!";

            // set images
            LoadPreview(SourcePictureBox, source);
            LoadPreview(DestinationPictureBox, destination);

            // set name text box text
            NameTextBox.Text = Path.GetFileNameWithoutExtension(destination);

            FormClosed += DuplicateForm_FormClosed;
        }

        private void DeleteSourceButton_Click(object sender, EventArgs e)
        {
            parent.DeleteCurrentImage();

            DialogResult = DialogResult.Cancel;

            Close();
        }
        private void IgnoreSourceButton_Click(object sender, EventArgs e)
        {
            parent.IgnoreCurrentImage();

            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            File.Delete(destination);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            parent.RenameCurrentImage(NameTextBox.Text);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void DuplicateForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ClearPreviewImage(SourcePictureBox);
            ClearPreviewImage(DestinationPictureBox);
        }

        private static void LoadPreview(PictureBox pictureBox, string path)
        {
            ClearPreviewImage(pictureBox);

            if (!File.Exists(path))
            {
                return;
            }

            if (TryLoadImage(path, out Bitmap? preview) || TryLoadThumbnail(path, out preview))
            {
                pictureBox.Image = preview;
            }
        }

        private static bool TryLoadImage(string path, out Bitmap? preview)
        {
            try
            {
                using Image image = Image.FromFile(path);
                preview = new Bitmap(image);
                return true;
            }
            catch
            {
                preview = null;
                return false;
            }
        }

        private static bool TryLoadThumbnail(string path, out Bitmap? preview)
        {
            try
            {
                using ShellFile shellFile = ShellFile.FromFilePath(path);
                using Bitmap thumbnail = shellFile.Thumbnail.ExtraLargeBitmap;

                preview = new Bitmap(thumbnail);
                return true;
            }
            catch
            {
                preview = null;
                return false;
            }
        }

        private static void ClearPreviewImage(PictureBox pictureBox)
        {
            if (pictureBox.Image is Image oldImage)
            {
                pictureBox.Image = null;
                oldImage.Dispose();
            }
        }
    }
}
