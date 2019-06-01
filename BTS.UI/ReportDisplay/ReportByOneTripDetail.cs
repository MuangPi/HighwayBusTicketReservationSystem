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
    public partial class ReportByOneTripDetail : Form
    {
        private string routeName;
        private DateTime date;
        private string time;

        public ReportByOneTripDetail()
        {
            InitializeComponent();
        }

        public  ReportByOneTripDetail(string RouteName,DateTime Date,string Time)
        {
            InitializeComponent();
            routeName = RouteName;
            date = Date;
            time = Time;
        }

        private void ReportByOneTripDetail_Load(object sender, EventArgs e)
        {
            SaleController controller = new SaleController();
            this.rpvTripOneDetail.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "SaleDataSet_SaleDataTable";
            rds.Value = controller.SelectDetailByTripOne(routeName, date, time);
            this.rpvTripOneDetail.LocalReport.DataSources.Add(rds);

            ReportParameter[] param = new ReportParameter[3];
            param[0] = new ReportParameter("RouteName", this.routeName.ToString());
            param[1] = new ReportParameter("Date", this.date.ToString());
            param[2] = new ReportParameter("Time", this.time.ToString());

            this.rpvTripOneDetail.LocalReport.SetParameters(param);
            this.rpvTripOneDetail.ZoomMode = ZoomMode.Percent;

            this.rpvTripOneDetail.RefreshReport();
        }
    }
}