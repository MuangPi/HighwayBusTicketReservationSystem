namespace BTS.UI.ReportDisplay
{
    partial class LocationReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationReport));
            this.rpvLocation = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvLocation
            // 
            this.rpvLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvLocation.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.LocationReport.rdlc";
            this.rpvLocation.Location = new System.Drawing.Point(0, 0);
            this.rpvLocation.Name = "rpvLocation";
            this.rpvLocation.Size = new System.Drawing.Size(695, 343);
            this.rpvLocation.TabIndex = 0;
            this.rpvLocation.Load += new System.EventHandler(this.LocationReport_Load);
            // 
            // LocationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 343);
            this.Controls.Add(this.rpvLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocationReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LocationReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvLocation;
    }
}