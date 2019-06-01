using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BTS.BusinessLogic;

namespace BTS.UI
{
    public partial class MainMenu : Form
    {
        public int x = 0;
        public int y = 529;
        public MainMenu()
        {
            InitializeComponent();
        }

        UserAction userAction = new UserAction();

        

        #region MouseHoverEvents
        private void Picture1_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(250, 200);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(11, 0);
        }
        private void Picture2_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(250, 200);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(267, 0);
        }
        private void Picture3_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(250, 200);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(11, 208);
        }
        private void Picture4_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(250, 200);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(267, 208);
        }
        #endregion

        #region MouseLeaveEvents
        private void Picture1_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(190, 160);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(71, 37);
        }
        private void Picture2_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(190, 160);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(267, 37);
        }
        private void Picture3_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(190, 160);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(71, 208);
        }
        private void Picture4_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)(sender)).Size = new System.Drawing.Size(190, 160);
            ((PictureBox)(sender)).Location = new System.Drawing.Point(267, 208);
        }
        #endregion

        
        //private void ticketOutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    TicketOut ticketOut = new TicketOut();
        //    ticketOut.ShowDialog();
        //}

        private void busTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.CodeSetup.BusType busType = new BTS.UI.CodeSetup.BusType();
            busType.ShowDialog();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.CodeSetup.Driver driver = new BTS.UI.CodeSetup.Driver();
            driver.ShowDialog();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.CodeSetup.Location location = new BTS.UI.CodeSetup.Location();
            location.ShowDialog();
        }

        private void timeScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.CodeSetup.TimeSchedule timeSchedule = new BTS.UI.CodeSetup.TimeSchedule();
            timeSchedule.ShowDialog();
        }

        
        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.FlatForm.Bus bus = new BTS.UI.FlatForm.Bus();
            bus.ShowDialog();
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.FlatForm.Route route = new BTS.UI.FlatForm.Route();
            route.ShowDialog();
        }

        private void salToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.Grid.Sale sale = new BTS.UI.Grid.Sale();
            sale.ShowDialog();
        }

        private void bookingEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.Grid.Booking booking = new BTS.UI.Grid.Booking();
            booking.ShowDialog();
        }

        private void userLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.CodeSetup.frmUserLevel userLevel = new BTS.UI.CodeSetup.frmUserLevel();
            userLevel.ShowDialog();
        }

        private void userEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.FlatForm.User user = new BTS.UI.FlatForm.User();
            user.ShowDialog();
        }

        private void bookingCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.Process.BookingCancel bookingCancel = new BTS.UI.Process.BookingCancel();
            bookingCancel.ShowDialog();
        }

        //private void tripConfirmToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    BTS.UI.Process.Trip_Confirm tripConfirm = new BTS.UI.Process.Trip_Confirm();
        //    tripConfirm.ShowDialog();
        //}

        private void tripPlanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BTS.UI.FlatForm.TripPlan tripPlan = new BTS.UI.FlatForm.TripPlan();
            tripPlan.ShowDialog();
        }

        private void proccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.Posting.SalePosting posting = new BTS.UI.Posting.SalePosting();
            posting.ShowDialog();
        }

        //private void bookingConfirmToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    BTS.UI.Confirm confirm = new Confirm();
        //    confirm.ShowDialog();
        //}

        //private void ticketOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{
        //    BTS.UI.TicketOut ticketOut = new TicketOut();
        //    ticketOut.ShowDialog();
        //}

        private void pb1_Click(object sender, EventArgs e)
        {
            BTS.UI.ReportAll reportAll = new ReportAll();
            reportAll.ShowDialog();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            BTS.UI.Posting.SalePosting salePosting = new BTS.UI.Posting.SalePosting();
            salePosting.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dialogresult =Globalizer.ShowMessage(MessageType.Question, "Are you sure to exit?");
           if (dialogresult == DialogResult.Yes)
           {
               Application.Exit();
              
               string log = "------------------------------USER Logout;User:"+Globalizer.userName+"userName"+"------------------------------";
               userAction.Log(log);
           }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.ReportAll reportAll = new ReportAll();
            reportAll.ShowDialog();
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            BTS.UI.UserActionHistory userActionHistory = new UserActionHistory();
            userActionHistory.ShowDialog();
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            BTS.UI.FlatForm.User user = new BTS.UI.FlatForm.User();
            user.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BTS.UI.FlatForm.TripPlan tripPlan = new BTS.UI.FlatForm.TripPlan();
            tripPlan.ShowDialog();
        }

        private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BTS.UI.ReportAll reportAll = new ReportAll();
            reportAll.ShowDialog();
        }

        private void postingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.Posting.SalePosting posting = new BTS.UI.Posting.SalePosting();
            posting.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = Globalizer.ShowMessage(MessageType.Question, "Are you sure to exit?");
            if (dialogresult == DialogResult.Yes)
            {
                Application.Exit();

                string log = "------------------------------USER Logout;User:" + Globalizer.userName + "userName" + "------------------------------";
                userAction.Log(log);
            }
        }

        private void tripConfirmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTS.UI.Process.Trip_Confirm tripConfirm = new BTS.UI.Process.Trip_Confirm();
             tripConfirm.ShowDialog();

        }

          
    }
}