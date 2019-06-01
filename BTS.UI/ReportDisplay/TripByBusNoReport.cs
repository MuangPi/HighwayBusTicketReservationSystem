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
    public partial class TripByBusNoReport : Form
    {
        private string busNo;

        public TripByBusNoReport()
        {
            InitializeComponent();
        }

        public TripByBusNoReport(string BusNo)
        {
            InitializeComponent();
            busNo = BusNo;
        }

        private void TripByBusNoReport_Load(object sender, EventArgs e)
        {
            TripController controller = new TripController();
            rpvBusNo.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "TripDataSet_TripDataTable";
            rds.Value = controller.SelectListByBusNo(busNo);
            this.rpvBusNo.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("BusNo", busNo.ToString());
            rpvBusNo.LocalReport.SetParameters(param);

            rpvBusNo.ZoomMode = ZoomMode.Percent;

            this.rpvBusNo.RefreshReport();
        }
    }
}