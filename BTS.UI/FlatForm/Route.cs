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
    public partial class Route : Form
    {
        #region Constructor
        public Route()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Helper Methods
        private void EnableDisableControls(bool enable)
        {
            this.txtRouteCode.Enabled = enable;
            this.txtRouteName.Enabled = enable;
            this.cboFromLocation.Enabled = enable;
            this.cboToLocation.Enabled = enable;
        }

        private void VisibleControls(bool visible)
        {
            this.cboRouteCode.Visible = visible;
            this.txtRouteCode.Visible = !visible;
        }

        private void InitializeControls()
        {
            this.cboRouteCode.SelectedIndex = 0;
            this.txtRouteCode.Clear();
            this.txtRouteName.Clear();
            this.cboFromLocation.SelectedIndex = 0;
            this.cboToLocation.SelectedIndex = 0;
        }

        private void BindRouteCode()
        {
            RouteController routeController = new RouteController();
            RouteCollections routeCollections = routeController.SelectList();

            RouteInfo info = new RouteInfo();
            info.RouteCode = " - Select One - ";
            info.RouteID = null;
            routeCollections.Insert(0, info);

            this.cboRouteCode.DisplayMember = "RouteCode";
            this.cboRouteCode.ValueMember = "RouteID";
            this.cboRouteCode.DataSource = routeCollections;
            this.cboRouteCode.SelectedIndex = 0;
        }

        private void BindFromLocation()
        {
            LocationController locationController = new LocationController();
            LocationCollection locationCollections = locationController.SelectList();

            LocationInfo info = new LocationInfo();
            info.LocationName = " - Select One - ";
            info.LocationID = null;
            locationCollections.Insert(0, info);

            this.cboFromLocation.DisplayMember = "LocationName";
            this.cboFromLocation.ValueMember = "LocationID";
            this.cboFromLocation.DataSource = locationCollections;
            this.cboFromLocation.SelectedIndex = 0;
        }

        private void BindToLocation()
        {

            LocationController locationController = new LocationController();
            LocationCollection locationCollections = locationController.SelectList();

            LocationInfo info = new LocationInfo();
            info.LocationName = " - Select One - ";
            info.LocationID = null;
            locationCollections.Insert(0, info);

            this.cboToLocation.DisplayMember = "LocationName";
            this.cboToLocation.ValueMember = "LocationID";
            this.cboToLocation.DataSource = locationCollections;
            this.cboToLocation.SelectedIndex = 0;
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

        private void BindComboBox(bool isIncludedRoute)
        {
            if (isIncludedRoute)
            {
                this.BindRouteCode();
            }

            this.BindFromLocation();
            this.BindToLocation();
        }

        private void BindControls()
        {
            RouteController routeController = new RouteController();
            RouteInfo routeInfo = routeController.SelectByRouteID(this.cboRouteCode.SelectedValue.ToString());

            //this.lblRouteID = routeInfo.RouteID;
            this.cboRouteCode.SelectedValue = routeInfo.RouteID; ;
            this.txtRouteName.Text = routeInfo.RouteName;
            this.cboFromLocation.SelectedValue = routeInfo.FromLocationID;
            this.cboToLocation.SelectedValue = routeInfo.ToLocationID;
        }

        private bool CheckRequiredFields()
        {
            if (this.txtRouteCode.Visible == true)
            {
                if (string.IsNullOrEmpty(this.txtRouteCode.Text.Trim()))
                {
                    Globalizer.ShowMessage(MessageType.Warning, "Route Code should not be blank");
                    this.txtRouteCode.Focus();
                    return false;
                }
            }

            if (this.cboRouteCode.Visible == true)
            {
                if (this.cboRouteCode.SelectedValue == null)
                {
                    Globalizer.ShowMessage(MessageType.Warning, "Route Code should not be blank");
                    this.cboRouteCode.Focus();
                    return false;
                }
            }            

            if (this.cboFromLocation.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "From Location should not be blank");
                this.cboFromLocation.Focus();
                return false;
            }

            if (this.cboToLocation.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "To Location should not be blank");
                this.cboToLocation.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtRouteName.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Route Name should not be blank");
                this.txtRouteName.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Event
        private void Route_Load(object sender, EventArgs e)
        {
            this.EnableDisableControls(false);
            this.VisibleControls(false);
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
            ReportDisplay.RouteReport routeReport = new ReportDisplay.RouteReport();
            routeReport.ShowDialog();
        }

        private void cboRouteCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboRouteCode.SelectedIndex != 0)
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
                        this.txtRouteCode.Focus();
                        break;

                    case "&Save":
                        if (this.CheckRequiredFields())
                        {
                            RouteController routeController = new RouteController();
                            RouteInfo routeInfo = new RouteInfo();

                            routeInfo.RouteID = string.Empty;
                            routeInfo.RouteCode = this.txtRouteCode.Text.Trim();
                            routeInfo.RouteName = this.txtRouteName.Text.Trim();
                            routeInfo.FromLocationID = this.cboFromLocation.SelectedValue.ToString();
                            routeInfo.ToLocationID = this.cboToLocation.SelectedValue.ToString();

                            routeController.Insert(routeInfo);

                            string log = "Form-Route;Item-RouteCode:" + this.txtRouteCode.Text + ";action-Save";
                            userAction.Log(log);

                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                            this.ResetControl();

                            this.txtRouteCode.Focus();
                        }
                        break;

                    case "&Update":
                        if (this.CheckRequiredFields())
                        {
                            RouteController routeController = new RouteController();
                            RouteInfo routeInfo = new RouteInfo();

                            routeInfo.RouteID = this.cboRouteCode.SelectedValue.ToString();
                            routeInfo.RouteCode = this.cboRouteCode.Text.Trim();
                            routeInfo.RouteName = this.txtRouteName.Text.Trim();
                            routeInfo.FromLocationID = this.cboFromLocation.SelectedValue.ToString();
                            routeInfo.ToLocationID = this.cboToLocation.SelectedValue.ToString();

                            routeController.UpdateByRouteID(routeInfo);

                            string log = "Form-Route;Item-RouteCode:" + this.cboRouteCode.Text + ";action-Update";
                            userAction.Log(log);

                            Globalizer.ShowMessage(MessageType.Information, "Updated Successfully");
                            this.ResetControl();
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Warning, ex.Message);
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
                        if (this.cboRouteCode.SelectedValue != null)
                        {
                            if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                            {
                                RouteController routeController = new RouteController();

                                routeController.DeleteByRouteID(this.cboRouteCode.SelectedValue.ToString());

                                string log = "Form-Route;Item-RouteCode:" + this.cboRouteCode.Text + ";action-Delete";
                                userAction.Log(log);

                                this.BindComboBox(true);
                                Globalizer.ShowMessage(MessageType.Information, "Delete Successful");
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