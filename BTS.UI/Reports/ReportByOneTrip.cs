using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;

namespace BTS.UI.Reports
{
    public partial class ReportByOneTrip : Form
    {
        #region Constructor
        public ReportByOneTrip()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void ReportByOneTrip_Load(object sender, EventArgs e)
        {
            this.BindRoute();
            this.BindTime();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFields())
            {
                if (this.rdoDetail.Checked)
                {
                    ReportDisplay.ReportByOneTripDetail oneTripDetail = new BTS.UI.ReportDisplay.ReportByOneTripDetail(this.cboRoute.Text.ToString(), this.dtpDate.Value, this.cboTime.Text.ToString());
                    oneTripDetail.ShowDialog();
                   
                }
                else
                {
                    ReportDisplay.ReportByOneTripSummary oneTripSummary = new BTS.UI.ReportDisplay.ReportByOneTripSummary(this.cboRoute.Text.ToString(), this.dtpDate.Value, this.cboTime.Text.ToString());
                    oneTripSummary.ShowDialog();
                   
                }
            }
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