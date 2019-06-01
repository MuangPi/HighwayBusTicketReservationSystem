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
    public partial class MonthlyReport : Form
    {
        #region Constructor
        public MonthlyReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Helper Method
        private bool CheckRequiredFields()
        {
            if (String.IsNullOrEmpty(txtMonth.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Month should not be blank");
                this.txtMonth.Focus(); //set focus to control
                return false;
            }

            if (String.IsNullOrEmpty(txtYear.Text))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Year should not be blank");
                this.txtYear.Focus(); //set focus to control
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFields())
            {
                if (this.rdoDetail.Checked)
                {

                    ReportDisplay.MonthlyDetailReport monthlyDetailReport = new BTS.UI.ReportDisplay.MonthlyDetailReport(txtMonth.Text.ToString(), txtYear.Text.ToString());
                    monthlyDetailReport.ShowDialog();
                }
                else
                {
                    ReportDisplay.MonthlySummaryReport monthlySummaryReport = new BTS.UI.ReportDisplay.MonthlySummaryReport(txtMonth.Text.ToString(), txtYear.Text.ToString());
                    monthlySummaryReport.ShowDialog();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void txtMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion

    }
}