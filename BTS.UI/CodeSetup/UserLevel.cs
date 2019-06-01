using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;

namespace BTS.UI.CodeSetup
{
    public partial class frmUserLevel : Form
    {
        #region Properties
        private string recordID = string.Empty;
        #endregion

        UserAction userAction = new UserAction();

        #region Constructor
        public frmUserLevel()
        {
            InitializeComponent();
        }
        #endregion 

        #region Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.btnSave.Text)
                {
                    case "&Save":
                        if (CheckRequiredFields())
                        {
                            UserLevelController userLevelController = new UserLevelController();
                            UserLevelInfo userLevelInfo = new UserLevelInfo();

                            userLevelInfo.UserLevelID = this.recordID;
                            userLevelInfo.UserLevelCode = this.txtUserLevelCode.Text.Trim();
                            userLevelInfo.UserLevel = this.txtUserLevel.Text.Trim();

                            userLevelController.Insert(userLevelInfo);

                            string log = "Form-UserLevel;Item-UserLevelCode:" + this.txtUserLevelCode.Text + ";action-Save";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                        }
                        break;

                    case "&Update":
                        if (CheckRequiredFields())
                        {
                            UserLevelController userLevelController = new UserLevelController();
                            UserLevelInfo userLevelInfo = new UserLevelInfo();

                            userLevelInfo.UserLevelID = this.recordID;
                            userLevelInfo.UserLevelCode = this.txtUserLevelCode.Text.Trim();
                            userLevelInfo.UserLevel = this.txtUserLevel.Text.Trim();

                            userLevelController.UpdateByUserLevelID(userLevelInfo);

                            string log = "Form-UserLevel;Item-UserLevelCode:" + this.txtUserLevelCode.Text + ";action-Update";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Updated Successfully");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Critical, ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.InitializeControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserLevel_Load(object sender, EventArgs e)
        {
            this.BindDataGridView();
        }

        private void txtUserLevelCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.UserLevelReport userLevelReport = new ReportDisplay.UserLevelReport();
            userLevelReport.ShowDialog();
        }

        private void txtUserLevelCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void dgvUserLevel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.recordID = this.dgvUserLevel.Rows[e.RowIndex].Cells["UserLevelID"].Value.ToString();

                        this.txtUserLevelCode.Text = this.dgvUserLevel.Rows[e.RowIndex].Cells["UserLevelCode"].Value.ToString();
                        this.txtUserLevel.Text = this.dgvUserLevel.Rows[e.RowIndex].Cells["UserLevel"].Value.ToString();

                        this.btnSave.Text = "&Update";
                        break;

                    case 1:
                        if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                        {
                            recordID = this.dgvUserLevel.Rows[e.RowIndex].Cells["UserLevelID"].Value.ToString();
                            UserLevelController userLevelController = new UserLevelController();

                            userLevelController.DeleteByUserLevelID(recordID);

                            string log = "Form-UserLevel;Item-UserLevelCode:" + this.txtUserLevelCode.Text + ";action-Delete";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Delete Successful");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Critical, ex.Message);
            }
        }
        #endregion

        #region Helper Methods
        private void InitializeControls()
        {
            this.txtUserLevelCode.Text = "";
            this.txtUserLevel.Text = "";
            this.btnSave.Text = "&Save";
            this.txtUserLevelCode.Focus();
            this.recordID = "";
        }

        private bool CheckRequiredFields()
        {
            if (string.IsNullOrEmpty(this.txtUserLevelCode.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "User Level  Code should not be blank");
                this.txtUserLevelCode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtUserLevel.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "User Level should not be blank");
                this.txtUserLevel.Focus();
                return false;
            }
            return true;
        }

        private void BindDataGridView()
        {
            UserLevelController userLevelController = new UserLevelController();
            UserLevelCollections userLevelCollections = userLevelController.SelectList();

            this.dgvUserLevel.AutoGenerateColumns = false;
            this.dgvUserLevel.DataSource = userLevelCollections;
        }
        #endregion                
    }
}