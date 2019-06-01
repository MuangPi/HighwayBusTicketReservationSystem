namespace BTS.UI.ReportDisplay
{
    partial class ReportBySaleDateSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBySaleDateSummary));
            this.rpvSaleDateSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvSaleDateSummary
            // 
            this.rpvSaleDateSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvSaleDateSummary.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportBySaleDateSummary.rdlc";
            this.rpvSaleDateSummary.Location = new System.Drawing.Point(0, 0);
            this.rpvSaleDateSummary.Name = "rpvSaleDateSummary";
            this.rpvSaleDateSummary.Size = new System.Drawing.Size(627, 304);
            this.rpvSaleDateSummary.TabIndex = 0;
            // 
            // ReportBySaleDateSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 304);
            this.Controls.Add(this.rpvSaleDateSummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportBySaleDateSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By Sale Date Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportBySaleDateSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvSaleDateSummary;
    }
}