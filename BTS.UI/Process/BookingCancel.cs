using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;


namespace BTS.UI.Process
{
    public partial class BookingCancel : Form
    {
        #region Constructor
        public BookingCancel()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Events
        private void BookingCancel_Load(object sender, EventArgs e)
        {
            this.BindRoute();
            this.BindTime();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredFields())
                {

                    string routeName = cboRoute.Text.ToString();
                    DateTime date = dtpDate.Value;
                    string time = cboTime.Text.ToString();

                    BookingController bookingController = new BookingController();
                    bookingController.CancelBooking(routeName, date, time);


                    this.cboRoute.SelectedValue = 0;
                    this.cboTime.SelectedValue = 0;
                    Globalizer.ShowMessage(MessageType.Information, "Process Successfully");
                }
            }
            catch
            {
                Globalizer.ShowMessage(MessageType.Information, "Booking is not exist for this trip.");
            }
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboRoute_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion
        
        #region Helper Method
        private void BindRoute()
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

        private void BindTime()
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

        private bool CheckRequiredFields()
        {
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
            return true;
        }
        #endregion

       

    }
}