namespace HardwareRentalApp.Forms
{
    partial class UpdateRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRent));
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_LesseeName = new TextBox();
            tb_LesseeAddress = new TextBox();
            lbl_ItemID = new Label();
            tb_MobileNum = new TextBox();
            lbl_ItemName = new Label();
            lbl_Rent = new Label();
            btn_Close = new Button();
            btn_Update = new Button();
            lbl_main = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(tb_LesseeName, 1, 0);
            tableLayoutPanel1.Controls.Add(tb_LesseeAddress, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl_ItemID, 0, 0);
            tableLayoutPanel1.Controls.Add(tb_MobileNum, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_ItemName, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_Rent, 0, 2);
            tableLayoutPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(53, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(434, 175);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tb_LesseeName
            // 
            tb_LesseeName.Anchor = AnchorStyles.None;
            tb_LesseeName.Font = new Font("Nirmala UI", 14.25F);
            tb_LesseeName.Location = new Point(176, 12);
            tb_LesseeName.Name = "tb_LesseeName";
            tb_LesseeName.ReadOnly = true;
            tb_LesseeName.Size = new Size(255, 33);
            tb_LesseeName.TabIndex = 2;
            // 
            // tb_LesseeAddress
            // 
            tb_LesseeAddress.Anchor = AnchorStyles.None;
            tb_LesseeAddress.Font = new Font("Nirmala UI", 14.25F);
            tb_LesseeAddress.Location = new Point(177, 129);
            tb_LesseeAddress.Margin = new Padding(4, 3, 4, 3);
            tb_LesseeAddress.Name = "tb_LesseeAddress";
            tb_LesseeAddress.Size = new Size(253, 33);
            tb_LesseeAddress.TabIndex = 4;
            // 
            // lbl_ItemID
            // 
            lbl_ItemID.AutoSize = true;
            lbl_ItemID.Dock = DockStyle.Fill;
            lbl_ItemID.Font = new Font("Nirmala UI", 14.25F);
            lbl_ItemID.ImeMode = ImeMode.NoControl;
            lbl_ItemID.Location = new Point(4, 0);
            lbl_ItemID.Margin = new Padding(4, 0, 4, 0);
            lbl_ItemID.Name = "lbl_ItemID";
            lbl_ItemID.Size = new Size(165, 58);
            lbl_ItemID.TabIndex = 0;
            lbl_ItemID.Text = "Item ID";
            lbl_ItemID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_MobileNum
            // 
            tb_MobileNum.Anchor = AnchorStyles.None;
            tb_MobileNum.Font = new Font("Nirmala UI", 14.25F);
            tb_MobileNum.Location = new Point(177, 70);
            tb_MobileNum.Margin = new Padding(4, 3, 4, 3);
            tb_MobileNum.Name = "tb_MobileNum";
            tb_MobileNum.ReadOnly = true;
            tb_MobileNum.Size = new Size(253, 33);
            tb_MobileNum.TabIndex = 3;
            // 
            // lbl_ItemName
            // 
            lbl_ItemName.AutoSize = true;
            lbl_ItemName.Dock = DockStyle.Fill;
            lbl_ItemName.Font = new Font("Nirmala UI", 14.25F);
            lbl_ItemName.ImeMode = ImeMode.NoControl;
            lbl_ItemName.Location = new Point(4, 58);
            lbl_ItemName.Margin = new Padding(4, 0, 4, 0);
            lbl_ItemName.Name = "lbl_ItemName";
            lbl_ItemName.Size = new Size(165, 58);
            lbl_ItemName.TabIndex = 0;
            lbl_ItemName.Text = "Item Name";
            lbl_ItemName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Rent
            // 
            lbl_Rent.AutoSize = true;
            lbl_Rent.Dock = DockStyle.Fill;
            lbl_Rent.Font = new Font("Nirmala UI", 14.25F);
            lbl_Rent.ImeMode = ImeMode.NoControl;
            lbl_Rent.Location = new Point(4, 116);
            lbl_Rent.Margin = new Padding(4, 0, 4, 0);
            lbl_Rent.Name = "lbl_Rent";
            lbl_Rent.Size = new Size(165, 59);
            lbl_Rent.TabIndex = 0;
            lbl_Rent.Text = "Rent (₹)";
            lbl_Rent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Nirmala UI", 8.25F);
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.ImeMode = ImeMode.NoControl;
            btn_Close.Location = new Point(496, 0);
            btn_Close.Margin = new Padding(1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(33, 33);
            btn_Close.TabIndex = 6;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btn_Update.ImeMode = ImeMode.NoControl;
            btn_Update.Location = new Point(175, 314);
            btn_Update.Margin = new Padding(4, 3, 4, 3);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(182, 48);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // lbl_main
            // 
            lbl_main.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            lbl_main.ImeMode = ImeMode.NoControl;
            lbl_main.Location = new Point(0, 39);
            lbl_main.Margin = new Padding(4, 0, 4, 0);
            lbl_main.Name = "lbl_main";
            lbl_main.Size = new Size(530, 44);
            lbl_main.TabIndex = 4;
            lbl_main.Text = "Update Rent";
            lbl_main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateRent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 417);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_Close);
            Controls.Add(btn_Update);
            Controls.Add(lbl_main);
            Font = new Font("Nirmala UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateRent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRent";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tb_LesseeName;
        private TextBox tb_LesseeAddress;
        private Label lbl_ItemID;
        private TextBox tb_MobileNum;
        private Label lbl_ItemName;
        private Label lbl_Rent;
        private Button btn_Close;
        private Button btn_Update;
        private Label lbl_main;
    }
}