namespace BTS.UI.ReportDisplay
{
    partial class MonthlySummaryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlySummaryReport));
            this.rpvMonthlySummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvMonthlySummary
            // 
            this.rpvMonthlySummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvMonthlySummary.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.MonthlySummaryReport.rdlc";
            this.rpvMonthlySummary.Location = new System.Drawing.Point(0, 0);
            this.rpvMonthlySummary.Name = "rpvMonthlySummary";
            this.rpvMonthlySummary.Size = new System.Drawing.Size(1096, 473);
            this.rpvMonthlySummary.TabIndex = 0;
            // 
            // MonthlySummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 473);
            this.Controls.Add(this.rpvMonthlySummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonthlySummaryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Summary Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonthlySummaryReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvMonthlySummary;
    }
}