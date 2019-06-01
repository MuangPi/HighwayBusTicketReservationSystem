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
    public partial class TimeScheduleReport : Form
    {
        public TimeScheduleReport()
        {
            InitializeComponent();
        }

        private void TimeScheduleReport_Load(object sender, EventArgs e)
        {
            TimeScheduleController Controller = new TimeScheduleController();
            rpvTimeSchedule.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "TimeScheduleDataSet_TimeScheduleDataTable";
            rds.Value = Controller.SelectList();
            this.rpvTimeSchedule.LocalReport.DataSources.Add(rds);

            rpvTimeSchedule.ZoomMode = ZoomMode.Percent;
            this.rpvTimeSchedule.RefreshReport();
        }
    }
}