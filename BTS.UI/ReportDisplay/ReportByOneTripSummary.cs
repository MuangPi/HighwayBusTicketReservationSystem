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
    public partial class ReportByOneTripSummary : Form
    {
        private string routeName;
        private DateTime date;
        private string time;

        public ReportByOneTripSummary()
        {
            InitializeComponent();
        }

        public ReportByOneTripSummary(string RouteName, DateTime Date, string Time)
        {
            InitializeComponent();
            routeName = RouteName;
            date = Date;
            time = Time;
        }

        private void ReportByOneTripSummary_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvOneTripSummary.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectSummaryByTripOne(routeName, date, time);
            this.rpvOneTripSummary.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[3];
            param[0] = new ReportParameter("RouteName", this.routeName.ToString());
            param[1] = new ReportParameter("Date", this.date.ToString());
            param[2] = new ReportParameter("Time", this.time.ToString());

            this.rpvOneTripSummary.LocalReport.SetParameters(param);
            this.rpvOneTripSummary.ZoomMode = ZoomMode.Percent;

            this.rpvOneTripSummary.RefreshReport();
        }
    }
}