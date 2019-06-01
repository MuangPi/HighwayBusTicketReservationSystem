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
    public partial class ReportBySaleDateSummary : Form
    {
        private string fromSaleDate;
        private string toSaleDate;

        public ReportBySaleDateSummary()
        {
            InitializeComponent();
        }

        public ReportBySaleDateSummary(string FromSaleDate, string ToSaleDate)
        {
            InitializeComponent();
            fromSaleDate = FromSaleDate;
            toSaleDate = ToSaleDate;
        }

        private void ReportBySaleDateSummary_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvSaleDateSummary.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectSummaryBySaleDate(fromSaleDate, toSaleDate);
            this.rpvSaleDateSummary.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromSaleDate", this.fromSaleDate);
            param[1] = new ReportParameter("ToSaleDate", this.toSaleDate);

            this.rpvSaleDateSummary.LocalReport.SetParameters(param);
            this.rpvSaleDateSummary.ZoomMode = ZoomMode.Percent;

            this.rpvSaleDateSummary.RefreshReport();
        }
    }
}