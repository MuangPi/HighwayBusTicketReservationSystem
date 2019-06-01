namespace BTS.UI.ReportDisplay
{
    partial class ReportByOneTripDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportByOneTripDetail));
            this.rpvTripOneDetail = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTripOneDetail
            // 
            this.rpvTripOneDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTripOneDetail.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportByOneTripDetail.rdlc";
            this.rpvTripOneDetail.Location = new System.Drawing.Point(0, 0);
            this.rpvTripOneDetail.Name = "rpvTripOneDetail";
            this.rpvTripOneDetail.Size = new System.Drawing.Size(553, 322);
            this.rpvTripOneDetail.TabIndex = 0;
            // 
            // ReportByOneTripDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 322);
            this.Controls.Add(this.rpvTripOneDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportByOneTripDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By One Trip Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportByOneTripDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTripOneDetail;
    }
}