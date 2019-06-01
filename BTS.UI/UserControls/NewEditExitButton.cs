using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BTS.UI.UserControls
{
    public partial class NewEditExitButton : UserControl
    {
        #region Constructor
        public NewEditExitButton()
        {
            InitializeComponent();
        }
        #endregion

        #region EventHandler

        public event EventHandler NewClick;
        public event EventHandler EditClick;
        public event EventHandler CloseClick;

        #endregion

        #region Properties
        private string btnNewText;
        public string BtnNewText
        {
            get { return btnNewText; }
            set { btnNewText = value; }
        }

        private string btnEditText;
        public string BtnEditText
        {
            get { return btnEditText; }
            set { btnEditText = value; }
        }

        private string btnCloseText;
        public string BtnCloseText
        {
            get { return btnCloseText; }
            set { btnCloseText = value; }
        }
        #endregion

        #region Event
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnNewText = btnNew.Text;
            btnEditText = btnEdit.Text;
            btnCloseText = btnClose.Text;

            if (this.btnNew.Text.Equals("&New"))
            {
                btnNew.Text = "&Save";
                btnNew.ImageIndex = 3;
                btnEdit.Enabled = false;
                btnClose.Text = "&Cancel";
                btnClose.ImageIndex = 0;
            }

            if (this.NewClick != null)
            {
                this.NewClick(sender, e);
            }
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNewText = btnNew.Text;
            btnEditText = btnEdit.Text;
            btnCloseText = btnClose.Text;

            if (this.btnEdit.Text.Equals("&Edit"))
            {
                btnNew.Text = "&Update";
                btnNew.ImageIndex = 4;
                btnEdit.Text = "&Delete";
                btnEdit.ImageIndex = 6;
                btnClose.Text = "&Cancel";
                btnClose.ImageIndex = 0;
            }

            if (this.EditClick != null)
            {
                this.EditClick(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnNewText = btnNew.Text;
            btnEditText = btnEdit.Text;
            btnCloseText = btnClose.Text;

            if (this.btnClose.Text.Equals("&Cancel"))
            {
                btnNew.Text = "&New";
                btnNew.ImageIndex = 5;
                btnEdit.Text = "&Edit";
                btnEdit.Enabled = true;
                btnEdit.ImageIndex = 2;
                btnClose.Text = "&Close";
                btnClose.ImageIndex = 1;
            }

            if (this.CloseClick != null)
            {
                this.CloseClick(sender, e);
            }
        }
      
        #endregion

     


    }
}
