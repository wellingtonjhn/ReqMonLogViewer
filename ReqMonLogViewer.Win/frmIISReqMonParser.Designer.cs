namespace ReqMonLogViewer.Win
{
    partial class frmIISReqMonParser
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtTraceFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParseLog = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.gbApplPool = new System.Windows.Forms.GroupBox();
            this.grdAppPool = new System.Windows.Forms.DataGridView();
            this.gbWebRequest = new System.Windows.Forms.GroupBox();
            this.grdWebRequests = new System.Windows.Forms.DataGridView();
            this.ColumnContextID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSiteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalIPAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConnectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClientIPAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVerb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProcessingState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeElapsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeFromLastState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRunDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRunCmd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdWorkerThread = new System.Windows.Forms.DataGridView();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.gbApplPool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppPool)).BeginInit();
            this.gbWebRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWebRequests)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkerThread)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(389, 25);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtTraceFile
            // 
            this.txtTraceFile.Location = new System.Drawing.Point(12, 27);
            this.txtTraceFile.Name = "txtTraceFile";
            this.txtTraceFile.Size = new System.Drawing.Size(371, 20);
            this.txtTraceFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trace File";
            // 
            // btnParseLog
            // 
            this.btnParseLog.Location = new System.Drawing.Point(470, 25);
            this.btnParseLog.Name = "btnParseLog";
            this.btnParseLog.Size = new System.Drawing.Size(75, 23);
            this.btnParseLog.TabIndex = 3;
            this.btnParseLog.Text = "Parse";
            this.btnParseLog.UseVisualStyleBackColor = true;
            this.btnParseLog.Click += new System.EventHandler(this.btnParseLog_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(699, 23);
            this.progressBar.TabIndex = 4;
            // 
            // gbApplPool
            // 
            this.gbApplPool.Controls.Add(this.grdAppPool);
            this.gbApplPool.Location = new System.Drawing.Point(15, 123);
            this.gbApplPool.Name = "gbApplPool";
            this.gbApplPool.Size = new System.Drawing.Size(368, 96);
            this.gbApplPool.TabIndex = 6;
            this.gbApplPool.TabStop = false;
            this.gbApplPool.Text = "Application Pools";
            // 
            // grdAppPool
            // 
            this.grdAppPool.AllowUserToAddRows = false;
            this.grdAppPool.AllowUserToDeleteRows = false;
            this.grdAppPool.AllowUserToOrderColumns = true;
            this.grdAppPool.AllowUserToResizeRows = false;
            this.grdAppPool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAppPool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAppPool.Location = new System.Drawing.Point(3, 16);
            this.grdAppPool.MultiSelect = false;
            this.grdAppPool.Name = "grdAppPool";
            this.grdAppPool.ReadOnly = true;
            this.grdAppPool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAppPool.Size = new System.Drawing.Size(362, 77);
            this.grdAppPool.TabIndex = 6;
            this.grdAppPool.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.grdAppPool_RowStateChanged);
            // 
            // gbWebRequest
            // 
            this.gbWebRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbWebRequest.Controls.Add(this.grdWebRequests);
            this.gbWebRequest.Location = new System.Drawing.Point(18, 225);
            this.gbWebRequest.Name = "gbWebRequest";
            this.gbWebRequest.Size = new System.Drawing.Size(989, 416);
            this.gbWebRequest.TabIndex = 7;
            this.gbWebRequest.TabStop = false;
            this.gbWebRequest.Text = "Web Requests";
            // 
            // grdWebRequests
            // 
            this.grdWebRequests.AllowUserToAddRows = false;
            this.grdWebRequests.AllowUserToDeleteRows = false;
            this.grdWebRequests.AllowUserToOrderColumns = true;
            this.grdWebRequests.AllowUserToResizeRows = false;
            this.grdWebRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWebRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnContextID,
            this.ColumnSiteID,
            this.ColumnLocalIPAddr,
            this.ColumnLocalPort,
            this.ColumnHostName,
            this.ColumnConnectionID,
            this.ColumnClientIPAddr,
            this.ColumnVerb,
            this.ColumnURL,
            this.ColumnProcessingState,
            this.ColumnTimeElapsed,
            this.ColumnTimeFromLastState});
            this.grdWebRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWebRequests.Location = new System.Drawing.Point(3, 16);
            this.grdWebRequests.MultiSelect = false;
            this.grdWebRequests.Name = "grdWebRequests";
            this.grdWebRequests.ReadOnly = true;
            this.grdWebRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdWebRequests.Size = new System.Drawing.Size(983, 397);
            this.grdWebRequests.TabIndex = 6;
            // 
            // ColumnContextID
            // 
            this.ColumnContextID.HeaderText = "ContextID";
            this.ColumnContextID.Name = "ColumnContextID";
            this.ColumnContextID.ReadOnly = true;
            // 
            // ColumnSiteID
            // 
            this.ColumnSiteID.HeaderText = "SiteID";
            this.ColumnSiteID.Name = "ColumnSiteID";
            this.ColumnSiteID.ReadOnly = true;
            // 
            // ColumnLocalIPAddr
            // 
            this.ColumnLocalIPAddr.HeaderText = "LocalIPAddr";
            this.ColumnLocalIPAddr.Name = "ColumnLocalIPAddr";
            this.ColumnLocalIPAddr.ReadOnly = true;
            // 
            // ColumnLocalPort
            // 
            this.ColumnLocalPort.HeaderText = "LocalPort";
            this.ColumnLocalPort.Name = "ColumnLocalPort";
            this.ColumnLocalPort.ReadOnly = true;
            // 
            // ColumnHostName
            // 
            this.ColumnHostName.HeaderText = "HostName";
            this.ColumnHostName.Name = "ColumnHostName";
            this.ColumnHostName.ReadOnly = true;
            // 
            // ColumnConnectionID
            // 
            this.ColumnConnectionID.HeaderText = "ConnectionID";
            this.ColumnConnectionID.Name = "ColumnConnectionID";
            this.ColumnConnectionID.ReadOnly = true;
            // 
            // ColumnClientIPAddr
            // 
            this.ColumnClientIPAddr.HeaderText = "ClientIPAddr";
            this.ColumnClientIPAddr.Name = "ColumnClientIPAddr";
            this.ColumnClientIPAddr.ReadOnly = true;
            // 
            // ColumnVerb
            // 
            this.ColumnVerb.HeaderText = "Verb";
            this.ColumnVerb.Name = "ColumnVerb";
            this.ColumnVerb.ReadOnly = true;
            // 
            // ColumnURL
            // 
            this.ColumnURL.HeaderText = "URL";
            this.ColumnURL.Name = "ColumnURL";
            this.ColumnURL.ReadOnly = true;
            // 
            // ColumnProcessingState
            // 
            this.ColumnProcessingState.HeaderText = "ProcessingState";
            this.ColumnProcessingState.Name = "ColumnProcessingState";
            this.ColumnProcessingState.ReadOnly = true;
            // 
            // ColumnTimeElapsed
            // 
            this.ColumnTimeElapsed.HeaderText = "TimeElapsed";
            this.ColumnTimeElapsed.Name = "ColumnTimeElapsed";
            this.ColumnTimeElapsed.ReadOnly = true;
            // 
            // ColumnTimeFromLastState
            // 
            this.ColumnTimeFromLastState.HeaderText = "TimeFromLastState";
            this.ColumnTimeFromLastState.Name = "ColumnTimeFromLastState";
            this.ColumnTimeFromLastState.ReadOnly = true;
            // 
            // lblRunDate
            // 
            this.lblRunDate.AutoSize = true;
            this.lblRunDate.Location = new System.Drawing.Point(80, 99);
            this.lblRunDate.Name = "lblRunDate";
            this.lblRunDate.Size = new System.Drawing.Size(36, 13);
            this.lblRunDate.TabIndex = 8;
            this.lblRunDate.Text = "Empty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Run Date: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cmd:";
            // 
            // lblRunCmd
            // 
            this.lblRunCmd.AutoSize = true;
            this.lblRunCmd.Location = new System.Drawing.Point(270, 99);
            this.lblRunCmd.Name = "lblRunCmd";
            this.lblRunCmd.Size = new System.Drawing.Size(36, 13);
            this.lblRunCmd.TabIndex = 10;
            this.lblRunCmd.Text = "Empty";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdWorkerThread);
            this.groupBox1.Location = new System.Drawing.Point(389, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Threads";
            // 
            // grdWorkerThread
            // 
            this.grdWorkerThread.AllowUserToAddRows = false;
            this.grdWorkerThread.AllowUserToDeleteRows = false;
            this.grdWorkerThread.AllowUserToOrderColumns = true;
            this.grdWorkerThread.AllowUserToResizeRows = false;
            this.grdWorkerThread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdWorkerThread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdWorkerThread.Location = new System.Drawing.Point(3, 16);
            this.grdWorkerThread.MultiSelect = false;
            this.grdWorkerThread.Name = "grdWorkerThread";
            this.grdWorkerThread.ReadOnly = true;
            this.grdWorkerThread.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdWorkerThread.Size = new System.Drawing.Size(316, 77);
            this.grdWorkerThread.TabIndex = 6;
            this.grdWorkerThread.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.grdWorkerThread_RowStateChanged);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportCSV.Location = new System.Drawing.Point(929, 648);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(75, 23);
            this.btnExportCSV.TabIndex = 12;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // frmIISReqMonParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 683);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRunCmd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRunDate);
            this.Controls.Add(this.gbWebRequest);
            this.Controls.Add(this.gbApplPool);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnParseLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTraceFile);
            this.Controls.Add(this.btnOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmIISReqMonParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IIS Request Monitor Parser";
            this.gbApplPool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAppPool)).EndInit();
            this.gbWebRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWebRequests)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdWorkerThread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtTraceFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParseLog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox gbApplPool;
        
        private System.Windows.Forms.GroupBox gbWebRequest;
        
        private System.Windows.Forms.Label lblRunDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRunCmd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportCSV;

        private System.Windows.Forms.DataGridView grdAppPool;
        private System.Windows.Forms.DataGridView grdWorkerThread;
        private System.Windows.Forms.DataGridView grdWebRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContextID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSiteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalIPAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConnectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClientIPAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVerb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProcessingState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeElapsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeFromLastState;

    }
}

