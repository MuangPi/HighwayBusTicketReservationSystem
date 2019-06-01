using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;

namespace BTS.UI.Grid
{
    public partial class Booking : Form
    {
        #region Variables
        public string code = "Booking";
        //public bool enable;
        #endregion

        #region Constructor
        public Booking()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Methods
        private void EnableDisableControls(bool enable)
        {
            this.txtBookingNo.Enabled = enable;
            this.cboTrip.Enabled = enable;
            this.cboDate.Enabled = enable;
            this.cboTime.Enabled = enable;
            this.txtBusNo.Enabled = enable;
            this.txtAvailableSeats.Enabled = enable;
            this.txtSeatNo.Enabled = enable;
            this.btnSeat.Enabled = enable;
            this.txtQuantity.Enabled = enable;
            this.txtName.Enabled = enable;
            this.txtNRCNo.Enabled = enable;
            this.cboGender.Enabled = enable;
            this.txtPhoneNo.Enabled = enable;
        }

        private void VisibleControls(bool visible)
        {
            this.txtBookingNo.Visible = visible;
            this.QuickSearch.Visible = !visible;
        }

        private void VisibleCon(bool visible)
        {
            this.lblSelectedSeats.Visible = visible;
            this.btnSeat.Visible = visible;
            this.txtSeatNo.Visible = visible;
            this.lblQuantity.Visible = visible;
            this.txtQuantity.Visible = visible;
        }

        private void TripInitializeControls()
        {
            this.cboTrip.SelectedIndex = 0;
            this.cboDate.Text = null;
            this.cboDate.SelectedText = "- Select One -";
            this.cboTime.Text = null;
            this.cboTime.SelectedIndex = 0;
        }

        private void TripDetailInitializeControls()
        {
            this.txtBusNo.Text = null;
            this.txtAvailableSeats.Text = "0";
            this.txtSeatNo.Text = null;
            this.txtQuantity.Text = "0";
        }

        private void CustInitializeControls()
        {
            this.txtName.Text = null;
            this.cboGender.SelectedIndex = 0;
            this.txtNRCNo.Text = null;
            this.txtPhoneNo.Text = null;
        }

        private void InitializeControls()
        {
            this.TripInitializeControls();
            this.TripDetailInitializeControls();
            this.CustInitializeControls();
        }

        private void BindRoute()
        {
            RouteController routeController = new RouteController();
            RouteCollections routeCollections = routeController.SelectList();

            RouteInfo info = new RouteInfo();
            info.RouteName = " - Select One - ";
            info.RouteID = null;
            routeCollections.Insert(0, info);

            this.cboTrip.DisplayMember = "RouteName";
            this.cboTrip.ValueMember = "RouteID";
            this.cboTrip.DataSource = routeCollections;
            this.cboTrip.SelectedIndex = 0;
        }

        private void BindTripDate()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectDateByRouteID(this.cboTrip.SelectedValue.ToString());

            this.cboDate.DisplayMember = "TripDate";
            this.cboDate.ValueMember = "TripDate";
            this.cboDate.DataSource = tripCollection;
        }

        private void BindTime()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectTime(this.cboTrip.SelectedValue.ToString(), Convert.ToDateTime(this.cboDate.SelectedValue.ToString()));

            TripInfo tripInfo = new TripInfo();
            tripInfo.Time = "-Select One-";
            tripInfo.TimeID = null;
            tripCollection.Insert(0, tripInfo);

