using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;

namespace BTS.UI.Reports
{
    public partial class ReportBySaleDate : Form
    {
        #region Constructor
        public ReportBySaleDate()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFields())
            {
                if (this.rdoDetail.Checked)
                {
                    ReportDisplay.ReportBySaleDateDetail saleDateDetail = new BTS.UI.ReportDisplay.ReportBySaleDateDetail(dtpFromSaleDate.Value.ToString(), dtpToSaleDate.Value.ToString());
                    saleDateDetail.ShowDialog();

                }
                else
                {
                    ReportDisplay.ReportBySaleDateSummary saleDateSummary = new BTS.UI.ReportDisplay.ReportBySaleDateSummary(dtpFromSaleDate.Value.ToString(), dtpToSaleDate.Value.ToString());
                    saleDateSummary.ShowDialog();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFromSaleDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion

        #region Helper Method
        private bool CheckRequiredFields()
        {
            if (this.dtpFromSaleDate.Value.CompareTo(this.dtpToSaleDate.Value) == 1)
            {
                string temp = dtpFromSaleDate.Value.ToString();
                dtpFromSaleDate.Text = dtpToSaleDate.Value.ToString();
                dtpToSaleDate.Value = Convert.ToDateTime(temp);
            }
            return true;
        }
        #endregion

     
    }
}