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
    public partial class TextDialog : Form
    {
        public string TextResult => TextBox.Text;

        public TextDialog(string title, string text, string startingText = "")
        {
            InitializeComponent();

            Text = title;
            Label.Text = text;
            TextBox.Text = startingText;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;

            Close();
        }
    }
}