            this.cboTime.DisplayMember = "Time";
            this.cboTime.ValueMember = "TimeID";
            this.cboTime.DataSource = tripCollection;
            this.cboTime.SelectedIndex = 0;
        }

        private void BindBusNo()
        {
            TripController tripController = new TripController();
            TripInfo tripInfo = tripController.SelectBusTripID(this.cboTrip.SelectedValue.ToString(), Convert.ToDateTime(this.cboDate.SelectedValue.ToString()), this.cboTime.SelectedValue.ToString());

            this.lblTripID.Text = tripInfo.TripID;
            // this.lblBusID.Text = tripInfo.BusID;
            this.txtBusNo.Text = tripInfo.BusNo;
        }

        private void BindAvailableSeat()
        {
            TripInfo tripInfo = new TripInfo();
            TripDetailController controller = new TripDetailController();
            TripDetailCollection  collection = controller.SelectDetailByTripID(lblTripID.Text);

            int a = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Status == "A")
                { a++; }
            }
            txtAvailableSeats.Text = Convert.ToString(a);
        }

        private void GetCustomerInfo(CustomerInfo custInfo)
        {
            if (NewEditExit.BtnNewText == "&Save")
            {
                custInfo.CustomerID = string.Empty;
                custInfo.CustomerName = Convert.ToString(this.txtName.Text.Trim());
                custInfo.Gender = Convert.ToString(this.cboGender.Text.Trim());
                custInfo.NRCNo = Convert.ToString(this.txtNRCNo.Text.Trim());
                custInfo.PhoneNo = Convert.ToString(this.txtPhoneNo.Text.Trim());
            }

            else if (NewEditExit.btnNew.Text == "&Update")
            {
                custInfo.CustomerID = this.lblCustomerID.Text;
                custInfo.CustomerName = Convert.ToString(this.txtName.Text.Trim());
                custInfo.Gender = Convert.ToString(this.cboGender.Text.Trim());
                custInfo.NRCNo = Convert.ToString(this.txtNRCNo.Text.Trim());
                custInfo.PhoneNo = Convert.ToString(this.txtPhoneNo.Text.Trim());
            }

        }

        private void GetBookingInfo(BookingInfo bookingInfo)
        {
            if (NewEditExit.BtnNewText == "&Save")
            {
                bookingInfo.BookingID = string.Empty;
                bookingInfo.BookingNo = Convert.ToString(this.txtBookingNo.Text.Trim());
                bookingInfo.BookingDate = Convert.ToDateTime(this.dtpDate.Text.Trim());
                bookingInfo.Quantity = Convert.ToInt32(this.txtQuantity.Text.Trim());
                bookingInfo.CustomerID = string.Empty;
            }
            else if (NewEditExit.btnNew.Text == "&Update")
            {
                bookingInfo.BookingID = this.lblID.Text;
                bookingInfo.BookingNo = Convert.ToString(this.txtBookingNo.Text.Trim());
                bookingInfo.BookingDate = Convert.ToDateTime(this.dtpDate.Text.Trim());
                bookingInfo.Quantity = Convert.ToInt32(this.txtQuantity.Text.Trim());
                bookingInfo.CustomerID = this.lblCustomerID.Text;
            }
        }

        private void GetBookingDetailInfo(BookingDetailInfo bookingDetailInfo)
        {
            if (NewEditExit.BtnNewText == "&Save")
            {
                bookingDetailInfo.BookingDetailID = string.Empty;
                bookingDetailInfo.BookingID = string.Empty;
                bookingDetailInfo.TripID = this.lblTripID.Text;
                bookingDetailInfo.SeatNo = this.txtSeatNo.Text;
            }
            else if (NewEditExit.btnNew.Text == "&Update")
            {
                bookingDetailInfo.BookingDetailID = this.lblDetailID.Text;
                bookingDetailInfo.BookingID = this.lblID.Text;
                bookingDetailInfo.TripID = this.lblTripID.Text;
                bookingDetailInfo.SeatNo = this.txtSeatNo.Text;
            }
        }

        private bool CheckRequiredFields()
        {
            if (this.cboTrip.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Trip should not be blank");
                this.cboTrip.Focus();
                return false;
            }

            if (this.cboDate.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Trip Date should not be blank");
                this.cboDate.Focus();
                return false;
            }

            if (this.cboTime.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Time should not be blank");
                this.cboTime.Focus();
                return false;
            }

            if (this.txtSeatNo.Text == string.Empty)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Selected Seat No should not be blank");
                this.txtSeatNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Customer Name should not be blank");
                this.txtName.Focus();
                return false;
            }

            if (this.cboGender.Text == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Gender should not be blank");
                this.cboGender.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtNRCNo.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "NRC should not be blank");
                this.txtNRCNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtPhoneNo.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "PhoneNo should not be blank");
                this.txtPhoneNo.Focus();
                return false;
            }
            return true;
        }

        private void NewControl()
        {
            this.EnableDisableControls(true);
            this.cboDate.Enabled = false;
            this.cboTime.Enabled = false;
            this.VisibleControls(true);
            this.VisibleCon(true);
            this.BindRoute();
            this.Autogenerate();
            this.InitializeControls();
        }

        private void ResetControl()
        {
            if (NewEditExit.BtnNewText == "&Save"||NewEditExit.BtnNewText=="&Update"||NewEditExit.btnNew.Text=="&Update")
            {
                NewEditExit.btnNew.Text = "&New";
                NewEditExit.btnNew.ImageIndex = 5;
                NewEditExit.btnEdit.Enabled = true;
                NewEditExit.btnEdit.Text = "&Edit";
                NewEditExit.btnEdit.ImageIndex = 2;
                NewEditExit.btnClose.Text = "&Close";
                NewEditExit.btnClose.ImageIndex = 1;
            }
            this.EnableDisableControls(false);
            this.VisibleControls(true);
            this.VisibleCon(true);
            this.txtBookingNo.Text = null;
            this.lblTripID.Text = null;
        }

        private void Autogenerate()
        {
            BookingController bookingController = new BookingController();
            BookingInfo bookingInfo = bookingController.AutogenerateCode(code);

            this.txtBookingNo.Text = bookingInfo.AutoCode;
        }

        private void AutogenerateReduce()
        {
            BookingController bookingController = new BookingController();
            bookingController.AutogenerateReduce(code);
        }

        private void UpdateSeatPlan()
        {
            if (this.NewEditExit.btnNew.Text == "&Update")
            {
                if (this.QuickSearch.txtNo.Text != null)
                {
                    BookingController bookingController = new BookingController();
                    BookingDetailInfo bookingDetailInfo = new BookingDetailInfo();
                    GetBookingDetailInfo(bookingDetailInfo);
                    bookingController.TripDetailUpdate(bookingDetailInfo);
                }
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
                        this.NewControl();
                        break;

                    case "&Save":
                        if (this.CheckRequiredFields())
                        {
                            BookingController bookingController = new BookingController();
                            BookingInfo bookingInfo = new BookingInfo();
                            CustomerInfo custInfo = new CustomerInfo();
                            BookingDetailInfo bookingDetailInfo = new BookingDetailInfo();


                            GetCustomerInfo(custInfo);
                            GetBookingInfo(bookingInfo);
                            GetBookingDetailInfo(bookingDetailInfo);

                            bookingController.Insert(bookingInfo, custInfo, bookingDetailInfo);

                            string log = "Form-BookingEntry;Item-BookingNo:" + this.txtBookingNo.Text + ";action-Save";
                            userAction.Log(log);

                            this.InitializeControls();                            
                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                            this.ResetControl();
                        }
                        break;

                    case "&Update":
                        if (this.CheckRequiredFields())
                        {
                            BookingController bookingController = new BookingController();
                            BookingInfo bookingInfo = new BookingInfo();
                            CustomerInfo custInfo = new CustomerInfo();
                            BookingDetailInfo bookingDetailInfo = new BookingDetailInfo();

                            GetCustomerInfo(custInfo);
                            GetBookingInfo(bookingInfo);
                            GetBookingDetailInfo(bookingDetailInfo);

                            bookingController.Update(bookingInfo, custInfo, bookingDetailInfo);

                            string log = "Form-BookingEntry;Item-BookingNo:" + this.txtBookingNo.Text + ";action-Update";
                            userAction.Log(log);

                            this.InitializeControls();
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
                        this.VisibleControls(false);
                        this.VisibleCon(true);
                        this.QuickSearch.txtNo.Text = null;

                        break;

                    case "&Delete":
                        if (!string.IsNullOrEmpty(this.lblID.Text.Trim()))
                        {
                            if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                            {
                                BookingController bookingController = new BookingController();
                                bookingController.Delete(this.lblTripID.Text.Trim(), this.lblID.Text.Trim());

                                string log = "Form-BookingEntry;Item-BookingNo:" + this.txtBookingNo.Text + ";action-Delete";
                                userAction.Log(log);

                                this.InitializeControls();
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
                    if (this.NewEditExit.BtnNewText == "&Save")
                    {
                        this.AutogenerateReduce();
                    }
                    this.ResetControl();
                    this.InitializeControls();
                    this.txtBookingNo.Text = null;
                    break;
            }
        }

        private void QuickSearch_SearchClick(SearchInfo result)
        {
            this.VisibleControls(true);
            this.BindRoute();
            this.lblID.Text = result.BookingID;
            this.lblDetailID.Text = result.BookingDetailID;
            this.QuickSearch.txtNo.Text = result.BookingNo;
            this.txtBookingNo.Text = this.QuickSearch.txtNo.Text;
            if (String.IsNullOrEmpty(this.txtBookingNo.Text))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Error!,Please check the searching form tab");
                this.ResetControl();
            }
            else
            {
                this.EnableDisableControls(true);
                this.lblTripID.Text = result.TripID;
                this.cboTrip.SelectedValue = result.RouteID;
                this.BindTripDate();
                this.cboDate.SelectedValue = result.Date;
                this.BindTime();
                this.cboTime.SelectedValue = result.TimeID;
                this.txtBusNo.Text = result.BusNo;
                this.txtSeatNo.Text = result.SeatNo;
                this.txtQuantity.Text = Convert.ToString(result.Quantity);
                this.lblCustomerID.Text = result.CustomerID;
                this.txtName.Text = result.CustomerName;
                this.cboGender.Text = result.Gender;
                this.txtNRCNo.Text = result.NRCNo;
                this.txtPhoneNo.Text = result.PhoneNo;
            }            
        }
        #endregion

        #region Events
        private void Booking_Load(object sender, EventArgs e)
        {
            this.EnableDisableControls(false);
            this.VisibleControls(true);
            this.VisibleCon(false);            
        }  

        private void cboTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.TripDetailInitializeControls();
            //this.cboDate.SelectedText = "- Select One -";
            //this.cboTime.SelectedIndex = 0;
            if (this.cboTrip.SelectedValue != null)
            {
                this.UpdateSeatPlan();
                this.TripDetailInitializeControls();
                this.cboDate.SelectedText = "- Select One -";
                this.cboTime.SelectedIndex = 0;
                this.BindTripDate();
                this.cboDate.Enabled = true;
                      
            }
        }

        private void cboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.TripDetailInitializeControls();
            if (this.cboDate.SelectedValue != null)
            {
                this.cboTime.Enabled = true;
                this.BindTime();
                this.UpdateSeatPlan();
                this.TripDetailInitializeControls();
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

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTime.SelectedValue != null)
            {
                this.UpdateSeatPlan();
                this.BindBusNo();
                this.BindAvailableSeat();

                this.txtSeatNo.Text = null;
                
                this.txtQuantity.Text = "0";
            }
        }

        private void cboControls_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            if (this.NewEditExit.btnNew.Text == "&Update")
            {
                this.UpdateSeatPlan();
                //this.enable = true;
                Globalizer.enable = true;
            }
            SeatDisplay seatDisplay = new SeatDisplay();
            seatDisplay.GetTripID(lblTripID.Text);
            seatDisplay.sendSeatNo(txtSeatNo.Text.Trim());
            seatDisplay.ShowDialog();
            seatDisplay.Dispose();
            this.txtSeatNo.Text = seatDisplay.getTextBoxValue();

            if (txtSeatNo.Text != null)
            {
                string strSeat = txtSeatNo.Text;
                String[] array = strSeat.Split(',');

                int count = array.Length;

                if (this.txtSeatNo.Text != string.Empty)
                {
                    this.txtQuantity.Text = Convert.ToString(count);
                }
            }
        }              
        #endregion        

       
    }
}