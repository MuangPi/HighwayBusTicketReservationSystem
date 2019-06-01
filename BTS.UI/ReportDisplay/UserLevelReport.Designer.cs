namespace BTS.UI.ReportDisplay
{
    partial class UserLevelReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLevelReport));
            this.rpvUserLevel = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvUserLevel
            // 
            this.rpvUserLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvUserLevel.LocalReport.ReportEmbeddedResource = "BTS.UI.ReportFiles.UserLevelReport.rdlc";
            this.rpvUserLevel.Location = new System.Drawing.Point(0, 0);
            this.rpvUserLevel.Name = "rpvUserLevel";
            this.rpvUserLevel.Size = new System.Drawing.Size(748, 440);
            this.rpvUserLevel.TabIndex = 0;
            // 
            // UserLevelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 440);
            this.Controls.Add(this.rpvUserLevel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserLevelReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Level Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserLevelReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvUserLevel;
    }
}