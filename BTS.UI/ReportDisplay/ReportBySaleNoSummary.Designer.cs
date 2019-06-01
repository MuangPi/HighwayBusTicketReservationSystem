namespace BTS.UI.ReportDisplay
{
    partial class ReportBySaleNoSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBySaleNoSummary));
            this.rpvSaleNoSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvSaleNoSummary
            // 
            this.rpvSaleNoSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvSaleNoSummary.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportBySaleNoSummary.rdlc";
            this.rpvSaleNoSummary.Location = new System.Drawing.Point(0, 0);
            this.rpvSaleNoSummary.Name = "rpvSaleNoSummary";
            this.rpvSaleNoSummary.Size = new System.Drawing.Size(694, 335);
            this.rpvSaleNoSummary.TabIndex = 0;
            // 
            // ReportBySaleNoSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 335);
            this.Controls.Add(this.rpvSaleNoSummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportBySaleNoSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By Sale No Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportBySaleNoSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSaleNoSummary;
    }
}