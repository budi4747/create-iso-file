using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CreateISOImage
{
    public partial class FormMain : Form
    {
        private string mInputFolder;
        private string mOutputFile;
        private FormProcessOutput mForm;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            DialogResult dlg = folderBrowserDialog.ShowDialog();

            if (!dlg.Equals(DialogResult.Cancel))
            {
                mInputFolder = txtBoxInputFolder.Text = folderBrowserDialog.SelectedPath;
                LoadFilesFromFolder(mInputFolder);
            }

            EnableCreateButton();

        }

        private void LoadFilesFromFolder(string FolderPath)
        {
            lstFilesView.Items.Clear();
            string[] mAllFiles = Directory.GetFiles(FolderPath);
            FileInfo mfInfo;
            ListViewItem mItem;
            string mFileName = string.Empty;

            if (mAllFiles.Length > 0)
            {
                lstFilesView.BeginUpdate();

                for (int iFilesCounter = 0; iFilesCounter < mAllFiles.Length; iFilesCounter++)
                {
                    mfInfo = new FileInfo(mAllFiles[iFilesCounter].ToString());

                    //Convert to normal file name only without folder path
                    mFileName = mAllFiles[iFilesCounter].ToString();
                    mFileName = mFileName.Substring(mFileName.LastIndexOf("\\") + 1, mFileName.Length - mFileName.LastIndexOf("\\") - 1);
                    mItem = new ListViewItem(mFileName);

                    mItem.SubItems.Add(mfInfo.Length.ToString() +" byte");
                    mItem.SubItems.Add(mfInfo.CreationTime.ToLongDateString());

                    mfInfo = null;

                    lstFilesView.Items.Add(mItem);
                }

                lstFilesView.EndUpdate();
            }
            else
            {
                lstFilesView.Items.Add("No files", "No files");
            }

        }

        private void EnableCreateButton()
        {
            btnCreateIso.Enabled = false;

            if (string.IsNullOrEmpty(mInputFolder)) return;
            if (string.IsNullOrEmpty(mOutputFile)) return;

            btnCreateIso.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowseIso_Click(object sender, EventArgs e)
        {
            DialogResult dlg;

            if (!string.IsNullOrEmpty(mInputFolder))
                saveFileDialog.InitialDirectory = mInputFolder;

            dlg = saveFileDialog.ShowDialog();

            if (!dlg.Equals(DialogResult.Cancel))
            {
                txtIsoImagePath.Text = mOutputFile = saveFileDialog.FileName;
            }

            EnableCreateButton();
        }

        private void btnCreateIso_Click(object sender, EventArgs e)
        {
            mForm = new FormProcessOutput(mInputFolder, mOutputFile);
            mForm.Show();
            mForm.Refresh();
            mForm.TopMost = true;
            mForm.ProcessEnd +=new HandledEventHandler(mForm_ProcessEnd);

            this.Enabled = false;

            mForm.Start();
        }

        void mForm_ProcessEnd(object sender, HandledEventArgs e)
        {
            lblStatus.Text = "ISO image created at " + mOutputFile;

            //Clear everythign
            txtBoxInputFolder.Text = txtIsoImagePath.Text = string.Empty;
            mInputFolder = mOutputFile = string.Empty;
            lstFilesView.Items.Clear();
            btnCreateIso.Enabled = false;

            mForm.TopMost = false;
            mForm.Close();
            mForm = null;

            this.Enabled = true;
            this.Focus();
            Application.DoEvents();
        }
    }//class close
}//namespace close