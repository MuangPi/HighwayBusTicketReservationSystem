using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;

namespace BTS.UI.Process
{
    public partial class Trip_Confirm : Form
    {
        #region Constructor
        public Trip_Confirm()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Methods
        private void BindTripID()
        {
            TripController tripController = new TripController();
            TripCollection tripCollection = tripController.SelectList();

            TripInfo tripInfo = new TripInfo();
            tripInfo.TripCode = " - Select One - ";
            tripInfo.TripID = null;
            tripCollection.Insert(0, tripInfo);

            this.cboTrip.DisplayMember = "TripCode";
            this.cboTrip.ValueMember = "TripID";
            this.cboTrip.DataSource = tripCollection;
            this.cboTrip.SelectedIndex = 0;
        }

        private void BindControls()
        {
            TripController tripController = new TripController();
            TripInfo tripInfo = tripController.SelectByTripID(this.cboTrip.SelectedValue.ToString());

            string date = Convert.ToString(tripInfo.TripDate);
            this.txtTripDate.Text = date.Substring(0, 10);
            this.txtTime.Text = (tripInfo.Time);
        }

        private void InitializeControls()
        {
            this.txtTripDate.Text = null;
            this.txtTime.Text = null;
        }

        private bool CheckRequiredField()
        {
            if (this.cboTrip.SelectedValue == null)
            {
                Globalizer.ShowMessage(MessageType.Warning, "Trip should not be blank");
                this.cboTrip.Focus(); //set focus to control
                return false;
            }
            return true;
        }
        #endregion

        #region Events
        private void Trip_Confirm_Load(object sender, EventArgs e)
        {
            this.BindTripID();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (CheckRequiredField())
            {
                TripController tripController = new TripController();
                tripController.PostByTripID(this.cboTrip.SelectedValue.ToString());

                string log = "Form-TripConfirm;Item-TripConfirm:" + this.cboTrip.Text + "TripTime:" + "(" + txtTime.Text + ")" + "TripDate:" + "(" + txtTripDate.Text + ")" + ";action-Confrim";
                userAction.Log(log);

                this.BindTripID();
                this.InitializeControls();
                Globalizer.ShowMessage(MessageType.Information, "Process Successfully");
            }
        }

        private void cboTrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboTrip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTrip.SelectedIndex != 0)
            {
                this.BindControls();
            }
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}