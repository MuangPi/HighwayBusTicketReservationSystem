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
    public partial class MonthlySummaryReport : Form
    {
        private string month;
        private string year;

        public MonthlySummaryReport()
        {
            InitializeComponent();
        }

        public MonthlySummaryReport(string Month, string Year)
        {
            InitializeComponent();
            month = Month;
            year = Year;
        }

        private void MonthlySummaryReport_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            rpvMonthlySummary.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectMonthlySummary(month, year);
            this.rpvMonthlySummary.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("Month", this.month);
            param[1] = new ReportParameter("Year", this.year);
            rpvMonthlySummary.LocalReport.SetParameters(param);
            rpvMonthlySummary.ZoomMode = ZoomMode.Percent;

            this.rpvMonthlySummary.RefreshReport();
        }
    }
}