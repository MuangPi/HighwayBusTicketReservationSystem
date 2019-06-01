using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using BTS.BusinessLogic;

namespace BTS.UI
{
    public partial class LogIn : Form
    {
        #region Constructor
        public LogIn()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Events
        private void LogIn_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            if (CheckRequiredFields())
            {
                try
                {
                    string str = userController.CheckUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                    if (str == "admin")
                    {
                        if (Globalizer.userName != null)
                        {
                            Globalizer.userName = null;
                        }
                        Globalizer.userName = txtUserName.Text;
                        string log = "--------------User LogIn:" + txtUserName.Text+";" +"Level:"+str+ "--------------";
                        userAction.Log(log);

                        MainMenu admin = new MainMenu();
                        admin.Show();
                        this.InitializeControl();
                        //this.txtUserName.Text = "";
                        //this.txtPassword.Text = "";
                    }
                    else if (str == "staff")
                    {
                        if (Globalizer.userName != null)
                        {
                            Globalizer.userName = null;
                        }
                        Globalizer.userName = txtUserName.Text;
                        string log = "--------------User LogIn:" + txtUserName.Text + "Level:" + str + "--------------";
                        userAction.Log(log);
                        
                        MainMenuForStaff staff = new MainMenuForStaff();
                        staff.Show();
                        this.InitializeControl();
                        //this.txtUserName.Text = "";
                        //this.txtPassword.Text = "";
                    }
                    this.Hide();
                }
                catch (Exception ex)
                {
                   
                    Globalizer.ShowMessage(MessageType.Warning, ex.Message);
                    this.InitializeControl();
                    this.txtUserName.Focus();
                }
               // this.Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Methods
        private bool CheckRequiredFields()
        {
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Please enter the User Name");
                this.txtUserName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Please enter the Password");
                this.txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void InitializeControl()
        {
            this.txtUserName.Text = "";
            this.txtPassword.Text = "";
        }
        #endregion

    }
}