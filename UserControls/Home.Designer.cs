namespace HardwareRentalApp.UserControls
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            btn_SaveFilePath = new Button();
            lbl_FilePath = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tt_SavePath = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_SaveFilePath
            // 
            btn_SaveFilePath.Dock = DockStyle.Fill;
            btn_SaveFilePath.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SaveFilePath.Location = new Point(4, 4);
            btn_SaveFilePath.Name = "btn_SaveFilePath";
            btn_SaveFilePath.Size = new Size(304, 34);
            btn_SaveFilePath.TabIndex = 0;
            btn_SaveFilePath.Text = "Path to Save Bill";
            btn_SaveFilePath.UseVisualStyleBackColor = true;
            btn_SaveFilePath.Click += btn_SaveFilePath_Click;
            // 
            // lbl_FilePath
            // 
            lbl_FilePath.AutoEllipsis = true;
            lbl_FilePath.AutoSize = true;
            lbl_FilePath.BackColor = Color.FromArgb(255, 224, 192);
            lbl_FilePath.Dock = DockStyle.Fill;
            lbl_FilePath.Font = new Font("Nirmala UI", 14.25F);
            lbl_FilePath.Location = new Point(315, 1);
            lbl_FilePath.Name = "lbl_FilePath";
            lbl_FilePath.Size = new Size(513, 40);
            lbl_FilePath.TabIndex = 1;
            lbl_FilePath.Text = "Path To File";
            lbl_FilePath.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(btn_SaveFilePath, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_FilePath, 1, 0);
            tableLayoutPanel1.Location = new Point(97, 84);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(832, 42);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tt_SavePath
            // 
            tt_SavePath.ShowAlways = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Nirmala UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Home";
            Size = new Size(1600, 900);
            Load += Home_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_SaveFilePath;
        private Label lbl_FilePath;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolTip tt_SavePath;
    }
}
