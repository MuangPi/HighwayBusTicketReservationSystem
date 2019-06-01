using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;


namespace BTS.UI.Posting
{
    public partial class SalePosting : Form
    {
        #region Constructor
        public SalePosting()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Methods
        public void BindFromSaleNo()
        {
            SaleController saleController = new SaleController();
            SaleCollection saleCollection = saleController.SelectList();

            SaleInfo saleInfo = new SaleInfo();
            saleInfo.SaleNo = "-Select One";
            saleInfo.SaleID = null;
            saleCollection.Insert(0, saleInfo);

            this.cboFromSaleInvoiceNo.DisplayMember = "SaleNo";
            this.cboFromSaleInvoiceNo.ValueMember = "SaleID";
            this.cboFromSaleInvoiceNo.DataSource = saleCollection;
            this.cboFromSaleInvoiceNo.SelectedIndex = 0;
        }

        public void BindToSaleNo()
        {
            SaleController saleController = new SaleController();
            SaleCollection saleCollection = saleController.SelectList();

            SaleInfo saleInfo = new SaleInfo();
            saleInfo.SaleNo = "-Select One";
            saleInfo.SaleID = null;
            saleCollection.Insert(0, saleInfo);

            this.cboToSaleInvoiceNo.DisplayMember = "SaleNo";
            this.cboToSaleInvoiceNo.ValueMember = "SaleID";
            this.cboToSaleInvoiceNo.DataSource = saleCollection;
            this.cboToSaleInvoiceNo.SelectedIndex = 0;
        }

        public bool CheckRequiredFieldForSaleNo()
        {
            if (this.cboFromSaleInvoiceNo.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "From Sale Invoice No should not be blank");
                return false;
            }
            if (this.cboToSaleInvoiceNo.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "To Sale Invoice No should not be blank");
                return false;
            }
            return true;
        }

        private bool CheckRequiredFieldForSaleDate()
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

        #region Events
        private void PostingBySaleNo_Load(object sender, EventArgs e)
        {
            this.BindFromSaleNo();
            this.BindToSaleNo();
            this.VisibleControlforSaleNo();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (rdoSaleNo.Checked)
            {
                if (CheckRequiredFieldForSaleNo())
                {
                    SaleController saleController = new SaleController();
                    saleController.PostBySaleNo(this.cboFromSaleInvoiceNo.Text, this.cboToSaleInvoiceNo.Text);

                    string log = "Form-Posting;Item-Posting:" +"From"+ "("+this.cboFromSaleInvoiceNo.SelectedText+")"+"To"+"("+this.cboToSaleInvoiceNo.SelectedText+")" + ";action-Post";
                    userAction.Log(log);

                    this.BindFromSaleNo();
                    this.BindToSaleNo();
                    Globalizer.ShowMessage(MessageType.Information, "Posted Successfully");
                }
            }
            else
            {
                if (CheckRequiredFieldForSaleDate())
                {
                    try
                    {
                        SaleController saleController = new SaleController();
                        saleController.PostBySaleDate(dtpFromSaleDate.Value, dtpToSaleDate.Value);

                        string log = "Form-Posting;Item-Posting:" + "From" + "(" + this.dtpFromSaleDate.ToString() + ")" + "To" + "(" + this.dtpToSaleDate.ToString() + ")" + ";action-Post";
                        userAction.Log(log);

                        Globalizer.ShowMessage(MessageType.Information, "Posted Successfully");
                    }
                    catch (Exception ex)
                    {
                        Globalizer.ShowMessage(MessageType.Warning, ex.Message);
                    }                    
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void VisibleControlforSaleNo()
        {
            this.cboFromSaleInvoiceNo.Visible = true;
            this.cboToSaleInvoiceNo.Visible = true;
            lblFromSaleNo.Visible = true;
            lblToSaleNo.Visible = true;
            this.dtpFromSaleDate.Visible = false;
            this.dtpToSaleDate.Visible = false;
            lblFromSaleDate.Visible = false;
            lblToSaleDate.Visible = false;                    
        }

        private void VisibleControlforSaleDate()
        {
            this.cboFromSaleInvoiceNo.Visible = false;
            this.cboToSaleInvoiceNo.Visible = false;
            lblFromSaleNo.Visible = false;
            lblToSaleNo.Visible = false;
            this.dtpFromSaleDate.Visible = true;
            this.dtpToSaleDate.Visible = true;
            lblFromSaleDate.Visible = true;
            lblToSaleDate.Visible = true;
        }

        private void rdoSaleDate_CheckedChanged(object sender, EventArgs e)
        {
            this.VisibleControlforSaleDate();
        }

        private void rdoSaleNo_CheckedChanged(object sender, EventArgs e)
        {
            this.VisibleControlforSaleNo();
        }
        #endregion

        private void dtpFromSaleDate_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
    }
}