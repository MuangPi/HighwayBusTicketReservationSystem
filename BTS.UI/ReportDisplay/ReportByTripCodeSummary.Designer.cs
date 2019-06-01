namespace BTS.UI.ReportDisplay
{
    partial class ReportByTripCodeSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportByTripCodeSummary));
            this.rpvTripCodeSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTripCodeSummary
            // 
            this.rpvTripCodeSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTripCodeSummary.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.ReportByTripCodeSummary.rdlc";
            this.rpvTripCodeSummary.Location = new System.Drawing.Point(0, 0);
            this.rpvTripCodeSummary.Name = "rpvTripCodeSummary";
            this.rpvTripCodeSummary.Size = new System.Drawing.Size(632, 317);
            this.rpvTripCodeSummary.TabIndex = 0;
            // 
            // ReportByTripCodeSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 317);
            this.Controls.Add(this.rpvTripCodeSummary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportByTripCodeSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report By Trip Code Summary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportByTripCodeSummary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTripCodeSummary;
    }
}