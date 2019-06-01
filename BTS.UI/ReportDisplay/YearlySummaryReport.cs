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
    public partial class YearlySummaryReport : Form
    {
        private string year;

        public YearlySummaryReport()
        {
            InitializeComponent();
        }

        public YearlySummaryReport(string Year)
        {
            InitializeComponent();
            year = Year;
        }

        private void YearlySummaryReport_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            rpvYearlySummary.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectYearlySummary(year);
            this.rpvYearlySummary.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[1];

            param[0] = new ReportParameter("Year", year);
            
            rpvYearlySummary.LocalReport.SetParameters(param);
            rpvYearlySummary.ZoomMode = ZoomMode.Percent;
            this.rpvYearlySummary.RefreshReport();
        }
    }
}