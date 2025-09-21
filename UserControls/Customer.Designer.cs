namespace HardwareRentalApp.UserControls
{
    partial class Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_ShowBills = new Button();
            btn_AddCustomer = new Button();
            tb_search = new TextBox();
            lbl_search = new Label();
            lbl_mainPanel = new Label();
            dgv_MultipurposeTable = new DataGridView();
            pnl_customerTable = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_MultipurposeTable).BeginInit();
            pnl_customerTable.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ShowBills
            // 
            btn_ShowBills.Enabled = false;
            btn_ShowBills.ImeMode = ImeMode.NoControl;
            btn_ShowBills.Location = new Point(165, 766);
            btn_ShowBills.Name = "btn_ShowBills";
            btn_ShowBills.Size = new Size(309, 42);
            btn_ShowBills.TabIndex = 3;
            btn_ShowBills.Text = "Show Bills";
            btn_ShowBills.UseVisualStyleBackColor = true;
            btn_ShowBills.Click += btn_ShowBills_Click;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.ImeMode = ImeMode.NoControl;
            btn_AddCustomer.Location = new Point(163, 681);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(309, 42);
            btn_AddCustomer.TabIndex = 1;
            btn_AddCustomer.Text = "Add New Customer";
            btn_AddCustomer.UseVisualStyleBackColor = true;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // tb_search
            // 
            tb_search.Location = new Point(127, 68);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(293, 33);
            tb_search.TabIndex = 1;
            tb_search.MouseClick += tb_search_MouseClick;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Font = new Font("Noto Sans", 14.25F);
            lbl_search.ImeMode = ImeMode.NoControl;
            lbl_search.Location = new Point(30, 70);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(79, 29);
            lbl_search.TabIndex = 0;
            lbl_search.Text = "Search:";
            lbl_search.Click += lbl_search_Click;
            // 
            // lbl_mainPanel
            // 
            lbl_mainPanel.Dock = DockStyle.Top;
            lbl_mainPanel.Font = new Font("Noto Sans", 15.75F, FontStyle.Bold);
            lbl_mainPanel.ImeMode = ImeMode.NoControl;
            lbl_mainPanel.Location = new Point(0, 0);
            lbl_mainPanel.Name = "lbl_mainPanel";
            lbl_mainPanel.Size = new Size(1272, 32);
            lbl_mainPanel.TabIndex = 0;
            lbl_mainPanel.Text = "Customer Information";
            lbl_mainPanel.TextAlign = ContentAlignment.MiddleCenter;
            lbl_mainPanel.Click += lbl_mainPanel_Click;
            // 
            // dgv_MultipurposeTable
            // 
            dgv_MultipurposeTable.AllowUserToAddRows = false;
            dgv_MultipurposeTable.AllowUserToDeleteRows = false;
            dgv_MultipurposeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_MultipurposeTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Noto Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_MultipurposeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_MultipurposeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_MultipurposeTable.Dock = DockStyle.Bottom;
            dgv_MultipurposeTable.Location = new Point(0, 137);
            dgv_MultipurposeTable.MultiSelect = false;
            dgv_MultipurposeTable.Name = "dgv_MultipurposeTable";
            dgv_MultipurposeTable.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Noto Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_MultipurposeTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_MultipurposeTable.RowHeadersVisible = false;
            dgv_MultipurposeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_MultipurposeTable.Size = new Size(1272, 407);
            dgv_MultipurposeTable.TabIndex = 2;
            dgv_MultipurposeTable.CellClick += dgv_MultipurposeTable_CellClick;
            dgv_MultipurposeTable.MouseDown += dgv_MultipurposeTable_MouseDown;
            // 
            // pnl_customerTable
            // 
            pnl_customerTable.BorderStyle = BorderStyle.FixedSingle;
            pnl_customerTable.Controls.Add(dgv_MultipurposeTable);
            pnl_customerTable.Controls.Add(tb_search);
            pnl_customerTable.Controls.Add(lbl_search);
            pnl_customerTable.Controls.Add(lbl_mainPanel);
            pnl_customerTable.Location = new Point(163, 93);
            pnl_customerTable.Name = "pnl_customerTable";
            pnl_customerTable.Size = new Size(1274, 546);
            pnl_customerTable.TabIndex = 0;
            pnl_customerTable.Click += pnl_customerTable_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_ShowBills);
            Controls.Add(btn_AddCustomer);
            Controls.Add(pnl_customerTable);
            Font = new Font("Noto Sans", 13.8F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Customer";
            Size = new Size(1600, 900);
            Load += Customer_Load;
            Click += Customer_Click;
            ((System.ComponentModel.ISupportInitialize)dgv_MultipurposeTable).EndInit();
            pnl_customerTable.ResumeLayout(false);
            pnl_customerTable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_ShowBills;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Label lbl_mainPanel;
        private System.Windows.Forms.DataGridView dgv_MultipurposeTable;
        private System.Windows.Forms.Panel pnl_customerTable;
    }
}
