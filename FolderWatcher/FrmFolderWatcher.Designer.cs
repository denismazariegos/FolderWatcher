
namespace FolderWatcher
{
    partial class FrmFolderWatcher
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtxSelectedFolder = new System.Windows.Forms.TextBox();
            this.lblfolderpath = new System.Windows.Forms.Label();
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.richTextLog = new System.Windows.Forms.RichTextBox();
            this.btnStopMonitor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(547, 32);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(32, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtxSelectedFolder
            // 
            this.txtxSelectedFolder.Enabled = false;
            this.txtxSelectedFolder.Location = new System.Drawing.Point(129, 32);
            this.txtxSelectedFolder.Name = "txtxSelectedFolder";
            this.txtxSelectedFolder.Size = new System.Drawing.Size(412, 20);
            this.txtxSelectedFolder.TabIndex = 1;
            // 
            // lblfolderpath
            // 
            this.lblfolderpath.AutoSize = true;
            this.lblfolderpath.Location = new System.Drawing.Point(12, 32);
            this.lblfolderpath.Name = "lblfolderpath";
            this.lblfolderpath.Size = new System.Drawing.Size(111, 13);
            this.lblfolderpath.TabIndex = 2;
            this.lblfolderpath.Text = "Folder Path to Monitor";
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Location = new System.Drawing.Point(547, 66);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnStartMonitor.TabIndex = 3;
            this.btnStartMonitor.Text = "Start Monitor";
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // richTextLog
            // 
            this.richTextLog.Location = new System.Drawing.Point(15, 66);
            this.richTextLog.Name = "richTextLog";
            this.richTextLog.ReadOnly = true;
            this.richTextLog.Size = new System.Drawing.Size(526, 140);
            this.richTextLog.TabIndex = 4;
            this.richTextLog.Text = "";
            // 
            // btnStopMonitor
            // 
            this.btnStopMonitor.Enabled = false;
            this.btnStopMonitor.Location = new System.Drawing.Point(547, 95);
            this.btnStopMonitor.Name = "btnStopMonitor";
            this.btnStopMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnStopMonitor.TabIndex = 5;
            this.btnStopMonitor.Text = "Stop Monitor";
            this.btnStopMonitor.UseVisualStyleBackColor = true;
            this.btnStopMonitor.Click += new System.EventHandler(this.btnStopMonitor_Click);
            // 
            // FrmFolderWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 218);
            this.Controls.Add(this.btnStopMonitor);
            this.Controls.Add(this.richTextLog);
            this.Controls.Add(this.btnStartMonitor);
            this.Controls.Add(this.lblfolderpath);
            this.Controls.Add(this.txtxSelectedFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmFolderWatcher";
            this.Text = "Folder Watcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtxSelectedFolder;
        private System.Windows.Forms.Label lblfolderpath;
        private System.Windows.Forms.Button btnStartMonitor;
        private System.Windows.Forms.RichTextBox richTextLog;
        private System.Windows.Forms.Button btnStopMonitor;
    }
}

