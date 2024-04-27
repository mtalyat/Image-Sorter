using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SourcePictureBox.ImageLocation = source;
            DestinationPictureBox.ImageLocation = destination;

            // set name text box text
            NameTextBox.Text = Path.GetFileNameWithoutExtension(destination);
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
    }
}
