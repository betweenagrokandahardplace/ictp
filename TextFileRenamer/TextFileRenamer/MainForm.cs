using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileRenamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string fetchFolderPath = txtFetchPath.Text;
            WriteTextToLog("We will fetch documents from path: " + fetchFolderPath);

           /* foreach (textfile in folder)
            * open text file
            * read first string (make sure its not blank!)
            * find the index of the known string "Published by Commonwealth of Australia"
            * from that index work back 15 characters " - 21 Jan 2016 "
            * remove spaces and dashes (we should now have 21Jan2016)
            * set file name string to 2016-01-21 format
            * save file in subfolder "\processed"
            * end for each */
            



        }

        internal int logNumber = 1;
        internal void WriteTextToLog(string logText)
        {
            if (LogWriter(logText) == true) { } //we wrote to the log! woo!
            else { MessageBox.Show("LOG WRITE ERRROR"); } //we didn't write to the log :(
        }
        internal bool LogWriter(string s) {
            try {
                txtLog.AppendText(logNumber.ToString() + "\t" + s + "\r\n");
                logNumber++;
                return true;
            }
            catch {
                return false;
            }
        }
    }
}
