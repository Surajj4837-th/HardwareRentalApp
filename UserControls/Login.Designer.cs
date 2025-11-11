namespace HardwareRentalApp.UserControls
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            cb_Language = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Language = new Label();
            lbl_admin = new Label();
            ll_register = new LinkLabel();
            pnl_login = new Panel();
            btn_login = new Button();
            tb_Password = new TextBox();
            tb_MobileNo = new TextBox();
            lbl_Password = new Label();
            lbl_MobileNo = new Label();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            pnl_login.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cb_Language
            // 
            resources.ApplyResources(cb_Language, "cb_Language");
            cb_Language.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Language.FormattingEnabled = true;
            cb_Language.Items.AddRange(new object[] { resources.GetString("cb_Language.Items"), resources.GetString("cb_Language.Items1") });
            cb_Language.Name = "cb_Language";
            cb_Language.SelectedIndexChanged += Language_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(lbl_Language, 0, 0);
            tableLayoutPanel1.Controls.Add(cb_Language, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lbl_Language
            // 
            resources.ApplyResources(lbl_Language, "lbl_Language");
            lbl_Language.Name = "lbl_Language";
            // 
            // lbl_admin
            // 
            resources.ApplyResources(lbl_admin, "lbl_admin");
            lbl_admin.BackColor = Color.LightGreen;
            lbl_admin.Name = "lbl_admin";
            // 
            // ll_register
            // 
            resources.ApplyResources(ll_register, "ll_register");
            ll_register.Name = "ll_register";
            ll_register.TabStop = true;
            ll_register.LinkClicked += ll_register_LinkClicked;
            // 
            // pnl_login
            // 
            resources.ApplyResources(pnl_login, "pnl_login");
            pnl_login.BorderStyle = BorderStyle.FixedSingle;
            pnl_login.Controls.Add(btn_login);
            pnl_login.Controls.Add(tb_Password);
            pnl_login.Controls.Add(tb_MobileNo);
            pnl_login.Controls.Add(lbl_Password);
            pnl_login.Controls.Add(lbl_MobileNo);
            pnl_login.Name = "pnl_login";
            // 
            // btn_login
            // 
            resources.ApplyResources(btn_login, "btn_login");
            btn_login.Name = "btn_login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tb_Password
            // 
            resources.ApplyResources(tb_Password, "tb_Password");
            tb_Password.Name = "tb_Password";
            tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_MobileNo
            // 
            resources.ApplyResources(tb_MobileNo, "tb_MobileNo");
            tb_MobileNo.Name = "tb_MobileNo";
            // 
            // lbl_Password
            // 
            resources.ApplyResources(lbl_Password, "lbl_Password");
            lbl_Password.Name = "lbl_Password";
            // 
            // lbl_MobileNo
            // 
            resources.ApplyResources(lbl_MobileNo, "lbl_MobileNo");
            lbl_MobileNo.Name = "lbl_MobileNo";
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(pnl_login);
            panel1.Controls.Add(ll_register);
            panel1.Controls.Add(lbl_admin);
            panel1.Name = "panel1";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            pnl_login.ResumeLayout(false);
            pnl_login.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Language;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Language;
        private Label lbl_admin;
        private LinkLabel ll_register;
        private Panel pnl_login;
        private Button btn_login;
        private TextBox tb_Password;
        private TextBox tb_MobileNo;
        private Label lbl_Password;
        private Label lbl_MobileNo;
        private Panel panel1;
    }
}
