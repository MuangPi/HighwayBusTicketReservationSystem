namespace BTS.UI.Posting
{
    partial class SalePosting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalePosting));
            this.lblFromSaleNo = new System.Windows.Forms.Label();
            this.lblToSaleNo = new System.Windows.Forms.Label();
            this.cboFromSaleInvoiceNo = new System.Windows.Forms.ComboBox();
            this.cboToSaleInvoiceNo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSaleDate = new System.Windows.Forms.RadioButton();
            this.rdoSaleNo = new System.Windows.Forms.RadioButton();
            this.lblFromSaleDate = new System.Windows.Forms.Label();
            this.dtpFromSaleDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblToSaleDate = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFromSaleNo
            // 
            this.lblFromSaleNo.AutoSize = true;
            this.lblFromSaleNo.Location = new System.Drawing.Point(87, 213);
            this.lblFromSaleNo.Name = "lblFromSaleNo";
            this.lblFromSaleNo.Size = new System.Drawing.Size(77, 13);
            this.lblFromSaleNo.TabIndex = 0;
            this.lblFromSaleNo.Text = "From Sale No :";
            // 
            // lblToSaleNo
            // 
            this.lblToSaleNo.AutoSize = true;
            this.lblToSaleNo.Location = new System.Drawing.Point(97, 273);
            this.lblToSaleNo.Name = "lblToSaleNo";
            this.lblToSaleNo.Size = new System.Drawing.Size(67, 13);
            this.lblToSaleNo.TabIndex = 1;
            this.lblToSaleNo.Text = "To Sale No :";
            // 
            // cboFromSaleInvoiceNo
            // 
            this.cboFromSaleInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFromSaleInvoiceNo.FormattingEnabled = true;
            this.cboFromSaleInvoiceNo.Location = new System.Drawing.Point(207, 213);
            this.cboFromSaleInvoiceNo.Name = "cboFromSaleInvoiceNo";
            this.cboFromSaleInvoiceNo.Size = new System.Drawing.Size(121, 21);
            this.cboFromSaleInvoiceNo.TabIndex = 0;
            this.cboFromSaleInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFromSaleDate_KeyDown);
            // 
            // cboToSaleInvoiceNo
            // 
            this.cboToSaleInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboToSaleInvoiceNo.FormattingEnabled = true;
            this.cboToSaleInvoiceNo.Location = new System.Drawing.Point(207, 270);
            this.cboToSaleInvoiceNo.Name = "cboToSaleInvoiceNo";
            this.cboToSaleInvoiceNo.Size = new System.Drawing.Size(121, 21);
            this.cboToSaleInvoiceNo.TabIndex = 1;
            this.cboToSaleInvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFromSaleDate_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSaleDate);
            this.groupBox1.Controls.Add(this.rdoSaleNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(23, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 73);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posting Format :";
            // 
            // rdoSaleDate
            // 
            this.rdoSaleDate.AutoSize = true;
            this.rdoSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSaleDate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rdoSaleDate.Location = new System.Drawing.Point(247, 34);
            this.rdoSaleDate.Name = "rdoSaleDate";
            this.rdoSaleDate.Size = new System.Drawing.Size(99, 17);
            this.rdoSaleDate.TabIndex = 1;
            this.rdoSaleDate.Text = "By Sale Date";
            this.rdoSaleDate.UseVisualStyleBackColor = true;
            this.rdoSaleDate.CheckedChanged += new System.EventHandler(this.rdoSaleDate_CheckedChanged);
            // 
            // rdoSaleNo
            // 
            this.rdoSaleNo.AutoSize = true;
            this.rdoSaleNo.Checked = true;
            this.rdoSaleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSaleNo.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rdoSaleNo.Location = new System.Drawing.Point(67, 34);
            this.rdoSaleNo.Name = "rdoSaleNo";
            this.rdoSaleNo.Size = new System.Drawing.Size(88, 17);
            this.rdoSaleNo.TabIndex = 0;
            this.rdoSaleNo.TabStop = true;
            this.rdoSaleNo.Text = "By Sale No";
            this.rdoSaleNo.UseVisualStyleBackColor = true;
            this.rdoSaleNo.CheckedChanged += new System.EventHandler(this.rdoSaleNo_CheckedChanged);
            // 
            // lblFromSaleDate
            // 
            this.lblFromSaleDate.AutoSize = true;
            this.lblFromSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromSaleDate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblFromSaleDate.Location = new System.Drawing.Point(75, 213);
            this.lblFromSaleDate.Name = "lblFromSaleDate";
            this.lblFromSaleDate.Size = new System.Drawing.Size(102, 13);
            this.lblFromSaleDate.TabIndex = 7;
            this.lblFromSaleDate.Text = "From Sale Date :";
            // 
            // dtpFromSaleDate
            // 
            this.dtpFromSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromSaleDate.Location = new System.Drawing.Point(207, 213);
            this.dtpFromSaleDate.Name = "dtpFromSaleDate";
            this.dtpFromSaleDate.Size = new System.Drawing.Size(121, 20);
            this.dtpFromSaleDate.TabIndex = 0;
            this.dtpFromSaleDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFromSaleDate_KeyDown);
            // 
            // dtpToSaleDate
            // 
            this.dtpToSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToSaleDate.Location = new System.Drawing.Point(207, 270);
            this.dtpToSaleDate.Name = "dtpToSaleDate";
            this.dtpToSaleDate.Size = new System.Drawing.Size(121, 20);
            this.dtpToSaleDate.TabIndex = 1;
            this.dtpToSaleDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFromSaleDate_KeyDown);
            // 
            // lblToSaleDate
            // 
            this.lblToSaleDate.AutoSize = true;
            this.lblToSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToSaleDate.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblToSaleDate.Location = new System.Drawing.Point(87, 273);
            this.lblToSaleDate.Name = "lblToSaleDate";
            this.lblToSaleDate.Size = new System.Drawing.Size(90, 13);
            this.lblToSaleDate.TabIndex = 10;
            this.lblToSaleDate.Text = "To Sale Date :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Trash-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-dialog-cancel-icon.png");
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(296, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.White;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPost.ImageIndex = 0;
            this.btnPost.ImageList = this.imageList1;
            this.btnPost.Location = new System.Drawing.Point(207, 318);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(83, 36);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "&Post";
            this.btnPost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Harrington", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(32, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 74);
            this.label5.TabIndex = 144;
            this.label5.Text = "Highway Bus Ticket Reservation System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SalePosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(453, 380);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblToSaleDate);
            this.Controls.Add(this.dtpToSaleDate);
            this.Controls.Add(this.dtpFromSaleDate);
            this.Controls.Add(this.lblFromSaleDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.cboToSaleInvoiceNo);
            this.Controls.Add(this.cboFromSaleInvoiceNo);
            this.Controls.Add(this.lblToSaleNo);
            this.Controls.Add(this.lblFromSaleNo);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalePosting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posting";
            this.Load += new System.EventHandler(this.PostingBySaleNo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromSaleNo;
        private System.Windows.Forms.Label lblToSaleNo;
        private System.Windows.Forms.ComboBox cboFromSaleInvoiceNo;
        private System.Windows.Forms.ComboBox cboToSaleInvoiceNo;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSaleDate;
        private System.Windows.Forms.RadioButton rdoSaleNo;
        private System.Windows.Forms.Label lblFromSaleDate;
        private System.Windows.Forms.DateTimePicker dtpFromSaleDate;
        private System.Windows.Forms.DateTimePicker dtpToSaleDate;
        private System.Windows.Forms.Label lblToSaleDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
    }
}