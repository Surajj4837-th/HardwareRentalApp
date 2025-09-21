using HardwareRentalApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HardwareRentalApp.Classes.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HardwareRentalApp.UserControls
{
    public partial class Login : UserControl
    {
        private DBInterface DBInterface = new DBInterface();
        private ResourceManager LangManager = new ResourceManager("HardwareRentalApp.Resources.MessageFiles.MessageStrings", typeof(Login).Assembly);
        private DataTable dtUser = new DataTable();
        public static Int32 AdminID;
        public static string m_st_Role;
        //private ActivateProduct Obj_ProductActivation = new ActivateProduct();
        string culture = Properties.Settings.Default.Language;
        public event EventHandler LoginSuccessful;

        public Login()
        {
            InitializeComponent();

            SetLanguage();

            ApplyLanguage();

            //***********************For development purpose only***********************
            if (System.Diagnostics.Debugger.IsAttached)
            {
                tb_MobileNo.Text = "9822236529";
                tb_Password.Text = "1234";
            }
        }
        public void ApplyLanguage()
        {
            this.lbl_admin.Text = LangManager.GetString("AdminLogin");
            this.lbl_MobileNo.Text = LangManager.GetString("MobileNumber");
            this.lbl_Password.Text = LangManager.GetString("Password");
            this.lbl_Language.Text = LangManager.GetString("Language");
            this.btn_login.Text = LangManager.GetString("Login");
            this.ll_register.Text = LangManager.GetString("RegisterHere");
        }

        private void SetLanguage()
        {
            if (Properties.Settings.Default.Language == "mr-IN")
                cb_Language.SelectedIndex = 0;
            else if (Properties.Settings.Default.Language == "mr")
                cb_Language.SelectedIndex = 0;
            else if (Properties.Settings.Default.Language == "en")
                cb_Language.SelectedIndex = 1;
            else
                cb_Language.SelectedIndex = 1;      //Default English language
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            string message = "";

            if (true)//(Obj_ProductActivation.VerifyProduct(out message))  //Temporarily deactivated
            {
                string mobile_num = tb_MobileNo.Text;
                string password = PasswordHelper.HashPassword(tb_Password.Text);

                if (mobile_num.Equals(""))
                {
                    MessageBox.Show(LangManager.GetString("EnterUsername"));
                }
                else if (password.Equals(""))

                {
                    MessageBox.Show(LangManager.GetString("EnterPassword"));
                }
                else
                {
                    try
                    {
                        string query = "Select * from Credentials Where MobileNumber = @mobile_num AND PasswordHash = @password";

                        var parameters = new Dictionary<string, object> { { "@mobile_num", mobile_num }, { "@password", password } };

                        DBInterface.ReadDataThroughAdapter(query, dtUser, parameters);

                        if (dtUser.Rows.Count >= 1)
                        {
                            AdminID = Convert.ToInt32(dtUser.Rows[0]["AdminId"].ToString());

                            m_st_Role = dtUser.Rows[0]["UserRole"].ToString();

                            if (m_st_Role == "Owner")
                            {
                                GlobalState.e_LoginProfile = Profile.Owner;
                            }
                            else if (m_st_Role == "Employee")
                            {
                                GlobalState.e_LoginProfile = Profile.Employee;
                            }

                            //if (Obj_ProductActivation.LessActivationDaysRemaining())  //Temporarily deactivated
                            //{
                            //    MessageBox.Show(LangManager.GetString("ActivationNeeded"));
                            //}

                            // Save selected language
                            Properties.Settings.Default.Language = culture;
                            Properties.Settings.Default.Save();
                            //MessageBox.Show("Login Successful");
                            this.Parent.Controls.Remove(this);
                            LoginSuccessful?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show(LangManager.GetString("InvalidCredentials"));
                        }
                    }
                    catch (Exception ex)
                    {
                        // Show exception details in a MessageBox
                        MessageBox.Show(
                            ex.Message,           // The exception message
                            "Error",              // Title of the message box
                            MessageBoxButtons.OK, // MessageBox buttons (OK)
                            MessageBoxIcon.Error);// MessageBox icon (Error)
                    }
                }
            }
            else
            {
                //ShowProductActivation(message);
            }
        }
        //private void ShowProductActivation(string message)
        //{
        //    using (var PA_form = new ActivateProduct(message))
        //    {
        //        if (PA_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //        }
        //    }
        //}

        private void ll_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var RegisterAdminForm = new RegisterAdmin();
            //RegisterAdminForm.ShowDialog();
        }

        private void Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_Language.SelectedIndex)
            {
                case 0:
                    culture = "mr-IN";
                    break;

                case 1:
                    culture = "en";
                    break;
            }

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);

            ApplyResourceToControl(this,
            new ComponentResourceManager(typeof(Login)),
            new CultureInfo(culture));

            ApplyLanguage();
        }
        private void ApplyResourceToControl(Control control, ComponentResourceManager cmp, CultureInfo cultureInfo)
        {
            foreach (Control child in control.Controls)
            {
                //Store current position and size of the control
                var childSize = child.Size;
                var childLoc = child.Location;

                //Apply CultureInfo to child control
                ApplyResourceToControl(child, cmp, cultureInfo);

                //Restore position and size
                child.Location = childLoc;
                child.Size = childSize;
            }

            //Do the same with the parent control
            var parentSize = control.Size;
            var parentLoc = control.Location;
            cmp.ApplyResources(control, control.Name, cultureInfo);
            control.Location = parentLoc;
            control.Size = parentSize;
        }
    }
}
