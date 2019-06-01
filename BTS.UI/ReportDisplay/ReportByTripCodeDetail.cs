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
    public partial class ReportByTripCodeDetail : Form
    {
        private string fromTripCode;
        private string toTripCode;

        public ReportByTripCodeDetail()
        {
            InitializeComponent();
        }

        public ReportByTripCodeDetail(string FromTripCode, string ToTripCode)
        {
            InitializeComponent();
            fromTripCode = FromTripCode;
            toTripCode = ToTripCode;
        }

        private void ReportByTripCodeDetail_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvTripCodeDetail.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectDetailByTripCode(fromTripCode, toTripCode);
            this.rpvTripCodeDetail.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromTripCode", this.fromTripCode);
            param[1] = new ReportParameter("ToTripCode", this.toTripCode);

            this.rpvTripCodeDetail.LocalReport.SetParameters(param);
            this.rpvTripCodeDetail.ZoomMode = ZoomMode.Percent;

            this.rpvTripCodeDetail.RefreshReport();
        }
    }
}