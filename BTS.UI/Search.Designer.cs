namespace BTS.UI
{
    partial class Search
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.tcSearch = new System.Windows.Forms.TabControl();
            this.tpSale = new System.Windows.Forms.TabPage();
            this.btnSaleCancel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.dgvSaleSearch = new System.Windows.Forms.DataGridView();
            this.SaleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRCNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booking = new System.Windows.Forms.TabPage();
            this.btnBookingCancel = new System.Windows.Forms.Button();
            this.dgvBookingSearch = new System.Windows.Forms.DataGridView();
            this.BookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trip1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TripDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRCNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tcSearch.SuspendLayout();
            this.tpSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleSearch)).BeginInit();
            this.Booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSearch
            // 
            this.tcSearch.Controls.Add(this.tpSale);
            this.tcSearch.Controls.Add(this.Booking);
            this.tcSearch.Location = new System.Drawing.Point(30, 131);
            this.tcSearch.Name = "tcSearch";
            this.tcSearch.SelectedIndex = 0;
            this.tcSearch.Size = new System.Drawing.Size(1181, 321);
            this.tcSearch.TabIndex = 0;
            // 
            // tpSale
            // 
            this.tpSale.Controls.Add(this.btnSaleCancel);
            this.tpSale.Controls.Add(this.txtCustomerName);
            this.tpSale.Controls.Add(this.lblCustomerName);
            this.tpSale.Controls.Add(this.dgvSaleSearch);
            this.tpSale.Location = new System.Drawing.Point(4, 22);
            this.tpSale.Name = "tpSale";
            this.tpSale.Padding = new System.Windows.Forms.Padding(3);
            this.tpSale.Size = new System.Drawing.Size(1173, 295);
            this.tpSale.TabIndex = 0;
            this.tpSale.Text = "Sale";
            this.tpSale.UseVisualStyleBackColor = true;
            // 
            // btnSaleCancel
            // 
            this.btnSaleCancel.BackColor = System.Drawing.Color.White;
            this.btnSaleCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaleCancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnSaleCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleCancel.ImageIndex = 0;
            this.btnSaleCancel.ImageList = this.imageList1;
            this.btnSaleCancel.Location = new System.Drawing.Point(1049, 240);
            this.btnSaleCancel.Name = "btnSaleCancel";
            this.btnSaleCancel.Size = new System.Drawing.Size(91, 35);
            this.btnSaleCancel.TabIndex = 1;
            this.btnSaleCancel.Text = "&Cancel";
            this.btnSaleCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaleCancel.UseVisualStyleBackColor = false;
            this.btnSaleCancel.Click += new System.EventHandler(this.btnSaleCancel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Actions-dialog-cancel-icon.png");
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(174, 19);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(153, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCustomerName.Location = new System.Drawing.Point(47, 22);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name :";
            // 
            // dgvSaleSearch
            // 
            this.dgvSaleSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleID,
            this.SaleNo,
            this.SaleDate,
            this.TripID,
            this.RouteID,
            this.Trip,
            this.TripDate,
            this.TimeID,
            this.Time,
            this.BusNo,
            this.SeatNo,
            this.Quantity,
            this.CustomerName,
            this.NRCNo});
            this.dgvSaleSearch.Location = new System.Drawing.Point(27, 72);
            this.dgvSaleSearch.Name = "dgvSaleSearch";
            this.dgvSaleSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleSearch.Size = new System.Drawing.Size(1113, 150);
            this.dgvSaleSearch.TabIndex = 0;
            this.dgvSaleSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleSearch_CellContentDoubleClick);
            // 
            // SaleID
            // 
            this.SaleID.DataPropertyName = "SaleID";
            this.SaleID.HeaderText = "";
            this.SaleID.Name = "SaleID";
            this.SaleID.ReadOnly = true;
            this.SaleID.Visible = false;
            // 
            // SaleNo
            // 
            this.SaleNo.DataPropertyName = "SaleNo";
            this.SaleNo.HeaderText = "Sale No";
            this.SaleNo.Name = "SaleNo";
            this.SaleNo.ReadOnly = true;
            // 
            // SaleDate
            // 
            this.SaleDate.DataPropertyName = "SaleDate";
            this.SaleDate.HeaderText = "Sale Date";
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.ReadOnly = true;
            // 
            // TripID
            // 
            this.TripID.DataPropertyName = "TripID";
            this.TripID.HeaderText = "";
            this.TripID.Name = "TripID";
            this.TripID.ReadOnly = true;
            this.TripID.Visible = false;
            // 
            // RouteID
            // 
            this.RouteID.DataPropertyName = "RouteID";
            this.RouteID.HeaderText = "";
            this.RouteID.Name = "RouteID";
            this.RouteID.ReadOnly = true;
            this.RouteID.Visible = false;
            // 
            // Trip
            // 
            this.Trip.DataPropertyName = "RouteName";
            this.Trip.HeaderText = "Trip";
            this.Trip.Name = "Trip";
            this.Trip.ReadOnly = true;
            // 
            // TripDate
            // 
            this.TripDate.DataPropertyName = "Date";
            this.TripDate.HeaderText = "Trip Date";
            this.TripDate.Name = "TripDate";
            this.TripDate.ReadOnly = true;
            // 
            // TimeID
            // 
            this.TimeID.DataPropertyName = "TimeID";
            this.TimeID.HeaderText = "";
            this.TimeID.Name = "TimeID";
            this.TimeID.ReadOnly = true;
            this.TimeID.Visible = false;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // BusNo
            // 
            this.BusNo.DataPropertyName = "BusNo";
            this.BusNo.HeaderText = "Bus No";
            this.BusNo.Name = "BusNo";
            this.BusNo.ReadOnly = true;
            // 
            // SeatNo
            // 
            this.SeatNo.DataPropertyName = "SeatNo";
            this.SeatNo.HeaderText = "Seat No";
            this.SeatNo.Name = "SeatNo";
            this.SeatNo.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // NRCNo
            // 
            this.NRCNo.DataPropertyName = "NRCNo";
            this.NRCNo.HeaderText = "NRC No";
            this.NRCNo.Name = "NRCNo";
            this.NRCNo.ReadOnly = true;
            this.NRCNo.Width = 120;
            // 
            // Booking
            // 
            this.Booking.Controls.Add(this.btnBookingCancel);
            this.Booking.Controls.Add(this.dgvBookingSearch);
            this.Booking.Controls.Add(this.txtCustomer);
            this.Booking.Controls.Add(this.lblCustomer);
            this.Booking.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.Booking.Location = new System.Drawing.Point(4, 22);
            this.Booking.Name = "Booking";
            this.Booking.Padding = new System.Windows.Forms.Padding(3);
            this.Booking.Size = new System.Drawing.Size(1173, 295);
            this.Booking.TabIndex = 1;
            this.Booking.Text = "Booking";
            this.Booking.UseVisualStyleBackColor = true;
            // 
            // btnBookingCancel
            // 
            this.btnBookingCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookingCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookingCancel.ImageIndex = 0;
            this.btnBookingCancel.ImageList = this.imageList1;
            this.btnBookingCancel.Location = new System.Drawing.Point(1052, 241);
            this.btnBookingCancel.Name = "btnBookingCancel";
            this.btnBookingCancel.Size = new System.Drawing.Size(91, 35);
            this.btnBookingCancel.TabIndex = 3;
            this.btnBookingCancel.Text = "&Cancel";
            this.btnBookingCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookingCancel.UseVisualStyleBackColor = true;
            this.btnBookingCancel.Click += new System.EventHandler(this.btnBookingCancel_Click);
            // 
            // dgvBookingSearch
            // 
            this.dgvBookingSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingID,
            this.BookingDetailID,
            this.BookingNo,
            this.BookingDate,
            this.TripID1,
            this.RouteID1,
            this.Trip1,
            this.TripDate1,
            this.TimeID1,
            this.Time1,
            this.BusNo1,
            this.SeatNo1,
            this.Quantity1,
            this.CustomerName1,
            this.NRCNo1});
            this.dgvBookingSearch.Location = new System.Drawing.Point(29, 70);
            this.dgvBookingSearch.Name = "dgvBookingSearch";
            this.dgvBookingSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingSearch.Size = new System.Drawing.Size(1114, 165);
            this.dgvBookingSearch.TabIndex = 2;
            this.dgvBookingSearch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookingSearch_CellContentDoubleClick);
            // 
            // BookingID
            // 
            this.BookingID.DataPropertyName = "BookingID";
            this.BookingID.HeaderText = "";
            this.BookingID.Name = "BookingID";
            this.BookingID.ReadOnly = true;
            this.BookingID.Visible = false;
            // 
            // BookingDetailID
            // 
            this.BookingDetailID.DataPropertyName = "BookingDetailID";
            this.BookingDetailID.HeaderText = "";
            this.BookingDetailID.Name = "BookingDetailID";
            this.BookingDetailID.ReadOnly = true;
            this.BookingDetailID.Visible = false;
            // 
            // BookingNo
            // 
            this.BookingNo.DataPropertyName = "BookingNo";
            this.BookingNo.HeaderText = "Booking No";
            this.BookingNo.Name = "BookingNo";
            this.BookingNo.ReadOnly = true;
            // 
            // BookingDate
            // 
            this.BookingDate.DataPropertyName = "BookingDate";
            this.BookingDate.HeaderText = "Booking Date";
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.ReadOnly = true;
            // 
            // TripID1
            // 
            this.TripID1.DataPropertyName = "TripID";
            this.TripID1.HeaderText = "";
            this.TripID1.Name = "TripID1";
            this.TripID1.ReadOnly = true;
            this.TripID1.Visible = false;
            // 
            // RouteID1
            // 
            this.RouteID1.DataPropertyName = "RouteID";
            this.RouteID1.HeaderText = "";
            this.RouteID1.Name = "RouteID1";
            this.RouteID1.ReadOnly = true;
            this.RouteID1.Visible = false;
            // 
            // Trip1
            // 
            this.Trip1.DataPropertyName = "RouteName";
            this.Trip1.HeaderText = "Trip";
            this.Trip1.Name = "Trip1";
            this.Trip1.ReadOnly = true;
            // 
            // TripDate1
            // 
            this.TripDate1.DataPropertyName = "Date";
            this.TripDate1.HeaderText = "Trip Date";
            this.TripDate1.Name = "TripDate1";
            this.TripDate1.ReadOnly = true;
            // 
            // TimeID1
            // 
            this.TimeID1.DataPropertyName = "TimeID";
            this.TimeID1.HeaderText = "";
            this.TimeID1.Name = "TimeID1";
            this.TimeID1.ReadOnly = true;
            this.TimeID1.Visible = false;
            // 
            // Time1
            // 
            this.Time1.DataPropertyName = "Time";
            this.Time1.HeaderText = "Time";
            this.Time1.Name = "Time1";
            this.Time1.ReadOnly = true;
            // 
            // BusNo1
            // 
            this.BusNo1.DataPropertyName = "BusNo";
            this.BusNo1.HeaderText = "Bus No";
            this.BusNo1.Name = "BusNo1";
            this.BusNo1.ReadOnly = true;
            // 
            // SeatNo1
            // 
            this.SeatNo1.DataPropertyName = "SeatNo";
            this.SeatNo1.HeaderText = "Seat No";
            this.SeatNo1.Name = "SeatNo1";
            this.SeatNo1.ReadOnly = true;
            // 
            // Quantity1
            // 
            this.Quantity1.DataPropertyName = "Quantity";
            this.Quantity1.HeaderText = "Quantity";
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.ReadOnly = true;
            // 
            // CustomerName1
            // 
            this.CustomerName1.DataPropertyName = "CustomerName";
            this.CustomerName1.HeaderText = "Customer Name";
            this.CustomerName1.Name = "CustomerName1";
            this.CustomerName1.ReadOnly = true;
            this.CustomerName1.Width = 150;
            // 
            // NRCNo1
            // 
            this.NRCNo1.DataPropertyName = "NRCNo";
            this.NRCNo1.HeaderText = "NRC No";
            this.NRCNo1.Name = "NRCNo1";
            this.NRCNo1.ReadOnly = true;
            this.NRCNo1.Width = 120;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(153, 24);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(165, 20);
            this.txtCustomer.TabIndex = 1;
            this.txtCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomer_KeyDown);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCustomer.Location = new System.Drawing.Point(33, 27);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(103, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Name :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Harrington", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(98, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1109, 74);
            this.label5.TabIndex = 144;
            this.label5.Text = "Highway Bus Ticket Reservation System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1237, 464);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tcSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.tcSearch.ResumeLayout(false);
            this.tpSale.ResumeLayout(false);
            this.tpSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleSearch)).EndInit();
            this.Booking.ResumeLayout(false);
            this.Booking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSearch;
        private System.Windows.Forms.TabPage tpSale;
        private System.Windows.Forms.DataGridView dgvSaleSearch;
        private System.Windows.Forms.TabPage Booking;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnSaleCancel;
        private System.Windows.Forms.Button btnBookingCancel;
        private System.Windows.Forms.DataGridView dgvBookingSearch;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trip;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRCNo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TripDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRCNo1;
        private System.Windows.Forms.Label label5;
    }
}