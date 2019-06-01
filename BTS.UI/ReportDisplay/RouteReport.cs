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
    public partial class RouteReport : Form
    {
        public RouteReport()
        {
            InitializeComponent();
        }

        private void RouteReport_Load(object sender, EventArgs e)
        {
            RouteController Controller = new RouteController();
            rpvRoute.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "RouteDataSet_RouteDataTable";
            rds.Value = Controller.SelectList();
            this.rpvRoute.LocalReport.DataSources.Add(rds);

            rpvRoute.ZoomMode = ZoomMode.Percent;
            this.rpvRoute.RefreshReport();
        }
    }
}