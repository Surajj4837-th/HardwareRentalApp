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
            dgv_Bill = new DataGridView();
            lbl_WorkLocation = new Label();
            lbl_RentDate = new Label();
            lbl_Reference = new Label();
            lbl_OwnerName = new Label();
            tb_WorkLocation = new TextBox();
            tb_Reference = new TextBox();
            lbl_LesseeName = new Label();
            tb_OwnerName = new TextBox();
            tb_LesseeName = new TextBox();
            btn_Close = new Button();
            lbl_EndRentDate = new Label();
            dtp_EndRentDate = new DateTimePicker();
            tb_StartRentDate = new TextBox();
            tb_BillAmount = new TextBox();
            lbl_BillAmount = new Label();
            btn_MultipurposeButton = new Button();
            lbl_main = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).BeginInit();
            SuspendLayout();
            // 
            // dgv_Bill
            // 
            dgv_Bill.AllowUserToAddRows = false;
            dgv_Bill.AllowUserToResizeRows = false;
            dgv_Bill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Bill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bill.Location = new Point(60, 249);
            dgv_Bill.Name = "dgv_Bill";
            dgv_Bill.Size = new Size(892, 530);
            dgv_Bill.TabIndex = 19;
            dgv_Bill.CellBeginEdit += dgv_Bill_CellBeginEdit;
            dgv_Bill.CellValidating += dgv_Bill_CellValidating;
            dgv_Bill.CurrentCellDirtyStateChanged += dgv_Bill_CurrentCellDirtyStateChanged;
            dgv_Bill.EditingControlShowing += dgv_Bill_EditingControlShowing;
            // 
            // lbl_WorkLocation
            // 
            lbl_WorkLocation.AutoSize = true;
            lbl_WorkLocation.Font = new Font("Nirmala UI", 14.25F);
            lbl_WorkLocation.Location = new Point(518, 154);
            lbl_WorkLocation.Name = "lbl_WorkLocation";
            lbl_WorkLocation.Size = new Size(134, 25);
            lbl_WorkLocation.TabIndex = 14;
            lbl_WorkLocation.Text = "Work Location";
            // 
            // lbl_RentDate
            // 
            lbl_RentDate.AutoSize = true;
            lbl_RentDate.Font = new Font("Nirmala UI", 14.25F);
            lbl_RentDate.Location = new Point(60, 203);
            lbl_RentDate.Name = "lbl_RentDate";
            lbl_RentDate.Size = new Size(93, 25);
            lbl_RentDate.TabIndex = 15;
            lbl_RentDate.Text = "Rent Date";
            // 
            // lbl_Reference
            // 
            lbl_Reference.AutoSize = true;
            lbl_Reference.Font = new Font("Nirmala UI", 14.25F);
            lbl_Reference.Location = new Point(60, 149);
            lbl_Reference.Name = "lbl_Reference";
            lbl_Reference.Size = new Size(95, 25);
            lbl_Reference.TabIndex = 16;
            lbl_Reference.Text = "Reference";
            // 
            // lbl_OwnerName
            // 
            lbl_OwnerName.AutoSize = true;
            lbl_OwnerName.Font = new Font("Nirmala UI", 14.25F);
            lbl_OwnerName.Location = new Point(518, 99);
            lbl_OwnerName.Name = "lbl_OwnerName";
            lbl_OwnerName.Size = new Size(123, 25);
            lbl_OwnerName.TabIndex = 17;
            lbl_OwnerName.Text = "Owner Name";
            // 
            // tb_WorkLocation
            // 
            tb_WorkLocation.Font = new Font("Nirmala UI", 14.25F);
            tb_WorkLocation.Location = new Point(716, 146);
            tb_WorkLocation.Name = "tb_WorkLocation";
            tb_WorkLocation.ReadOnly = true;
            tb_WorkLocation.Size = new Size(236, 33);
            tb_WorkLocation.TabIndex = 10;
            // 
            // tb_Reference
            // 
            tb_Reference.Font = new Font("Nirmala UI", 14.25F);
            tb_Reference.Location = new Point(193, 146);
            tb_Reference.Name = "tb_Reference";
            tb_Reference.ReadOnly = true;
            tb_Reference.Size = new Size(236, 33);
            tb_Reference.TabIndex = 11;
            // 
            // lbl_LesseeName
            // 
            lbl_LesseeName.AutoSize = true;
            lbl_LesseeName.Font = new Font("Nirmala UI", 14.25F);
            lbl_LesseeName.Location = new Point(60, 99);
            lbl_LesseeName.Name = "lbl_LesseeName";
            lbl_LesseeName.Size = new Size(62, 25);
            lbl_LesseeName.TabIndex = 18;
            lbl_LesseeName.Text = "Name";
            // 
            // tb_OwnerName
            // 
            tb_OwnerName.Font = new Font("Nirmala UI", 14.25F);
            tb_OwnerName.Location = new Point(716, 91);
            tb_OwnerName.Name = "tb_OwnerName";
            tb_OwnerName.ReadOnly = true;
            tb_OwnerName.Size = new Size(236, 33);
            tb_OwnerName.TabIndex = 12;
            // 
            // tb_LesseeName
            // 
            tb_LesseeName.Font = new Font("Nirmala UI", 14.25F);
            tb_LesseeName.Location = new Point(193, 96);
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
            btn_Close.Click += btn_Close_Click;
            // 
            // lbl_EndRentDate
            // 
            lbl_EndRentDate.AutoSize = true;
            lbl_EndRentDate.Font = new Font("Nirmala UI", 14.25F);
            lbl_EndRentDate.Location = new Point(518, 203);
            lbl_EndRentDate.Name = "lbl_EndRentDate";
            lbl_EndRentDate.Size = new Size(111, 25);
            lbl_EndRentDate.TabIndex = 15;
            lbl_EndRentDate.Text = "Return Date";
            // 
            // dtp_EndRentDate
            // 
            dtp_EndRentDate.CalendarFont = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtp_EndRentDate.Font = new Font("Nirmala UI", 14.25F);
            dtp_EndRentDate.Location = new Point(716, 197);
            dtp_EndRentDate.Name = "dtp_EndRentDate";
            dtp_EndRentDate.Size = new Size(236, 33);
            dtp_EndRentDate.TabIndex = 21;
            dtp_EndRentDate.ValueChanged += dtp_EndRentDate_ValueChanged;
            // 
            // tb_StartRentDate
            // 
            tb_StartRentDate.Font = new Font("Nirmala UI", 14.25F);
            tb_StartRentDate.Location = new Point(193, 197);
            tb_StartRentDate.Name = "tb_StartRentDate";
            tb_StartRentDate.ReadOnly = true;
            tb_StartRentDate.Size = new Size(236, 33);
            tb_StartRentDate.TabIndex = 11;
            // 
            // tb_BillAmount
            // 
            tb_BillAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tb_BillAmount.Font = new Font("Nirmala UI", 14.25F);
            tb_BillAmount.Location = new Point(712, 809);
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
            lbl_BillAmount.Location = new Point(549, 812);
            lbl_BillAmount.Name = "lbl_BillAmount";
            lbl_BillAmount.Size = new Size(110, 25);
            lbl_BillAmount.TabIndex = 14;
            lbl_BillAmount.Text = "Bill Amount";
            // 
            // btn_MultipurposeButton
            // 
            btn_MultipurposeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_MultipurposeButton.BackColor = Color.PaleGreen;
            btn_MultipurposeButton.Enabled = false;
            btn_MultipurposeButton.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MultipurposeButton.Location = new Point(768, 864);
            btn_MultipurposeButton.Name = "btn_MultipurposeButton";
            btn_MultipurposeButton.Size = new Size(180, 36);
            btn_MultipurposeButton.TabIndex = 20;
            btn_MultipurposeButton.Text = "Finish Purchase";
            btn_MultipurposeButton.UseVisualStyleBackColor = false;
            btn_MultipurposeButton.Click += btn_MultipurposeButton_Click;
            // 
            // lbl_main
            // 
            lbl_main.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_main.Location = new Point(0, 37);
            lbl_main.Name = "lbl_main";
            lbl_main.Size = new Size(1023, 33);
            lbl_main.TabIndex = 22;
            lbl_main.Text = "Pending Bill";
            lbl_main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 924);
            ControlBox = false;
            Controls.Add(lbl_main);
            Controls.Add(dtp_EndRentDate);
            Controls.Add(btn_MultipurposeButton);
            Controls.Add(dgv_Bill);
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
            Controls.Add(lbl_LesseeName);
            Controls.Add(tb_OwnerName);
            Controls.Add(tb_LesseeName);
            Controls.Add(btn_Close);
            Font = new Font("Nirmala UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            Load += Bill_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Bill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_Bill;
        private Label lbl_WorkLocation;
        private Label lbl_RentDate;
        private Label lbl_Reference;
        private Label lbl_OwnerName;
        private TextBox tb_WorkLocation;
        private TextBox tb_Reference;
        private Label lbl_LesseeName;
        private TextBox tb_OwnerName;
        private TextBox tb_LesseeName;
        private Button btn_Close;
        private Label lbl_EndRentDate;
        private DateTimePicker dtp_EndRentDate;
        private TextBox tb_StartRentDate;
        private TextBox tb_BillAmount;
        private Label lbl_BillAmount;
        private Button btn_MultipurposeButton;
        private Label lbl_main;
    }
}