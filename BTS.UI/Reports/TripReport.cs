using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;

namespace BTS.UI.Reports
{
    public partial class TripReport : Form
    {
        #region Constructor
        public TripReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void TripReport_Load(object sender, EventArgs e)
        {
            this.BindFromTripCode();
            this.BindToTripCode();
            this.BindRouteName();
            this.BindBus();
            this.BindDriver();
        }

        private void btnPreviewTripCode_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFieldsForTripCode())
            {
                ReportDisplay.TripCodeReport tripCodeReport = new BTS.UI.ReportDisplay.TripCodeReport(cboFromTripCode.Text.ToString(), cboToTripCode.Text.ToString());
                tripCodeReport.ShowDialog();
            }
        }

        private void btnCloseTripCode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreviewTripDate_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFields())
            {
                ReportDisplay.TripDateReport tripDateReport = new BTS.UI.ReportDisplay.TripDateReport(dtpFromDate.Value.ToString(), dtpToDate.Value.ToString());
                tripDateReport.ShowDialog();

            }
        }

        private void btnCloseTripDate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreviewRouteName_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFieldsForRoute())
            {
                ReportDisplay.TripByRouteNameReport tripByRouteNameReport = new BTS.UI.ReportDisplay.TripByRouteNameReport(cboRoute.Text.ToString());
                tripByRouteNameReport.ShowDialog();
            }
        }

        private void btnCloseRouteName_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreviewBusNo_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFieldsForBus())
            {
                ReportDisplay.TripByBusNoReport tripByBusReport = new BTS.UI.ReportDisplay.TripByBusNoReport(cboBusNo.Text.ToString());
                tripByBusReport.ShowDialog();
            }
        }

        private void btnCloseBusNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreviewDriverName_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFieldsForDriver())
            {
                ReportDisplay.TripByDriverNameReport tripByDriverNameReport = new BTS.UI.ReportDisplay.TripByDriverNameReport(cboDriver.SelectedValue.ToString());
                tripByDriverNameReport.ShowDialog();
            }
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCloseDriverName_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Helper Method
        private void BindFromTripCode()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectListRecord();

            TripInfo info = new TripInfo();
            info.TripCode = " - Select One - ";
            info.TripID = null;
            tripCollection.Insert(0, info);

            cboFromTripCode.DisplayMember = "TripCode";
            cboFromTripCode.ValueMember = "TripID";
            cboFromTripCode.DataSource = tripCollection;

            cboFromTripCode.SelectedIndex = 0;
        }

        private void BindToTripCode()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectListRecord();

            TripInfo info = new TripInfo();
            info.TripCode = " - Select One - ";
            info.TripID = null;
            tripCollection.Insert(0, info);

            cboToTripCode.DisplayMember = "TripCode";
            cboToTripCode.ValueMember = "TripID";
            cboToTripCode.DataSource = tripCollection;

            cboToTripCode.SelectedIndex = 0;
        }

        private void BindRouteName()
        {
            RouteController routeController = new RouteController();
            RouteCollections routeCollection = routeController.SelectList();

            RouteInfo info = new RouteInfo();
            info.RouteName = " - Select One - ";
            info.RouteID = null;
            routeCollection.Insert(0, info);

            cboRoute.DisplayMember = "RouteName";
            cboRoute.ValueMember = "RouteID";
            cboRoute.DataSource = routeCollection;

            cboRoute.SelectedIndex = 0;
        }

        private void BindBus()
        {
            BusController busController = new BusController();
            BusCollection busCollection = busController.SelectList();

            BusInfo info = new BusInfo();
            info.BusNo = " - Select One - ";
            info.BusID = null;
            busCollection.Insert(0, info);

            cboBusNo.DisplayMember = "BusNo";
            cboBusNo.ValueMember = "BusID";
            cboBusNo.DataSource = busCollection;

            cboBusNo.SelectedIndex = 0;
        }

        private void BindDriver()
        {
            DriverController driverController = new DriverController();
            DriverCollections driverCollection = driverController.SelectList();

            DriverInfo info = new DriverInfo();
            info.DriverName = " - Select One - ";
            info.DriverID = null;
            driverCollection.Insert(0, info);

            cboDriver.DisplayMember = "DriverName";
            cboDriver.ValueMember = "DriverID";
            cboDriver.DataSource = driverCollection;

            cboDriver.SelectedIndex = 0;
        }

        private bool CheckRequiredFieldsForTripCode()
        {
            if (this.cboFromTripCode.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "From Trip Code should not be blank");
                this.cboFromTripCode.Focus();
                return false;
            }

            else if (this.cboToTripCode.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "To Trip Code should not be blank");
                this.cboToTripCode.Focus();
                return false;
            }

            else if (this.cboFromTripCode.SelectedIndex > this.cboToTripCode.SelectedIndex)
            {
                Globalizer.ShowMessage(MessageType.Warning, "To Trip Code should not be greater From Trip Code");
                this.cboToTripCode.Focus();
                return false;
            }
            return true;
        }

        private bool CheckRequiredFieldsForRoute()
        {
            if (this.cboRoute.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Route Name should not be blank");
                this.cboRoute.Focus();
                return false;
            }
            return true;
        }

        private bool CheckRequiredFields()
        {
            if (this.dtpFromDate.Value.CompareTo(this.dtpToDate.Value) == 1)
            {
                string temp = dtpFromDate.Value.ToString();
                dtpFromDate.Text = dtpToDate.Value.ToString();
                dtpToDate.Value = Convert.ToDateTime(temp);
            }            
            return true;
        }

        private bool CheckRequiredFieldsForBus()
        {
            if (this.cboBusNo.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Bus No should not be blank");
                this.cboBusNo.Focus();
                return false;
            }
            return true;
        }

        private bool CheckRequiredFieldsForDriver()
        {

            if (this.cboDriver.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Driver Name should not be blank");
                this.cboDriver.Focus();
                return false;
            }
            return true;
        }
        #endregion                
    }
}