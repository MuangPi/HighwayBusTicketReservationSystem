namespace BTS.UI.ReportDisplay
{
    partial class MonthlyDetailReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyDetailReport));
            this.rpvMonthlyDetail = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvMonthlyDetail
            // 
            this.rpvMonthlyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvMonthlyDetail.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.MonthlyDetailReport.rdlc";
            this.rpvMonthlyDetail.Location = new System.Drawing.Point(0, 0);
            this.rpvMonthlyDetail.Name = "rpvMonthlyDetail";
            this.rpvMonthlyDetail.Size = new System.Drawing.Size(905, 441);
            this.rpvMonthlyDetail.TabIndex = 0;
            // 
            // MonthlyDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 441);
            this.Controls.Add(this.rpvMonthlyDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonthlyDetailReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Detail Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MonthlyDetailReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvMonthlyDetail;
    }
}