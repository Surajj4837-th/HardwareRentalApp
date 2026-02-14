namespace HardwareRentalApp.Forms
{
    partial class UpdateItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItem));
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_MinRentalDays = new TextBox();
            lbl_MinRentalDays = new Label();
            tb_ItemID = new TextBox();
            tb_RentPerDay = new TextBox();
            lbl_ItemID = new Label();
            tb_ItemName = new TextBox();
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
            tableLayoutPanel1.Controls.Add(tb_MinRentalDays, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_MinRentalDays, 0, 3);
            tableLayoutPanel1.Controls.Add(tb_ItemID, 1, 0);
            tableLayoutPanel1.Controls.Add(tb_RentPerDay, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl_ItemID, 0, 0);
            tableLayoutPanel1.Controls.Add(tb_ItemName, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_ItemName, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_Rent, 0, 2);
            tableLayoutPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(53, 102);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(434, 198);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tb_MinRentalDays
            // 
            tb_MinRentalDays.Anchor = AnchorStyles.None;
            tb_MinRentalDays.Font = new Font("Nirmala UI", 14.25F);
            tb_MinRentalDays.Location = new Point(177, 153);
            tb_MinRentalDays.Margin = new Padding(4, 3, 4, 3);
            tb_MinRentalDays.Name = "tb_MinRentalDays";
            tb_MinRentalDays.Size = new Size(253, 39);
            tb_MinRentalDays.TabIndex = 6;
            tb_MinRentalDays.KeyPress += tb_MinRentalDays_KeyPress;
            // 
            // lbl_MinRentalDays
            // 
            lbl_MinRentalDays.AutoSize = true;
            lbl_MinRentalDays.Dock = DockStyle.Fill;
            lbl_MinRentalDays.Font = new Font("Nirmala UI", 14.25F);
            lbl_MinRentalDays.ImeMode = ImeMode.NoControl;
            lbl_MinRentalDays.Location = new Point(4, 147);
            lbl_MinRentalDays.Margin = new Padding(4, 0, 4, 0);
            lbl_MinRentalDays.Name = "lbl_MinRentalDays";
            lbl_MinRentalDays.Size = new Size(165, 51);
            lbl_MinRentalDays.TabIndex = 5;
            lbl_MinRentalDays.Text = "Min. Rental Days";
            lbl_MinRentalDays.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_ItemID
            // 
            tb_ItemID.Anchor = AnchorStyles.None;
            tb_ItemID.Font = new Font("Nirmala UI", 14.25F);
            tb_ItemID.Location = new Point(176, 5);
            tb_ItemID.Name = "tb_ItemID";
            tb_ItemID.ReadOnly = true;
            tb_ItemID.Size = new Size(255, 39);
            tb_ItemID.TabIndex = 2;
            // 
            // tb_RentPerDay
            // 
            tb_RentPerDay.Anchor = AnchorStyles.None;
            tb_RentPerDay.Font = new Font("Nirmala UI", 14.25F);
            tb_RentPerDay.Location = new Point(177, 103);
            tb_RentPerDay.Margin = new Padding(4, 3, 4, 3);
            tb_RentPerDay.Name = "tb_RentPerDay";
            tb_RentPerDay.Size = new Size(253, 39);
            tb_RentPerDay.TabIndex = 4;
            tb_RentPerDay.KeyPress += tb_RentPerDay_KeyPress;
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
            lbl_ItemID.Size = new Size(165, 49);
            lbl_ItemID.TabIndex = 0;
            lbl_ItemID.Text = "Item ID";
            lbl_ItemID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_ItemName
            // 
            tb_ItemName.Anchor = AnchorStyles.None;
            tb_ItemName.Font = new Font("Nirmala UI", 14.25F);
            tb_ItemName.Location = new Point(177, 54);
            tb_ItemName.Margin = new Padding(4, 3, 4, 3);
            tb_ItemName.Name = "tb_ItemName";
            tb_ItemName.ReadOnly = true;
            tb_ItemName.Size = new Size(253, 39);
            tb_ItemName.TabIndex = 3;
            // 
            // lbl_ItemName
            // 
            lbl_ItemName.AutoSize = true;
            lbl_ItemName.Dock = DockStyle.Fill;
            lbl_ItemName.Font = new Font("Nirmala UI", 14.25F);
            lbl_ItemName.ImeMode = ImeMode.NoControl;
            lbl_ItemName.Location = new Point(4, 49);
            lbl_ItemName.Margin = new Padding(4, 0, 4, 0);
            lbl_ItemName.Name = "lbl_ItemName";
            lbl_ItemName.Size = new Size(165, 49);
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
            lbl_Rent.Location = new Point(4, 98);
            lbl_Rent.Margin = new Padding(4, 0, 4, 0);
            lbl_Rent.Name = "lbl_Rent";
            lbl_Rent.Size = new Size(165, 49);
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
            btn_Update.Location = new Point(175, 324);
            btn_Update.Margin = new Padding(4, 3, 4, 3);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(182, 48);
            btn_Update.TabIndex = 5;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
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
            lbl_main.Text = "Update Item";
            lbl_main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UpdateItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(530, 417);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_Close);
            Controls.Add(btn_Update);
            Controls.Add(lbl_main);
            Font = new Font("Nirmala UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateRent";
            Load += UpdateRent_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tb_ItemID;
        private TextBox tb_RentPerDay;
        private Label lbl_ItemID;
        private TextBox tb_ItemName;
        private Label lbl_ItemName;
        private Label lbl_Rent;
        private Button btn_Close;
        private Button btn_Update;
        private Label lbl_main;
        private TextBox tb_MinRentalDays;
        private Label lbl_MinRentalDays;
    }
}