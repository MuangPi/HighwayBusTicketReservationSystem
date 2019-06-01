namespace BTS.UI.Reports
{
    partial class TripReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripReport));
            this.tcTrip = new System.Windows.Forms.TabControl();
            this.TripCode = new System.Windows.Forms.TabPage();
            this.btnCloseTripCode = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPreviewTripCode = new System.Windows.Forms.Button();
            this.cboToTripCode = new System.Windows.Forms.ComboBox();
            this.cboFromTripCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TripDate = new System.Windows.Forms.TabPage();
            this.btnCloseTripDate = new System.Windows.Forms.Button();
            this.btnPreviewTripDate = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RouteName = new System.Windows.Forms.TabPage();
            this.btnCloseRouteName = new System.Windows.Forms.Button();
            this.btnPreviewRouteName = new System.Windows.Forms.Button();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BusNo = new System.Windows.Forms.TabPage();
            this.btnCloseBusNo = new System.Windows.Forms.Button();
            this.btnPreviewBusNo = new System.Windows.Forms.Button();
            this.cboBusNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DriverName = new System.Windows.Forms.TabPage();
            this.btnCloseDriverName = new System.Windows.Forms.Button();
            this.btnPreviewDriverName = new System.Windows.Forms.Button();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tcTrip.SuspendLayout();
            this.TripCode.SuspendLayout();
            this.TripDate.SuspendLayout();
            this.RouteName.SuspendLayout();
            this.BusNo.SuspendLayout();
            this.DriverName.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcTrip
            // 
            this.tcTrip.Controls.Add(this.TripCode);
            this.tcTrip.Controls.Add(this.TripDate);
            this.tcTrip.Controls.Add(this.RouteName);
            this.tcTrip.Controls.Add(this.BusNo);
            this.tcTrip.Controls.Add(this.DriverName);
            this.tcTrip.Location = new System.Drawing.Point(30, 27);
            this.tcTrip.Name = "tcTrip";
            this.tcTrip.SelectedIndex = 0;
            this.tcTrip.Size = new System.Drawing.Size(575, 215);
            this.tcTrip.TabIndex = 0;
            // 
            // TripCode
            // 
            this.TripCode.Controls.Add(this.btnCloseTripCode);
            this.TripCode.Controls.Add(this.btnPreviewTripCode);
            this.TripCode.Controls.Add(this.cboToTripCode);
            this.TripCode.Controls.Add(this.cboFromTripCode);
            this.TripCode.Controls.Add(this.label2);
            this.TripCode.Controls.Add(this.label1);
            this.TripCode.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TripCode.Location = new System.Drawing.Point(4, 22);
            this.TripCode.Name = "TripCode";
            this.TripCode.Padding = new System.Windows.Forms.Padding(3);
            this.TripCode.Size = new System.Drawing.Size(567, 189);
            this.TripCode.TabIndex = 0;
            this.TripCode.Text = "TripCode";
            this.TripCode.UseVisualStyleBackColor = true;
            // 
            // btnCloseTripCode
            // 
            this.btnCloseTripCode.BackColor = System.Drawing.Color.White;
            this.btnCloseTripCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseTripCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseTripCode.ImageIndex = 1;
            this.btnCloseTripCode.ImageList = this.imageList1;
            this.btnCloseTripCode.Location = new System.Drawing.Point(372, 121);
            this.btnCloseTripCode.Name = "btnCloseTripCode";
            this.btnCloseTripCode.Size = new System.Drawing.Size(90, 36);
            this.btnCloseTripCode.TabIndex = 3;
            this.btnCloseTripCode.Text = "&Close";
            this.btnCloseTripCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseTripCode.UseVisualStyleBackColor = false;
            this.btnCloseTripCode.Click += new System.EventHandler(this.btnCloseTripCode_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Document-Preview-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-application-exit-icon.png");
            // 
            // btnPreviewTripCode
            // 
            this.btnPreviewTripCode.BackColor = System.Drawing.Color.White;
            this.btnPreviewTripCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewTripCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviewTripCode.ImageIndex = 0;
            this.btnPreviewTripCode.ImageList = this.imageList1;
            this.btnPreviewTripCode.Location = new System.Drawing.Point(276, 121);
            this.btnPreviewTripCode.Name = "btnPreviewTripCode";
            this.btnPreviewTripCode.Size = new System.Drawing.Size(90, 36);
            this.btnPreviewTripCode.TabIndex = 2;
            this.btnPreviewTripCode.Text = "&Preview";
            this.btnPreviewTripCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviewTripCode.UseVisualStyleBackColor = false;
            this.btnPreviewTripCode.Click += new System.EventHandler(this.btnPreviewTripCode_Click);
            // 
            // cboToTripCode
            // 
            this.cboToTripCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToTripCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboToTripCode.FormattingEnabled = true;
            this.cboToTripCode.Location = new System.Drawing.Point(276, 70);
            this.cboToTripCode.Name = "cboToTripCode";
            this.cboToTripCode.Size = new System.Drawing.Size(147, 21);
            this.cboToTripCode.TabIndex = 1;
            this.cboToTripCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // cboFromTripCode
            // 
            this.cboFromTripCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFromTripCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFromTripCode.FormattingEnabled = true;
            this.cboFromTripCode.Location = new System.Drawing.Point(276, 26);
            this.cboFromTripCode.Name = "cboFromTripCode";
            this.cboFromTripCode.Size = new System.Drawing.Size(147, 21);
            this.cboFromTripCode.TabIndex = 0;
            this.cboFromTripCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Trip Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FromTrip Code :";
            // 
            // TripDate
            // 
            this.TripDate.Controls.Add(this.btnCloseTripDate);
            this.TripDate.Controls.Add(this.btnPreviewTripDate);
            this.TripDate.Controls.Add(this.dtpToDate);
            this.TripDate.Controls.Add(this.dtpFromDate);
            this.TripDate.Controls.Add(this.label4);
            this.TripDate.Controls.Add(this.label3);
            this.TripDate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.TripDate.Location = new System.Drawing.Point(4, 22);
            this.TripDate.Name = "TripDate";
            this.TripDate.Padding = new System.Windows.Forms.Padding(3);
            this.TripDate.Size = new System.Drawing.Size(567, 189);
            this.TripDate.TabIndex = 1;
            this.TripDate.Text = "TripDate";
            this.TripDate.UseVisualStyleBackColor = true;
            // 
            // btnCloseTripDate
            // 
            this.btnCloseTripDate.BackColor = System.Drawing.Color.White;
            this.btnCloseTripDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseTripDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseTripDate.ImageIndex = 1;
            this.btnCloseTripDate.ImageList = this.imageList1;
            this.btnCloseTripDate.Location = new System.Drawing.Point(339, 122);
            this.btnCloseTripDate.Name = "btnCloseTripDate";
            this.btnCloseTripDate.Size = new System.Drawing.Size(90, 36);
            this.btnCloseTripDate.TabIndex = 5;
            this.btnCloseTripDate.Text = "&Close";
            this.btnCloseTripDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseTripDate.UseVisualStyleBackColor = false;
            this.btnCloseTripDate.Click += new System.EventHandler(this.btnCloseTripDate_Click);
            // 
            // btnPreviewTripDate
            // 
            this.btnPreviewTripDate.BackColor = System.Drawing.Color.White;
            this.btnPreviewTripDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewTripDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviewTripDate.ImageIndex = 0;
            this.btnPreviewTripDate.ImageList = this.imageList1;
            this.btnPreviewTripDate.Location = new System.Drawing.Point(243, 122);
            this.btnPreviewTripDate.Name = "btnPreviewTripDate";
            this.btnPreviewTripDate.Size = new System.Drawing.Size(90, 36);
            this.btnPreviewTripDate.TabIndex = 4;
            this.btnPreviewTripDate.Text = "&Preview";
            this.btnPreviewTripDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviewTripDate.UseVisualStyleBackColor = false;
            this.btnPreviewTripDate.Click += new System.EventHandler(this.btnPreviewTripDate_Click);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(243, 70);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(151, 20);
            this.dtpToDate.TabIndex = 3;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(243, 29);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(151, 20);
            this.dtpFromDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "To Trip Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "FromTrip Date :";
            // 
            // RouteName
            // 
            this.RouteName.Controls.Add(this.btnCloseRouteName);
            this.RouteName.Controls.Add(this.btnPreviewRouteName);
            this.RouteName.Controls.Add(this.cboRoute);
            this.RouteName.Controls.Add(this.label5);
            this.RouteName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.RouteName.Location = new System.Drawing.Point(4, 22);
            this.RouteName.Name = "RouteName";
            this.RouteName.Size = new System.Drawing.Size(567, 189);
            this.RouteName.TabIndex = 2;
            this.RouteName.Text = "RouteName";
            this.RouteName.UseVisualStyleBackColor = true;
            // 
            // btnCloseRouteName
            // 
            this.btnCloseRouteName.BackColor = System.Drawing.Color.White;
            this.btnCloseRouteName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseRouteName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseRouteName.ImageIndex = 1;
            this.btnCloseRouteName.ImageList = this.imageList1;
            this.btnCloseRouteName.Location = new System.Drawing.Point(363, 95);
            this.btnCloseRouteName.Name = "btnCloseRouteName";
            this.btnCloseRouteName.Size = new System.Drawing.Size(90, 36);
            this.btnCloseRouteName.TabIndex = 3;
            this.btnCloseRouteName.Text = "&Close";
            this.btnCloseRouteName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseRouteName.UseVisualStyleBackColor = false;
            this.btnCloseRouteName.Click += new System.EventHandler(this.btnCloseRouteName_Click);
            // 
            // btnPreviewRouteName
            // 
            this.btnPreviewRouteName.BackColor = System.Drawing.Color.White;
            this.btnPreviewRouteName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewRouteName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviewRouteName.ImageIndex = 0;
            this.btnPreviewRouteName.ImageList = this.imageList1;
            this.btnPreviewRouteName.Location = new System.Drawing.Point(267, 95);
            this.btnPreviewRouteName.Name = "btnPreviewRouteName";
            this.btnPreviewRouteName.Size = new System.Drawing.Size(90, 36);
            this.btnPreviewRouteName.TabIndex = 2;
            this.btnPreviewRouteName.Text = "&Preview";
            this.btnPreviewRouteName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviewRouteName.UseVisualStyleBackColor = false;
            this.btnPreviewRouteName.Click += new System.EventHandler(this.btnPreviewRouteName_Click);
            // 
            // cboRoute
            // 
            this.cboRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(241, 29);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(150, 21);
            this.cboRoute.TabIndex = 1;
            this.cboRoute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Route Name :";
            // 
            // BusNo
            // 
            this.BusNo.Controls.Add(this.btnCloseBusNo);
            this.BusNo.Controls.Add(this.btnPreviewBusNo);
            this.BusNo.Controls.Add(this.cboBusNo);
            this.BusNo.Controls.Add(this.label6);
            this.BusNo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BusNo.Location = new System.Drawing.Point(4, 22);
            this.BusNo.Name = "BusNo";
            this.BusNo.Size = new System.Drawing.Size(567, 189);
            this.BusNo.TabIndex = 3;
            this.BusNo.Text = "BusNo";
            this.BusNo.UseVisualStyleBackColor = true;
            // 
            // btnCloseBusNo
            // 
            this.btnCloseBusNo.BackColor = System.Drawing.Color.White;
            this.btnCloseBusNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseBusNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseBusNo.ImageIndex = 1;
            this.btnCloseBusNo.ImageList = this.imageList1;
            this.btnCloseBusNo.Location = new System.Drawing.Point(357, 87);
            this.btnCloseBusNo.Name = "btnCloseBusNo";
            this.btnCloseBusNo.Size = new System.Drawing.Size(90, 36);
            this.btnCloseBusNo.TabIndex = 3;
            this.btnCloseBusNo.Text = "&Close";
            this.btnCloseBusNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseBusNo.UseVisualStyleBackColor = false;
            this.btnCloseBusNo.Click += new System.EventHandler(this.btnCloseBusNo_Click);
            // 
            // btnPreviewBusNo
            // 
            this.btnPreviewBusNo.BackColor = System.Drawing.Color.White;
            this.btnPreviewBusNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewBusNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviewBusNo.ImageIndex = 0;
            this.btnPreviewBusNo.ImageList = this.imageList1;
            this.btnPreviewBusNo.Location = new System.Drawing.Point(261, 87);
            this.btnPreviewBusNo.Name = "btnPreviewBusNo";
            this.btnPreviewBusNo.Size = new System.Drawing.Size(90, 36);
            this.btnPreviewBusNo.TabIndex = 2;
            this.btnPreviewBusNo.Text = "&Preview";
            this.btnPreviewBusNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviewBusNo.UseVisualStyleBackColor = false;
            this.btnPreviewBusNo.Click += new System.EventHandler(this.btnPreviewBusNo_Click);
            // 
            // cboBusNo
            // 
            this.cboBusNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusNo.FormattingEnabled = true;
            this.cboBusNo.Location = new System.Drawing.Point(252, 43);
            this.cboBusNo.Name = "cboBusNo";
            this.cboBusNo.Size = new System.Drawing.Size(146, 21);
            this.cboBusNo.TabIndex = 1;
            this.cboBusNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "BusNo :";
            // 
            // DriverName
            // 
            this.DriverName.Controls.Add(this.btnCloseDriverName);
            this.DriverName.Controls.Add(this.btnPreviewDriverName);
            this.DriverName.Controls.Add(this.cboDriver);
            this.DriverName.Controls.Add(this.label7);
            this.DriverName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.DriverName.Location = new System.Drawing.Point(4, 22);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(567, 189);
            this.DriverName.TabIndex = 4;
            this.DriverName.Text = "DriverName";
            this.DriverName.UseVisualStyleBackColor = true;
            // 
            // btnCloseDriverName
            // 
            this.btnCloseDriverName.BackColor = System.Drawing.Color.White;
            this.btnCloseDriverName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseDriverName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseDriverName.ImageIndex = 1;
            this.btnCloseDriverName.ImageList = this.imageList1;
            this.btnCloseDriverName.Location = new System.Drawing.Point(368, 79);
            this.btnCloseDriverName.Name = "btnCloseDriverName";
            this.btnCloseDriverName.Size = new System.Drawing.Size(90, 36);
            this.btnCloseDriverName.TabIndex = 3;
            this.btnCloseDriverName.Text = "&Close";
            this.btnCloseDriverName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseDriverName.UseVisualStyleBackColor = false;
            this.btnCloseDriverName.Click += new System.EventHandler(this.btnCloseDriverName_Click);
            // 
            // btnPreviewDriverName
            // 
            this.btnPreviewDriverName.BackColor = System.Drawing.Color.White;
            this.btnPreviewDriverName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewDriverName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviewDriverName.ImageIndex = 0;
            this.btnPreviewDriverName.ImageList = this.imageList1;
            this.btnPreviewDriverName.Location = new System.Drawing.Point(268, 79);
            this.btnPreviewDriverName.Name = "btnPreviewDriverName";
            this.btnPreviewDriverName.Size = new System.Drawing.Size(90, 36);
            this.btnPreviewDriverName.TabIndex = 2;
            this.btnPreviewDriverName.Text = "&Preview";
            this.btnPreviewDriverName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreviewDriverName.UseVisualStyleBackColor = false;
            this.btnPreviewDriverName.Click += new System.EventHandler(this.btnPreviewDriverName_Click);
            // 
            // cboDriver
            // 
            this.cboDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.Location = new System.Drawing.Point(262, 28);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.Size = new System.Drawing.Size(151, 21);
            this.cboDriver.TabIndex = 1;
            this.cboDriver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Driver Name :";
            // 
            // TripReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(633, 263);
            this.ControlBox = false;
            this.Controls.Add(this.tcTrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TripReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Report";
            this.Load += new System.EventHandler(this.TripReport_Load);
            this.tcTrip.ResumeLayout(false);
            this.TripCode.ResumeLayout(false);
            this.TripCode.PerformLayout();
            this.TripDate.ResumeLayout(false);
            this.TripDate.PerformLayout();
            this.RouteName.ResumeLayout(false);
            this.RouteName.PerformLayout();
            this.BusNo.ResumeLayout(false);
            this.BusNo.PerformLayout();
            this.DriverName.ResumeLayout(false);
            this.DriverName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTrip;
        private System.Windows.Forms.TabPage TripCode;
        private System.Windows.Forms.TabPage TripDate;
        private System.Windows.Forms.TabPage RouteName;
        private System.Windows.Forms.TabPage BusNo;
        private System.Windows.Forms.TabPage DriverName;
        private System.Windows.Forms.Button btnCloseTripCode;
        private System.Windows.Forms.Button btnPreviewTripCode;
        private System.Windows.Forms.ComboBox cboToTripCode;
        private System.Windows.Forms.ComboBox cboFromTripCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseTripDate;
        private System.Windows.Forms.Button btnPreviewTripDate;
        private System.Windows.Forms.Button btnCloseRouteName;
        private System.Windows.Forms.Button btnPreviewRouteName;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCloseBusNo;
        private System.Windows.Forms.Button btnPreviewBusNo;
        private System.Windows.Forms.ComboBox cboBusNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCloseDriverName;
        private System.Windows.Forms.Button btnPreviewDriverName;
        private System.Windows.Forms.ComboBox cboDriver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ImageList imageList1;
    }
}