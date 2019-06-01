namespace BTS.UI.ReportDisplay
{
    partial class BusTypeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusTypeReport));
            this.rpvBusType = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvBusType
            // 
            this.rpvBusType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBusType.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.BusTypeReport.rdlc";
            this.rpvBusType.Location = new System.Drawing.Point(0, 0);
            this.rpvBusType.Name = "rpvBusType";
            this.rpvBusType.Size = new System.Drawing.Size(675, 337);
            this.rpvBusType.TabIndex = 0;
            this.rpvBusType.Load += new System.EventHandler(this.BusTypeReport_Load);
            // 
            // BusTypeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 337);
            this.Controls.Add(this.rpvBusType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusTypeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Type Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BusTypeReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBusType;
    }
}