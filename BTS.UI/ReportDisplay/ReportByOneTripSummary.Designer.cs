namespace BTS.UI.ReportDisplay
{
    partial class ReportByOneTripSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportByOneTripSummary));
            this.rpvOneTripSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvOneTripSummary
            // 
            this.rpvOneTripSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvOneTripSummary.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportByOneTripSummary.rdlc";
            this.rpvOneTripSummary.Location = new System.Drawing.Point(0, 0);
            this.rpvOneTripSummary.Name = "rpvOneTripSummary";
            this.rpvOneTripSummary.Size = new System.Drawing.Size(585, 326);
            this.rpvOneTripSummary.TabIndex = 0;
            // 
            // ReportByOneTripSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 326);
            this.Controls.Add(this.rpvOneTripSummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportByOneTripSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By One Trip Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportByOneTripSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvOneTripSummary;
    }
}