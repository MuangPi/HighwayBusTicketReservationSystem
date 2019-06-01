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
    public partial class BusReport : Form
    {
        public BusReport()
        {
            InitializeComponent();
        }

        private void BusReport_Load(object sender, EventArgs e)
        {
            BusController Controller = new BusController();
            rpvBus.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "BusDataSet_BusDataTable";
            rds.Value = Controller.SelectBus();
            this.rpvBus.LocalReport.DataSources.Add(rds);

            rpvBus.ZoomMode = ZoomMode.Percent;
            this.rpvBus.RefreshReport();
        }
    }
}