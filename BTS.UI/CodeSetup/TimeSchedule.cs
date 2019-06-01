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
    public partial class TimeSchedule : Form
    {
        #region Variables
        private string recordID = string.Empty;
        #endregion

        #region Constructor
        public TimeSchedule()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Events
        private void TimeSchedule_Load(object sender, EventArgs e)
        {
            this.BindDataGridView();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            ReportDisplay.TimeScheduleReport timeScheduleReport = new ReportDisplay.TimeScheduleReport();
            timeScheduleReport.ShowDialog();
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void InputControls_KeyDown(object sender, KeyEventArgs e)
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
                        if (CheckRequiredFields())
                        {
                            TimeScheduleController timeController = new TimeScheduleController();
                            TimeScheduleInfo timeInfo = new TimeScheduleInfo();

                            timeInfo.TimeID = this.recordID;
                            timeInfo.Time = this.txtTime.Text.Trim();
                            timeInfo.Description = this.txtDescription.Text.Trim();

                            timeController.Insert(timeInfo);

                            string log = "Form-TimeSchedule;Item-Time:" + this.txtTime.Text + ";action-Save";
                            userAction.Log(log);

                            this.InitializeControls();
                            this.BindDataGridView();
                            Globalizer.ShowMessage(MessageType.Information, "Saved Successfully");
                        }
                        break;

                    case "&Update":
                        if (CheckRequiredFields())
                        {
                            TimeScheduleController timeController = new TimeScheduleController();
                            TimeScheduleInfo timeInfo = new TimeScheduleInfo();

                            timeInfo.TimeID = this.recordID;
                            timeInfo.Time = this.txtTime.Text.Trim();
                            timeInfo.Description = this.txtDescription.Text.Trim();

                            timeController.UpdateByTimeID(timeInfo);

                            string log = "Form-TimeSchedule;Item-Time:" + this.txtTime.Text + ";action-Update";
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

        private void dgvTimeSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            try
            {
                switch (e.ColumnIndex)
                {
                    case 0:
                        this.recordID = this.dgvTimeSchedule.Rows[e.RowIndex].Cells["TimeID"].Value.ToString();

                        this.txtTime.Text = this.dgvTimeSchedule.Rows[e.RowIndex].Cells["Time"].Value.ToString();
                        this.txtDescription.Text = this.dgvTimeSchedule.Rows[e.RowIndex].Cells["Description"].Value.ToString();

                        this.btnSave.Text = "&Update";
                        break;

                    case 1:
                        if (Globalizer.ShowMessage(MessageType.Question, "Are you sure want to delete?") == DialogResult.Yes)
                        {
                            recordID = this.dgvTimeSchedule.Rows[e.RowIndex].Cells["TimeID"].Value.ToString();
                            TimeScheduleController timeController = new TimeScheduleController();

                            timeController.DeleteByTimeID(recordID);

                            string log = "Form-TimeSchedule;Item-Time:" + this.txtTime.Text + ";action-:Delete";
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

        #region Helper Methods
        private void InitializeControls()
        {
            this.txtTime.Text = "";
            this.txtDescription.Text = "";
            this.btnSave.Text = "&Save";
            this.txtTime.Focus();
            this.recordID = "";
        }

        private bool CheckRequiredFields()
        {
            if (string.IsNullOrEmpty(this.txtTime.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Time should not be blank");
                this.txtTime.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtDescription.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Description should not be blank");
                this.txtDescription.Focus();
                return false;
            }
            return true;
        }

        private void BindDataGridView()
        {
            TimeScheduleController timeController = new TimeScheduleController();
            TimeCollections timeCollections = timeController.SelectList();

            this.dgvTimeSchedule.AutoGenerateColumns = false;
            this.dgvTimeSchedule.DataSource = timeCollections;
        }

        #endregion
    }
}