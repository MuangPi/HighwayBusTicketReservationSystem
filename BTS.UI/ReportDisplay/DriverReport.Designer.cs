namespace BTS.UI.ReportDisplay
{
    partial class DriverReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverReport));
            this.rpvDriver = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvDriver
            // 
            this.rpvDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDriver.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.DriverReport.rdlc";
            this.rpvDriver.Location = new System.Drawing.Point(0, 0);
            this.rpvDriver.Name = "rpvDriver";
            this.rpvDriver.Size = new System.Drawing.Size(683, 400);
            this.rpvDriver.TabIndex = 0;
            this.rpvDriver.Load += new System.EventHandler(this.DriverReport_Load);
            // 
            // DriverReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 400);
            this.Controls.Add(this.rpvDriver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DriverReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DriverReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDriver;
    }
}