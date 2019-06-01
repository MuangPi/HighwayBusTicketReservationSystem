namespace BTS.UI.ReportDisplay
{
    partial class ReportByTripCodeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportByTripCodeDetail));
            this.rpvTripCodeDetail = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTripCodeDetail
            // 
            this.rpvTripCodeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTripCodeDetail.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportByTripCodeDetail.rdlc";
            this.rpvTripCodeDetail.Location = new System.Drawing.Point(0, 0);
            this.rpvTripCodeDetail.Name = "rpvTripCodeDetail";
            this.rpvTripCodeDetail.Size = new System.Drawing.Size(618, 334);
            this.rpvTripCodeDetail.TabIndex = 0;
            // 
            // ReportByTripCodeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 334);
            this.Controls.Add(this.rpvTripCodeDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportByTripCodeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By Trip Code Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportByTripCodeDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTripCodeDetail;
    }
}