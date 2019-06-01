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
    public partial class TripByDriverNameReport : Form
    {
        private string driverID;

        public TripByDriverNameReport()
        {
            InitializeComponent();
        }

        public TripByDriverNameReport(string DriverID)
        {
            InitializeComponent();
            driverID = DriverID;
        }

        private void TripByDriverNameReport_Load(object sender, EventArgs e)
        {
            TripController controller = new TripController();
            rpvDriverName.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "TripDataSet_TripDataTable";
            rds.Value = controller.SelectListByDriverName(driverID);
            this.rpvDriverName.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("DriverID", driverID.ToString());
            rpvDriverName.LocalReport.SetParameters(param);

            rpvDriverName.ZoomMode = ZoomMode.Percent;

            this.rpvDriverName.RefreshReport();
        }
    }
}