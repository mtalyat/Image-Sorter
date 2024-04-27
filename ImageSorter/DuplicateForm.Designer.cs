namespace ImageSorter
{
    partial class DuplicateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourcePictureBox = new System.Windows.Forms.PictureBox();
            this.DestinationPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.DeleteSourceButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeNameButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IgnoreSourceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SourcePictureBox
            // 
            this.SourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SourcePictureBox.Location = new System.Drawing.Point(12, 32);
            this.SourcePictureBox.Name = "SourcePictureBox";
            this.SourcePictureBox.Size = new System.Drawing.Size(400, 400);
            this.SourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SourcePictureBox.TabIndex = 0;
            this.SourcePictureBox.TabStop = false;
            // 
            // DestinationPictureBox
            // 
            this.DestinationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationPictureBox.Location = new System.Drawing.Point(418, 32);
            this.DestinationPictureBox.Name = "DestinationPictureBox";
            this.DestinationPictureBox.Size = new System.Drawing.Size(400, 400);
            this.DestinationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DestinationPictureBox.TabIndex = 1;
            this.DestinationPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplaceButton.Location = new System.Drawing.Point(700, 438);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(120, 64);
            this.ReplaceButton.TabIndex = 4;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // DeleteSourceButton
            // 
            this.DeleteSourceButton.Location = new System.Drawing.Point(138, 438);
            this.DeleteSourceButton.Name = "DeleteSourceButton";
            this.DeleteSourceButton.Size = new System.Drawing.Size(120, 64);
            this.DeleteSourceButton.TabIndex = 5;
            this.DeleteSourceButton.Text = "Delete Source";
            this.DeleteSourceButton.UseVisualStyleBackColor = true;
            this.DeleteSourceButton.Click += new System.EventHandler(this.DeleteSourceButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(104, 508);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(714, 27);
            this.NameTextBox.TabIndex = 7;
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeNameButton.Location = new System.Drawing.Point(574, 438);
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.Size = new System.Drawing.Size(120, 64);
            this.ChangeNameButton.TabIndex = 9;
            this.ChangeNameButton.Text = "Change Name";
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Name:";
            // 
            // IgnoreSourceButton
            // 
            this.IgnoreSourceButton.Location = new System.Drawing.Point(12, 438);
            this.IgnoreSourceButton.Name = "IgnoreSourceButton";
            this.IgnoreSourceButton.Size = new System.Drawing.Size(120, 64);
            this.IgnoreSourceButton.TabIndex = 11;
            this.IgnoreSourceButton.Text = "Ignore";
            this.IgnoreSourceButton.UseVisualStyleBackColor = true;
            this.IgnoreSourceButton.Click += new System.EventHandler(this.IgnoreSourceButton_Click);
            // 
            // DuplicateForm
            // 
            this.AcceptButton = this.ReplaceButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 548);
            this.ControlBox = false;
            this.Controls.Add(this.IgnoreSourceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeNameButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DeleteSourceButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinationPictureBox);
            this.Controls.Add(this.SourcePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DuplicateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Duplicate of XXX.png";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.SourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox SourcePictureBox;
        private PictureBox DestinationPictureBox;
        private Label label1;
        private Label label2;
        private Button ReplaceButton;
        private Button DeleteSourceButton;
        private TextBox NameTextBox;
        private Button ChangeNameButton;
        private Label label3;
        private Button IgnoreSourceButton;
    }
}