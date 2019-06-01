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
    public partial class DailyReport : Form
    {
        #region Constructor
        public DailyReport()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.DailyReport dailyReport = new BTS.UI.ReportDisplay.DailyReport(dtpDate.Value.ToString());
            dailyReport.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}