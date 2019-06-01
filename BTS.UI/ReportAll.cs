using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;

namespace BTS.UI
{
    public partial class ReportAll : Form
    {
        #region Constructor
        public ReportAll()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rdoTrip.Checked)
            {
                Reports.TripReport tripReport = new BTS.UI.Reports.TripReport();
                tripReport.ShowDialog();
            }
            else if (rdoTripCode.Checked)
            {
                Reports.ReportByTripCode tripCode = new BTS.UI.Reports.ReportByTripCode();
                tripCode.ShowDialog();
            }
            else if (rdoOneTrip.Checked)
            {
                Reports.ReportByOneTrip oneTrip = new BTS.UI.Reports.ReportByOneTrip();
                oneTrip.ShowDialog();
            }
            else if (rdoSaleNo.Checked)
            {
                Reports.ReportBySaleNo saleNo = new BTS.UI.Reports.ReportBySaleNo();
                saleNo.ShowDialog();
            }
            else if (rdoSaleDate.Checked)
            {
                Reports.ReportBySaleDate saleDate = new BTS.UI.Reports.ReportBySaleDate();
                saleDate.ShowDialog();
            }
            else if (rdoDaily.Checked)
            {
                Reports.DailyReport dailyReport = new BTS.UI.Reports.DailyReport();
                dailyReport.ShowDialog();
            }
            else if (rdoMonthly.Checked)
            {
                Reports.MonthlyReport monthlyReport = new BTS.UI.Reports.MonthlyReport();
                monthlyReport.ShowDialog();
            }
            else if (rdoYearly.Checked)
            {
                Reports.YearlyReport yearlyReport = new BTS.UI.Reports.YearlyReport();
                yearlyReport.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}