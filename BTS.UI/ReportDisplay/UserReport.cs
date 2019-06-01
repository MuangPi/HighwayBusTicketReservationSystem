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
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            UserController Controller = new UserController();
            rpvUser.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "UserDataSet_UserDataTable";
            rds.Value = Controller.SelectList();
            this.rpvUser.LocalReport.DataSources.Add(rds);

            rpvUser.ZoomMode = ZoomMode.Percent;
            this.rpvUser.RefreshReport();
        }
    }
}