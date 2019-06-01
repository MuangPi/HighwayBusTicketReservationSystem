namespace BTS.UI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingCancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tripConfirmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.postingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(72, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 72);
            this.panel1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEntryToolStripMenuItem,
            this.tripEntryToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.userToolStripMenuItem,
            this.processToolStripMenuItem,
            this.reportToolStripMenuItem1,
            this.postingToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataEntryToolStripMenuItem
            // 
            this.dataEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busTypeToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.timeScheduleToolStripMenuItem});
            this.dataEntryToolStripMenuItem.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dataEntryToolStripMenuItem.Image")));
            this.dataEntryToolStripMenuItem.Name = "dataEntryToolStripMenuItem";
            this.dataEntryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.dataEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 54);
            this.dataEntryToolStripMenuItem.Text = "Data Entry";
            // 
            // busTypeToolStripMenuItem
            // 
            this.busTypeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("busTypeToolStripMenuItem.Image")));
            this.busTypeToolStripMenuItem.Name = "busTypeToolStripMenuItem";
            this.busTypeToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.busTypeToolStripMenuItem.Text = "Bus Type";
            this.busTypeToolStripMenuItem.Click += new System.EventHandler(this.busTypeToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driverToolStripMenuItem.Image")));
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.driverToolStripMenuItem.Text = "Driver";
            this.driverToolStripMenuItem.Click += new System.EventHandler(this.driverToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locationToolStripMenuItem.Image")));
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // timeScheduleToolStripMenuItem
            // 
            this.timeScheduleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("timeScheduleToolStripMenuItem.Image")));
            this.timeScheduleToolStripMenuItem.Name = "timeScheduleToolStripMenuItem";
            this.timeScheduleToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.timeScheduleToolStripMenuItem.Text = "Time Schedule";
            this.timeScheduleToolStripMenuItem.Click += new System.EventHandler(this.timeScheduleToolStripMenuItem_Click);
            // 
            // tripEntryToolStripMenuItem
            // 
            this.tripEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busToolStripMenuItem,
            this.routeToolStripMenuItem});
            this.tripEntryToolStripMenuItem.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripEntryToolStripMenuItem.Image = global::BTS.UI.Properties.Resources.MenuTripEntry;
            this.tripEntryToolStripMenuItem.Name = "tripEntryToolStripMenuItem";
            this.tripEntryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.tripEntryToolStripMenuItem.Size = new System.Drawing.Size(127, 54);
            this.tripEntryToolStripMenuItem.Text = "Setup";
            // 
            // busToolStripMenuItem
            // 
            this.busToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("busToolStripMenuItem.Image")));
            this.busToolStripMenuItem.Name = "busToolStripMenuItem";
            this.busToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.busToolStripMenuItem.Text = "Bus";
            this.busToolStripMenuItem.Click += new System.EventHandler(this.busToolStripMenuItem_Click);
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("routeToolStripMenuItem.Image")));
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.routeToolStripMenuItem.Text = "Route";
            this.routeToolStripMenuItem.Click += new System.EventHandler(this.routeToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.salToolStripMenuItem,
            this.bookingEntryToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Image = global::BTS.UI.Properties.Resources.MenuTransaction;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 20, 0);
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(190, 54);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 30);
            this.toolStripMenuItem1.Text = "Trip Plan";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // salToolStripMenuItem
            // 
            this.salToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salToolStripMenuItem.Image")));
            this.salToolStripMenuItem.Name = "salToolStripMenuItem";
            this.salToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.salToolStripMenuItem.Text = "Sale Entry";
            this.salToolStripMenuItem.Click += new System.EventHandler(this.salToolStripMenuItem_Click);
            // 
            // bookingEntryToolStripMenuItem
            // 
            this.bookingEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingEntryToolStripMenuItem.Image")));
            this.bookingEntryToolStripMenuItem.Name = "bookingEntryToolStripMenuItem";
            this.bookingEntryToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.bookingEntryToolStripMenuItem.Text = "Booking Entry";
            this.bookingEntryToolStripMenuItem.Click += new System.EventHandler(this.bookingEntryToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLevelToolStripMenuItem,
            this.userEntryToolStripMenuItem});
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userToolStripMenuItem.Image = global::BTS.UI.Properties.Resources.MenuUserEntry;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 20);
            this.userToolStripMenuItem.Size = new System.Drawing.Size(163, 54);
            this.userToolStripMenuItem.Text = "User Entry";
            // 
            // userLevelToolStripMenuItem
            // 
            this.userLevelToolStripMenuItem.Image = global::BTS.UI.Properties.Resources.MenuUser;
            this.userLevelToolStripMenuItem.Name = "userLevelToolStripMenuItem";
            this.userLevelToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.userLevelToolStripMenuItem.Text = "User Level";
            this.userLevelToolStripMenuItem.Click += new System.EventHandler(this.userLevelToolStripMenuItem_Click);
            // 
            // userEntryToolStripMenuItem
            // 
            this.userEntryToolStripMenuItem.Image = global::BTS.UI.Properties.Resources.MenuUser2;
            this.userEntryToolStripMenuItem.Name = "userEntryToolStripMenuItem";
            this.userEntryToolStripMenuItem.Size = new System.Drawing.Size(260, 30);
            this.userEntryToolStripMenuItem.Text = "User Registration";
            this.userEntryToolStripMenuItem.Click += new System.EventHandler(this.userEntryToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingCancelToolStripMenuItem,
            this.tripConfirmToolStripMenuItem});
            this.processToolStripMenuItem.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processToolStripMenuItem.Image = global::BTS.UI.Properties.Resources.MenuProcesss;
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(135, 54);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // bookingCancelToolStripMenuItem
            // 
            this.bookingCancelToolStripMenuItem.Image = global::BTS.UI.Properties.Resources.MenuBookingCancel;
            this.bookingCancelToolStripMenuItem.Name = "bookingCancelToolStripMenuItem";
            this.bookingCancelToolStripMenuItem.Size = new System.Drawing.Size(256, 36);
            this.bookingCancelToolStripMenuItem.Text = "Booking Cancel";
            this.bookingCancelToolStripMenuItem.Click += new System.EventHandler(this.bookingCancelToolStripMenuItem_Click);
            // 
            // tripConfirmToolStripMenuItem
            // 
            this.tripConfirmToolStripMenuItem.Name = "tripConfirmToolStripMenuItem";
            this.tripConfirmToolStripMenuItem.Size = new System.Drawing.Size(256, 36);
            this.tripConfirmToolStripMenuItem.Text = "Trip Confirm";
            this.tripConfirmToolStripMenuItem.Click += new System.EventHandler(this.tripConfirmToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(92, 54);
            this.reportToolStripMenuItem1.Text = "Report";
            this.reportToolStripMenuItem1.Click += new System.EventHandler(this.reportToolStripMenuItem1_Click);
            // 
            // postingToolStripMenuItem
            // 
            this.postingToolStripMenuItem.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postingToolStripMenuItem.Name = "postingToolStripMenuItem";
            this.postingToolStripMenuItem.Size = new System.Drawing.Size(102, 54);
            this.postingToolStripMenuItem.Text = "Posting";
            this.postingToolStripMenuItem.Click += new System.EventHandler(this.postingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Font = new System.Drawing.Font("Harrington", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(63, 54);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Harrington", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(971, 64);
            this.label1.TabIndex = 24;
            this.label1.Text = "Highway Bus Ticket Reservation System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BTS.UI.Properties.Resources.b;
            this.pictureBox1.Location = new System.Drawing.Point(72, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1056, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1127, 745);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tripEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem postingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tripConfirmToolStripMenuItem;
    }
}