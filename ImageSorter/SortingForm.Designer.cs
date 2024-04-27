namespace ImageSorter
{
    partial class SortingForm
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
            this.ImageGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IgnoreButton = new System.Windows.Forms.Button();
            this.MoveButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.NextImageButton = new System.Windows.Forms.Button();
            this.PreviousImageButton = new System.Windows.Forms.Button();
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.SortingGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenFolderButton = new System.Windows.Forms.Button();
            this.NewFolderButton = new System.Windows.Forms.Button();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.FolderTreeView = new System.Windows.Forms.TreeView();
            this.RootFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectRootFolderButton = new System.Windows.Forms.Button();
            this.ImageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            this.SortingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageGroupBox
            // 
            this.ImageGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageGroupBox.Controls.Add(this.DeleteButton);
            this.ImageGroupBox.Controls.Add(this.IgnoreButton);
            this.ImageGroupBox.Controls.Add(this.MoveButton);
            this.ImageGroupBox.Controls.Add(this.CopyButton);
            this.ImageGroupBox.Controls.Add(this.NextImageButton);
            this.ImageGroupBox.Controls.Add(this.PreviousImageButton);
            this.ImageGroupBox.Controls.Add(this.PreviewPictureBox);
            this.ImageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ImageGroupBox.Name = "ImageGroupBox";
            this.ImageGroupBox.Size = new System.Drawing.Size(562, 733);
            this.ImageGroupBox.TabIndex = 0;
            this.ImageGroupBox.TabStop = false;
            this.ImageGroupBox.Text = "Image";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteButton.Location = new System.Drawing.Point(196, 679);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(89, 40);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IgnoreButton
            // 
            this.IgnoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IgnoreButton.Location = new System.Drawing.Point(467, 679);
            this.IgnoreButton.Name = "IgnoreButton";
            this.IgnoreButton.Size = new System.Drawing.Size(89, 40);
            this.IgnoreButton.TabIndex = 5;
            this.IgnoreButton.Text = "Ignore";
            this.IgnoreButton.UseVisualStyleBackColor = true;
            this.IgnoreButton.Click += new System.EventHandler(this.IgnoreButton_Click);
            // 
            // MoveButton
            // 
            this.MoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveButton.Location = new System.Drawing.Point(101, 679);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(89, 40);
            this.MoveButton.TabIndex = 3;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyButton.Location = new System.Drawing.Point(6, 679);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(89, 40);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // NextImageButton
            // 
            this.NextImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextImageButton.Location = new System.Drawing.Point(307, 633);
            this.NextImageButton.Name = "NextImageButton";
            this.NextImageButton.Size = new System.Drawing.Size(249, 40);
            this.NextImageButton.TabIndex = 2;
            this.NextImageButton.Text = ">>>";
            this.NextImageButton.UseVisualStyleBackColor = true;
            this.NextImageButton.Click += new System.EventHandler(this.NextImageButton_Click);
            // 
            // PreviousImageButton
            // 
            this.PreviousImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PreviousImageButton.Location = new System.Drawing.Point(6, 633);
            this.PreviousImageButton.Name = "PreviousImageButton";
            this.PreviousImageButton.Size = new System.Drawing.Size(249, 40);
            this.PreviousImageButton.TabIndex = 1;
            this.PreviousImageButton.Text = "<<<";
            this.PreviousImageButton.UseVisualStyleBackColor = true;
            this.PreviousImageButton.Click += new System.EventHandler(this.PreviousImageButton_Click);
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewPictureBox.Location = new System.Drawing.Point(6, 26);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(550, 601);
            this.PreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewPictureBox.TabIndex = 0;
            this.PreviewPictureBox.TabStop = false;
            this.PreviewPictureBox.Click += new System.EventHandler(this.PreviewPictureBox_Click);
            // 
            // SortingGroupBox
            // 
            this.SortingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortingGroupBox.Controls.Add(this.OpenFolderButton);
            this.SortingGroupBox.Controls.Add(this.NewFolderButton);
            this.SortingGroupBox.Controls.Add(this.DestinationLabel);
            this.SortingGroupBox.Controls.Add(this.FolderTreeView);
            this.SortingGroupBox.Controls.Add(this.RootFolderTextBox);
            this.SortingGroupBox.Controls.Add(this.SelectRootFolderButton);
            this.SortingGroupBox.Location = new System.Drawing.Point(580, 12);
            this.SortingGroupBox.Name = "SortingGroupBox";
            this.SortingGroupBox.Size = new System.Drawing.Size(792, 733);
            this.SortingGroupBox.TabIndex = 1;
            this.SortingGroupBox.TabStop = false;
            this.SortingGroupBox.Text = "Sorting";
            // 
            // OpenFolderButton
            // 
            this.OpenFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenFolderButton.Location = new System.Drawing.Point(106, 663);
            this.OpenFolderButton.Name = "OpenFolderButton";
            this.OpenFolderButton.Size = new System.Drawing.Size(94, 29);
            this.OpenFolderButton.TabIndex = 5;
            this.OpenFolderButton.Text = "Open";
            this.OpenFolderButton.UseVisualStyleBackColor = true;
            this.OpenFolderButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // NewFolderButton
            // 
            this.NewFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewFolderButton.Location = new System.Drawing.Point(6, 663);
            this.NewFolderButton.Name = "NewFolderButton";
            this.NewFolderButton.Size = new System.Drawing.Size(94, 29);
            this.NewFolderButton.TabIndex = 4;
            this.NewFolderButton.Text = "New";
            this.NewFolderButton.UseVisualStyleBackColor = true;
            this.NewFolderButton.Click += new System.EventHandler(this.NewFolderButton_Click);
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(6, 699);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(92, 20);
            this.DestinationLabel.TabIndex = 3;
            this.DestinationLabel.Text = "Destination: ";
            // 
            // FolderTreeView
            // 
            this.FolderTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderTreeView.Location = new System.Drawing.Point(6, 61);
            this.FolderTreeView.Name = "FolderTreeView";
            this.FolderTreeView.Size = new System.Drawing.Size(748, 596);
            this.FolderTreeView.TabIndex = 2;
            this.FolderTreeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.FolderTreeView_BeforeCollapse);
            this.FolderTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.FolderTreeView_BeforeExpand);
            this.FolderTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FolderTreeView_AfterSelect);
            this.FolderTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.FolderTreeView_NodeMouseDoubleClick);
            this.FolderTreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FolderTreeView_MouseDown);
            // 
            // RootFolderTextBox
            // 
            this.RootFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RootFolderTextBox.Location = new System.Drawing.Point(6, 28);
            this.RootFolderTextBox.Name = "RootFolderTextBox";
            this.RootFolderTextBox.Size = new System.Drawing.Size(573, 27);
            this.RootFolderTextBox.TabIndex = 1;
            this.RootFolderTextBox.TextChanged += new System.EventHandler(this.RootFolderTextBox_TextChanged);
            // 
            // SelectRootFolderButton
            // 
            this.SelectRootFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectRootFolderButton.Location = new System.Drawing.Point(585, 26);
            this.SelectRootFolderButton.Name = "SelectRootFolderButton";
            this.SelectRootFolderButton.Size = new System.Drawing.Size(169, 29);
            this.SelectRootFolderButton.TabIndex = 0;
            this.SelectRootFolderButton.Text = "Select Root Folder...";
            this.SelectRootFolderButton.UseVisualStyleBackColor = true;
            this.SelectRootFolderButton.Click += new System.EventHandler(this.SelectRootFolderButton_Click);
            // 
            // SortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 757);
            this.Controls.Add(this.SortingGroupBox);
            this.Controls.Add(this.ImageGroupBox);
            this.Name = "SortingForm";
            this.Text = "Sorting: ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SortingForm_FormClosed);
            this.ImageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            this.SortingGroupBox.ResumeLayout(false);
            this.SortingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox ImageGroupBox;
        private Button NextImageButton;
        private Button PreviousImageButton;
        private PictureBox PreviewPictureBox;
        private GroupBox SortingGroupBox;
        private Button SelectRootFolderButton;
        private TextBox RootFolderTextBox;
        private Button CopyButton;
        private Button MoveButton;
        private TreeView FolderTreeView;
        private Button IgnoreButton;
        private Label DestinationLabel;
        private Button DeleteButton;
        private Button NewFolderButton;
        private Button OpenFolderButton;
    }
}