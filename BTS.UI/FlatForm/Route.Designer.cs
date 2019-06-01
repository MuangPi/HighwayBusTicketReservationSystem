namespace BTS.UI.FlatForm
{
    partial class Route
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Route));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRouteCode = new System.Windows.Forms.TextBox();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.cboFromLocation = new System.Windows.Forms.ComboBox();
            this.cboToLocation = new System.Windows.Forms.ComboBox();
            this.cboRouteCode = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.NewEditExit = new BTS.UI.UserControls.NewEditExitButton();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(37, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Route Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(24, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Location :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(34, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Route Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(37, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To Location :";
            // 
            // txtRouteCode
            // 
            this.txtRouteCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteCode.Location = new System.Drawing.Point(143, 117);
            this.txtRouteCode.Name = "txtRouteCode";
            this.txtRouteCode.Size = new System.Drawing.Size(146, 20);
            this.txtRouteCode.TabIndex = 0;
            this.txtRouteCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.txtRouteCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpperKey_KeyPress);
            // 
            // txtRouteName
            // 
            this.txtRouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteName.Location = new System.Drawing.Point(143, 262);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(146, 20);
            this.txtRouteName.TabIndex = 3;
            this.txtRouteName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.txtRouteName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpperKey_KeyPress);
            // 
            // cboFromLocation
            // 
            this.cboFromLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFromLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFromLocation.FormattingEnabled = true;
            this.cboFromLocation.Items.AddRange(new object[] {
            "0"});
            this.cboFromLocation.Location = new System.Drawing.Point(143, 162);
            this.cboFromLocation.Name = "cboFromLocation";
            this.cboFromLocation.Size = new System.Drawing.Size(146, 21);
            this.cboFromLocation.TabIndex = 1;
            this.cboFromLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboFromLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // cboToLocation
            // 
            this.cboToLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboToLocation.FormattingEnabled = true;
            this.cboToLocation.Items.AddRange(new object[] {
            "0"});
            this.cboToLocation.Location = new System.Drawing.Point(143, 206);
            this.cboToLocation.Name = "cboToLocation";
            this.cboToLocation.Size = new System.Drawing.Size(146, 21);
            this.cboToLocation.TabIndex = 2;
            this.cboToLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboToLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // cboRouteCode
            // 
            this.cboRouteCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRouteCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRouteCode.FormattingEnabled = true;
            this.cboRouteCode.Items.AddRange(new object[] {
            "0"});
            this.cboRouteCode.Location = new System.Drawing.Point(143, 116);
            this.cboRouteCode.Name = "cboRouteCode";
            this.cboRouteCode.Size = new System.Drawing.Size(146, 21);
            this.cboRouteCode.TabIndex = 0;
            this.cboRouteCode.Visible = false;
            this.cboRouteCode.SelectedIndexChanged += new System.EventHandler(this.cboRouteCode_SelectedIndexChanged);
            this.cboRouteCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputControls_KeyDown);
            this.cboRouteCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboControl_KeyPress);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.White;
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreview.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.ImageIndex = 0;
            this.btnPreview.ImageList = this.imageList1;
            this.btnPreview.Location = new System.Drawing.Point(380, 378);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 33);
            this.btnPreview.TabIndex = 5;
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
            // NewEditExit
            // 
            this.NewEditExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewEditExit.BtnCloseText = null;
            this.NewEditExit.BtnEditText = null;
            this.NewEditExit.BtnNewText = null;
            this.NewEditExit.Location = new System.Drawing.Point(143, 315);
            this.NewEditExit.Name = "NewEditExit";
            this.NewEditExit.Size = new System.Drawing.Size(266, 42);
            this.NewEditExit.TabIndex = 4;
            this.NewEditExit.NewClick += new System.EventHandler(this.NewEditExit_NewClick);
            this.NewEditExit.EditClick += new System.EventHandler(this.NewEditExit_EditClick);
            this.NewEditExit.CloseClick += new System.EventHandler(this.NewEditExit_CloseClick);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Harrington", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label9.Location = new System.Drawing.Point(26, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(383, 74);
            this.label9.TabIndex = 144;
            this.label9.Text = "Highway Bus Ticket Reservation System";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 423);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.NewEditExit);
            this.Controls.Add(this.cboRouteCode);
            this.Controls.Add(this.cboToLocation);
            this.Controls.Add(this.cboFromLocation);
            this.Controls.Add(this.txtRouteName);
            this.Controls.Add(this.txtRouteCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Route";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Route";
            this.Load += new System.EventHandler(this.Route_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRouteCode;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.ComboBox cboFromLocation;
        private System.Windows.Forms.ComboBox cboToLocation;
        private System.Windows.Forms.ComboBox cboRouteCode;
        private BTS.UI.UserControls.NewEditExitButton NewEditExit;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label9;
    }
}