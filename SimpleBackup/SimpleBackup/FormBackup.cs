using BackupMechanism;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimpleBackup
{
    public partial class FormMain : Form
    {
        //private BackupSound sound = new BackupSound();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start backup button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartBackup_Click(object sender, EventArgs e)
        {
            string sourcePath;
            string targetPath;

            //sound.startSound();
            sourcePath = textBoxSource.Text;
            targetPath = textBoxTarget.Text;
            var formMechanism = new BackupData(sourcePath, targetPath);
            Thread dataThread = new Thread(new ThreadStart(formMechanism.copyData));

            if (!string.IsNullOrEmpty(sourcePath) && !string.IsNullOrEmpty(targetPath))
            {
                do
                {
                    dataThread.Start();
                    //Thread.Sleep(10);
                    progressBar.Increment(1);
                    
                } while (progressBar.Value != progressBar.Maximum && formMechanism.flagSuccess);
            }

            //Debug.Assert(flagSuccess, "Backup failed! ");
            if (formMechanism.flagSuccess)
            {
                //sound.finishSound();
                ViewMassage("Backup completed! ", formMechanism.fileCount);
            }
            else
            {
                //sound.errorSound();
                ViewMassage("Backup failed! ", formMechanism.fileCount);
            }
        }

        private void ViewMassage(string message, int quantity)
        {
            StringBuilder newString = new StringBuilder(message);
            newString.AppendFormat("{0} files", quantity);
            MessageBox.Show(newString.ToString());
        }

        private void browseSource_Click(object sender, EventArgs e)
        {
            //sound.pressButton();
            clickBrowse(textBoxSource);
        }

        private void browseTarget_Click(object sender, EventArgs e)
        {
            //sound.pressButton();
            clickBrowse(textBoxTarget);
        }

        private void clickBrowse(TextBox textBox)
        {
            var folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            textBox.Text = folderBrowser.SelectedPath;
        }

       
    }
}