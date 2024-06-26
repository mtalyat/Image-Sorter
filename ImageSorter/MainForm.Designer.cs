﻿namespace ImageSorter
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
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.ExtensionsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFolderButton.Location = new System.Drawing.Point(12, 272);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(323, 86);
            this.SelectFolderButton.TabIndex = 0;
            this.SelectFolderButton.Text = "Select Folder to Sort";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // ExtensionsRichTextBox
            // 
            this.ExtensionsRichTextBox.Location = new System.Drawing.Point(12, 32);
            this.ExtensionsRichTextBox.Name = "ExtensionsRichTextBox";
            this.ExtensionsRichTextBox.Size = new System.Drawing.Size(323, 234);
            this.ExtensionsRichTextBox.TabIndex = 1;
            this.ExtensionsRichTextBox.Text = ".png\n.jpeg\n.jpg\n.mov\n.gif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Extensions:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtensionsRichTextBox);
            this.Controls.Add(this.SelectFolderButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectFolderButton;
        private RichTextBox ExtensionsRichTextBox;
        private Label label1;
    }
}