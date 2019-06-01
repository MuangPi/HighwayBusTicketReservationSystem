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
    public partial class TripPlan : Form
    {
        #region Variables
        private int totalseat = 0;
        private string recordID = string.Empty;
        #endregion

        #region Constructor
        public TripPlan()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();
        
        #region Methods
        private void EnableDisableControls(bool enable)
        {
            //this.cboTripCode.Enabled = enable;
            this.txtTripCode.Enabled = enable;
            this.cboRoute.Enabled = enable;
            this.dtpDate.Enabled = enable;
            this.cboTime.Enabled = enable;
            this.txtPrice.Enabled = enable;
            this.cboBusNumber.Enabled = enable;
            this.txtTotalSeat.Enabled = enable;
            this.cboDriver1.Enabled = enable;
            this.cboDriver2.Enabled = enable;
        }

        private void VisibleControls(bool visible)
        {
            this.cboTripCode.Visible = visible;
            this.txtTripCode.Visible = !visible;
        }

        private void GetHeaderInfo(TripInfo tripInfo)
        {
            if (NewEditExit.BtnNewText == "&Save")
            {
                tripInfo.TripID = string.Empty;
                tripInfo.TripCode = txtTripCode.Text;
                tripInfo.RouteID = cboRoute.SelectedValue.ToString();
                tripInfo.TripDate = Convert.ToDateTime(dtpDate.Text);
                tripInfo.TimeID = cboTime.SelectedValue.ToString();
                tripInfo.Price = Convert.ToDecimal(this.txtPrice.Text.Trim());
                tripInfo.BusID = cboBusNumber.SelectedValue.ToString();
                tripInfo.Driver1ID = cboDriver1.SelectedValue.ToString();
                tripInfo.Driver2ID = cboDriver2.SelectedValue.ToString();
                totalseat = Convert.ToInt32(txtTotalSeat.Text);
            }

            else if (NewEditExit.BtnNewText == "&Update")
            {
                tripInfo.TripID = recordID;
                tripInfo.TripCode = this.cboTripCode.Text;
                tripInfo.RouteID = cboRoute.SelectedValue.ToString();
                tripInfo.TripDate = Convert.ToDateTime(dtpDate.Text);
                tripInfo.TimeID = cboTime.SelectedValue.ToString();
                tripInfo.Price = Convert.ToDecimal(this.txtPrice.Text.Trim());
                tripInfo.BusID = cboBusNumber.SelectedValue.ToString();
                tripInfo.Driver1ID = cboDriver1.SelectedValue.ToString();
                tripInfo.Driver2ID = cboDriver2.SelectedValue.ToString();
                totalseat = Convert.ToInt32(txtTotalSeat.Text);
            }
        }

        private TripDetailCollection GetItemCollection()
        {
            TripDetailCollection tripDetailCollection = new TripDetailCollection();

            if (NewEditExit.BtnNewText == "&Save")
            {
                for (int i = 1; i <= totalseat; i++)
                {
                    TripDetailInfo tripDetailInfo = new TripDetailInfo();

                    tripDetailInfo.TripDetailID = string.Empty;
                    tripDetailInfo.TripID = string.Empty;
                    if (i < 10)
                    {
                        tripDetailInfo.SeatNo = "0" + i.ToString();
                        tripDetailInfo.Status = "A";
                    }
                    else
                    {
                        tripDetailInfo.SeatNo = i.ToString();
                        tripDetailInfo.Status = "A";
                    }
                    tripDetailCollection.Add(tripDetailInfo);
                }
            }

            else if (NewEditExit.BtnNewText == "&Update")
            {
                for (int i = 1; i <= totalseat; i++)
                {
                    TripDetailInfo tripDetailInfo = new TripDetailInfo();

                    tripDetailInfo.TripDetailID = string.Empty;
                    tripDetailInfo.TripID = recordID;
                    if (i < 10)
                    {
                        tripDetailInfo.SeatNo = "0" + i.ToString();
                        tripDetailInfo.Status = "A";
                    }
                    else
                    {
                        tripDetailInfo.SeatNo = i.ToString();
                        tripDetailInfo.Status = "A";
                    }
                    tripDetailCollection.Add(tripDetailInfo);
                }
            }
            return tripDetailCollection;
        }

        private void InitializeControls()
        {
            this.txtTripCode.Text = "";
            this.cboTripCode.SelectedIndex = 0;
            this.cboRoute.SelectedIndex = 0;
            this.dtpDate.Text = Convert.ToString(System.DateTime.Now);
            this.cboTime.SelectedIndex = 0;
            this.txtPrice.Text = "";
            this.cboBusNumber.SelectedIndex = 0;
            this.txtTotalSeat.Text = "";
            this.cboDriver1.SelectedIndex = 0;
            this.cboDriver2.SelectedIndex = 0;
            this.txtTripCode.Focus();
            this.recordID = "";
        }

        private void BindTripID()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectList();

            TripInfo tripInfo = new TripInfo();
            tripInfo.TripCode = " - Select One - ";
            tripInfo.TripID = null;
            tripCollection.Insert(0, tripInfo);

            this.cboTripCode.DisplayMember = "TripCode";
            this.cboTripCode.ValueMember = "TripID";
            this.cboTripCode.DataSource = tripCollection;
            this.cboTripCode.SelectedIndex = 0;
        }

        private void BindRouteID()
        {
            RouteController routeController = new RouteController();
            RouteCollections routeCollections = routeController.SelectList();

            RouteInfo info = new RouteInfo();
            info.RouteName = " - Select One - ";
            info.RouteID = null;
            routeCollections.Insert(0, info);

            this.cboRoute.DisplayMember = "RouteName";
            this.cboRoute.ValueMember = "RouteID";
            this.cboRoute.DataSource = routeCollections;
            this.cboRoute.SelectedIndex = 0;
        }

        private void BindTimeID()
        {
            TimeScheduleController timeController = new TimeScheduleController();
            TimeCollections timeCollections = timeController.SelectList();

            TimeScheduleInfo info = new TimeScheduleInfo();
            info.Time = " - Select One - ";
            info.TimeID = null;
            timeCollections.Insert(0, info);

            this.cboTime.DisplayMember = "Time";
            this.cboTime.ValueMember = "TimeID";
            this.cboTime.DataSource = timeCollections;
            this.cboTime.SelectedIndex = 0;
        }

        private void BindBusNo()
        {
            BusController busController = new BusController();
            BusCollection BusCollections = busController.SelectList();

            BusInfo info = new BusInfo();
            info.BusNo = " - Select One - ";
            info.BusID = null;
            BusCollections.Insert(0, info);

            this.cboBusNumber.DisplayMember = "BusNo";
            this.cboBusNumber.ValueMember = "BusID";
            this.cboBusNumber.DataSource = BusCollections;
            this.cboBusNumber.SelectedIndex = 0;
        }

        private void BindDriver1ID()
        {
            DriverController driverController = new DriverController();
            DriverCollections driverCollections = driverController.SelectList();

            DriverInfo info = new DriverInfo();
            info.DriverName = " - Select One - ";
            info.DriverID = null;
            driverCollections.Insert(0, info);

            this.cboDriver1.DisplayMember = "DriverName";
            this.cboDriver1.ValueMember = "DriverID";
            this.cboDriver1.DataSource = driverCollections;
            this.cboDriver1.SelectedIndex = 0;
        }

        private void BindDriver2ID()
        {
            DriverController driverController = new DriverController();
            DriverCollections driverCollections = driverController.SelectList();

            DriverInfo info = new DriverInfo();
            info.DriverName = " - Select One - ";
            info.DriverID = null;
            driverCollections.Insert(0, info);

            this.cboDriver2.DisplayMember = "DriverName";
            this.cboDriver2.ValueMember = "DriverID";
            this.cboDriver2.DataSource = driverCollections;
            this.cboDriver2.SelectedIndex = 0;
        }

        private void BindComboBox(bool isIncludedTripCode)
        {
            if (isIncludedTripCode)
            {
                BindTripID();
            }
            this.BindRouteID();
            this.BindBusNo();
            this.BindDriver1ID();
            this.BindDriver2ID();
            this.BindTimeID();
        }

        private void BindControlsTotalSeat()
        {
            TripController tripController = new TripController();
            string seat = tripController.SelectTotalSeat(this.cboBusNumber.SelectedValue.ToString());

            this.txtTotalSeat.Text = seat;
        }

        private void BindTripComboBox()
        {
            TripController tripController = new TripController();
            TripInfo tripInfo = tripController.SelectByTripID(this.cboTripCode.SelectedValue.ToString());

            this.cboTripCode.SelectedValue = tripInfo.TripID;
            this.cboRoute.SelectedValue = tripInfo.RouteID;
            this.dtpDate.Text = Convert.ToString(tripInfo.TripDate);
            this.cboTime.SelectedValue = tripInfo.TimeID;
            this.txtPrice.Text = Convert.ToString(tripInfo.Price);
            decimal price = Convert.ToDecimal(this.txtPrice.Text);
            this.txtPrice.Text = price.ToString("N");
            this.cboBusNumber.SelectedValue = tripInfo.BusID;
            string seat = tripController.SelectTotalSeat(this.cboBusNumber.SelectedValue.ToString());

            this.txtTotalSeat.Text = seat;
            this.cboDriver1.SelectedValue = tripInfo.Driver1ID;
            this.cboDriver2.SelectedValue = tripInfo.Driver2ID;
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
            if (this.cboTripCode.Visible == true)
            {
                if (this.cboTripCode.SelectedValue == null)
                {
                    Globalizer.ShowMessage(MessageType.Warning, "Trip Code should not be blank");
                    this.cboTripCode.Focus();
                    return false;
                }
            }

            if (this.txtTripCode.Visible == true)
            {
                if (string.IsNullOrEmpty(this.txtTripCode.Text.Trim()))
                {
                    Globalizer.ShowMessage(MessageType.Warning, "Trip Code should not be blank");
                    this.txtTripCode.Focus();
                    return false;
                }
            }

            if (this.cboRoute.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Route should not be blank");
                this.cboRoute.Focus();
                return false;
            }

            if (this.cboTime.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Time should not be blank");
                this.cboTime.Focus();
                return false;
            }

            if (this.cboBusNumber.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Bus Number should not be blank");
                this.cboBusNumber.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPrice.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Price should not be blank");
                this.txtPrice.Focus();
                return false;
            }

            if ((Convert.ToDecimal(txtPrice.Text)) <= 0)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Price should not be less than Zero");
                this.txtPrice.Focus();
                return false;
            }

            if (this.cboDriver1.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Driver1 should not be blank");
                this.cboDriver1.Focus();
                return false;
            }

            if (this.cboDriver2.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Driver2 should not be blank");
                this.cboDriver2.Focus();
                return false;
            }

            return true;

        }
        #endregion

        #region Event
        private void TripPlan_Load(object sender, EventArgs e)
        {
            this.EnableDisableControls(false);
            this.VisibleControls(false);
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPrice.Text))
            {
                decimal price = Convert.ToDecimal(this.txtPrice.Text);
                this.txtPrice.Text = price.ToString("N");
            }
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboTripCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTripCode.SelectedIndex != 0)
            {
                this.BindTripComboBox();
                this.EnableDisableControls(true);
            }
        }

        private void cboBusNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboBusNumber.SelectedIndex != 0)
            {
                this.BindControlsTotalSeat();
            }
        }

        private void txtTripCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& (Keys)e.KeyChar!=Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void InputControls_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
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
                        this.VisibleControls(false);
                        this.BindComboBox(false);
                        this.InitializeControls();
                        this.txtTripCode.Focus();
                        break;

                    case "&Save":
                        if (this.CheckRequiredFields())
                        {
                            TripController tripController = new TripController();
                            TripInfo tripInfo = new TripInfo();
                            TripDetailCollection tripDetailCollection = new TripDetailCollection();

                            GetHeaderInfo(tripInfo);
                            tripDetailCollection = GetItemCollection();

                            tripController.Insert(tripInfo, tripDetailCollection);

                            string log = "Form-TripPlan;Item-TripCode:" + this.txtTripCode.Text + ";action-Save";
                            userAction.Log(log);

                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                            this.ResetControl();

                        }
                        break;

                    case "&Update":
                        if (this.CheckRequiredFields())
                        {
                            TripController tripController = new TripController();
                            TripInfo tripInfo = new TripInfo();
                            TripDetailCollection tripDetailCollection = new TripDetailCollection();

                            recordID = this.cboTripCode.SelectedValue.ToString();
                            GetHeaderInfo(tripInfo);
                            tripDetailCollection = GetItemCollection();

                            tripController.UpdateByTripID(tripInfo, tripDetailCollection);

                            string log = "Form-TripPlan;Item-TripCode:" + this.cboTripCode.Text + ";action-Update";
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
                switch (this.NewEditExit.BtnEditText)
                {
                    case "&Edit":
                        this.EnableDisableControls(false);
                        this.cboTripCode.Enabled = true;
                        this.VisibleControls(true);
                        this.BindComboBox(true);
                        this.InitializeControls();
                        break;

                    case "&Delete":
                        if (this.cboTripCode.SelectedValue != null)
                        {
                            if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                            {
                                TripController tripController = new TripController();

                                tripController.DeleteByTripID(this.cboTripCode.SelectedValue.ToString());

                                string log = "Form-TripPlan;Item-TripCode:" + this.cboTripCode.Text + ";action-Delete";
                                userAction.Log(log);

                                Globalizer.ShowMessage(MessageType.Information, "Deleted Successfully");
                                this.ResetControl();
                                this.BindTripID();
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