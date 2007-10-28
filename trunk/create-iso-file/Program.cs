using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CreateISOImage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!File.Exists(FormProcessOutput.PROGRAM_NAME))
            {
                MessageBox.Show("Program to create images: " + FormProcessOutput.PROGRAM_NAME + " does not exist at folder " + Application.StartupPath +
                    "\nPlease install the program (" + FormProcessOutput.PROGRAM_NAME + ") and start again", "Create ISO image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                Application.Run(new FormMain());
            }
        }//main close
    }//class close
}//namespace close