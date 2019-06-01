using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;


namespace BTS.UI.FlatForm
{
    public partial class User : Form
    {
        #region Constructor
        public User()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Events
        private void cboUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboUserName.SelectedIndex != 0)
            {
                this.BindControls();
                this.EnableDisableControls(true);
            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            this.EnableDisableControls(false);
            this.VisibleControls(false);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.UserReport userReport = new ReportDisplay.UserReport();
            userReport.ShowDialog();
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtUpperKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void InputControls_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        #endregion

        #region Method
        private void EnableDisableControls(bool enable)
        {
            this.txtUserName.Enabled = enable;
            //this.cboUserName.Enabled = enable;
            this.txtPassword.Enabled = enable;
            this.txtConfrimPassword.Enabled = enable;
            this.cboUserLevel.Enabled = enable;
            this.txtName.Enabled = enable;
        }

        private void VisibleControls(bool visible)
        {
            this.cboUserName.Visible = visible;
            this.txtUserName.Visible = !visible;
        }

        private void InitializeControls()
        {
            this.cboUserName.SelectedIndex = 0;
            this.txtUserName.Clear();
            this.txtPassword.Clear();
            this.txtConfrimPassword.Clear();
            this.cboUserLevel.SelectedIndex = 0;
            this.txtName.Clear();
        }

        private void BindUserName()
        {
            UserController userController = new UserController();
            UserCollection userCollection = userController.SelectList();

            UserInfo info = new UserInfo();
            info.UserName = " - Select One - ";
            info.UserID = null;
            userCollection.Insert(0, info);

            this.cboUserName.DisplayMember = "UserName";
            this.cboUserName.ValueMember = "UserID";
            this.cboUserName.DataSource = userCollection;
            this.cboUserName.SelectedIndex = 0;
        }

        private void BindUserLevel()
        {
            UserLevelController userLevelController = new UserLevelController();
            UserLevelCollections userLevelCollections = userLevelController.SelectList();

            UserLevelInfo info = new UserLevelInfo();
            info.UserLevel = " - Select One - ";
            info.UserLevelID = null;
            userLevelCollections.Insert(0, info);

            this.cboUserLevel.DisplayMember = "UserLevel";
            this.cboUserLevel.ValueMember = "UserLevelID";
            this.cboUserLevel.DataSource = userLevelCollections;
            this.cboUserLevel.SelectedIndex = 0;
        }
        
        private void BindComboBox(bool isIncludedUserName)
        {
            if (isIncludedUserName)
            {
                this.BindUserName();
            }
            this.BindUserLevel();
        }

        private void BindControls()
        {
            UserController userController = new UserController();
            UserInfo userInfo = userController.SelectByUserID(this.cboUserName.SelectedValue.ToString());

            this.txtName.Text = userInfo.Name;
            this.cboUserName.SelectedValue = userInfo.UserID;
            this.txtPassword.Text = userInfo.Password;
            this.txtConfrimPassword.Text = userInfo.Password;
            this.cboUserLevel.SelectedValue = userInfo.UserLevelID;
        }

        private void ResetControl()
        {
            if (NewEditExit.BtnNewText == "&Save" || NewEditExit.BtnNewText == "&Update" || NewEditExit.btnNew.Text == "&Update")
            {
                NewEditExit.btnNew.Text = "&New";
                NewEditExit.btnNew.ImageIndex = 5;
                NewEditExit.btnEdit.Enabled = true;
                NewEditExit.btnEdit.Text = "&Edit";
                NewEditExit.btnEdit.ImageIndex = 2;
                NewEditExit.btnClose.Text = "&Close";
                NewEditExit.btnClose.ImageIndex = 1;
            }
            this.InitializeControls();
            this.EnableDisableControls(false);
            this.VisibleControls(false);
        }

        private bool CheckRequiredFields()
        {
            if (this.txtUserName.Visible == true)
            {
                if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
                {
                    Globalizer.ShowMessage(MessageType.Warning, "User Name should not be blank");
                    this.txtUserName.Focus();
                    return false;
                }
            }

            if (this.cboUserName.Visible == true)
            {
                if (this.cboUserName.SelectedValue == null)
                {
                    Globalizer.ShowMessage(MessageType.Warning, "User Name should not be blank");
                    this.cboUserName.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Password should not be blank");
                this.txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtConfrimPassword.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Confrim Password should not be blank");
                this.txtConfrimPassword.Focus();
                return false;
            }

            if (this.txtPassword.Text != this.txtConfrimPassword.Text)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Password and Confrim Password does not match");
                this.txtConfrimPassword.Focus();
                return false;
            }


            if (this.cboUserLevel.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "User Level should not be blank");
                this.cboUserLevel.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Name should not be blank");
                this.txtName.Focus();
                return false;
            }
            return true;
        }
        #endregion           
        
