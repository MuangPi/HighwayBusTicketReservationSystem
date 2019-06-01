using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTS.UI
{
    public partial class UserActionHistory : Form
    {
        #region Constructor
        public UserActionHistory()
        {
            InitializeComponent();
        }
        #endregion

        UserAction userAction = new UserAction();

        #region Events
        private void UserActionHistory_Load(object sender, EventArgs e)
        {
            txtLogText.Text = userAction.GetAction();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            userAction.ClearLog();
            txtLogText.Clear();
            txtLogText.Text = userAction.GetAction();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}