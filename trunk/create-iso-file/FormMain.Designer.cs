namespace CreateISOImage
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.txtBoxInputFolder = new System.Windows.Forms.TextBox();
            this.lstFilesView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseIso = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIsoImagePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnCreateIso = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Location = new System.Drawing.Point(516, 27);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFiles.TabIndex = 1;
            this.btnBrowseFiles.Text = "Browse";
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // txtBoxInputFolder
            // 
            this.txtBoxInputFolder.BackColor = System.Drawing.Color.White;
            this.txtBoxInputFolder.Location = new System.Drawing.Point(69, 27);
            this.txtBoxInputFolder.Name = "txtBoxInputFolder";
            this.txtBoxInputFolder.ReadOnly = true;
            this.txtBoxInputFolder.Size = new System.Drawing.Size(431, 22);
            this.txtBoxInputFolder.TabIndex = 2;
            // 
            // lstFilesView
            // 
            this.lstFilesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstFilesView.FullRowSelect = true;
            this.lstFilesView.GridLines = true;
            this.lstFilesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstFilesView.Location = new System.Drawing.Point(18, 66);
            this.lstFilesView.MultiSelect = false;
            this.lstFilesView.Name = "lstFilesView";
            this.lstFilesView.Size = new System.Drawing.Size(573, 212);
            this.lstFilesView.TabIndex = 3;
            this.lstFilesView.UseCompatibleStateImageBehavior = false;
            this.lstFilesView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 295;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size (bytes)";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date created";
            this.columnHeader3.Width = 127;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lstFilesView);
            this.groupBox1.Controls.Add(this.txtBoxInputFolder);
            this.groupBox1.Controls.Add(this.btnBrowseFiles);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 293);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input data";
            // 
            // btnBrowseIso
            // 
            this.btnBrowseIso.Location = new System.Drawing.Point(516, 32);
            this.btnBrowseIso.Name = "btnBrowseIso";
            this.btnBrowseIso.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseIso.TabIndex = 5;
            this.btnBrowseIso.Text = "Browse";
            this.btnBrowseIso.UseVisualStyleBackColor = true;
            this.btnBrowseIso.Click += new System.EventHandler(this.btnBrowseIso_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(528, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIsoImagePath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnBrowseIso);
            this.groupBox2.Location = new System.Drawing.Point(12, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 86);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make ISO";
            // 
            // txtIsoImagePath
            // 
            this.txtIsoImagePath.Location = new System.Drawing.Point(105, 32);
            this.txtIsoImagePath.Name = "txtIsoImagePath";
            this.txtIsoImagePath.Size = new System.Drawing.Size(395, 22);
            this.txtIsoImagePath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Store folder";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Please select the folder where located files that will be converted to ISO image";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "iso";
            this.saveFileDialog.FileName = "image.iso";
            this.saveFileDialog.Filter = "ISO | *.iso";
            // 
            // btnCreateIso
            // 
            this.btnCreateIso.Enabled = false;
            this.btnCreateIso.Location = new System.Drawing.Point(437, 416);
            this.btnCreateIso.Name = "btnCreateIso";
            this.btnCreateIso.Size = new System.Drawing.Size(75, 23);
            this.btnCreateIso.TabIndex = 8;
            this.btnCreateIso.Text = "Create";
            this.btnCreateIso.UseVisualStyleBackColor = true;
            this.btnCreateIso.Click += new System.EventHandler(this.btnCreateIso_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 23);
            this.statusStrip1.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 18);
            this.lblStatus.Text = "Ready";
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(640, 478);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCreateIso);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create ISO image";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.TextBox txtBoxInputFolder;
        private System.Windows.Forms.ListView lstFilesView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseIso;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIsoImagePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnCreateIso;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

