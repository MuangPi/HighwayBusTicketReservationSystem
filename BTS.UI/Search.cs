using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;


namespace BTS.UI
{
    public partial class Search : Form
    {
        #region Properties
        private SearchInfo returnResult;
        public SearchInfo ReturnResult
        {
            get { return returnResult; }
        }
        #endregion

        #region Constructor
        public Search()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                if(string.IsNullOrEmpty(this.txtCustomerName.Text.Trim().ToString()))
                {
                    Globalizer.ShowMessage(MessageType.Warning,"Customer Name should not be blank");
                }
                else
                {
                this.SearchByCustomerName(this.txtCustomerName.Text.Trim());
                }
            }
        }

        public void SearchByCustomerName(string customerName)
        {
            SearchController searchController = new SearchController();
            SearchCollection searchCollection = searchController.SelectByCustomerName(customerName);

            if (searchCollection.Count != 0)
            {
                dgvSaleSearch.DataSource = searchCollection;
            }
            else
            {
                MessageBox.Show("Record not found in database", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchCollection.Clear();
                this.dgvSaleSearch.DataSource = searchCollection;
                this.txtCustomerName.Clear();
                this.txtCustomerName.Focus();
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.dgvSaleSearch.AutoGenerateColumns = false;
            this.dgvBookingSearch.AutoGenerateColumns = false;
        }

        private void btnSaleCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dgvSaleSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && this.dgvSaleSearch.SelectedRows.Count > 0)
            {
                this.returnResult = (SearchInfo)this.dgvSaleSearch.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        public void SearchByCustomer(string customer)
        {
            SearchController searchController = new SearchController();
            SearchCollection searchCollection = searchController.SelectByCustomer(customer);

            if (searchCollection.Count != 0)
            {
                dgvBookingSearch.DataSource = searchCollection;
            }
            else
            {
                MessageBox.Show("Record not found in database", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                searchCollection.Clear();
                this.dgvBookingSearch.DataSource = searchCollection;
                this.txtCustomer.Clear();
                this.txtCustomer.Focus();
            }
        }

        private void dgvBookingSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && this.dgvBookingSearch.SelectedRows.Count > 0)
            {
                this.returnResult = (SearchInfo)this.dgvBookingSearch.SelectedRows[0].DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnBookingCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(this.txtCustomer.Text.Trim().ToString()))
                {
                    Globalizer.ShowMessage(MessageType.Warning, "Customer Name should not be blank");
                }
                else
                {
                    this.SearchByCustomer(this.txtCustomer.Text.Trim());
                }
            }
        }
        #endregion
    }
}