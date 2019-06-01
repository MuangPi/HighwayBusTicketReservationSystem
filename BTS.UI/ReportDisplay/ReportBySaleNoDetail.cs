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
    public partial class ReportBySaleNoDetail : Form
    {
        private string fromSaleNo;
        private string toSaleNo;

        public ReportBySaleNoDetail()
        {
            InitializeComponent();
        }

        public ReportBySaleNoDetail(string FromSaleNo, string ToSaleNo)
        {
            InitializeComponent();
            fromSaleNo = FromSaleNo;
            toSaleNo = ToSaleNo;
        }

        private void ReportBySaleNoDetail_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvSaleNoDetail.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectDetailBySaleNo(fromSaleNo, toSaleNo);
            this.rpvSaleNoDetail.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromSaleNo", this.fromSaleNo);
            param[1] = new ReportParameter("ToSaleNo", this.toSaleNo);

            this.rpvSaleNoDetail.LocalReport.SetParameters(param);
            this.rpvSaleNoDetail.ZoomMode = ZoomMode.Percent;
            this.rpvSaleNoDetail.RefreshReport();
        }
    }
}