namespace BTM_495_Final_Prototype
{
    partial class OrderViewer
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
            WelcomeLabel = new Label();
            panel1 = new Panel();
            exitBottun = new Button();
            canceledButton = new Button();
            fulfilledButton = new Button();
            orderDetailsBox = new RichTextBox();
            orderLabel = new Label();
            orderBox = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(119, 21);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Placed Orders:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(exitBottun);
            panel1.Controls.Add(canceledButton);
            panel1.Controls.Add(fulfilledButton);
            panel1.Controls.Add(orderDetailsBox);
            panel1.Controls.Add(orderLabel);
            panel1.Controls.Add(orderBox);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 388);
            panel1.TabIndex = 2;
            // 
            // exitBottun
            // 
            exitBottun.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBottun.Location = new Point(679, 323);
            exitBottun.Name = "exitBottun";
            exitBottun.Size = new Size(54, 29);
            exitBottun.TabIndex = 5;
            exitBottun.Text = "Exit";
            exitBottun.UseVisualStyleBackColor = true;
            exitBottun.Click += exitBottun_Click;
            // 
            // canceledButton
            // 
            canceledButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            canceledButton.Location = new Point(180, 323);
            canceledButton.Name = "canceledButton";
            canceledButton.Size = new Size(118, 29);
            canceledButton.TabIndex = 4;
            canceledButton.Text = "Canceled";
            canceledButton.UseVisualStyleBackColor = true;
            canceledButton.Click += canceledButton_Click;
            // 
            // fulfilledButton
            // 
            fulfilledButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fulfilledButton.Location = new Point(36, 323);
            fulfilledButton.Name = "fulfilledButton";
            fulfilledButton.Size = new Size(118, 29);
            fulfilledButton.TabIndex = 3;
            fulfilledButton.Text = "Fulfilled";
            fulfilledButton.UseVisualStyleBackColor = true;
            fulfilledButton.Click += fulfilledButton_Click;
            // 
            // orderDetailsBox
            // 
            orderDetailsBox.Location = new Point(36, 71);
            orderDetailsBox.Name = "orderDetailsBox";
            orderDetailsBox.ReadOnly = true;
            orderDetailsBox.Size = new Size(697, 232);
            orderDetailsBox.TabIndex = 2;
            orderDetailsBox.Text = "";
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderLabel.Location = new Point(36, 27);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(103, 20);
            orderLabel.TabIndex = 1;
            orderLabel.Text = "Placed Order:";
            // 
            // orderBox
            // 
            orderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            orderBox.FormattingEnabled = true;
            orderBox.Location = new Point(145, 28);
            orderBox.Name = "orderBox";
            orderBox.Size = new Size(588, 23);
            orderBox.TabIndex = 0;
            orderBox.SelectedIndexChanged += orderBox_SelectedIndexChanged;
            // 
            // OrderViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(WelcomeLabel);
            Name = "OrderViewer";
            Text = "Order Viewer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Panel panel1;
        private Label orderLabel;
        private ComboBox orderBox;
        private Button fulfilledButton;
        private RichTextBox orderDetailsBox;
        private Button exitBottun;
        private Button canceledButton;
    }
}