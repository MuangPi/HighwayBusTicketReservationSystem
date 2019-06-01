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
    public partial class LocationReport : Form
    {
        public LocationReport()
        {
            InitializeComponent();
        }

        private void LocationReport_Load(object sender, EventArgs e)
        {
            LocationController Controller = new LocationController();
            rpvLocation.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "LocationDataSet_LocationDataTable";
            rds.Value = Controller.SelectList();
            this.rpvLocation.LocalReport.DataSources.Add(rds);

            rpvLocation.ZoomMode = ZoomMode.Percent;
            this.rpvLocation.RefreshReport();
        }
    }
}