        #region UserControl
        private void newEditExitButton_NewClick(object sender, EventArgs e)
        {
            try
            {
                switch (NewEditExit.BtnNewText)
                {
                    case "&New":
                        this.EnableDisableControls(true);
                        this.VisibleControls(false);
                        this.BindComboBox(false);
                        this.InitializeControls();
                        this.txtUserName.Focus();
                        break;

                    case "&Save":
                        if (this.CheckRequiredFields())
                        {
                            UserController userController = new UserController();
                            UserInfo userInfo = new UserInfo();

                            userInfo.UserID = string.Empty;
                            userInfo.Name = this.txtName.Text.Trim();
                            userInfo.UserName = this.txtUserName.Text.Trim();
                            userInfo.Password = this.txtPassword.Text.Trim();
                            userInfo.UserLevelID = this.cboUserLevel.SelectedValue.ToString();
                            userController.Insert(userInfo);

                            string log = "Form-User;Item-UserName:" + this.txtUserName.Text + ";action-Save";
                            userAction.Log(log);

                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                            this.ResetControl();

                            this.txtUserName.Focus();
                        }
                        break;

                    case "&Update":
                        if (this.CheckRequiredFields())
                        {
                            UserController userController = new UserController();
                            UserInfo userInfo = new UserInfo();

                            userInfo.UserID = this.cboUserName.SelectedValue.ToString();
                            userInfo.Name = this.txtName.Text.Trim();
                            userInfo.UserName = this.cboUserName.Text.Trim();
                            userInfo.Password = this.txtPassword.Text.Trim();
                            userInfo.UserLevelID = this.cboUserLevel.SelectedValue.ToString();
                            userController.UpdateByUserID(userInfo);

                            string log = "Form-User;Item-UserName:" + this.cboUserName.Text + ";action-Update";
                            userAction.Log(log);

                            Globalizer.ShowMessage(MessageType.Information, "Updated Successfully");
                            this.ResetControl();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Critical, ex.Message);
            }
        }

        private void newEditExitButton_EditClick(object sender, EventArgs e)
        {
            try
            {
                switch (NewEditExit.BtnEditText)
                {
                    case "&Edit":
                        this.EnableDisableControls(false);
                        this.VisibleControls(true);
                        this.BindComboBox(true);
                        this.InitializeControls();
                        break;

                    case "&Delete":
                        if (this.cboUserName.SelectedValue != null)
                        {
                            if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                            {
                                UserController userController = new UserController();

                                userController.DeleteByUserID(this.cboUserName.SelectedValue.ToString());

                                string log = "Form-User;Item-UserName:" + this.cboUserName.Text + ";action-Delete";
                                userAction.Log(log);

                                Globalizer.ShowMessage(MessageType.Information, "Deleted Successfully");
                                this.ResetControl();
                                this.BindUserName();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Critical, ex.Message);
            }
        }

        private void newEditExitButton_CloseClick(object sender, EventArgs e)
        {
            switch (NewEditExit.BtnCloseText)
            {
                case "&Close":
                    this.Dispose();
                    break;

                case "&Cancel":
                    this.EnableDisableControls(false);
                    this.VisibleControls(false);
                    this.InitializeControls();
                    break;
            }
        }
        #endregion        
    }
}