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
    public partial class MonthlyDetailReport : Form
    {
        private string month;
        private string year;

        public MonthlyDetailReport()
        {
            InitializeComponent();
        }

        public MonthlyDetailReport(string Month, string Year)
        {
            InitializeComponent();
            month = Month;
            year = Year;
        }

        private void MonthlyDetailReport_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            rpvMonthlyDetail.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectMonthlyDetail(month, year);
            this.rpvMonthlyDetail.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("Month", this.month);
            param[1] = new ReportParameter("Year", this.year);
            rpvMonthlyDetail.LocalReport.SetParameters(param);
            rpvMonthlyDetail.ZoomMode = ZoomMode.Percent;

            this.rpvMonthlyDetail.RefreshReport();
        }
    }
}