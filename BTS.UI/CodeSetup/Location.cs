using System;
using System.Collections.ObjectModel;
using BTS.BusinessLogic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace BTS.UI.CodeSetup
{
    public partial class Location : Form
    {
        #region Variables
        private string recordID = string.Empty;
        #endregion

        #region Constructor
        public Location()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region HelperMethods

        private void InitializeControls()
        {
            this.txtLocationCode.Text = "";
            this.txtLocationName.Text = "";
            this.btnSave.Text = "&Save";
            this.txtLocationCode.Focus();
            this.recordID = "";
        }

        private bool CheckRequiredFileds()
        {
            if (String.IsNullOrEmpty(this.txtLocationCode.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Location Code shouldn't be blank");
                this.txtLocationCode.Focus();
                return false;
            }

            if (String.IsNullOrEmpty(this.txtLocationName.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Location Name shouldn't be blank");
                this.txtLocationName.Focus();
                return false;
            }
            return true;
        }

        private void BindDataGridView()
        {
            LocationController locationController = new LocationController();
            LocationCollection locationCollection = locationController.SelectList();

            this.dgvLocation.AutoGenerateColumns = false;
            this.dgvLocation.DataSource = locationCollection;
        }

        #endregion

        #region Events
        private void Location_Load(object sender, EventArgs e)
        {
            this.BindDataGridView();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.LocationReport locationReport = new ReportDisplay.LocationReport();
            locationReport.ShowDialog();
        }

        private void txtLocationCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtLocationCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.btnSave.Text)
                {
                    case "&Save":
                        if (CheckRequiredFileds())
                        {
                            LocationController locationController = new LocationController();
                            LocationInfo locationInfo = new LocationInfo();

                            locationInfo.LocationID = this.recordID;
                            locationInfo.LocationCode = this.txtLocationCode.Text.Trim();
                            locationInfo.LocationName = this.txtLocationName.Text.Trim();

                            locationController.Insert(locationInfo);

                            string log = "Form-Location;Item-LocationCode:" + this.txtLocationCode.Text + ";action-Save";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                        }
                        break;

                    case "&Update":
                        if (CheckRequiredFileds())
                        {
                            LocationController locationController = new LocationController();
                            LocationInfo locationInfo = new LocationInfo();

                            locationInfo.LocationID = this.recordID;
                            locationInfo.LocationCode = this.txtLocationCode.Text.Trim();
                            locationInfo.LocationName = this.txtLocationName.Text.Trim();

                            locationController.UpdateByLocationID(locationInfo);

                            string log = "Form-Location;Item-LocationCode:" + this.txtLocationCode.Text + ";action-Update";
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

        private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.recordID = this.dgvLocation.Rows[e.RowIndex].Cells["LocationID"].Value.ToString();

                        this.txtLocationCode.Text = this.dgvLocation.Rows[e.RowIndex].Cells["LocationCode"].Value.ToString();
                        this.txtLocationName.Text = this.dgvLocation.Rows[e.RowIndex].Cells["LocationName"].Value.ToString();

                        this.btnSave.Text = "&Update";
                        break;

                    case 1:
                        if (Globalizer.ShowMessage(MessageType.Question, "Are you sure to delete?") == DialogResult.Yes)
                        {
                            recordID = this.dgvLocation.Rows[e.RowIndex].Cells["LocationID"].Value.ToString();

                            LocationController controller = new LocationController();
                            LocationInfo locationInfo = new LocationInfo();
                            locationInfo.LocationID = this.recordID;

                            controller.DeleteByLocationID(locationInfo);

                            string log = "Form-Location;Item-LocationCode:" + this.txtLocationCode.Text + ";action-Delete";
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

        #endregion
    }
}