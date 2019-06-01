using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;


namespace BTS.UI.Reports
{
    public partial class ReportBySaleNo : Form
    {
        #region Constructor
        public ReportBySaleNo()
        {
            InitializeComponent();
        }
        #endregion

        #region Helper Method
        private void BindFromSaleNo()
        {
            SaleController saleController = new SaleController();
            SaleCollection saleCollection = saleController.SelectList();

            SaleInfo info = new SaleInfo();
            info.SaleNo = " - Select One - ";
            info.SaleID = null;
            saleCollection.Insert(0, info);

            cboFromSaleNo.DisplayMember = "SaleNo";
            cboFromSaleNo.ValueMember = "SaleID";
            cboFromSaleNo.DataSource = saleCollection;

            cboFromSaleNo.SelectedIndex = 0;
        }

        private void BindToSaleNo()
        {
            SaleController saleController = new SaleController();
            SaleCollection saleCollection = saleController.SelectList();

            SaleInfo info = new SaleInfo();
            info.SaleNo = " - Select One - ";
            info.SaleID = null;
            saleCollection.Insert(0, info);

            cboToSaleNo.DisplayMember = "SaleNo";
            cboToSaleNo.ValueMember = "SaleID";
            cboToSaleNo.DataSource = saleCollection;

            cboToSaleNo.SelectedIndex = 0;
        }

        private bool CheckRequiredFields()
        {
            if (this.cboFromSaleNo.SelectedValue == null)
            {
                //Show warning message
                Globalizer.ShowMessage(MessageType.Warning, "From SaleNo should not be blank");
                this.cboFromSaleNo.Focus(); //set focus to control
                return false;
            }
            else if (this.cboToSaleNo.SelectedValue == null)
            {
                //Show warning message
                Globalizer.ShowMessage(MessageType.Warning, "To SaleNo should not be blank");
                this.cboToSaleNo.Focus(); //set focus to control
                return false;
            }
            else if (this.cboFromSaleNo.SelectedIndex > this.cboToSaleNo.SelectedIndex)
            {
                //Show warning message
                Globalizer.ShowMessage(MessageType.Warning, "From SaleNo should not be greater than To SaleNo");
                this.cboToSaleNo.Focus(); //set focus to control
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void ReportBySaleNo_Load(object sender, EventArgs e)
        {
            this.BindFromSaleNo();
            this.BindToSaleNo();
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFields())
            {
                if (this.rdoDetail.Checked)
                {
                    ReportDisplay.ReportBySaleNoDetail saleNoDetail = new BTS.UI.ReportDisplay.ReportBySaleNoDetail(cboFromSaleNo.Text.ToString(), cboToSaleNo.Text.ToString());
                    saleNoDetail.ShowDialog();
                  
                }
                else
                {
                    ReportDisplay.ReportBySaleNoSummary saleNoSummary = new BTS.UI.ReportDisplay.ReportBySaleNoSummary(cboFromSaleNo.Text.ToString(), cboToSaleNo.Text.ToString());
                    saleNoSummary.ShowDialog();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFromSaleNo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        #endregion

       
    }
}