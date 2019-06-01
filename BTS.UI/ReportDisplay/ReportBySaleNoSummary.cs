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
    public partial class ReportBySaleNoSummary : Form
    {
        private string fromSaleNo;
        private string toSaleNo;

        public ReportBySaleNoSummary()
        {
            InitializeComponent();
        }

        public ReportBySaleNoSummary(string FromSaleNo, string ToSaleNo)
        {
            InitializeComponent();
            fromSaleNo = FromSaleNo;
            toSaleNo = ToSaleNo;
        }

        private void ReportBySaleNoSummary_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvSaleNoSummary.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectSummaryBySaleNo(fromSaleNo, toSaleNo);
            this.rpvSaleNoSummary.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromSaleNo", this.fromSaleNo);
            param[1] = new ReportParameter("ToSaleNo", this.toSaleNo);

            this.rpvSaleNoSummary.LocalReport.SetParameters(param);
            this.rpvSaleNoSummary.ZoomMode = ZoomMode.Percent;

            this.rpvSaleNoSummary.RefreshReport();
        }
    }
}