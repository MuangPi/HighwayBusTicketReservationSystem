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
    public partial class TripDateReport : Form
    {
        private string fromTripDate;
        private string toTripDate;

        public TripDateReport()
        {
            InitializeComponent();
        }

        public TripDateReport(string FromTripDate, string ToTripDate)
        {
            InitializeComponent();
            fromTripDate = FromTripDate;
            toTripDate = ToTripDate;
        }

        private void TripDateReport_Load(object sender, EventArgs e)
        {
            TripController controller = new TripController();
            rpvTripDate.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "TripDataSet_TripDataTable";
            rds.Value = controller.SelectListByTripDate(fromTripDate, toTripDate);
            this.rpvTripDate.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[2];
            param[0] = new ReportParameter("FromTripDate", fromTripDate);
            param[1] = new ReportParameter("ToTripDate", toTripDate);
            rpvTripDate.LocalReport.SetParameters(param);

            rpvTripDate.ZoomMode = ZoomMode.Percent;
            this.rpvTripDate.RefreshReport();
        }
    }
}