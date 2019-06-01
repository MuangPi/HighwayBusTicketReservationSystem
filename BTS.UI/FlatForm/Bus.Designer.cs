namespace BTS.UI.FlatForm
{
    partial class Bus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bus));
            this.cboBusType = new System.Windows.Forms.ComboBox();
            this.cboBusCode = new System.Windows.Forms.ComboBox();
            this.lblTotalSeat = new System.Windows.Forms.Label();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.txtBusCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.NewEditExit = new BTS.UI.UserControls.NewEditExitButton();
            this.SuspendLayout();
            // 
            // cboBusType
            // 
            this.cboBusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusType.FormattingEnabled = true;
            this.cboBusType.Items.AddRange(new object[] {
            "0"});
            this.cboBusType.Location = new System.Drawing.Point(142, 229);
            this.cboBusType.Name = "cboBusType";
            this.cboBusType.Size = new System.Drawing.Size(121, 21);
            this.cboBusType.TabIndex = 2;
            this.cboBusType.SelectedIndexChanged += new System.EventHandler(this.cboBusType_SelectedIndexChanged);
            this.cboBusType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboBusType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // cboBusCode
            // 
            this.cboBusCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBusCode.FormattingEnabled = true;
            this.cboBusCode.Items.AddRange(new object[] {
            "0"});
            this.cboBusCode.Location = new System.Drawing.Point(142, 143);
            this.cboBusCode.Name = "cboBusCode";
            this.cboBusCode.Size = new System.Drawing.Size(138, 21);
            this.cboBusCode.TabIndex = 0;
            this.cboBusCode.Visible = false;
            this.cboBusCode.SelectedIndexChanged += new System.EventHandler(this.cboBusCode_SelectedIndexChanged);
            this.cboBusCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // lblTotalSeat
            // 
            this.lblTotalSeat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSeat.Location = new System.Drawing.Point(142, 275);
            this.lblTotalSeat.Name = "lblTotalSeat";
            this.lblTotalSeat.Size = new System.Drawing.Size(85, 23);
            this.lblTotalSeat.TabIndex = 20;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNumber.Location = new System.Drawing.Point(142, 186);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(138, 20);
            this.txtBusNumber.TabIndex = 1;
            this.txtBusNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.txtBusNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpperKey_KeyPress);
            // 
            // txtBusCode
            // 
            this.txtBusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusCode.Location = new System.Drawing.Point(142, 145);
            this.txtBusCode.Name = "txtBusCode";
            this.txtBusCode.Size = new System.Drawing.Size(138, 20);
            this.txtBusCode.TabIndex = 0;
            this.txtBusCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.txtBusCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpperKey_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(43, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Total Seat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(47, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bus Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(33, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bus Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(46, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bus Code :";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.White;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreview.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.ImageIndex = 0;
            this.btnPreview.ImageList = this.imageList1;
            this.btnPreview.Location = new System.Drawing.Point(327, 396);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 33);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Document-Preview-icon.png");
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Harrington", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(29, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 74);
            this.label5.TabIndex = 143;
            this.label5.Text = "Highway Bus Ticket Reservation System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewEditExit
            // 
            this.NewEditExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewEditExit.BtnCloseText = null;
            this.NewEditExit.BtnEditText = null;
            this.NewEditExit.BtnNewText = null;
            this.NewEditExit.Location = new System.Drawing.Point(113, 321);
            this.NewEditExit.Name = "NewEditExit";
            this.NewEditExit.Size = new System.Drawing.Size(266, 42);
            this.NewEditExit.TabIndex = 3;
            this.NewEditExit.NewClick += new System.EventHandler(this.NewEditExit_NewClick);
            this.NewEditExit.EditClick += new System.EventHandler(this.NewEditExit_EditClick);
            this.NewEditExit.CloseClick += new System.EventHandler(this.NewEditExit_CloseClick);
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(431, 441);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cboBusType);
            this.Controls.Add(this.cboBusCode);
            this.Controls.Add(this.lblTotalSeat);
            this.Controls.Add(this.NewEditExit);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.txtBusCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus";
            this.Load += new System.EventHandler(this.Bus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBusType;
        private System.Windows.Forms.ComboBox cboBusCode;
        private System.Windows.Forms.Label lblTotalSeat;
        private BTS.UI.UserControls.NewEditExitButton NewEditExit;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.TextBox txtBusCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
    }
}