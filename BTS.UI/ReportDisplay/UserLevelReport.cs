using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BTS.BusinessLogic;

namespace BTS.UI.ReportDisplay
{
    public partial class UserLevelReport : Form
    {
        public UserLevelReport()
        {
            InitializeComponent();
        }

        private void UserLevelReport_Load(object sender, EventArgs e)
        {
            UserLevelController Controller = new UserLevelController();
            rpvUserLevel.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "UserLevelDataSet_UserLevelDataTable";
            rds.Value = Controller.SelectList();
            this.rpvUserLevel.LocalReport.DataSources.Add(rds);

            rpvUserLevel.ZoomMode = ZoomMode.Percent;
            this.rpvUserLevel.RefreshReport();
        }
    }
}