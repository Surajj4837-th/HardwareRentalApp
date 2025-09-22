namespace HardwareRentalApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnl_navigation = new Panel();
            btn_Logout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_Home = new Button();
            btn_Sale = new Button();
            btn_Customers = new Button();
            btn_Inventory = new Button();
            btn_Settings = new Button();
            pnl_OverlayUC = new Panel();
            pnl_Title = new Panel();
            lbl_Title = new Label();
            toolTip1 = new ToolTip(components);
            pnl_navigation.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_navigation
            // 
            pnl_navigation.BackColor = SystemColors.GradientActiveCaption;
            pnl_navigation.Controls.Add(btn_Logout);
            pnl_navigation.Controls.Add(flowLayoutPanel1);
            pnl_navigation.Dock = DockStyle.Left;
            pnl_navigation.Location = new Point(0, 0);
            pnl_navigation.Margin = new Padding(1);
            pnl_navigation.Name = "pnl_navigation";
            pnl_navigation.Size = new Size(206, 768);
            pnl_navigation.TabIndex = 0;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.IndianRed;
            btn_Logout.Dock = DockStyle.Bottom;
            btn_Logout.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold);
            btn_Logout.Location = new Point(0, 724);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(206, 44);
            btn_Logout.TabIndex = 5;
            btn_Logout.Text = "Logout";
            btn_Logout.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_Home);
            flowLayoutPanel1.Controls.Add(btn_Sale);
            flowLayoutPanel1.Controls.Add(btn_Customers);
            flowLayoutPanel1.Controls.Add(btn_Inventory);
            flowLayoutPanel1.Controls.Add(btn_Settings);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(206, 250);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // btn_Home
            // 
            btn_Home.BackColor = Color.FromArgb(51, 51, 76);
            btn_Home.Font = new Font("Nirmala UI", 14.25F);
            btn_Home.ForeColor = SystemColors.ButtonFace;
            btn_Home.Location = new Point(3, 3);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(200, 44);
            btn_Home.TabIndex = 0;
            btn_Home.Text = "Home";
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
            btn_Home.MouseEnter += btn_Home_MouseEnter;
            btn_Home.MouseLeave += btn_Home_MouseLeave;
            // 
            // btn_Sale
            // 
            btn_Sale.BackColor = Color.FromArgb(51, 51, 76);
            btn_Sale.Font = new Font("Nirmala UI", 14.25F);
            btn_Sale.ForeColor = SystemColors.ButtonFace;
            btn_Sale.Location = new Point(3, 53);
            btn_Sale.Name = "btn_Sale";
            btn_Sale.Size = new Size(200, 44);
            btn_Sale.TabIndex = 1;
            btn_Sale.Text = "Sale";
            btn_Sale.UseVisualStyleBackColor = false;
            btn_Sale.Click += btn_Sale_Click;
            btn_Sale.MouseEnter += btn_Sale_MouseEnter;
            btn_Sale.MouseLeave += btn_Sale_MouseLeave;
            // 
            // btn_Customers
            // 
            btn_Customers.BackColor = Color.FromArgb(51, 51, 76);
            btn_Customers.Font = new Font("Nirmala UI", 14.25F);
            btn_Customers.ForeColor = SystemColors.ButtonFace;
            btn_Customers.Location = new Point(3, 103);
            btn_Customers.Name = "btn_Customers";
            btn_Customers.Size = new Size(200, 44);
            btn_Customers.TabIndex = 2;
            btn_Customers.Text = "Customers";
            btn_Customers.UseVisualStyleBackColor = false;
            btn_Customers.Click += btn_Customers_Click;
            btn_Customers.MouseEnter += btn_Customers_MouseEnter;
            btn_Customers.MouseLeave += btn_Customers_MouseLeave;
            // 
            // btn_Inventory
            // 
            btn_Inventory.BackColor = Color.FromArgb(51, 51, 76);
            btn_Inventory.Font = new Font("Nirmala UI", 14.25F);
            btn_Inventory.ForeColor = SystemColors.ButtonFace;
            btn_Inventory.Location = new Point(3, 153);
            btn_Inventory.Name = "btn_Inventory";
            btn_Inventory.Size = new Size(200, 44);
            btn_Inventory.TabIndex = 3;
            btn_Inventory.Text = "Inventory";
            btn_Inventory.UseVisualStyleBackColor = false;
            btn_Inventory.Click += btn_Inventory_Click;
            btn_Inventory.MouseEnter += btn_Inventory_MouseEnter;
            btn_Inventory.MouseLeave += btn_Inventory_MouseLeave;
            // 
            // btn_Settings
            // 
            btn_Settings.BackColor = Color.FromArgb(51, 51, 76);
            btn_Settings.Font = new Font("Nirmala UI", 14.25F);
            btn_Settings.ForeColor = SystemColors.ButtonFace;
            btn_Settings.Location = new Point(3, 203);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(200, 44);
            btn_Settings.TabIndex = 4;
            btn_Settings.Text = "Settings";
            btn_Settings.UseVisualStyleBackColor = false;
            btn_Settings.Click += btn_Settings_Click;
            btn_Settings.MouseEnter += btn_Settings_MouseEnter;
            btn_Settings.MouseLeave += btn_Settings_MouseLeave;
            // 
            // pnl_OverlayUC
            // 
            pnl_OverlayUC.BackColor = SystemColors.AppWorkspace;
            pnl_OverlayUC.Dock = DockStyle.Fill;
            pnl_OverlayUC.Location = new Point(206, 0);
            pnl_OverlayUC.Name = "pnl_OverlayUC";
            pnl_OverlayUC.Size = new Size(1003, 768);
            pnl_OverlayUC.TabIndex = 1;
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.Cornsilk;
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnl_Title.Location = new Point(206, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(1003, 44);
            pnl_Title.TabIndex = 2;
            // 
            // lbl_Title
            // 
            lbl_Title.Dock = DockStyle.Fill;
            lbl_Title.Location = new Point(0, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(1003, 44);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "label1";
            lbl_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 768);
            Controls.Add(pnl_Title);
            Controls.Add(pnl_OverlayUC);
            Controls.Add(pnl_navigation);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "Hardware Rental App";
            Load += MainForm_Load;
            pnl_navigation.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pnl_Title.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_navigation;
        private Button btn_Logout;
        private Panel pnl_OverlayUC;
        private Panel pnl_Title;
        private Label lbl_Title;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_Home;
        private Button btn_Sale;
        private Button btn_Customers;
        private Button btn_Inventory;
        private Button btn_Settings;
    }
}
