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
    public partial class ReportBySaleDateDetail : Form
    {
        private string fromSaleDate;
        private string toSaleDate;

        public ReportBySaleDateDetail()
        {
            InitializeComponent();
        }

        public ReportBySaleDateDetail(string FromSaleDate, string ToSaleDate)
        {
            InitializeComponent();
            fromSaleDate = FromSaleDate;
            toSaleDate = ToSaleDate;
        }


        private void ReportBySaleDateDetail_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvSaleDateDetail.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectDetailBySaleDate(fromSaleDate, toSaleDate);
            this.rpvSaleDateDetail.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromSaleDate", this.fromSaleDate);
            param[1] = new ReportParameter("ToSaleDate", this.toSaleDate);

            this.rpvSaleDateDetail.LocalReport.SetParameters(param);
            this.rpvSaleDateDetail.ZoomMode = ZoomMode.Percent;

            this.rpvSaleDateDetail.RefreshReport();
        }
    }
}