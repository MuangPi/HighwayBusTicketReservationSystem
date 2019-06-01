namespace BTS.UI.ReportDisplay
{
    partial class TripByRouteNameReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripByRouteNameReport));
            this.rpvRouteName = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvRouteName
            // 
            this.rpvRouteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvRouteName.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.TripByRouteNameReport.rdlc";
            this.rpvRouteName.Location = new System.Drawing.Point(0, 0);
            this.rpvRouteName.Name = "rpvRouteName";
            this.rpvRouteName.Size = new System.Drawing.Size(920, 407);
            this.rpvRouteName.TabIndex = 0;
            // 
            // TripByRouteNameReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 407);
            this.Controls.Add(this.rpvRouteName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TripByRouteNameReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip By Route Name Report";
            this.Load += new System.EventHandler(this.TripByRouteNameReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvRouteName;
    }
}