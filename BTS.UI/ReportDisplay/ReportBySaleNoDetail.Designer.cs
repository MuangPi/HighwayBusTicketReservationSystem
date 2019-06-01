namespace BTS.UI.ReportDisplay
{
    partial class ReportBySaleNoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBySaleNoDetail));
            this.rpvSaleNoDetail = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvSaleNoDetail
            // 
            this.rpvSaleNoDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvSaleNoDetail.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportBySaleNoDetail.rdlc";
            this.rpvSaleNoDetail.Location = new System.Drawing.Point(0, 0);
            this.rpvSaleNoDetail.Name = "rpvSaleNoDetail";
            this.rpvSaleNoDetail.Size = new System.Drawing.Size(599, 333);
            this.rpvSaleNoDetail.TabIndex = 0;
            // 
            // ReportBySaleNoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 333);
            this.Controls.Add(this.rpvSaleNoDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportBySaleNoDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By Sale No Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportBySaleNoDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSaleNoDetail;
    }
}