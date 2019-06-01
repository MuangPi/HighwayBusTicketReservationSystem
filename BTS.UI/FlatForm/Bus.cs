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
    public partial class Bus : Form
    {
        #region Constructor
        public Bus()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Methods
        private void EnableDisableControls(bool enable)
        {
            this.txtBusCode.Enabled = enable;
            this.txtBusNumber.Enabled = enable;
            this.cboBusType.Enabled = enable;
            this.lblTotalSeat.Enabled = enable;
        }

        private void VisibleControls(bool visible)
        {
            this.cboBusCode.Visible = visible;
            this.txtBusCode.Visible = !visible;
        }

        private void InitializeControls()
        {
            this.cboBusCode.SelectedIndex = 0;
            this.txtBusCode.Clear();
            this.txtBusNumber.Clear();
            this.cboBusType.SelectedIndex = 0;
            this.lblTotalSeat.Text = "";
        }

        private void BindBusCode()
        {
            BusController busController = new BusController();
            BusCollection busCollections = busController.SelectList();

            BusInfo info = new BusInfo();
            info.BusCode = " - Select One - ";
            info.BusID = null;
            busCollections.Insert(0, info);

            this.cboBusCode.DisplayMember = "BusCode";
            this.cboBusCode.ValueMember = "BusID";
            this.cboBusCode.DataSource = busCollections;
        }

        private void BindBusType()
        {
            BusTypeController busTypeController = new BusTypeController();
            BusTypeCollections busTypeCollections = busTypeController.SelectList();

            BusTypeInfo info = new BusTypeInfo();
            info.Description = " - Select One - ";
            info.BusTypeID = null;
            busTypeCollections.Insert(0, info);

            this.cboBusType.DisplayMember = "Description";
            this.cboBusType.ValueMember = "BusTypeID";
            this.cboBusType.DataSource = busTypeCollections;
        }

        private void BindComboBox(bool isIncludedBusCode)
        {
            if (isIncludedBusCode)
            {
                this.BindBusCode();
            }
            this.BindBusType();
        }

        private void BindControls()
        {
            BusController busController = new BusController();
            BusInfo busInfo = busController.SelectByBusID(this.cboBusCode.SelectedValue.ToString());

            this.cboBusCode.SelectedValue = busInfo.BusID;
            this.txtBusNumber.Text = busInfo.BusNo;
            this.cboBusType.SelectedValue = busInfo.BusTypeID;
            this.lblTotalSeat.Text = Convert.ToString(busInfo.TotalSeats);
        }

        private void BindTotalSeats()
        {
            BusTypeController busTypeController = new BusTypeController();
            BusTypeInfo busTypeInfo = busTypeController.SelectByBusTypeID(this.cboBusType.SelectedValue.ToString());

            this.cboBusType.SelectedValue = busTypeInfo.BusTypeID;
            this.lblTotalSeat.Text = Convert.ToString(busTypeInfo.TotalSeats);
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
            if (this.txtBusCode.Visible == true)
            {
                if (string.IsNullOrEmpty(this.txtBusCode.Text.Trim()))
                {
                    Globalizer.ShowMessage(MessageType.Warning, "Bus Code should not be blank");
                    this.txtBusCode.Focus();
                    return false;
                }
            }

            if (this.cboBusCode.Visible == true)
            {
                if (this.cboBusCode.SelectedValue == null)
                {
                    Globalizer.ShowMessage(MessageType.Warning, "Bus Code should not be blank");
                    this.cboBusCode.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(this.txtBusNumber.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Bus No should not be blank");
                this.txtBusNumber.Focus();
                return false;
            }

            if (this.cboBusType.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Bus Type should not be blank");
                this.cboBusType.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void Bus_Load(object sender, EventArgs e)
        {
            this.EnableDisableControls(false);
            this.VisibleControls(false);
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.BusReport busReport = new ReportDisplay.BusReport();
            busReport.ShowDialog();
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboBusType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboBusType.SelectedIndex != 0)
            {
                this.BindTotalSeats();
            }
        }

        private void cboBusCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboBusCode.SelectedIndex != 0)
            {
                this.EnableDisableControls(true);
                this.BindControls();
            }
        }
        #endregion        

        #region UserControl

        private void NewEditExit_NewClick(object sender, EventArgs e)
        {
            try
            {
                switch (NewEditExit.BtnNewText)
                {
                    case "&New":
                        this.EnableDisableControls(true);
                        this.BindComboBox(false);
                        this.InitializeControls();
                        this.txtBusCode.Focus();
                        break;

                    case "&Save":
                        if (this.CheckRequiredFields())
                        {
                            BusController busController = new BusController();
                            BusInfo busInfo = new BusInfo();

                            busInfo.BusID = string.Empty;
                            busInfo.BusCode = this.txtBusCode.Text.Trim();
                            busInfo.BusNo = this.txtBusNumber.Text.Trim();
                            busInfo.BusTypeID = this.cboBusType.SelectedValue.ToString();
                            busInfo.TotalSeats = Convert.ToInt32(this.lblTotalSeat.Text.Trim());

                            busController.Insert(busInfo);

                            string log = "Form-Bus;Item-BusCode:" + this.txtBusCode.Text + ";action-Save";
                            userAction.Log(log);

                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                            this.ResetControl();

                            this.txtBusCode.Focus();
                        }
                        break;

                    case "&Update":
                        if (this.CheckRequiredFields())
                        {
                            BusController busController = new BusController();
                            BusInfo busInfo = new BusInfo();

                            busInfo.BusID = this.cboBusCode.SelectedValue.ToString();
                            busInfo.BusCode = this.cboBusCode.Text.Trim();
                            busInfo.BusNo = this.txtBusNumber.Text.Trim();
                            busInfo.BusTypeID = this.cboBusType.SelectedValue.ToString();
                            busInfo.TotalSeats = Convert.ToInt32(this.lblTotalSeat.Text.Trim());

                            busController.UpdateByBusID(busInfo);

                            string log = "Form-Bus;Item-BusCode:" + this.cboBusCode.Text + ";action-Update";
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

        private void NewEditExit_EditClick(object sender, EventArgs e)
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
                        if (this.cboBusCode.SelectedValue != null)
                        {
                            if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                            {
                                BusController busController = new BusController();

                                busController.DeleteByBusID(this.cboBusCode.SelectedValue.ToString());

                                string log = "Form-Bus;Item-BusCode:" + this.cboBusCode.Text + ";action-Delete";
                                userAction.Log(log);

                                this.BindComboBox(true);
                                Globalizer.ShowMessage(MessageType.Information, "Deleted Successfully");
                                this.ResetControl();
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

        private void NewEditExit_CloseClick(object sender, EventArgs e)
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