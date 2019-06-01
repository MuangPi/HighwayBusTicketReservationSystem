namespace BTS.UI.ReportDisplay
{
    partial class ReportBySaleDateDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBySaleDateDetail));
            this.rpvSaleDateDetail = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvSaleDateDetail
            // 
            this.rpvSaleDateDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvSaleDateDetail.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportBySaleDateDetail.rdlc";
            this.rpvSaleDateDetail.Location = new System.Drawing.Point(0, 0);
            this.rpvSaleDateDetail.Name = "rpvSaleDateDetail";
            this.rpvSaleDateDetail.Size = new System.Drawing.Size(601, 329);
            this.rpvSaleDateDetail.TabIndex = 0;
            // 
            // ReportBySaleDateDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 329);
            this.Controls.Add(this.rpvSaleDateDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportBySaleDateDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By Sale Date Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportBySaleDateDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSaleDateDetail;
    }
}