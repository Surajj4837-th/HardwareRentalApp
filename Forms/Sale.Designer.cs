namespace HardwareRentalApp.Forms
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_Close = new Button();
            textBox1 = new TextBox();
            lbl_Customre = new Label();
            textBox2 = new TextBox();
            lbl_OwnerName = new Label();
            textBox3 = new TextBox();
            lbl_Reference = new Label();
            textBox4 = new TextBox();
            lbl_WorkLocation = new Label();
            dgv_Sale = new DataGridView();
            btn_Save = new Button();
            lbl_RentDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgv_Sale).BeginInit();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Nirmala UI", 8.25F);
            btn_Close.Image = (Image)resources.GetObject("btn_Close.Image");
            btn_Close.ImeMode = ImeMode.NoControl;
            btn_Close.Location = new Point(987, 2);
            btn_Close.Margin = new Padding(1);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(33, 33);
            btn_Close.TabIndex = 3;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(190, 49);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(236, 33);
            textBox1.TabIndex = 4;
            // 
            // lbl_Customre
            // 
            lbl_Customre.AutoSize = true;
            lbl_Customre.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Customre.Location = new Point(57, 52);
            lbl_Customre.Name = "lbl_Customre";
            lbl_Customre.Size = new Size(62, 25);
            lbl_Customre.TabIndex = 5;
            lbl_Customre.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(676, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 33);
            textBox2.TabIndex = 4;
            // 
            // lbl_OwnerName
            // 
            lbl_OwnerName.AutoSize = true;
            lbl_OwnerName.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_OwnerName.Location = new Point(515, 52);
            lbl_OwnerName.Name = "lbl_OwnerName";
            lbl_OwnerName.Size = new Size(123, 25);
            lbl_OwnerName.TabIndex = 5;
            lbl_OwnerName.Text = "Owner Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(190, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 33);
            textBox3.TabIndex = 4;
            // 
            // lbl_Reference
            // 
            lbl_Reference.AutoSize = true;
            lbl_Reference.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Reference.Location = new Point(57, 102);
            lbl_Reference.Name = "lbl_Reference";
            lbl_Reference.Size = new Size(95, 25);
            lbl_Reference.TabIndex = 5;
            lbl_Reference.Text = "Reference";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(676, 104);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 33);
            textBox4.TabIndex = 4;
            // 
            // lbl_WorkLocation
            // 
            lbl_WorkLocation.AutoSize = true;
            lbl_WorkLocation.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_WorkLocation.Location = new Point(515, 107);
            lbl_WorkLocation.Name = "lbl_WorkLocation";
            lbl_WorkLocation.Size = new Size(134, 25);
            lbl_WorkLocation.TabIndex = 5;
            lbl_WorkLocation.Text = "Work Location";
            // 
            // dgv_Sale
            // 
            dgv_Sale.AllowUserToAddRows = false;
            dgv_Sale.AllowUserToResizeRows = false;
            dgv_Sale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Sale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Sale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Sale.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Sale.Location = new Point(57, 202);
            dgv_Sale.Name = "dgv_Sale";
            dgv_Sale.RowHeadersVisible = false;
            dgv_Sale.Size = new Size(855, 527);
            dgv_Sale.TabIndex = 6;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.PaleGreen;
            btn_Save.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Save.Location = new Point(619, 759);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(141, 36);
            btn_Save.TabIndex = 7;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // lbl_RentDate
            // 
            lbl_RentDate.AutoSize = true;
            lbl_RentDate.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RentDate.Location = new Point(57, 156);
            lbl_RentDate.Name = "lbl_RentDate";
            lbl_RentDate.Size = new Size(93, 25);
            lbl_RentDate.TabIndex = 5;
            lbl_RentDate.Text = "Rent Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(190, 148);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 33);
            dateTimePicker1.TabIndex = 8;
            // 
            // Sale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 818);
            ControlBox = false;
            Controls.Add(dateTimePicker1);
            Controls.Add(btn_Save);
            Controls.Add(dgv_Sale);
            Controls.Add(lbl_WorkLocation);
            Controls.Add(lbl_RentDate);
            Controls.Add(lbl_Reference);
            Controls.Add(lbl_OwnerName);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(lbl_Customre);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_Close);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Sale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)dgv_Sale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Close;
        private TextBox textBox1;
        private Label lbl_Customre;
        private TextBox textBox2;
        private Label lbl_OwnerName;
        private TextBox textBox3;
        private Label lbl_Reference;
        private TextBox textBox4;
        private Label lbl_WorkLocation;
        private DataGridView dgv_Sale;
        private Button btn_Save;
        private Label lbl_RentDate;
        private DateTimePicker dateTimePicker1;
    }
}