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
    public partial class DriverReport : Form
    {
        public DriverReport()
        {
            InitializeComponent();
        }

        private void DriverReport_Load(object sender, EventArgs e)
        {
            DriverController Controller = new DriverController();
            rpvDriver.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DriverDataSet_DriverDataTable";
            rds.Value = Controller.SelectList();
            this.rpvDriver.LocalReport.DataSources.Add(rds);

            rpvDriver.ZoomMode = ZoomMode.Percent;
            this.rpvDriver.RefreshReport();
        }
    }
}