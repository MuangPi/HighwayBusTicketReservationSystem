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
    public partial class YearlyReport : Form
    {
        #region Constructor
        public YearlyReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (CheckRequiredFields())
            {
                if (rdoDetail.Checked)
                {
                    ReportDisplay.YearlyDetailReport yearlyDetailReport = new BTS.UI.ReportDisplay.YearlyDetailReport(this.txtYear.Text);
                    yearlyDetailReport.ShowDialog();
                }
                else
                {
                    ReportDisplay.YearlySummaryReport yearlySummaryReport = new BTS.UI.ReportDisplay.YearlySummaryReport(this.txtYear.Text);
                    yearlySummaryReport.ShowDialog();
                }
            }
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Helper Method
        private bool CheckRequiredFields()
        {
            if (String.IsNullOrEmpty(txtYear.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Year should not be blank");
                this.txtYear.Focus(); //set focus to control
                return false;
            }
            return true;
        }
        #endregion
    }
}