namespace ImageSorter
{
    partial class TextDialog
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
            Label = new Label();
            TextBox = new TextBox();
            CancelDialogButton = new Button();
            AcceptDialogButton = new Button();
            SuspendLayout();
            // 
            // Label
            // 
            Label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Label.AutoSize = true;
            Label.Location = new Point(20, 14);
            Label.Margin = new Padding(5, 0, 5, 0);
            Label.Name = "Label";
            Label.Size = new Size(70, 32);
            Label.TabIndex = 0;
            Label.Text = "Label";
            // 
            // TextBox
            // 
            TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TextBox.Location = new Point(20, 51);
            TextBox.Margin = new Padding(5, 5, 5, 5);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(683, 39);
            TextBox.TabIndex = 1;
            // 
            // CancelDialogButton
            // 
            CancelDialogButton.Location = new Point(20, 117);
            CancelDialogButton.Margin = new Padding(5, 5, 5, 5);
            CancelDialogButton.Name = "CancelDialogButton";
            CancelDialogButton.Size = new Size(153, 46);
            CancelDialogButton.TabIndex = 2;
            CancelDialogButton.Text = "Cancel";
            CancelDialogButton.UseVisualStyleBackColor = true;
            CancelDialogButton.Click += CancelButton_Click;
            // 
            // AcceptDialogButton
            // 
            AcceptDialogButton.Location = new Point(551, 117);
            AcceptDialogButton.Margin = new Padding(5, 5, 5, 5);
            AcceptDialogButton.Name = "AcceptDialogButton";
            AcceptDialogButton.Size = new Size(153, 46);
            AcceptDialogButton.TabIndex = 3;
            AcceptDialogButton.Text = "Done";
            AcceptDialogButton.UseVisualStyleBackColor = true;
            AcceptDialogButton.Click += AcceptButton_Click;
            // 
            // TextDialog
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 179);
            ControlBox = false;
            Controls.Add(AcceptDialogButton);
            Controls.Add(CancelDialogButton);
            Controls.Add(TextBox);
            Controls.Add(Label);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(5, 5, 5, 5);
            MinimumSize = new Size(750, 250);
            Name = "TextDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "TextDialog";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label Label;
        private TextBox TextBox;
        private Button CancelDialogButton;
        private Button AcceptDialogButton;
    }
}