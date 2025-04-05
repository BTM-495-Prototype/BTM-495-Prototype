namespace BTM_495_Final_Prototype
{
    partial class NotificationCreationDashboard
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
            categoryLabel = new Label();
            categoryBox = new ComboBox();
            messageLabel = new Label();
            label1 = new Label();
            recipientBox = new ComboBox();
            messageBox = new RichTextBox();
            submitButton = new Button();
            panel1 = new Panel();
            closeButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // FormTitleLabel
            // 
            FormTitleLabel.AutoSize = true;
            FormTitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormTitleLabel.Location = new Point(12, 9);
            FormTitleLabel.Name = "FormTitleLabel";
            FormTitleLabel.Size = new Size(206, 21);
            FormTitleLabel.TabIndex = 1;
            FormTitleLabel.Text = "Create a new notification:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.Location = new Point(56, 23);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(161, 20);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Notification Category:";
            // 
            // categoryBox
            // 
            categoryBox.AutoCompleteCustomSource.AddRange(new string[] { "Appoitment", "Order", "Information", "Update", "Other" });
            categoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryBox.FormattingEnabled = true;
            categoryBox.Items.AddRange(new object[] { "Appointment Update", "Order Update", "General Update", "Information", "Other" });
            categoryBox.Location = new Point(220, 23);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(287, 23);
            categoryBox.TabIndex = 3;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageLabel.Location = new Point(56, 149);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(157, 20);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Notification Message:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 86);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Recipient:";
            // 
            // recipientBox
            // 
            recipientBox.DropDownStyle = ComboBoxStyle.DropDownList;
            recipientBox.FormattingEnabled = true;
            recipientBox.Location = new Point(220, 86);
            recipientBox.Name = "recipientBox";
            recipientBox.Size = new Size(491, 23);
            recipientBox.TabIndex = 6;
            // 
            // messageBox
            // 
            messageBox.Location = new Point(220, 150);
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(491, 205);
            messageBox.TabIndex = 7;
            messageBox.Text = "";
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(220, 362);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(124, 35);
            submitButton.TabIndex = 8;
            submitButton.Text = "Submit Notification";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(closeButton);
            panel1.Controls.Add(submitButton);
            panel1.Controls.Add(messageBox);
            panel1.Controls.Add(recipientBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(messageLabel);
            panel1.Controls.Add(categoryBox);
            panel1.Controls.Add(categoryLabel);
            panel1.Location = new Point(4, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 407);
            panel1.TabIndex = 9;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeButton.Location = new Point(587, 362);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(124, 35);
            closeButton.TabIndex = 9;
            closeButton.Text = "Exit Dashboard";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // NotificationCreationDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormTitleLabel);
            Controls.Add(panel1);
            Name = "NotificationCreationDashboard";
            Text = "Notification Creation Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FormTitleLabel;
        private Label categoryLabel;
        private ComboBox categoryBox;
        private Label messageLabel;
        private Label label1;
        private ComboBox recipientBox;
        private RichTextBox messageBox;
        private Button submitButton;
        private Panel panel1;
        private Button closeButton;
    }
}