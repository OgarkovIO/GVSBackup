using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GVSBackup
{
    public partial class Form_Option : Form
    {
        public Form_Option()
        {
            InitializeComponent();
        }

        public void LoadConfig()
        {
            Options_save ops = new Options_save();
            ops.ReadConfig();
            textBoxSDP.Text = ops.SDPBackupPath;
            textBoxORA.Text = ops.OracleBackupPath;
            textBoxSUD.Text = ops.SudimostBackupPath;
            NumberOfDays.Value = int.Parse(ops.CountOfDays);
            NumberOfStoredFiles.Value = int.Parse(ops.CountOfFiles);
        }

        private void buttonSDP_Click(object sender, EventArgs e)
        {
            //string listAddres = "";
            FolderBrowserDialog fdl = new FolderBrowserDialog();
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSDP.Text = fdl.SelectedPath; 
            }
        }

        private void buttonORA_Click(object sender, EventArgs e)
        {
            //string listAddres = "";
            FolderBrowserDialog fdl = new FolderBrowserDialog();
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxORA.Text = fdl.SelectedPath; 
            }

        }

        private void buttonSUD_Click(object sender, EventArgs e)
        {
            //string listAddres = "";
            FolderBrowserDialog fdl = new FolderBrowserDialog();
            if (fdl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxSUD.Text = fdl.SelectedPath; 
            }
        }

        private void Applay_Click(object sender, EventArgs e)
        {
            Options_save ops = new Options_save();
            ops.FilePath = "config.xml";
            ops.LogPath = "log.txt";
            ops.OracleBackupPath = textBoxORA.Text;
            ops.SDPBackupPath = textBoxSDP.Text;
            ops.SudimostBackupPath = textBoxSUD.Text;
            ops.CountOfFiles = NumberOfStoredFiles.Value.ToString();
            ops.CountOfDays = NumberOfDays.Value.ToString();

            ops.saveConfig(ops.FilePath);
            Close();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
