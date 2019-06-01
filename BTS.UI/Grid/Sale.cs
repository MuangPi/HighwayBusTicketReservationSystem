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
    public partial class Sale : Form
    {
        #region variables
        public string code = "Sale";
        //public bool enable;
        #endregion

        #region Constructor
        public Sale()
        {
            InitializeComponent();
        }
        #endregion
           
        #region Methods
        private void EnableDisableControls(bool enable)
        {
            //this.QuickSearch.Enabled = enable;
            this.txtSaleNo.Enabled = enable;
            this.cboTrip.Enabled = enable;
            this.cboDate.Enabled = enable;
            this.cboTime.Enabled = enable;
            this.txtBusNo.Enabled = enable;
            this.txtAvailableSeats.Enabled = enable;
            this.txtSeatNo.Enabled = enable;
            this.btnSeat.Enabled = enable;
            this.txtQuantity.Enabled = enable;
            this.txtPrice.Enabled = enable;
            this.txtAmount.Enabled = enable;
            this.txtName.Enabled = enable;
            this.txtNRCNo.Enabled = enable;
            this.cboGender.Enabled = enable;
            this.txtPhoneNo.Enabled = enable;
        }

        private void VisibleControls(bool visible)
        {
            this.txtSaleNo.Visible = visible;
            this.QuickSearch.Visible = !visible;
        }

        private void VisibleCon(bool visible)
        {
            this.lblSelectedSeat.Visible=visible;
            this.btnSeat.Visible = visible;
            this.txtSeatNo.Visible = visible;
            this.lblQuantity.Visible = visible;
            this.txtQuantity.Visible = visible;
            this.lblPrice.Visible = visible;
            this.txtPrice.Visible = visible;
            this.lblAmount.Visible = visible;
            this.txtAmount.Visible = visible;

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
            this.txtPrice.Text = "0";
            this.txtAvailableSeats.Text = null;
            this.txtSeatNo.Text = null;
            this.txtAmount.Text = "0";
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
            this.txtPrice.Text = Convert.ToString(tripInfo.Price);
            decimal price1 = Convert.ToDecimal(this.txtPrice.Text);
            this.txtPrice.Text = price1.ToString("N");
        }

        private void BindAvailableSeat()
        {
            TripInfo tripInfo = new TripInfo();
            TripDetailController controller = new TripDetailController();
            TripDetailCollection collection = controller.SelectDetailByTripID(lblTripID.Text);

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

        private void GetSaleInfo(SaleInfo saleInfo)
        {
            if (NewEditExit.BtnNewText == "&Save")
            {
                saleInfo.SaleID = string.Empty;
                saleInfo.SaleNo = Convert.ToString(this.txtSaleNo.Text.Trim());
                saleInfo.SaleDate = Convert.ToDateTime(this.dtpDate.Text.Trim());
                saleInfo.Quantity = Convert.ToInt32(this.txtQuantity.Text.Trim());
                saleInfo.CustomerID = string.Empty;
            }

            else if (NewEditExit.btnNew.Text == "&Update")
            {
                saleInfo.SaleID = this.lblID.Text;
                saleInfo.SaleNo = Convert.ToString(this.txtSaleNo.Text.Trim());
                saleInfo.SaleDate = Convert.ToDateTime(this.dtpDate.Text.Trim());
                saleInfo.Quantity = Convert.ToInt32(this.txtQuantity.Text.Trim());
                saleInfo.CustomerID = this.lblCustomerID.Text;
            }
        }

        private void GetSaleDetailInfo(SaleDetailInfo saleDetailInfo)
        {
            if (NewEditExit.BtnNewText == "&Save")
            {
                saleDetailInfo.SaleDetailID = string.Empty;
                saleDetailInfo.SaleID = string.Empty;
                saleDetailInfo.TripID = this.lblTripID.Text;
                saleDetailInfo.SeatNo = this.txtSeatNo.Text;
            }
            else if (NewEditExit.btnNew.Text == "&Update")
            {
                saleDetailInfo.SaleDetailID = this.lblDetailID.Text;
                saleDetailInfo.SaleID = this.lblID.Text;
                saleDetailInfo.TripID = this.lblTripID.Text;
                saleDetailInfo.SeatNo = this.txtSeatNo.Text;
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

        private void Autogenerate()
        {
            SaleController saleController = new SaleController();
            SaleInfo saleInfo = saleController.AutogenerateCode(code);

            this.txtSaleNo.Text = saleInfo.AutoCode;
        }

        private void AutogenerateReduce()
        {
            SaleController saleController = new SaleController();
            saleController.AutogenerateReduce(code);
        }

        private void NewControl()
        {
            this.EnableDisableControls(true);
            this.VisibleControls(true);
            this.VisibleCon(true);
            this.cboDate.Enabled = false;
            this.cboTime.Enabled = false;
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
            this.txtSaleNo.Text = null;
            this.lblTripID.Text = null;
        }

        private void UpdateSeatPlan()
        {
            if (this.NewEditExit.btnNew.Text == "&Update")
            {
                if (this.QuickSearch.txtNo.Text != null)
                {
                    SaleController saleController = new SaleController();
                    SaleDetailInfo saleDetailInfo = new SaleDetailInfo();
                    GetSaleDetailInfo(saleDetailInfo);
                    saleController.TripDetailUpdate(saleDetailInfo);
                                       
                }
            }
        }
        #endregion

        #region Events
        private void Sale_Load(object sender, EventArgs e)
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

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTime.SelectedValue != null)
            {
                this.UpdateSeatPlan();                
                this.BindBusNo();
                this.BindAvailableSeat();

                this.txtSeatNo.Text = null;
                this.txtAmount.Text = "0";
                this.txtQuantity.Text = "0";
            }
        }

        private void cboControls_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void InputControls_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtUpperKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            if (this.NewEditExit.btnNew.Text == "&Update")
            {
                this.UpdateSeatPlan();
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
                Decimal decPrice = Convert.ToDecimal(this.txtPrice.Text);
                int price = Convert.ToInt32(decPrice);

                if (this.txtSeatNo.Text != string.Empty)
                {
                    this.txtQuantity.Text = Convert.ToString(count);
                    this.txtAmount.Text = Convert.ToString(price * count);
                    decimal amount = Convert.ToDecimal(this.txtAmount.Text);
                    this.txtAmount.Text = amount.ToString("N");
                }
            }
        }
        #endregion

        #region User Control
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
                            SaleController saleController = new SaleController();
                            SaleInfo saleInfo = new SaleInfo();
                            CustomerInfo custInfo = new CustomerInfo();
                            SaleDetailInfo saleDetailInfo = new SaleDetailInfo();


                            GetCustomerInfo(custInfo);
                            GetSaleInfo(saleInfo);
                            GetSaleDetailInfo(saleDetailInfo);

                            saleController.Insert(saleInfo, custInfo, saleDetailInfo);

                            this.InitializeControls();
                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                            this.ResetControl();
                        }
                        break;

                    case "&Update":
                        if (this.CheckRequiredFields())
                        {
                            SaleController saleController = new SaleController();
                            SaleInfo saleInfo = new SaleInfo();
                            CustomerInfo custInfo = new CustomerInfo();
                            SaleDetailInfo saleDetailInfo = new SaleDetailInfo();

                            GetCustomerInfo(custInfo);
                            GetSaleInfo(saleInfo);
                            GetSaleDetailInfo(saleDetailInfo);

                            saleController.Update(saleInfo, custInfo, saleDetailInfo);

                            this.InitializeControls();

                            //this.ResetControl();
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
                                SaleController saleController = new SaleController();
                                saleController.Delete(this.lblTripID.Text.Trim(), this.lblID.Text.Trim());

                               
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
                    this.txtSaleNo.Text = null;
                    break;
            }
        }

        private void QuickSearch_SearchClick(SearchInfo result)
        {
            this.VisibleControls(true);
            this.BindRoute();
            this.lblID.Text = result.SaleID;
            this.lblDetailID.Text = result.SaleDetailID;
            this.QuickSearch.txtNo.Text = result.SaleNo;
            this.txtSaleNo.Text = this.QuickSearch.txtNo.Text;
            if (string.IsNullOrEmpty(this.txtSaleNo.Text))
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
                this.txtPrice.Text = Convert.ToString(result.Price);
                decimal price = Convert.ToDecimal(this.txtPrice.Text);
                this.txtPrice.Text = price.ToString("N");
                this.txtAmount.Text = Convert.ToString(result.Quantity * result.Price);
                decimal amount1 = Convert.ToDecimal(this.txtAmount.Text);
                this.txtAmount.Text = amount1.ToString("N");
                this.lblCustomerID.Text = result.CustomerID;
                this.txtName.Text = result.CustomerName;
                this.cboGender.Text = result.Gender;
                this.txtNRCNo.Text = result.NRCNo;
                this.txtPhoneNo.Text = result.PhoneNo;
            }            
        } 
        #endregion               
     }
}