
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolderWatcher.Clases;
using FolderWatcher.Enums;

namespace FolderWatcher
{
    public partial class FrmFolderWatcher : Form
    {
        public FrmFolderWatcher()
        {
            InitializeComponent();
        }
        
        delegate void SetTextCallback(string text);

        System.Timers.Timer timer = new System.Timers.Timer();

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtxSelectedFolder.Text = folderBrowser.SelectedPath;
            }
        }

        public void FolderWatcher()
        {
            string[] files = Directory.GetFiles(txtxSelectedFolder.Text);
            FileOperations fileoper = new FileOperations();
            try
            {
                Log(DateTime.Now + " " + "Process Started!");

                foreach (string filename in files)
                {
                    Log(DateTime.Now + " " + "Processing filename " + filename);

                    if (Path.GetExtension(filename) == ".xls" || Path.GetExtension(filename) == ".xlsx")
                    {
                        
                        fileoper.ProcessExcelFile(filename);
                        fileoper.MoveFile(filename, CustomEnums.Filetype.Excel);
                    }
                    else
                    {
                        fileoper.MoveFile(filename, CustomEnums.Filetype.Other);
                    }
                    Log(DateTime.Now + " " + "Process Completed for filename " + filename);
                }

                Log(DateTime.Now + " " + "Process Completed!");
            }
            catch (Exception ex)
            {
                Log(DateTime.Now + " " + ex.Message);
            }
        }
       
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {            
            FolderWatcher();
        }

        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            if (txtxSelectedFolder.Text == string.Empty)
            {
                MessageBox.Show("Plese select a folder to monitor", "Folder Watcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Log(DateTime.Now + " " + "Monitor Started!");
                btnStartMonitor.Enabled = false;                
                timer.Interval = 30000;
                timer.Elapsed += timer_Elapsed;
                timer.Start();
                btnStopMonitor.Enabled = true;
            }
        }

        private void btnStopMonitor_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Log(DateTime.Now + " " + "Process Stopped!");
            btnStartMonitor.Enabled = true;
            btnStopMonitor.Enabled = false;
        }

        private void Log(string message)
        {
            if (this.richTextLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(Log);
                this.Invoke(d, new object[] { message });
            }
            else
                richTextLog.AppendText(message + Environment.NewLine);
        }
    }
}