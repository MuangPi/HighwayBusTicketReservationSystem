using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;

namespace BTS.UI.CodeSetup
{
    public partial class BusType : Form
    {
        #region Variables
        private string recordID = string.Empty;
        #endregion

        #region Constructor
        public BusType()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Events
        private void InputControls_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void txtBusTypeCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtTotalSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& (Keys)e.KeyChar!=Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void BusType_Load(object sender, EventArgs e)
        {
            this.BindDataGridView();
        }

        private void dgvBusType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.recordID = this.dgvBusType.Rows[e.RowIndex].Cells["BusTypeID"].Value.ToString();

                        this.txtBusTypeCode.Text = this.dgvBusType.Rows[e.RowIndex].Cells["BusTypeCode"].Value.ToString();
                        this.txtDescription.Text = this.dgvBusType.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                        this.txtTotalSeats.Text = this.dgvBusType.Rows[e.RowIndex].Cells["TotalSeats"].Value.ToString();

                        this.btnSave.Text = "&Update";
                        break;

                    case 1:
                        if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                        {
                            recordID = this.dgvBusType.Rows[e.RowIndex].Cells["BusTypeID"].Value.ToString();
                            BusTypeController busTypeController = new BusTypeController();

                            busTypeController.DeleteByBusTypeID(recordID);

                            string log = "Form-BusType;Item-BusCode:" + this.txtBusTypeCode.Text + ";action-Delete";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Deleted Successfully");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Critical, ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.btnSave.Text)
                {
                    case "&Save":
                        if (CheckRequiredFields())
                        {
                            BusTypeController busTypeController = new BusTypeController();
                            BusTypeInfo busTypeInfo = new BusTypeInfo();

                            busTypeInfo.BusTypeID = this.recordID;
                            busTypeInfo.BusTypeCode = this.txtBusTypeCode.Text.Trim();
                            busTypeInfo.TotalSeats = Convert.ToInt32(this.txtTotalSeats.Text.Trim());
                            busTypeInfo.Description = this.txtDescription.Text.Trim();
                            busTypeController.Insert(busTypeInfo);
                            string log = "Form-BusType;Item-BusCode:" + this.txtBusTypeCode.Text + ";action-Save";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                        }
                        break;

                    case "&Update":
                        if (CheckRequiredFields())
                        {
                            BusTypeController busTypeController = new BusTypeController();
                            BusTypeInfo busTypeInfo = new BusTypeInfo();

                            busTypeInfo.BusTypeID = this.recordID;
                            busTypeInfo.BusTypeCode = this.txtBusTypeCode.Text.Trim();
                            busTypeInfo.TotalSeats = Convert.ToInt32(this.txtTotalSeats.Text.Trim());
                            busTypeInfo.Description = this.txtDescription.Text.Trim();

                            busTypeController.UpdateByBusTypeID(busTypeInfo);

                            string log = "Form-BusType;Item-BusCode:" + this.txtBusTypeCode.Text + ";action-Update";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Updated Successfully");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Globalizer.ShowMessage(MessageType.Critical, ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.InitializeControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.BusTypeReport busTypeReport = new ReportDisplay.BusTypeReport();
            busTypeReport.ShowDialog();
        }

        #endregion

        #region Methods
        private void InitializeControls()
        {
            this.txtBusTypeCode.Text = "";
            this.txtDescription.Text = "";
            this.txtTotalSeats.Text = "";
            this.btnSave.Text = "&Save";
            this.txtBusTypeCode.Focus();
            this.recordID = "";
        }

        private void BindDataGridView()
        {
            BusTypeController busTypeController = new BusTypeController();
            BusTypeCollections busTypeCollections = busTypeController.SelectList();

            this.dgvBusType.AutoGenerateColumns = false;
            this.dgvBusType.DataSource = busTypeCollections;
        }

        private bool CheckRequiredFields()
        {
            if (string.IsNullOrEmpty(this.txtBusTypeCode.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Bus Type Code should not be blank");
                this.txtBusTypeCode.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtDescription.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Description should not be blank");
                this.txtDescription.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtTotalSeats.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Total Seats should not be blank");
                this.txtTotalSeats.Focus();
                return false;
            }

            return true;
        }

        #endregion


    }
}
        
        

      
