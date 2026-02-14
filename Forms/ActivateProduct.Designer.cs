namespace HardwareRentalApp.Forms
{
    partial class ActivateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivateProduct));
            btn_Activate = new Button();
            lbl_ActivateProduct = new Label();
            lbl_message = new Label();
            lbl_RequestDate = new Label();
            tb_RequestDate = new TextBox();
            lbl_MACAddress = new Label();
            tb_MACAddress = new TextBox();
            lbl_UserID = new Label();
            tb_UserID = new TextBox();
            lbl_ActivationKey = new Label();
            tb_ActivationKey = new TextBox();
            btn_Close = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Activate
            // 
            btn_Activate.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Activate.Location = new Point(125, 304);
            btn_Activate.Margin = new Padding(4);
            btn_Activate.Name = "btn_Activate";
            btn_Activate.Size = new Size(176, 41);
            btn_Activate.TabIndex = 5;
            btn_Activate.Text = "Activate";
            btn_Activate.UseVisualStyleBackColor = true;
            btn_Activate.Click += btn_Activate_Click;
            // 
            // lbl_ActivateProduct
            // 
            lbl_ActivateProduct.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold);
            lbl_ActivateProduct.Location = new Point(0, 33);
            lbl_ActivateProduct.Margin = new Padding(2, 0, 2, 0);
            lbl_ActivateProduct.Name = "lbl_ActivateProduct";
            lbl_ActivateProduct.Size = new Size(440, 32);
            lbl_ActivateProduct.TabIndex = 0;
            lbl_ActivateProduct.Text = "Activate Product";
            lbl_ActivateProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_message
            // 
            lbl_message.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbl_message.ForeColor = Color.Tomato;
            lbl_message.Location = new Point(0, 75);
            lbl_message.Margin = new Padding(2, 0, 2, 0);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(440, 20);
            lbl_message.TabIndex = 0;
            lbl_message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_RequestDate
            // 
            lbl_RequestDate.AutoSize = true;
            lbl_RequestDate.Dock = DockStyle.Fill;
            lbl_RequestDate.Font = new Font("Nirmala UI", 14.25F);
            lbl_RequestDate.Location = new Point(2, 0);
            lbl_RequestDate.Margin = new Padding(2, 0, 2, 0);
            lbl_RequestDate.Name = "lbl_RequestDate";
            lbl_RequestDate.Size = new Size(181, 36);
            lbl_RequestDate.TabIndex = 0;
            lbl_RequestDate.Text = "Request Date:";
            lbl_RequestDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_RequestDate
            // 
            tb_RequestDate.Font = new Font("Nirmala UI", 14.25F);
            tb_RequestDate.Location = new Point(187, 2);
            tb_RequestDate.Margin = new Padding(2);
            tb_RequestDate.Name = "tb_RequestDate";
            tb_RequestDate.ReadOnly = true;
            tb_RequestDate.Size = new Size(182, 39);
            tb_RequestDate.TabIndex = 1;
            // 
            // lbl_MACAddress
            // 
            lbl_MACAddress.AutoSize = true;
            lbl_MACAddress.Dock = DockStyle.Fill;
            lbl_MACAddress.Font = new Font("Nirmala UI", 14.25F);
            lbl_MACAddress.Location = new Point(2, 36);
            lbl_MACAddress.Margin = new Padding(2, 0, 2, 0);
            lbl_MACAddress.Name = "lbl_MACAddress";
            lbl_MACAddress.Size = new Size(181, 36);
            lbl_MACAddress.TabIndex = 0;
            lbl_MACAddress.Text = "MAC Address:";
            lbl_MACAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_MACAddress
            // 
            tb_MACAddress.Font = new Font("Nirmala UI", 14.25F);
            tb_MACAddress.Location = new Point(187, 38);
            tb_MACAddress.Margin = new Padding(2);
            tb_MACAddress.Name = "tb_MACAddress";
            tb_MACAddress.ReadOnly = true;
            tb_MACAddress.Size = new Size(182, 39);
            tb_MACAddress.TabIndex = 2;
            // 
            // lbl_UserID
            // 
            lbl_UserID.AutoSize = true;
            lbl_UserID.Dock = DockStyle.Fill;
            lbl_UserID.Font = new Font("Nirmala UI", 14.25F);
            lbl_UserID.Location = new Point(2, 72);
            lbl_UserID.Margin = new Padding(2, 0, 2, 0);
            lbl_UserID.Name = "lbl_UserID";
            lbl_UserID.Size = new Size(181, 36);
            lbl_UserID.TabIndex = 0;
            lbl_UserID.Text = "User ID:";
            lbl_UserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_UserID
            // 
            tb_UserID.Font = new Font("Nirmala UI", 14.25F);
            tb_UserID.Location = new Point(187, 74);
            tb_UserID.Margin = new Padding(2);
            tb_UserID.Name = "tb_UserID";
            tb_UserID.Size = new Size(182, 39);
            tb_UserID.TabIndex = 3;
            tb_UserID.KeyPress += tb_UserID_KeyPress;
            // 
            // lbl_ActivationKey
            // 
            lbl_ActivationKey.AutoSize = true;
            lbl_ActivationKey.Dock = DockStyle.Fill;
            lbl_ActivationKey.Font = new Font("Nirmala UI", 14.25F);
            lbl_ActivationKey.Location = new Point(2, 108);
            lbl_ActivationKey.Margin = new Padding(2, 0, 2, 0);
            lbl_ActivationKey.Name = "lbl_ActivationKey";
            lbl_ActivationKey.Size = new Size(181, 38);
            lbl_ActivationKey.TabIndex = 0;
            lbl_ActivationKey.Text = "Activation Key:";
            lbl_ActivationKey.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_ActivationKey
            // 
            tb_ActivationKey.Font = new Font("Nirmala UI", 14.25F);
            tb_ActivationKey.Location = new Point(187, 110);
            tb_ActivationKey.Margin = new Padding(2);
            tb_ActivationKey.Name = "tb_ActivationKey";
            tb_ActivationKey.Size = new Size(182, 39);
            tb_ActivationKey.TabIndex = 4;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Microsoft Sans Serif", 14.25F);
            btn_Close.Location = new Point(98, 0);
            btn_Close.Margin = new Padding(2, 1, 2, 1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(26, 25);
            btn_Close.TabIndex = 6;
            btn_Close.TextAlign = ContentAlignment.TopRight;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbl_RequestDate, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_ActivationKey, 0, 3);
            tableLayoutPanel1.Controls.Add(tb_ActivationKey, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_UserID, 0, 2);
            tableLayoutPanel1.Controls.Add(tb_RequestDate, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_MACAddress, 0, 1);
            tableLayoutPanel1.Controls.Add(tb_MACAddress, 1, 1);
            tableLayoutPanel1.Controls.Add(tb_UserID, 1, 2);
            tableLayoutPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(40, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(371, 146);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 8.25F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImeMode = ImeMode.NoControl;
            button1.Location = new Point(407, 1);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(33, 33);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // ActivateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(441, 379);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_message);
            Controls.Add(lbl_ActivateProduct);
            Controls.Add(btn_Activate);
            Controls.Add(btn_Close);
            Font = new Font("Nirmala UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ActivateProduct";
            Load += ActivateProduct_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Activate;
        private System.Windows.Forms.Label lbl_ActivateProduct;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_RequestDate;
        private System.Windows.Forms.TextBox tb_RequestDate;
        private System.Windows.Forms.Label lbl_MACAddress;
        private System.Windows.Forms.TextBox tb_MACAddress;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox tb_UserID;
        private System.Windows.Forms.Label lbl_ActivationKey;
        private System.Windows.Forms.TextBox tb_ActivationKey;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
    }
}