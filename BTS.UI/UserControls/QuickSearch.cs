using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;

namespace BTS.UI.UserControls
{
    public delegate void Click_Delegate(BTS.BusinessLogic.SearchInfo result);

    public partial class QuickSearch : UserControl
    {
        public event Click_Delegate SearchClick;

        public QuickSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            {

                if (search.ShowDialog() == DialogResult.OK)
                {                    
                    if (this.SearchClick != null)
                    {
                        this.SearchClick(search.ReturnResult);
                    }
                }
            }
        }
    }
}
