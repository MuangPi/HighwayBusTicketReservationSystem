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
    public partial class Driver : Form
    {
        #region Variables
        private string recordID = string.Empty;
        #endregion

        #region Constructor
        public Driver()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Events
        private void Driver_Load(object sender, EventArgs e)
        {
            this.BindDataGridView();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.DriverReport driverReport = new ReportDisplay.DriverReport();
            driverReport.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.btnSave.Text)
                {
                    case "&Save":
                        if (this.CheckRequiredFields())
                        {
                            DriverController driverController = new DriverController();
                            DriverInfo driverInfo = new DriverInfo();
                            driverInfo.DriverID = this.recordID;
                            driverInfo.DriverCode = this.txtDriverCode.Text.Trim();
                            driverInfo.DriverName = this.txtDriverName.Text.Trim();
                            driverInfo.DriverLicence = this.txtDriverLicence.Text.Trim();
                            driverInfo.NRCNo = this.txtNRCNo.Text.Trim();
                            driverInfo.PhoneNo = this.txtPhoneNo.Text.Trim();
                            driverInfo.Address = this.txtAddress.Text.Trim();

                            driverController.Insert(driverInfo);

                            string log = "Form-Driver;Item-DriverCode:" + this.txtDriverCode.Text + ";action-Save";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                        }
                        break;

                    case "&Update":
                        if (this.CheckRequiredFields())
                        {
                            DriverController driverController = new DriverController();
                            DriverInfo driverInfo = new DriverInfo();

                            driverInfo.DriverID = this.recordID;
                            driverInfo.DriverCode = this.txtDriverCode.Text.Trim();
                            driverInfo.DriverName = this.txtDriverName.Text.Trim();
                            driverInfo.DriverLicence = this.txtDriverLicence.Text.Trim();
                            driverInfo.NRCNo = this.txtNRCNo.Text.Trim();
                            driverInfo.PhoneNo = this.txtPhoneNo.Text.Trim();
                            driverInfo.Address = this.txtAddress.Text.Trim();

                            driverController.UpdateByDriverID(driverInfo);

                            string log = "Form-Driver;Item-DriverCode:" + this.txtDriverCode.Text + ";action-Update";
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

        private void dgvDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.recordID = this.dgvDriver.Rows[e.RowIndex].Cells["DriverID"].Value.ToString();

                        this.txtDriverCode.Text = this.dgvDriver.Rows[e.RowIndex].Cells["DriverCode"].Value.ToString();
                        this.txtDriverName.Text = this.dgvDriver.Rows[e.RowIndex].Cells["DriverName"].Value.ToString();
                        this.txtDriverLicence.Text = this.dgvDriver.Rows[e.RowIndex].Cells["DriverLicence"].Value.ToString();
                        this.txtNRCNo.Text = this.dgvDriver.Rows[e.RowIndex].Cells["NRCNo"].Value.ToString();
                        this.txtPhoneNo.Text = this.dgvDriver.Rows[e.RowIndex].Cells["PhoneNo"].Value.ToString();
                        this.txtAddress.Text = this.dgvDriver.Rows[e.RowIndex].Cells["Address"].Value.ToString();

                        this.btnSave.Text = "&Update";
                        break;

                    case 1:
                        if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                        {
                            recordID = this.dgvDriver.Rows[e.RowIndex].Cells["DriverID"].Value.ToString();
                            DriverController driverController = new DriverController();

                            driverController.DeleteByDriverID(this.recordID);

                            string log = "Form-Driver;Item-DriverCode:" + this.txtDriverCode.Text + ";action-Delete";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Deleted Successfully");
                        }
                        break;


                }

            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Critical, ex.Message);
            }
           
        }

        private void txtUpperKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void InputControls_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion

        #region Methods
        private void InitializeControls()
        {
            this.txtDriverCode.Text = "";
            this.txtDriverName.Text = "";
            this.txtDriverLicence.Text = "";
            this.txtNRCNo.Text = "";
            this.txtPhoneNo.Text = "";
            this.txtAddress.Text = "";
            this.btnSave.Text = "&Save";
            this.txtDriverCode.Focus();
            this.recordID = "";
        }

        private void BindDataGridView()
        {
            DriverController driverController = new DriverController();
            DriverCollections driverCollections = driverController.SelectList();

            dgvDriver.AutoGenerateColumns = false;
            dgvDriver.DataSource = driverCollections;
        }

        private bool CheckRequiredFields()
        {
            if (string.IsNullOrEmpty(this.txtDriverCode.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Driver Code should not be blank");
                this.txtDriverCode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtDriverName.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Driver Name should not be blank");
                this.txtDriverName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtDriverLicence.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Driver Licence should not be blank");
                this.txtDriverLicence.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtNRCNo.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "NRC No should not be blank");
                this.txtNRCNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPhoneNo.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Phone No should not be blank");
                this.txtPhoneNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtAddress.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Address should not be blank");
                this.txtAddress.Focus();
                return false;
            }
            return true;
        }
        #endregion               
    }
}