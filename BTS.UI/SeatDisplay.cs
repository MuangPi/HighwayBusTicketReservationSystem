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
    public partial class SeatDisplay : Form
    {
        #region Constructor
        public SeatDisplay()
        {
            InitializeComponent();
        }
        #endregion

        #region Helper Method
        public void BindSeat()
        {
            TripInfo tripInfo = new TripInfo();
            string TripID = Convert.ToString(tripInfo.TripID);
            TripDetailController tripDetailContoller = new TripDetailController();
            TripDetailCollection collections = tripDetailContoller.SelectDetailByTripID(lblGetTripID.Text);

            pnlSeat.Controls.Clear();

            int backSeat = collections.Count - 5;
            int backSeatNumber = (collections.Count % 2);
            
            for (int i = 0, x = 0, y = 0; i < collections.Count; i++)
            {

                Label lbl = new Label();

                if (collections[i].Status == "A")
                {

                    if (!string.IsNullOrEmpty(lblSeatSelectList.Text))
                    {
                        string[] arr = lblSeatSelectList.Text.Split(',');
                        string no = "";
                        for (int j = 0; j < arr.Length; j++)
                        {
                            no = arr[j];
                            if (no.Contains(collections[i].SeatNo))
                            {
                                lbl.Image = global::BTS.UI.Properties.Resources.sbs4;
                                lbl.Name = "lbl" + Convert.ToString(i);


                                break;
                            }
                            else
                            {
                                lbl.Image = global::BTS.UI.Properties.Resources.sa1;
                                lbl.Name = "Xlbl" + Convert.ToString(i);

                            }
                        }

                    }
                    else
                    {
                        lbl.Image = global::BTS.UI.Properties.Resources.sa1;
                        lbl.Name = "Xlbl" + Convert.ToString(i);

                    }
                }
                else
                {
                    if (collections[i].Status == "S")
                    {
                        lbl.Image = global::BTS.UI.Properties.Resources.ss2;
                    }
                    else
                    {
                        lbl.Image = global::BTS.UI.Properties.Resources.sb3;

                    }
                }


                if (i >= backSeat && backSeatNumber != 0)
                {
                    lbl.Location = new System.Drawing.Point(x, (41 * y));
                    lbl.AutoSize = false;
                    lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    lbl.Size = new System.Drawing.Size(40, 40);
                    lbl.Text = Convert.ToString(Convert.ToInt32(i + 1));
                    lbl.Name = "Xlbl" + Convert.ToString(i);
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lbl.TabIndex = 1;
                    lbl.TabStop = false;
                    if (collections[i].Status == "A")
                    {
                        lbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSeat_MouseClick);
                    }
                    pnlSeat.Controls.Add(lbl);
                    y++;

                    if (y == 5)
                    {
                        y = 0;
                        x = x + 45;
                    }
                }
                else
                {
                    if (y == 2 || y == 3 || y == 4)
                    {
                        lbl.Location = new System.Drawing.Point(x, (46 * y) + 25);
                    }
                    else
                    {
                        lbl.Location = new System.Drawing.Point(x, (46 * y));
                    }
                    lbl.AutoSize = false;
                    lbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    lbl.Size = new System.Drawing.Size(40, 40);
                    if (i < 9)
                    {
                        lbl.Text = "0" + Convert.ToString(Convert.ToInt32(i + 1));
                    }
                    else
                    {
                        lbl.Text = Convert.ToString(Convert.ToInt32(i + 1));
                    }

                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lbl.TabIndex = 1;
                    lbl.TabStop = false;
                    if (collections[i].Status == "A")
                    {
                        lbl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblSeat_MouseClick);
                    }
                    pnlSeat.Controls.Add(lbl);
                    y++;

                    if (y == 4)
                    {
                        y = 0;
                        x = x + 45;
                    }
                }
            }
        }

        public string getTextBoxValue()
        {
            return lblSeatSelectList.Text;
        }

        public void GetTripID(string getTripID)
        {
            lblGetTripID.Text = getTripID;
        }

        public void sendSeatNo(string getSeatNo)
        {
            if (getSeatNo == "")
            {
                getSeatNo = null;
            }
            this.lblSeatSelectList.Text = getSeatNo;
        }
        #endregion

        #region Events
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lblSeatSelectList.Text.Trim()))
            {
                Globalizer.ShowMessage(MessageType.Warning, "Select Seat No");
            }
            else
            {
                this.Close();
            }            
        }

        private void lblSeat_MouseClick(object sender, MouseEventArgs e)
        {
            if (((Label)(sender)).Name.Contains("X"))
            {
                ((Label)(sender)).Image = global::BTS.UI.Properties.Resources.sbs4;
                string i = ((Label)(sender)).Name.Replace("X", "");
                ((Label)(sender)).Name = i;

                if (lblSeatSelectList.Text.Contains(((Label)(sender)).Text))
                {

                }
                else
                {
                    if (lblSeatSelectList.Text == string.Empty)
                    {
                        lblSeatSelectList.Text = ((Label)(sender)).Text;

                    }
                    else
                    {
                        lblSeatSelectList.Text += "," + ((Label)(sender)).Text;
                    }
                }
            }
            else
            {
                ((Label)(sender)).Image = global::BTS.UI.Properties.Resources.sa1;
                ((Label)(sender)).Name = "X" + ((Label)(sender)).Name;

                if (lblSeatSelectList.Text.Contains(((Label)(sender)).Text + ","))
                {
                    lblSeatSelectList.Text = lblSeatSelectList.Text.Replace(((Label)(sender)).Text + ",", "");
                }
                else
                {
                    if (lblSeatSelectList.Text.Contains(","))
                    {
                        lblSeatSelectList.Text = lblSeatSelectList.Text.Replace("," + ((Label)(sender)).Text, "");
                    }
                    else
                    {
                        lblSeatSelectList.Text = lblSeatSelectList.Text.Replace(((Label)(sender)).Text, "");
                    }
                }
            }
        }       

        private void SeatDisplay_Load(object sender, EventArgs e)
        {
            this.BindSeat();
            //BTS.UI.Grid.Sale sale = new BTS.UI.Grid.Sale();
            //BTS.UI.Grid.Booking booking=new BTS.UI.Grid.Booking();
            //if (sale.enable == false || booking.enable == false)
            //{
            //    this.btnClose.Visible = true;
            //}
            if (Globalizer.enable == true)
            {
                this.btnClose.Visible = false;
                Globalizer.enable = false;
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(lblSeatSelectList.Text))
            //{ this.Close(); }
            //else
            //{
                this.lblSeatSelectList.Text = string.Empty;
                this.Close();
           // }
        }
        #endregion        
    }
}