namespace HardwareRentalApp.UserControls
{
    partial class Inventory
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
            pnl_customerTable = new Panel();
            dgv_InventoryTable = new DataGridView();
            tb_search = new TextBox();
            lbl_search = new Label();
            lbl_mainPanel = new Label();
            pnl_customerTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_InventoryTable).BeginInit();
            SuspendLayout();
            // 
            // pnl_customerTable
            // 
            pnl_customerTable.BorderStyle = BorderStyle.FixedSingle;
            pnl_customerTable.Controls.Add(dgv_InventoryTable);
            pnl_customerTable.Controls.Add(tb_search);
            pnl_customerTable.Controls.Add(lbl_search);
            pnl_customerTable.Controls.Add(lbl_mainPanel);
            pnl_customerTable.Font = new Font("Nirmala UI", 7.8F);
            pnl_customerTable.Location = new Point(138, 89);
            pnl_customerTable.Name = "pnl_customerTable";
            pnl_customerTable.Size = new Size(1183, 584);
            pnl_customerTable.TabIndex = 1;
            // 
            // dgv_InventoryTable
            // 
            dgv_InventoryTable.AllowUserToAddRows = false;
            dgv_InventoryTable.AllowUserToDeleteRows = false;
            dgv_InventoryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_InventoryTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_InventoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_InventoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_InventoryTable.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_InventoryTable.Dock = DockStyle.Bottom;
            dgv_InventoryTable.Location = new Point(0, 147);
            dgv_InventoryTable.MultiSelect = false;
            dgv_InventoryTable.Name = "dgv_InventoryTable";
            dgv_InventoryTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Nirmala UI", 7.8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_InventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_InventoryTable.RowHeadersVisible = false;
            dgv_InventoryTable.RowHeadersWidth = 51;
            dgv_InventoryTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_InventoryTable.Size = new Size(1181, 435);
            dgv_InventoryTable.TabIndex = 2;
            dgv_InventoryTable.CellClick += dgv_InventoryTable_CellClick;
            // 
            // tb_search
            // 
            tb_search.Font = new Font("Nirmala UI", 13.8F);
            tb_search.Location = new Point(118, 73);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(272, 32);
            tb_search.TabIndex = 1;
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
            lbl_mainPanel.Text = "Inventory Information";
            lbl_mainPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(pnl_customerTable);
            Font = new Font("Nirmala UI", 13.8F);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Inventory";
            Size = new Size(1486, 962);
            Load += Inventory_Load;
            pnl_customerTable.ResumeLayout(false);
            pnl_customerTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_InventoryTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_customerTable;
        private DataGridView dgv_InventoryTable;
        private TextBox tb_search;
        private Label lbl_search;
        private Label lbl_mainPanel;
    }
}
