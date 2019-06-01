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
    public partial class ReportByTripCode : Form
    {
        #region Constructor
        public ReportByTripCode()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void BindFromTripCode()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectListRecord();

            TripInfo info = new TripInfo();
            info.TripCode = " - Select One - ";
            info.TripID = null;
            tripCollection.Insert(0, info);

            cboFromTripCode.DisplayMember = "TripCode";
            cboFromTripCode.ValueMember = "TripID";
            cboFromTripCode.DataSource = tripCollection;

            cboFromTripCode.SelectedIndex = 0;
        }

        private void BindToTripCode()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectListRecord();

            TripInfo info = new TripInfo();
            info.TripCode = " - Select One - ";
            info.TripID = null;
            tripCollection.Insert(0, info);

            cboToTripCode.DisplayMember = "TripCode";
            cboToTripCode.ValueMember = "TripID";
            cboToTripCode.DataSource = tripCollection;

            cboToTripCode.SelectedIndex = 0;
        }

        private bool CheckRequiredFieldsForTripCode()
        {
            if (this.cboFromTripCode.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "From Trip Code should not be blank");
                this.cboFromTripCode.Focus();
                return false;
            }

            else if (this.cboToTripCode.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "To Trip Code should not be blank");
                this.cboToTripCode.Focus();
                return false;
            }

            else if (this.cboFromTripCode.SelectedIndex > this.cboToTripCode.SelectedIndex)
            {
                Globalizer.ShowMessage(MessageType.Warning, "To Trip Code should not be greater From Trip Code");
                this.cboToTripCode.Focus();
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void ReportByTripCode_Load(object sender, EventArgs e)
        {
            this.BindFromTripCode();
            this.BindToTripCode();
        }

        private void cboControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.CheckRequiredFieldsForTripCode())
            {
                if (this.rdoDetail.Checked)
                {
                    ReportDisplay.ReportByTripCodeDetail tripCodeDetail = new BTS.UI.ReportDisplay.ReportByTripCodeDetail(cboFromTripCode.Text.ToString(), cboToTripCode.Text.ToString());
                    tripCodeDetail.ShowDialog();
                  
                }
                else
                {
                    ReportDisplay.ReportByTripCodeSummary tripCodeSummary = new BTS.UI.ReportDisplay.ReportByTripCodeSummary(cboFromTripCode.Text.ToString(), cboToTripCode.Text.ToString());
                    tripCodeSummary.ShowDialog();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFromTripCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        
        
        #endregion

        
    }
}