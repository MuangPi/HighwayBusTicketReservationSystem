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
    public partial class BusTypeReport : Form
    {
        public BusTypeReport()
        {
            InitializeComponent();
        }

        private void BusTypeReport_Load(object sender, EventArgs e)
        {
            BusTypeController Controller = new BusTypeController();
            rpvBusType.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "BusTypeDataSet_BusTypeDataTable";
            rds.Value = Controller.SelectList();
            this.rpvBusType.LocalReport.DataSources.Add(rds);

            rpvBusType.ZoomMode = ZoomMode.Percent;
            this.rpvBusType.RefreshReport();
        }
    }
}