namespace BTS.UI.ReportDisplay
{
    partial class TimeScheduleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeScheduleReport));
            this.rpvTimeSchedule = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvTimeSchedule
            // 
            this.rpvTimeSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvTimeSchedule.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.TimeScheduleReport.rdlc";
            this.rpvTimeSchedule.Location = new System.Drawing.Point(0, 0);
            this.rpvTimeSchedule.Name = "rpvTimeSchedule";
            this.rpvTimeSchedule.Size = new System.Drawing.Size(772, 373);
            this.rpvTimeSchedule.TabIndex = 0;
            // 
            // TimeScheduleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 373);
            this.Controls.Add(this.rpvTimeSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeScheduleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Schedule Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TimeScheduleReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvTimeSchedule;
    }
}