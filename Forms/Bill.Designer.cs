namespace HardwareRentalApp.Forms
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            dgv_Sale = new DataGridView();
            lbl_WorkLocation = new Label();
            lbl_RentDate = new Label();
            lbl_Reference = new Label();
            lbl_OwnerName = new Label();
            tb_WorkLocation = new TextBox();
            tb_Reference = new TextBox();
            lbl_Customre = new Label();
            tb_OwnerName = new TextBox();
            tb_LesseeName = new TextBox();
            btn_Close = new Button();
            lbl_EndRentDate = new Label();
            dtp_EndRentDate = new DateTimePicker();
            tb_StartRentDate = new TextBox();
            tb_BillAmount = new TextBox();
            lbl_BillAmount = new Label();
            btn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Sale).BeginInit();
            SuspendLayout();
            // 
            // dgv_Sale
            // 
            dgv_Sale.AllowUserToAddRows = false;
            dgv_Sale.AllowUserToResizeRows = false;
            dgv_Sale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Sale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Sale.Location = new Point(60, 199);
            dgv_Sale.Name = "dgv_Sale";
            dgv_Sale.RowHeadersVisible = false;
            dgv_Sale.Size = new Size(855, 530);
            dgv_Sale.TabIndex = 19;
            // 
            // lbl_WorkLocation
            // 
            lbl_WorkLocation.AutoSize = true;
            lbl_WorkLocation.Font = new Font("Nirmala UI", 14.25F);
            lbl_WorkLocation.Location = new Point(518, 104);
            lbl_WorkLocation.Name = "lbl_WorkLocation";
            lbl_WorkLocation.Size = new Size(134, 25);
            lbl_WorkLocation.TabIndex = 14;
            lbl_WorkLocation.Text = "Work Location";
            // 
            // lbl_RentDate
            // 
            lbl_RentDate.AutoSize = true;
            lbl_RentDate.Font = new Font("Nirmala UI", 14.25F);
            lbl_RentDate.Location = new Point(60, 153);
            lbl_RentDate.Name = "lbl_RentDate";
            lbl_RentDate.Size = new Size(93, 25);
            lbl_RentDate.TabIndex = 15;
            lbl_RentDate.Text = "Rent Date";
            // 
            // lbl_Reference
            // 
            lbl_Reference.AutoSize = true;
            lbl_Reference.Font = new Font("Nirmala UI", 14.25F);
            lbl_Reference.Location = new Point(60, 99);
            lbl_Reference.Name = "lbl_Reference";
            lbl_Reference.Size = new Size(95, 25);
            lbl_Reference.TabIndex = 16;
            lbl_Reference.Text = "Reference";
            // 
            // lbl_OwnerName
            // 
            lbl_OwnerName.AutoSize = true;
            lbl_OwnerName.Font = new Font("Nirmala UI", 14.25F);
            lbl_OwnerName.Location = new Point(518, 49);
            lbl_OwnerName.Name = "lbl_OwnerName";
            lbl_OwnerName.Size = new Size(123, 25);
            lbl_OwnerName.TabIndex = 17;
            lbl_OwnerName.Text = "Owner Name";
            // 
            // tb_WorkLocation
            // 
            tb_WorkLocation.Font = new Font("Nirmala UI", 14.25F);
            tb_WorkLocation.Location = new Point(679, 101);
            tb_WorkLocation.Name = "tb_WorkLocation";
            tb_WorkLocation.ReadOnly = true;
            tb_WorkLocation.Size = new Size(236, 33);
            tb_WorkLocation.TabIndex = 10;
            // 
            // tb_Reference
            // 
            tb_Reference.Font = new Font("Nirmala UI", 14.25F);
            tb_Reference.Location = new Point(193, 96);
            tb_Reference.Name = "tb_Reference";
            tb_Reference.ReadOnly = true;
            tb_Reference.Size = new Size(236, 33);
            tb_Reference.TabIndex = 11;
            // 
            // lbl_Customre
            // 
            lbl_Customre.AutoSize = true;
            lbl_Customre.Font = new Font("Nirmala UI", 14.25F);
            lbl_Customre.Location = new Point(60, 49);
            lbl_Customre.Name = "lbl_Customre";
            lbl_Customre.Size = new Size(62, 25);
            lbl_Customre.TabIndex = 18;
            lbl_Customre.Text = "Name";
            // 
            // tb_OwnerName
            // 
            tb_OwnerName.Font = new Font("Nirmala UI", 14.25F);
            tb_OwnerName.Location = new Point(679, 46);
            tb_OwnerName.Name = "tb_OwnerName";
            tb_OwnerName.ReadOnly = true;
            tb_OwnerName.Size = new Size(236, 33);
            tb_OwnerName.TabIndex = 12;
            // 
            // tb_LesseeName
            // 
            tb_LesseeName.Font = new Font("Nirmala UI", 14.25F);
            tb_LesseeName.Location = new Point(193, 46);
            tb_LesseeName.Name = "tb_LesseeName";
            tb_LesseeName.ReadOnly = true;
            tb_LesseeName.Size = new Size(236, 33);
            tb_LesseeName.TabIndex = 13;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Nirmala UI", 8.25F);
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.ImeMode = ImeMode.NoControl;
            btn_Close.Location = new Point(990, 1);
            btn_Close.Margin = new Padding(1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(33, 33);
            btn_Close.TabIndex = 9;
            btn_Close.UseVisualStyleBackColor = true;
            // 
            // lbl_EndRentDate
            // 
            lbl_EndRentDate.AutoSize = true;
            lbl_EndRentDate.Font = new Font("Nirmala UI", 14.25F);
            lbl_EndRentDate.Location = new Point(518, 153);
            lbl_EndRentDate.Name = "lbl_EndRentDate";
            lbl_EndRentDate.Size = new Size(111, 25);
            lbl_EndRentDate.TabIndex = 15;
            lbl_EndRentDate.Text = "Return Date";
            // 
            // dtp_EndRentDate
            // 
            dtp_EndRentDate.CalendarFont = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_EndRentDate.Font = new Font("Nirmala UI", 14.25F);
            dtp_EndRentDate.Location = new Point(679, 147);
            dtp_EndRentDate.Name = "dtp_EndRentDate";
            dtp_EndRentDate.Size = new Size(236, 33);
            dtp_EndRentDate.TabIndex = 21;
            // 
            // tb_StartRentDate
            // 
            tb_StartRentDate.Font = new Font("Nirmala UI", 14.25F);
            tb_StartRentDate.Location = new Point(193, 147);
            tb_StartRentDate.Name = "tb_StartRentDate";
            tb_StartRentDate.ReadOnly = true;
            tb_StartRentDate.Size = new Size(236, 33);
            tb_StartRentDate.TabIndex = 11;
            // 
            // tb_BillAmount
            // 
            tb_BillAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_BillAmount.Font = new Font("Nirmala UI", 14.25F);
            tb_BillAmount.Location = new Point(679, 754);
            tb_BillAmount.Name = "tb_BillAmount";
            tb_BillAmount.ReadOnly = true;
            tb_BillAmount.Size = new Size(236, 33);
            tb_BillAmount.TabIndex = 10;
            // 
            // lbl_BillAmount
            // 
            lbl_BillAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_BillAmount.AutoSize = true;
            lbl_BillAmount.Font = new Font("Nirmala UI", 14.25F);
            lbl_BillAmount.Location = new Point(549, 757);
            lbl_BillAmount.Name = "lbl_BillAmount";
            lbl_BillAmount.Size = new Size(110, 25);
            lbl_BillAmount.TabIndex = 14;
            lbl_BillAmount.Text = "Bill Amount";
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Save.BackColor = Color.PaleGreen;
            btn_Save.Font = new Font("Nirmala UI", 14.25F);
            btn_Save.Location = new Point(735, 809);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(180, 36);
            btn_Save.TabIndex = 20;
            btn_Save.Text = "Finish Purchase";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 869);
            ControlBox = false;
            Controls.Add(dtp_EndRentDate);
            Controls.Add(btn_Save);
            Controls.Add(dgv_Sale);
            Controls.Add(lbl_EndRentDate);
            Controls.Add(lbl_BillAmount);
            Controls.Add(lbl_WorkLocation);
            Controls.Add(lbl_RentDate);
            Controls.Add(lbl_Reference);
            Controls.Add(lbl_OwnerName);
            Controls.Add(tb_BillAmount);
            Controls.Add(tb_WorkLocation);
            Controls.Add(tb_StartRentDate);
            Controls.Add(tb_Reference);
            Controls.Add(lbl_Customre);
            Controls.Add(tb_OwnerName);
            Controls.Add(tb_LesseeName);
            Controls.Add(btn_Close);
            Font = new Font("Nirmala UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill";
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)dgv_Sale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Sale;
        private Label lbl_WorkLocation;
        private Label lbl_RentDate;
        private Label lbl_Reference;
        private Label lbl_OwnerName;
        private TextBox tb_WorkLocation;
        private TextBox tb_Reference;
        private Label lbl_Customre;
        private TextBox tb_OwnerName;
        private TextBox tb_LesseeName;
        private Button btn_Close;
        private Label lbl_EndRentDate;
        private DateTimePicker dtp_EndRentDate;
        private TextBox tb_StartRentDate;
        private TextBox tb_BillAmount;
        private Label lbl_BillAmount;
        private Button btn_Save;
    }
}