namespace HardwareRentalApp.Forms
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            tableLayoutPanel1 = new TableLayoutPanel();
            tb_LesseeName = new TextBox();
            tb_LesseeAddress = new TextBox();
            lbl_LesseeName = new Label();
            tb_MobileNum = new TextBox();
            lbl_MobileNum = new Label();
            lbl_LesseeAddress = new Label();
            lbl_main = new Label();
            btn_Add = new Button();
            btn_Close = new Button();
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
            tableLayoutPanel1.Controls.Add(lbl_LesseeName, 0, 0);
            tableLayoutPanel1.Controls.Add(tb_MobileNum, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_MobileNum, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_LesseeAddress, 0, 2);
            tableLayoutPanel1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(52, 98);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(434, 175);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tb_LesseeName
            // 
            tb_LesseeName.Anchor = AnchorStyles.None;
            tb_LesseeName.Font = new Font("Nirmala UI", 14.25F);
            tb_LesseeName.Location = new Point(176, 12);
            tb_LesseeName.Name = "tb_LesseeName";
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
            // lbl_LesseeName
            // 
            lbl_LesseeName.AutoSize = true;
            lbl_LesseeName.Dock = DockStyle.Fill;
            lbl_LesseeName.Font = new Font("Nirmala UI", 14.25F);
            lbl_LesseeName.ImeMode = ImeMode.NoControl;
            lbl_LesseeName.Location = new Point(4, 0);
            lbl_LesseeName.Margin = new Padding(4, 0, 4, 0);
            lbl_LesseeName.Name = "lbl_LesseeName";
            lbl_LesseeName.Size = new Size(165, 58);
            lbl_LesseeName.TabIndex = 0;
            lbl_LesseeName.Text = "Lessee Name";
            lbl_LesseeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_MobileNum
            // 
            tb_MobileNum.Anchor = AnchorStyles.None;
            tb_MobileNum.Font = new Font("Nirmala UI", 14.25F);
            tb_MobileNum.Location = new Point(177, 70);
            tb_MobileNum.Margin = new Padding(4, 3, 4, 3);
            tb_MobileNum.Name = "tb_MobileNum";
            tb_MobileNum.Size = new Size(253, 33);
            tb_MobileNum.TabIndex = 3;
            tb_MobileNum.KeyPress += tb_MobileNum_KeyPress;
            // 
            // lbl_MobileNum
            // 
            lbl_MobileNum.AutoSize = true;
            lbl_MobileNum.Dock = DockStyle.Fill;
            lbl_MobileNum.Font = new Font("Nirmala UI", 14.25F);
            lbl_MobileNum.ImeMode = ImeMode.NoControl;
            lbl_MobileNum.Location = new Point(4, 58);
            lbl_MobileNum.Margin = new Padding(4, 0, 4, 0);
            lbl_MobileNum.Name = "lbl_MobileNum";
            lbl_MobileNum.Size = new Size(165, 58);
            lbl_MobileNum.TabIndex = 0;
            lbl_MobileNum.Text = "Mobile No.";
            lbl_MobileNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_LesseeAddress
            // 
            lbl_LesseeAddress.AutoSize = true;
            lbl_LesseeAddress.Dock = DockStyle.Fill;
            lbl_LesseeAddress.Font = new Font("Nirmala UI", 14.25F);
            lbl_LesseeAddress.ImeMode = ImeMode.NoControl;
            lbl_LesseeAddress.Location = new Point(4, 116);
            lbl_LesseeAddress.Margin = new Padding(4, 0, 4, 0);
            lbl_LesseeAddress.Name = "lbl_LesseeAddress";
            lbl_LesseeAddress.Size = new Size(165, 59);
            lbl_LesseeAddress.TabIndex = 0;
            lbl_LesseeAddress.Text = "Lessee Address";
            lbl_LesseeAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_main
            // 
            lbl_main.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            lbl_main.ImeMode = ImeMode.NoControl;
            lbl_main.Location = new Point(-1, 35);
            lbl_main.Margin = new Padding(4, 0, 4, 0);
            lbl_main.Name = "lbl_main";
            lbl_main.Size = new Size(530, 44);
            lbl_main.TabIndex = 0;
            lbl_main.Text = "Add New Customer";
            lbl_main.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold);
            btn_Add.ImeMode = ImeMode.NoControl;
            btn_Add.Location = new Point(174, 310);
            btn_Add.Margin = new Padding(4, 3, 4, 3);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(182, 48);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Add Customer";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Nirmala UI", 8.25F);
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.ImeMode = ImeMode.NoControl;
            btn_Close.Location = new Point(496, -3);
            btn_Close.Margin = new Padding(1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(33, 33);
            btn_Close.TabIndex = 2;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 417);
            Controls.Add(btn_Close);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_Add);
            Controls.Add(lbl_main);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddCustomer_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_LesseeAddress;
        private System.Windows.Forms.Label lbl_LesseeName;
        private System.Windows.Forms.TextBox tb_MobileNum;
        private System.Windows.Forms.Label lbl_MobileNum;
        private System.Windows.Forms.Label lbl_LesseeAddress;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_LesseeName;
        private Button btn_Close;
    }
}