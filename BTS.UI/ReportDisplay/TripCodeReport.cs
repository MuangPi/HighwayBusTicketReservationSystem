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
    public partial class TripCodeReport : Form
    {
        private string fromTripCode;
        private string toTripCode;

        public TripCodeReport()
        {
            InitializeComponent();
        }

        public TripCodeReport(string FromTripCode, string ToTripCode)
        {
            InitializeComponent();
            fromTripCode = FromTripCode;
            toTripCode = ToTripCode;
        }

        private void TripCodeReport_Load(object sender, EventArgs e)
        {
            TripController controller = new TripController();
            rpvTripCode.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "TripDataSet_TripDataTable";
            rds.Value = controller.SelectListByTripCode(fromTripCode, toTripCode);
            this.rpvTripCode.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromTripCode", fromTripCode);
            param[1] = new ReportParameter("ToTripCode", toTripCode);
            rpvTripCode.LocalReport.SetParameters(param);

            rpvTripCode.ZoomMode = ZoomMode.Percent;

            this.rpvTripCode.RefreshReport();
        }
    }
}