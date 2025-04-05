namespace BTM_495_Final_Prototype
{
    partial class NotificationView
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
            FormTitleLabel = new Label();
            panel1 = new Panel();
            exitButton = new Button();
            dismissButton = new Button();
            label1 = new Label();
            notificaitonSelector = new ComboBox();
            notificationBox = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FormTitleLabel
            // 
            FormTitleLabel.AutoSize = true;
            FormTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormTitleLabel.Location = new Point(12, 9);
            FormTitleLabel.Name = "FormTitleLabel";
            FormTitleLabel.Size = new Size(184, 21);
            FormTitleLabel.TabIndex = 2;
            FormTitleLabel.Text = "Notification on record:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(dismissButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(notificaitonSelector);
            panel1.Controls.Add(notificationBox);
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 405);
            panel1.TabIndex = 3;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(607, 350);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(135, 27);
            exitButton.TabIndex = 4;
            exitButton.Text = "Close Viewer";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // dismissButton
            // 
            dismissButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dismissButton.Location = new Point(33, 350);
            dismissButton.Name = "dismissButton";
            dismissButton.Size = new Size(135, 27);
            dismissButton.TabIndex = 3;
            dismissButton.Text = "Dismiss Notification";
            dismissButton.UseVisualStyleBackColor = true;
            dismissButton.Click += dismissButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 2;
            label1.Text = "Select notification to view:";
            // 
            // notificaitonSelector
            // 
            notificaitonSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            notificaitonSelector.FormattingEnabled = true;
            notificaitonSelector.Location = new Point(188, 20);
            notificaitonSelector.Name = "notificaitonSelector";
            notificaitonSelector.Size = new Size(583, 23);
            notificaitonSelector.TabIndex = 1;
            notificaitonSelector.SelectedIndexChanged += notificaitonSelector_SelectedIndexChanged;
            // 
            // notificationBox
            // 
            notificationBox.Location = new Point(3, 52);
            notificationBox.Name = "notificationBox";
            notificationBox.ReadOnly = true;
            notificationBox.Size = new Size(768, 270);
            notificationBox.TabIndex = 0;
            notificationBox.Text = "Please seelct a notification to view";
            // 
            // NotificationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(FormTitleLabel);
            Name = "NotificationView";
            Text = "Notification Viewer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormTitleLabel;
        private Panel panel1;
        private Label label1;
        private ComboBox notificaitonSelector;
        private RichTextBox notificationBox;
        private Button exitButton;
        private Button dismissButton;
    }
}