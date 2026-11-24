namespace ImageSorter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectFolderButton = new Button();
            ExtensionsRichTextBox = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SelectFolderButton
            // 
            SelectFolderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectFolderButton.Location = new Point(20, 435);
            SelectFolderButton.Margin = new Padding(5, 5, 5, 5);
            SelectFolderButton.Name = "SelectFolderButton";
            SelectFolderButton.Size = new Size(525, 138);
            SelectFolderButton.TabIndex = 0;
            SelectFolderButton.Text = "Select Folder to Sort";
            SelectFolderButton.UseVisualStyleBackColor = true;
            SelectFolderButton.Click += SelectFolderButton_Click;
            // 
            // ExtensionsRichTextBox
            // 
            ExtensionsRichTextBox.Location = new Point(20, 51);
            ExtensionsRichTextBox.Margin = new Padding(5, 5, 5, 5);
            ExtensionsRichTextBox.Name = "ExtensionsRichTextBox";
            ExtensionsRichTextBox.Size = new Size(522, 372);
            ExtensionsRichTextBox.TabIndex = 1;
            ExtensionsRichTextBox.Text = ".png\n.jpeg\n.jpg\n.mov\n.gif\n.heic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 2;
            label1.Text = "Extensions:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 592);
            Controls.Add(label1);
            Controls.Add(ExtensionsRichTextBox);
            Controls.Add(SelectFolderButton);
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Sorter";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button SelectFolderButton;
        private RichTextBox ExtensionsRichTextBox;
        private Label label1;
    }
}