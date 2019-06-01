namespace BTS.UI.Grid
{
    partial class Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaleNo = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnSeat = new System.Windows.Forms.Button();
            this.txtSeatNo = new System.Windows.Forms.TextBox();
            this.txtAvailableSeats = new System.Windows.Forms.TextBox();
            this.txtBusNo = new System.Windows.Forms.TextBox();
            this.lblSelectedSeat = new System.Windows.Forms.Label();
            this.lblAvailableSeat = new System.Windows.Forms.Label();
            this.lblBusNo = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.cboTrip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtNRCNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTripID = new System.Windows.Forms.Label();
            this.lblDetailID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NewEditExit = new BTS.UI.UserControls.NewEditExitButton();
            this.QuickSearch = new BTS.UI.UserControls.QuickSearch();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(23, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sale No :";
            // 
            // txtSaleNo
            // 
            this.txtSaleNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSaleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleNo.Location = new System.Drawing.Point(93, 209);
            this.txtSaleNo.Name = "txtSaleNo";
            this.txtSaleNo.ReadOnly = true;
            this.txtSaleNo.Size = new System.Drawing.Size(137, 20);
            this.txtSaleNo.TabIndex = 20;
            this.txtSaleNo.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy/M/d";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(487, 156);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(153, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.btnSeat);
            this.groupBox1.Controls.Add(this.txtSeatNo);
            this.groupBox1.Controls.Add(this.txtAvailableSeats);
            this.groupBox1.Controls.Add(this.txtBusNo);
            this.groupBox1.Controls.Add(this.lblSelectedSeat);
            this.groupBox1.Controls.Add(this.lblAvailableSeat);
            this.groupBox1.Controls.Add(this.lblBusNo);
            this.groupBox1.Controls.Add(this.cboTime);
            this.groupBox1.Controls.Add(this.cboDate);
            this.groupBox1.Controls.Add(this.cboTrip);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(15, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 317);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Info :";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAmount.Location = new System.Drawing.Point(333, 200);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(100, 21);
            this.txtAmount.TabIndex = 18;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.Location = new System.Drawing.Point(333, 159);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAmount.Location = new System.Drawing.Point(261, 203);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(57, 13);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblPrice.Location = new System.Drawing.Point(274, 162);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuantity.Location = new System.Drawing.Point(117, 284);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(59, 21);
            this.txtQuantity.TabIndex = 14;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblQuantity.Location = new System.Drawing.Point(47, 287);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(58, 13);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quanity :";
            // 
            // btnSeat
            // 
            this.btnSeat.BackColor = System.Drawing.Color.White;
            this.btnSeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeat.Location = new System.Drawing.Point(223, 237);
            this.btnSeat.Name = "btnSeat";
            this.btnSeat.Size = new System.Drawing.Size(60, 23);
            this.btnSeat.TabIndex = 3;
            this.btnSeat.Text = "Seat";
            this.btnSeat.UseVisualStyleBackColor = false;
            this.btnSeat.Click += new System.EventHandler(this.btnSeat_Click);
            this.btnSeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            // 
            // txtSeatNo
            // 
            this.txtSeatNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSeatNo.Location = new System.Drawing.Point(117, 240);
            this.txtSeatNo.Name = "txtSeatNo";
            this.txtSeatNo.ReadOnly = true;
            this.txtSeatNo.Size = new System.Drawing.Size(100, 21);
            this.txtSeatNo.TabIndex = 3;
            this.txtSeatNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            // 
            // txtAvailableSeats
            // 
            this.txtAvailableSeats.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAvailableSeats.Location = new System.Drawing.Point(117, 200);
            this.txtAvailableSeats.Name = "txtAvailableSeats";
            this.txtAvailableSeats.ReadOnly = true;
            this.txtAvailableSeats.Size = new System.Drawing.Size(88, 21);
            this.txtAvailableSeats.TabIndex = 10;
            // 
            // txtBusNo
            // 
            this.txtBusNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBusNo.Location = new System.Drawing.Point(117, 159);
            this.txtBusNo.Name = "txtBusNo";
            this.txtBusNo.ReadOnly = true;
            this.txtBusNo.Size = new System.Drawing.Size(100, 21);
            this.txtBusNo.TabIndex = 9;
            // 
            // lblSelectedSeat
            // 
            this.lblSelectedSeat.AutoSize = true;
            this.lblSelectedSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSeat.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblSelectedSeat.Location = new System.Drawing.Point(4, 243);
            this.lblSelectedSeat.Name = "lblSelectedSeat";
            this.lblSelectedSeat.Size = new System.Drawing.Size(101, 13);
            this.lblSelectedSeat.TabIndex = 8;
            this.lblSelectedSeat.Text = "Selected Seats :";
            // 
            // lblAvailableSeat
            // 
            this.lblAvailableSeat.AutoSize = true;
            this.lblAvailableSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableSeat.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAvailableSeat.Location = new System.Drawing.Point(8, 203);
            this.lblAvailableSeat.Name = "lblAvailableSeat";
            this.lblAvailableSeat.Size = new System.Drawing.Size(97, 13);
            this.lblAvailableSeat.TabIndex = 7;
            this.lblAvailableSeat.Text = "Avaliable Seat :";
            // 
            // lblBusNo
            // 
            this.lblBusNo.AutoSize = true;
            this.lblBusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusNo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblBusNo.Location = new System.Drawing.Point(49, 162);
            this.lblBusNo.Name = "lblBusNo";
            this.lblBusNo.Size = new System.Drawing.Size(56, 13);
            this.lblBusNo.TabIndex = 6;
            this.lblBusNo.Text = "Bus No :";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "- Select One -"});
            this.cboTime.Location = new System.Drawing.Point(102, 109);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(144, 23);
            this.cboTime.TabIndex = 2;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            this.cboTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControls_KeyPress);
            // 
            // cboDate
            // 
            this.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Items.AddRange(new object[] {
            "- Select One -"});
            this.cboDate.Location = new System.Drawing.Point(102, 70);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(144, 23);
            this.cboDate.TabIndex = 1;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            this.cboDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControls_KeyPress);
            // 
            // cboTrip
            // 
            this.cboTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrip.FormattingEnabled = true;
            this.cboTrip.Items.AddRange(new object[] {
            "0"});
            this.cboTrip.Location = new System.Drawing.Point(102, 29);
            this.cboTrip.Name = "cboTrip";
            this.cboTrip.Size = new System.Drawing.Size(244, 23);
            this.cboTrip.TabIndex = 0;
            this.cboTrip.SelectedIndexChanged += new System.EventHandler(this.cboTrip_SelectedIndexChanged);
            this.cboTrip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboTrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControls_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(44, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(44, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(49, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trip :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCustomerID);
            this.groupBox2.Controls.Add(this.cboGender);
            this.groupBox2.Controls.Add(this.txtPhoneNo);
            this.groupBox2.Controls.Add(this.txtNRCNo);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(487, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 254);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Info :";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(20, 29);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 15);
            this.lblCustomerID.TabIndex = 8;
            this.lblCustomerID.Visible = false;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "- Select One -",
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(109, 102);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(129, 23);
            this.cboGender.TabIndex = 5;
            this.cboGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControls_KeyPress);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(109, 200);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(192, 21);
            this.txtPhoneNo.TabIndex = 7;
            this.txtPhoneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            // 
            // txtNRCNo
            // 
            this.txtNRCNo.Location = new System.Drawing.Point(109, 151);
            this.txtNRCNo.Name = "txtNRCNo";
            this.txtNRCNo.Size = new System.Drawing.Size(192, 21);
            this.txtNRCNo.TabIndex = 6;
            this.txtNRCNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.txtNRCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpperKey_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 21);
            this.txtName.TabIndex = 4;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpperKey_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label14.Location = new System.Drawing.Point(26, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "NRC No :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label13.Location = new System.Drawing.Point(16, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Phone No :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label12.Location = new System.Drawing.Point(33, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Gender :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label11.Location = new System.Drawing.Point(40, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Name :";
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.Location = new System.Drawing.Point(252, 129);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(0, 13);
            this.lblTripID.TabIndex = 7;
            this.lblTripID.Visible = false;
            // 
            // lblDetailID
            // 
            this.lblDetailID.AutoSize = true;
            this.lblDetailID.Location = new System.Drawing.Point(336, 129);
            this.lblDetailID.Name = "lblDetailID";
            this.lblDetailID.Size = new System.Drawing.Size(0, 13);
            this.lblDetailID.TabIndex = 8;
            this.lblDetailID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(384, 129);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Fuccia-Seat-icon.png");
            // 
            // NewEditExit
            // 
            this.NewEditExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewEditExit.BtnCloseText = null;
            this.NewEditExit.BtnEditText = null;
            this.NewEditExit.BtnNewText = null;
            this.NewEditExit.Location = new System.Drawing.Point(487, 525);
            this.NewEditExit.Name = "NewEditExit";
            this.NewEditExit.Size = new System.Drawing.Size(266, 42);
            this.NewEditExit.TabIndex = 8;
            this.NewEditExit.NewClick += new System.EventHandler(this.NewEditExit_NewClick);
            this.NewEditExit.EditClick += new System.EventHandler(this.NewEditExit_EditClick);
            this.NewEditExit.CloseClick += new System.EventHandler(this.NewEditExit_CloseClick);
            // 
            // QuickSearch
            // 
            this.QuickSearch.Location = new System.Drawing.Point(15, 156);
            this.QuickSearch.Name = "QuickSearch";
            this.QuickSearch.Size = new System.Drawing.Size(215, 47);
            this.QuickSearch.TabIndex = 22;
            this.QuickSearch.SearchClick += new BTS.UI.UserControls.Click_Delegate(this.QuickSearch_SearchClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Harrington", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(792, 74);
            this.label5.TabIndex = 144;
            this.label5.Text = "Highway Bus Ticket Reservation System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(833, 583);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblDetailID);
            this.Controls.Add(this.lblTripID);
            this.Controls.Add(this.NewEditExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtSaleNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuickSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Entry";
            this.Load += new System.EventHandler(this.Sale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BTS.UI.UserControls.QuickSearch QuickSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaleNo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeatNo;
        private System.Windows.Forms.TextBox txtAvailableSeats;
        private System.Windows.Forms.TextBox txtBusNo;
        private System.Windows.Forms.Label lblSelectedSeat;
        private System.Windows.Forms.Label lblAvailableSeat;
        private System.Windows.Forms.Label lblBusNo;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.ComboBox cboTrip;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnSeat;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtNRCNo;
        private System.Windows.Forms.TextBox txtName;
        private BTS.UI.UserControls.NewEditExitButton NewEditExit;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.Label lblDetailID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
    }
}