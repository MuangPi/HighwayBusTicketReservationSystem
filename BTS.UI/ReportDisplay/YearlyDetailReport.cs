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
    public partial class YearlyDetailReport : Form
    {
        private string year;

        public YearlyDetailReport()
        {
            InitializeComponent();
        }

        public YearlyDetailReport(string Year)
        {
            InitializeComponent();

            this.year = Year;
        }

        private void YearlyDetailReport_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            rpvYearlyDetail.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectYearlyDetail(this.year);
            rpvYearlyDetail.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[1];

            param[0] = new ReportParameter("Year", this.year);
            this.rpvYearlyDetail.LocalReport.SetParameters(param);
            this.rpvYearlyDetail.ZoomMode = ZoomMode.Percent;
            this.rpvYearlyDetail.RefreshReport();
        }
    }
}