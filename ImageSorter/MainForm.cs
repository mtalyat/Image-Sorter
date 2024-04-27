using Microsoft.WindowsAPICodePack.Dialogs;

namespace ImageSorter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new()
            {
                IsFolderPicker = true,
                Title = "Select a folder to sort."
            };

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(cofd.FileName))
            {
                // show sorting form
                SortingForm form = new SortingForm(this, cofd.FileName, ExtensionsRichTextBox.Lines);
                form.Show();

                // hide self
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}