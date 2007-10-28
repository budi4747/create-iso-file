using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CreateISOImage
{
    public partial class FormProcessOutput : Form
    {
        public static string PROGRAM_NAME = "cdimage.exe";

        private string mInputFolder;
        private string mOutputFileName;
        internal event HandledEventHandler ProcessEnd;
        private Process mMainProcess;
        private ProcessStartInfo mMainProcessStartInfo;
        private StreamReader mOutputReader;

        public FormProcessOutput(string InputFolder, string OutputFileName)
        {
            InitializeComponent();

            mInputFolder = InputFolder;
            mOutputFileName = OutputFileName;

            this.Show();
            Application.DoEvents();


            mMainProcess = new Process();
            mMainProcessStartInfo = new ProcessStartInfo();
            mMainProcessStartInfo.CreateNoWindow = true;
            mMainProcessStartInfo.RedirectStandardOutput = true;
            mMainProcessStartInfo.RedirectStandardError = false;
            mMainProcessStartInfo.UseShellExecute = false;
            mMainProcessStartInfo.FileName = FormProcessOutput.PROGRAM_NAME;
            mMainProcessStartInfo.Arguments = "-j1 \"" + InputFolder + "\" \"" + OutputFileName + "\"";
            mMainProcess.StartInfo = mMainProcessStartInfo;
            
            mMainProcess.EnableRaisingEvents = true;
            mMainProcess.OutputDataReceived += new DataReceivedEventHandler(mMainProcess_OutputDataReceived);
            mMainProcess.Exited += new EventHandler(mMainProcess_Exited);
        }

        void mMainProcess_Exited(object sender, EventArgs e)
        {
            if (richTxtBoxOutput.InvokeRequired)
            {
                this.Invoke(new EventHandler(mMainProcess_Exited), new object[] { sender, e });
            }
            else
            {
                richTxtBoxOutput.Text = mOutputReader.ReadToEnd();
                MessageBox.Show("Done");
            }
        }

        void mMainProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
//            richTxtBoxOutput.Text = mOutputReader.ReadToEnd();
            richTxtBoxOutput.Text  = mMainProcess.StandardOutput.ReadToEnd();
        }


        internal void Start()
        {
            mMainProcess.Start();
            mOutputReader = mMainProcess.StandardOutput;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //no more waiting
            if (!mMainProcess.HasExited)
                mMainProcess.Kill();

            mMainProcess = null;

            if (ProcessEnd != null)
                ProcessEnd(this, null);
        }

    }//class close
}//namespace close