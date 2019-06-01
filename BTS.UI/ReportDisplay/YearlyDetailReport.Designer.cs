namespace BTS.UI.ReportDisplay
{
    partial class YearlyDetailReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YearlyDetailReport));
            this.rpvYearlyDetail = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvYearlyDetail
            // 
            this.rpvYearlyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvYearlyDetail.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.YearlyDetailReport.rdlc";
            this.rpvYearlyDetail.Location = new System.Drawing.Point(0, 0);
            this.rpvYearlyDetail.Name = "rpvYearlyDetail";
            this.rpvYearlyDetail.Size = new System.Drawing.Size(626, 375);
            this.rpvYearlyDetail.TabIndex = 0;
            // 
            // YearlyDetailReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 375);
            this.Controls.Add(this.rpvYearlyDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YearlyDetailReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yearly Detail Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YearlyDetailReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvYearlyDetail;
    }
}