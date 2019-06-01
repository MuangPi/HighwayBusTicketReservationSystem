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
    public partial class TripByRouteNameReport : Form
    {
        private string routeName;

        public TripByRouteNameReport()
        {
            InitializeComponent();
        }

        public TripByRouteNameReport(string RouteName)
        {
            InitializeComponent();
            routeName = RouteName;
        }

        private void TripByRouteNameReport_Load(object sender, EventArgs e)
        {
            TripController controller = new TripController();
            rpvRouteName.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "TripDataSet_TripDataTable";
            rds.Value = controller.SelectListByRouteName(routeName);
            this.rpvRouteName.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("RouteName", routeName);
            rpvRouteName.LocalReport.SetParameters(param);

            rpvRouteName.ZoomMode = ZoomMode.Percent;

            this.rpvRouteName.RefreshReport();
        }
    }
}