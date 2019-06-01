using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BTS.UI
{
    public partial class MainMenuForStaff : Form
    {
        public MainMenuForStaff()
        {
            InitializeComponent();
        }

        UserAction userAction = new UserAction();

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BTS.UI.FlatForm.TripPlan tripPlan = new BTS.UI.FlatForm.TripPlan();
            tripPlan.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BTS.UI.Grid.Sale sale = new BTS.UI.Grid.Sale();
            sale.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BTS.UI.Grid.Booking booking = new BTS.UI.Grid.Booking();
            booking.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BTS.UI.Process.BookingCancel bookingCancel = new BTS.UI.Process.BookingCancel();
            bookingCancel.ShowDialog();
        }

        //private void toolStripMenuItem5_Click(object sender, EventArgs e)
        //{
        //    BTS.UI.Process.Trip_Confirm tripConfirm = new BTS.UI.Process.Trip_Confirm();
        //    tripConfirm.ShowDialog();
        //}

        //private void toolStripMenuItem6_Click(object sender, EventArgs e)
        //{
        //    BTS.UI.Confirm confirm = new Confirm();
        //    confirm.ShowDialog();
        //}

        //private void toolStripMenuItem7_Click(object sender, EventArgs e)
        //{
        //    BTS.UI.TicketOut ticketOut = new TicketOut();
        //    ticketOut.ShowDialog();
        //}

        private void tsmExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = Globalizer.ShowMessage(MessageType.Question, "Are you sure to exit?");
            if (dialogresult == DialogResult.Yes)
            {
                Application.Exit();        

                string log = "------------------------------USER LOGOUT------------------------------";
                userAction.Log(log);
            }
        }       
    }
}