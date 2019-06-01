namespace BTS.UI.ReportDisplay
{
    partial class TripCodeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripCodeReport));
            this.rpvTripCode = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTripCode
            // 
            this.rpvTripCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTripCode.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.TripCodeReport.rdlc";
            this.rpvTripCode.Location = new System.Drawing.Point(0, 0);
            this.rpvTripCode.Name = "rpvTripCode";
            this.rpvTripCode.Size = new System.Drawing.Size(935, 406);
            this.rpvTripCode.TabIndex = 0;
            // 
            // TripCodeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 406);
            this.Controls.Add(this.rpvTripCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TripCodeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Code Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TripCodeReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTripCode;
    }
}