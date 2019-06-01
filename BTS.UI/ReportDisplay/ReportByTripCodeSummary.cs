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
    public partial class ReportByTripCodeSummary : Form
    {
        private string fromTripCode;
        private string toTripCode;

        public ReportByTripCodeSummary()
        {
            InitializeComponent();
        }

        public ReportByTripCodeSummary(string FromTripCode, string ToTripCode)
        {
            InitializeComponent();
            fromTripCode = FromTripCode;
            toTripCode = ToTripCode;
        }

        private void ReportByTripCodeSummary_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvTripCodeSummary.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectSummaryByTripCode(fromTripCode, toTripCode);
            this.rpvTripCodeSummary.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromTripCode", this.fromTripCode);
            param[1] = new ReportParameter("ToTripCode", this.toTripCode);

            this.rpvTripCodeSummary.LocalReport.SetParameters(param);
            this.rpvTripCodeSummary.ZoomMode = ZoomMode.Percent;

            this.rpvTripCodeSummary.RefreshReport();
        }
    }
}