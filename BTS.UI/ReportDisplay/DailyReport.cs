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
    public partial class DailyReport : Form
    {
        private string date;

        public DailyReport()
        {
            InitializeComponent();
        }

        public DailyReport(string Date)
        {
            InitializeComponent();
            date = Date;
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvDaily.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.DailyReport(date);
            this.rpvDaily.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("Date", this.date);

            this.rpvDaily.LocalReport.SetParameters(param);
            this.rpvDaily.ZoomMode = ZoomMode.Percent;

            this.rpvDaily.RefreshReport();
        }
    }
}