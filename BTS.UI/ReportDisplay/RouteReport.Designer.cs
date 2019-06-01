namespace BTS.UI.ReportDisplay
{
    partial class RouteReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteReport));
            this.rpvRoute = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvRoute
            // 
            this.rpvRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvRoute.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.RouteReport.rdlc";
            this.rpvRoute.Location = new System.Drawing.Point(0, 0);
            this.rpvRoute.Name = "rpvRoute";
            this.rpvRoute.Size = new System.Drawing.Size(758, 351);
            this.rpvRoute.TabIndex = 0;
            this.rpvRoute.Load += new System.EventHandler(this.RouteReport_Load);
            // 
            // RouteReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 351);
            this.Controls.Add(this.rpvRoute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RouteReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Route Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RouteReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvRoute;
    }
}