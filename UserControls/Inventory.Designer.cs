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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnl_customerTable = new Panel();
            dgv_InventoryTable = new DataGridView();
            tb_search = new TextBox();
            lbl_search = new Label();
            lbl_mainPanel = new Label();
            btn_AddItem = new Button();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_InventoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_InventoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgv_InventoryTable.DefaultCellStyle = dataGridViewCellStyle5;
            dgv_InventoryTable.Dock = DockStyle.Bottom;
            dgv_InventoryTable.Location = new Point(0, 147);
            dgv_InventoryTable.MultiSelect = false;
            dgv_InventoryTable.Name = "dgv_InventoryTable";
            dgv_InventoryTable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Nirmala UI", 7.8F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgv_InventoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // btn_AddItem
            // 
            btn_AddItem.BackColor = SystemColors.ControlLightLight;
            btn_AddItem.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            btn_AddItem.ImeMode = ImeMode.NoControl;
            btn_AddItem.Location = new Point(138, 756);
            btn_AddItem.Name = "btn_AddItem";
            btn_AddItem.Size = new Size(270, 45);
            btn_AddItem.TabIndex = 2;
            btn_AddItem.Text = "Add New Item";
            btn_AddItem.UseVisualStyleBackColor = false;
            btn_AddItem.Click += btn_AddItem_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btn_AddItem);
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
        private Button btn_AddItem;
    }
}
