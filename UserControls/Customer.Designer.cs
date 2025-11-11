namespace HardwareRentalApp.UserControls
{
    partial class Customers
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            btn_ShowBills = new Button();
            btn_AddCustomer = new Button();
            tb_search = new TextBox();
            lbl_search = new Label();
            lbl_mainPanel = new Label();
            dgv_MultipurposeTable = new DataGridView();
            pnl_customerTable = new Panel();
            btn_Sale = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_MultipurposeTable).BeginInit();
            pnl_customerTable.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ShowBills
            // 
            btn_ShowBills.BackColor = SystemColors.ControlLightLight;
            btn_ShowBills.Enabled = false;
            btn_ShowBills.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            btn_ShowBills.ImeMode = ImeMode.NoControl;
            btn_ShowBills.Location = new Point(1063, 728);
            btn_ShowBills.Name = "btn_ShowBills";
            btn_ShowBills.Size = new Size(270, 45);
            btn_ShowBills.TabIndex = 3;
            btn_ShowBills.Text = "Show Bills";
            btn_ShowBills.UseVisualStyleBackColor = false;
            btn_ShowBills.Click += btn_ShowBills_Click;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.BackColor = SystemColors.ControlLightLight;
            btn_AddCustomer.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            btn_AddCustomer.ImeMode = ImeMode.NoControl;
            btn_AddCustomer.Location = new Point(151, 728);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(270, 45);
            btn_AddCustomer.TabIndex = 1;
            btn_AddCustomer.Text = "Add New Customer";
            btn_AddCustomer.UseVisualStyleBackColor = false;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // tb_search
            // 
            tb_search.Font = new Font("Nirmala UI", 13.8F);
            tb_search.Location = new Point(118, 73);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(272, 32);
            tb_search.TabIndex = 1;
            tb_search.MouseClick += tb_search_MouseClick;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // lbl_search
            // 
            lbl_search.AutoSize = true;
            lbl_search.Font = new Font("Nirmala UI", 13.8F);
            lbl_search.ImeMode = ImeMode.NoControl;
            lbl_search.Location = new Point(28, 75);
            lbl_search.Name = "lbl_search";
            lbl_search.Size = new Size(73, 25);
            lbl_search.TabIndex = 0;
            lbl_search.Text = "Search:";
            lbl_search.Click += lbl_search_Click;
            // 
            // lbl_mainPanel
            // 
            lbl_mainPanel.Dock = DockStyle.Top;
            lbl_mainPanel.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_mainPanel.ImeMode = ImeMode.NoControl;
            lbl_mainPanel.Location = new Point(0, 0);
            lbl_mainPanel.Name = "lbl_mainPanel";
            lbl_mainPanel.Size = new Size(1181, 34);
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
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_MultipurposeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_MultipurposeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_MultipurposeTable.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_MultipurposeTable.Dock = DockStyle.Bottom;
            dgv_MultipurposeTable.Location = new Point(0, 147);
            dgv_MultipurposeTable.MultiSelect = false;
            dgv_MultipurposeTable.Name = "dgv_MultipurposeTable";
            dgv_MultipurposeTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 7.8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_MultipurposeTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_MultipurposeTable.RowHeadersVisible = false;
            dgv_MultipurposeTable.RowHeadersWidth = 51;
            dgv_MultipurposeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_MultipurposeTable.Size = new Size(1181, 435);
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
            pnl_customerTable.Font = new Font("Nirmala UI", 7.8F);
            pnl_customerTable.Location = new Point(151, 99);
            pnl_customerTable.Name = "pnl_customerTable";
            pnl_customerTable.Size = new Size(1183, 584);
            pnl_customerTable.TabIndex = 0;
            pnl_customerTable.Click += pnl_customerTable_Click;
            // 
            // btn_Sale
            // 
            btn_Sale.BackColor = SystemColors.ControlLightLight;
            btn_Sale.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            btn_Sale.Image = (Image)resources.GetObject("btn_Sale.Image");
            btn_Sale.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sale.ImeMode = ImeMode.NoControl;
            btn_Sale.Location = new Point(620, 728);
            btn_Sale.Name = "btn_Sale";
            btn_Sale.Size = new Size(216, 45);
            btn_Sale.TabIndex = 1;
            btn_Sale.Text = "Sale";
            btn_Sale.UseVisualStyleBackColor = false;
            btn_Sale.Click += btn_Sale_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btn_ShowBills);
            Controls.Add(btn_Sale);
            Controls.Add(btn_AddCustomer);
            Controls.Add(pnl_customerTable);
            Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Customers";
            Size = new Size(1486, 962);
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
        private Button btn_Sale;
    }
}
