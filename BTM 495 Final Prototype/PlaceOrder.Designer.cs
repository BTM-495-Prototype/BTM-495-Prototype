namespace BTM_495_Final_Prototype
{
    partial class PlaceOrder
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
            totalBox = new TextBox();
            totalLabel = new Label();
            resetButton = new Button();
            cartBox = new RichTextBox();
            addButton = new Button();
            cartLabel = new Label();
            exitButton = new Button();
            orderButton = new Button();
            itemBox = new ComboBox();
            utemLabel = new Label();
            itemTip = new LinkLabel();
            typeBox = new ComboBox();
            orderType = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(144, 21);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Order Dashboard:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(totalBox);
            panel1.Controls.Add(totalLabel);
            panel1.Controls.Add(resetButton);
            panel1.Controls.Add(cartBox);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(cartLabel);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(orderButton);
            panel1.Controls.Add(itemBox);
            panel1.Controls.Add(utemLabel);
            panel1.Controls.Add(itemTip);
            panel1.Controls.Add(typeBox);
            panel1.Controls.Add(orderType);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 389);
            panel1.TabIndex = 2;
            // 
            // totalBox
            // 
            totalBox.Location = new Point(537, 270);
            totalBox.Name = "totalBox";
            totalBox.ReadOnly = true;
            totalBox.Size = new Size(119, 23);
            totalBox.TabIndex = 13;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(489, 269);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(46, 20);
            totalLabel.TabIndex = 12;
            totalLabel.Text = "Total:";
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(489, 96);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 11;
            resetButton.Text = "Reset Cart";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // cartBox
            // 
            cartBox.Location = new Point(134, 160);
            cartBox.Name = "cartBox";
            cartBox.ReadOnly = true;
            cartBox.Size = new Size(349, 129);
            cartBox.TabIndex = 10;
            cartBox.Text = "";
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(408, 96);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 9;
            addButton.Text = "Add to cart";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cartLabel.Location = new Point(31, 160);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(41, 20);
            cartLabel.TabIndex = 7;
            cartLabel.Text = "Cart:";
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(534, 311);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(122, 48);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit Order";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // orderButton
            // 
            orderButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderButton.Location = new Point(134, 311);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(122, 48);
            orderButton.TabIndex = 5;
            orderButton.Text = "Place Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // itemBox
            // 
            itemBox.AutoCompleteCustomSource.AddRange(new string[] { "Medicine", "Medical Devices" });
            itemBox.DropDownStyle = ComboBoxStyle.DropDownList;
            itemBox.FormattingEnabled = true;
            itemBox.Location = new Point(134, 96);
            itemBox.Name = "itemBox";
            itemBox.Size = new Size(250, 23);
            itemBox.TabIndex = 4;
            // 
            // utemLabel
            // 
            utemLabel.AutoSize = true;
            utemLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utemLabel.Location = new Point(31, 95);
            utemLabel.Name = "utemLabel";
            utemLabel.Size = new Size(43, 20);
            utemLabel.TabIndex = 3;
            utemLabel.Text = "Item:";
            // 
            // itemTip
            // 
            itemTip.AutoSize = true;
            itemTip.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemTip.Location = new Point(386, 96);
            itemTip.Name = "itemTip";
            itemTip.Size = new Size(16, 20);
            itemTip.TabIndex = 2;
            itemTip.TabStop = true;
            itemTip.Text = "?";
            itemTip.LinkClicked += itemTip_LinkClicked;
            // 
            // typeBox
            // 
            typeBox.AutoCompleteCustomSource.AddRange(new string[] { "Medicine", "Medical Devices" });
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.FormattingEnabled = true;
            typeBox.Items.AddRange(new object[] { "Medicine", "Medical device" });
            typeBox.Location = new Point(134, 31);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(250, 23);
            typeBox.TabIndex = 1;
            typeBox.SelectedIndexChanged += typeBox_SelectedIndexChanged;
            // 
            // orderType
            // 
            orderType.AutoSize = true;
            orderType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderType.Location = new Point(31, 30);
            orderType.Name = "orderType";
            orderType.Size = new Size(97, 20);
            orderType.TabIndex = 0;
            orderType.Text = "Type of item:";
            // 
            // PlaceOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(WelcomeLabel);
            Name = "PlaceOrder";
            Text = "New Order";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WelcomeLabel;
        private Panel panel1;
        private Label orderType;
        private ComboBox itemBox;
        private Label utemLabel;
        private LinkLabel itemTip;
        private ComboBox typeBox;
        private Button exitButton;
        private Button orderButton;
        private Label cartLabel;
        private Button addButton;
        private RichTextBox cartBox;
        private Button resetButton;
        private TextBox totalBox;
        private Label totalLabel;
    }
}