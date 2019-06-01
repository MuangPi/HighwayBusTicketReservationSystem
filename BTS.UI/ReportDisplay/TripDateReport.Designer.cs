namespace BTS.UI.ReportDisplay
{
    partial class TripDateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripDateReport));
            this.rpvTripDate = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTripDate
            // 
            this.rpvTripDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTripDate.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.TripDateReport.rdlc";
            this.rpvTripDate.Location = new System.Drawing.Point(0, 0);
            this.rpvTripDate.Name = "rpvTripDate";
            this.rpvTripDate.Size = new System.Drawing.Size(854, 425);
            this.rpvTripDate.TabIndex = 0;
            // 
            // TripDateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 425);
            this.Controls.Add(this.rpvTripDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TripDateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Date Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TripDateReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTripDate;
    }
}