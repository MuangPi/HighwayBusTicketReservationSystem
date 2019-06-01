namespace BTS.UI
{
    partial class ReportAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAll));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoYearly = new System.Windows.Forms.RadioButton();
            this.rdoMonthly = new System.Windows.Forms.RadioButton();
            this.rdoDaily = new System.Windows.Forms.RadioButton();
            this.rdoSaleDate = new System.Windows.Forms.RadioButton();
            this.rdoSaleNo = new System.Windows.Forms.RadioButton();
            this.rdoOneTrip = new System.Windows.Forms.RadioButton();
            this.rdoTripCode = new System.Windows.Forms.RadioButton();
            this.rdoTrip = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoYearly);
            this.groupBox1.Controls.Add(this.rdoMonthly);
            this.groupBox1.Controls.Add(this.rdoDaily);
            this.groupBox1.Controls.Add(this.rdoSaleDate);
            this.groupBox1.Controls.Add(this.rdoSaleNo);
            this.groupBox1.Controls.Add(this.rdoOneTrip);
            this.groupBox1.Controls.Add(this.rdoTripCode);
            this.groupBox1.Controls.Add(this.rdoTrip);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(52, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports :";
            // 
            // rdoYearly
            // 
            this.rdoYearly.AutoSize = true;
            this.rdoYearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoYearly.Location = new System.Drawing.Point(259, 161);
            this.rdoYearly.Name = "rdoYearly";
            this.rdoYearly.Size = new System.Drawing.Size(102, 17);
            this.rdoYearly.TabIndex = 7;
            this.rdoYearly.Text = "Yearly Report";
            this.rdoYearly.UseVisualStyleBackColor = true;
            // 
            // rdoMonthly
            // 
            this.rdoMonthly.AutoSize = true;
            this.rdoMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMonthly.Location = new System.Drawing.Point(259, 117);
            this.rdoMonthly.Name = "rdoMonthly";
            this.rdoMonthly.Size = new System.Drawing.Size(111, 17);
            this.rdoMonthly.TabIndex = 6;
            this.rdoMonthly.Text = "Monthly Report";
            this.rdoMonthly.UseVisualStyleBackColor = true;
            // 
            // rdoDaily
            // 
            this.rdoDaily.AutoSize = true;
            this.rdoDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDaily.Location = new System.Drawing.Point(259, 77);
            this.rdoDaily.Name = "rdoDaily";
            this.rdoDaily.Size = new System.Drawing.Size(95, 17);
            this.rdoDaily.TabIndex = 5;
            this.rdoDaily.Text = "Daily Report";
            this.rdoDaily.UseVisualStyleBackColor = true;
            // 
            // rdoSaleDate
            // 
            this.rdoSaleDate.AutoSize = true;
            this.rdoSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSaleDate.Location = new System.Drawing.Point(259, 32);
            this.rdoSaleDate.Name = "rdoSaleDate";
            this.rdoSaleDate.Size = new System.Drawing.Size(141, 17);
            this.rdoSaleDate.TabIndex = 4;
            this.rdoSaleDate.Text = "Report By Sale Date";
            this.rdoSaleDate.UseVisualStyleBackColor = true;
            // 
            // rdoSaleNo
            // 
            this.rdoSaleNo.AutoSize = true;
            this.rdoSaleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSaleNo.Location = new System.Drawing.Point(50, 161);
            this.rdoSaleNo.Name = "rdoSaleNo";
            this.rdoSaleNo.Size = new System.Drawing.Size(130, 17);
            this.rdoSaleNo.TabIndex = 3;
            this.rdoSaleNo.Text = "Report By Sale No";
            this.rdoSaleNo.UseVisualStyleBackColor = true;
            // 
            // rdoOneTrip
            // 
            this.rdoOneTrip.AutoSize = true;
            this.rdoOneTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOneTrip.Location = new System.Drawing.Point(50, 117);
            this.rdoOneTrip.Name = "rdoOneTrip";
            this.rdoOneTrip.Size = new System.Drawing.Size(134, 17);
            this.rdoOneTrip.TabIndex = 2;
            this.rdoOneTrip.Text = "Report By One Trip";
            this.rdoOneTrip.UseVisualStyleBackColor = true;
            // 
            // rdoTripCode
            // 
            this.rdoTripCode.AutoSize = true;
            this.rdoTripCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTripCode.Location = new System.Drawing.Point(50, 77);
            this.rdoTripCode.Name = "rdoTripCode";
            this.rdoTripCode.Size = new System.Drawing.Size(140, 17);
            this.rdoTripCode.TabIndex = 1;
            this.rdoTripCode.Text = "Report By Trip Code";
            this.rdoTripCode.UseVisualStyleBackColor = true;
            // 
            // rdoTrip
            // 
            this.rdoTrip.AutoSize = true;
            this.rdoTrip.Checked = true;
            this.rdoTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTrip.Location = new System.Drawing.Point(50, 32);
            this.rdoTrip.Name = "rdoTrip";
            this.rdoTrip.Size = new System.Drawing.Size(89, 17);
            this.rdoTrip.TabIndex = 0;
            this.rdoTrip.TabStop = true;
            this.rdoTrip.Text = "Trip Report";
            this.rdoTrip.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Document-Preview-icon.png");
            this.imageList1.Images.SetKeyName(1, "Exit.png");
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 1;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(370, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.ImageIndex = 0;
            this.btnShow.ImageList = this.imageList1;
            this.btnShow.Location = new System.Drawing.Point(262, 326);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(93, 35);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "&Show";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Harrington", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(45, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 74);
            this.label5.TabIndex = 144;
            this.label5.Text = "Highway Bus Ticket Reservation System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(522, 384);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoYearly;
        private System.Windows.Forms.RadioButton rdoMonthly;
        private System.Windows.Forms.RadioButton rdoDaily;
        private System.Windows.Forms.RadioButton rdoSaleDate;
        private System.Windows.Forms.RadioButton rdoSaleNo;
        private System.Windows.Forms.RadioButton rdoOneTrip;
        private System.Windows.Forms.RadioButton rdoTripCode;
        private System.Windows.Forms.RadioButton rdoTrip;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
    }
}