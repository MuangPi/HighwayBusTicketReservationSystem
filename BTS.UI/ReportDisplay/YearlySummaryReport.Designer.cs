namespace BTS.UI.ReportDisplay
{
    partial class YearlySummaryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearlySummaryReport));
            this.rpvYearlySummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvYearlySummary
            // 
            this.rpvYearlySummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvYearlySummary.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.YearlySummaryReport.rdlc";
            this.rpvYearlySummary.Location = new System.Drawing.Point(0, 0);
            this.rpvYearlySummary.Name = "rpvYearlySummary";
            this.rpvYearlySummary.Size = new System.Drawing.Size(944, 429);
            this.rpvYearlySummary.TabIndex = 0;
            // 
            // YearlySummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 429);
            this.Controls.Add(this.rpvYearlySummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YearlySummaryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yearly Summary Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YearlySummaryReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvYearlySummary;
    }
}