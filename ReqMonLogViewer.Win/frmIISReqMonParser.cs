using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace ReqMonLogViewer.Win
{
    public partial class frmIISReqMonParser : Form
    {
       
        IISRequestMonTrace trace = null;

        string selectedAppPool = string.Empty;
        string selectedWorkThread = string.Empty;

        public frmIISReqMonParser()
        {
            InitializeComponent();

            this.grdWebRequests.AutoGenerateColumns = false;
            this.ColumnClientIPAddr.DataPropertyName = "ClientIPAddr";
            this.ColumnContextID.DataPropertyName = "ContextID";
            this.ColumnSiteID.DataPropertyName = "SiteID";
            this.ColumnLocalIPAddr.DataPropertyName = "LocalIPAddr";
            this.ColumnLocalPort.DataPropertyName = "LocalPort";
            this.ColumnHostName.DataPropertyName = "HostName";
            this.ColumnConnectionID.DataPropertyName = "ConnectionID";
            this.ColumnClientIPAddr.DataPropertyName = "ClientIPAddr";
            this.ColumnVerb.DataPropertyName = "Verb";
            this.ColumnURL.DataPropertyName = "URL";
            this.ColumnProcessingState.DataPropertyName = "ProcessingState";
            this.ColumnTimeElapsed.DataPropertyName = "TimeElapsed";
            this.ColumnTimeFromLastState.DataPropertyName = "TimeFromLastState";

            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
        }

        void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Canceled");
                UpdateProgressBar(0);
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
                UpdateProgressBar(0);
            }
            else
            {
                if (trace != null)
                {
                    UpdateProgressBar(100);

                    ClearGrids();

                    lblRunDate.Text = trace.RunDate.ToString();
                    lblRunCmd.Text = trace.RunCmd;

                    grdAppPool.DataSource = trace.ApplicationPoolList;
                }

            }
        }

        void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateProgressBar(e.ProgressPercentage);
        }

        void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string filePath = txtTraceFile.Text;

                if (String.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Invalid File. Please select a valid log file!", "Atenção", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        string text = string.Empty;
                        using (StreamReader reader = new StreamReader(filePath, System.Text.Encoding.ASCII, true))
                        {
                            text = reader.ReadToEnd();
                            trace = ParseXmlLogInIISRequestMonTrace(text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("The file can not be read. Error: {0}", ex.Message));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "IIS Request Monitor Log|*.log";
            openFile.Title = "Open File";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTraceFile.Text = openFile.FileName;
            }
        }

        private void btnParseLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
           
            try
            {
                List<WebRequest> lstRequest = trace.ApplicationPoolList.Where(a => a.AppPoolId == selectedAppPool).First()
                                                                         .WorkerProcessList.Where(a => a.ProcessID.ToString() == selectedWorkThread).First()
                                                                         .WebRequestList;

                if (lstRequest.Count < 1)
                {
                    throw new InvalidOperationException("WebRequests is empty");
                }

                string csv = CSVExport.GetCsv<WebRequest>(lstRequest);

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Save File";
                saveFile.Filter = "CSV File|*.csv";

                string fileName = string.Empty;

                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileName = saveFile.FileName;
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.Write(csv);
                        writer.Dispose();
                    }

                    MessageBox.Show("CSV File created");
                }

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grdAppPool_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
            {
                return;
            }

            if (selectedAppPool != e.Row.Cells[0].Value.ToString())
            {
                selectedAppPool = e.Row.Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(selectedAppPool))
                {
                    ApplicationPool pool = trace.ApplicationPoolList.Where(a => a.AppPoolId == selectedAppPool).First();
                    grdWorkerThread.DataSource = pool.WorkerProcessList;

                }
            }

        }

        private void grdWorkerThread_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected)
            {
                return;
            }

            if (selectedWorkThread != e.Row.Cells[0].Value.ToString())
            {
                selectedWorkThread = e.Row.Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(selectedWorkThread))
                {
                    List<WebRequest> lstRequest = trace.ApplicationPoolList.Where(a => a.AppPoolId == selectedAppPool).First()
                                                                           .WorkerProcessList.Where(a => a.ProcessID.ToString() == selectedWorkThread).First()
                                                                           .WebRequestList;

                    SortableBindingList<WebRequest> lstRequestsSorted = new SortableBindingList<WebRequest>(lstRequest);
                    grdWebRequests.DataSource = lstRequestsSorted;

                }
            }

        }

        private void UpdateProgressBar(int percent)
        {
            progressBar.Value = percent;
        }

        private void ClearGrids()
        {
            selectedAppPool = string.Empty;
            selectedWorkThread = string.Empty;

            grdAppPool.DataSource = null;
            grdWorkerThread.DataSource = null;
            grdWebRequests.DataSource = null;
        }

        #region Parsers

        private IISRequestMonTrace ParseXmlLogInIISRequestMonTrace(string xml)
        {
            try
            {
                if (!xml.Contains("IisReqMonList"))
                {
                    throw new InvalidOperationException("Invalid file format");
                }

                IISRequestMonTrace trace = null;

                if (!string.IsNullOrWhiteSpace(xml))
                {
                    XDocument doc = XDocument.Parse(xml);

                    trace = GetIISRequestMonTraceObject(doc);

                }

                return trace;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private IISRequestMonTrace GetIISRequestMonTraceObject(XDocument doc)
        {
            IISRequestMonTrace trace = new IISRequestMonTrace();
            var runDate = doc.Root.Attributes("RunDate").First().Value;
            var runCmd = doc.Root.Attributes("RunCmd").First().Value;

            trace.RunDate = Convert.ToDateTime(runDate);
            trace.RunCmd = runCmd;

            trace.ApplicationPoolList = GetApplicationPoolList(doc);

            return trace;
        }

        private List<ApplicationPool> GetApplicationPoolList(XDocument doc)
        {
            List<ApplicationPool> lstApplPool = new List<ApplicationPool>();
            var appPoolElements = doc.Root.Elements("AppPool");

            if (appPoolElements.Count() > 0)
            {
                foreach (var item in appPoolElements)
                {
                    ApplicationPool pool = new ApplicationPool();
                    pool.AppPoolId = item.Attributes("AppPoolId").First().Value;

                    pool.WorkerProcessList = GetWorkerProcessListByPoolID(doc, pool.AppPoolId);
                    lstApplPool.Add(pool);
                }
            }
            return lstApplPool;
        }

        private List<WorkerProcess> GetWorkerProcessListByPoolID(XDocument doc, string appPoolID)
        {
            List<WorkerProcess> lstWorkerProcess = new List<WorkerProcess>();
            var workerProcessElements = doc.Root.Elements().Where(a => a.Attributes().First().Value == appPoolID);

            if (workerProcessElements.Count() > 0)
            {
                foreach (var item in workerProcessElements)
                {
                    WorkerProcess workerProcess = new WorkerProcess();
                    workerProcess.ProcessID = Convert.ToInt32(item.Elements().Attributes("ProcessID").First().Value);

                    workerProcess.WebRequestList = GetWebRequestListByWorkerProcessID(doc, workerProcess.ProcessID);

                    lstWorkerProcess.Add(workerProcess);
                }
            }

            return lstWorkerProcess;
        }

        private List<WebRequest> GetWebRequestListByWorkerProcessID(XDocument doc, int processID)
        {
            List<WebRequest> lstWebRequest = new List<WebRequest>();
            //var webRequestList = doc.Root.Elements().Where(a => a.Attributes().First().Value == processID.ToString());

            var workerProcess = doc.Root.Elements().Elements().Where(a => a.Attributes("ProcessID").First().Value == processID.ToString());

            if (workerProcess.Count() > 0 && workerProcess.Elements().Elements("WebRequest").Count() > 0)
            {
                var webRequestList = workerProcess.Elements().Elements("WebRequest");

                foreach (var item in webRequestList)
                {
                    WebRequest request = new WebRequest();
                    request.ClientIPAddr = item.Attributes("ClientIPAddr").First().Value;
                    request.ConnectionID = item.Attributes("ConnectionID").First().Value;
                    request.ContextID = item.Attributes("ContextID").First().Value;
                    request.HostName = item.Attributes("HostName").First().Value;
                    request.LocalIPAddr = item.Attributes("LocalIPAddr").First().Value;
                    request.LocalPort = Convert.ToInt32(item.Attributes("LocalPort").First().Value);
                    request.ProcessingState = item.Attributes("ProcessingState").First().Value;
                    request.SiteID = Convert.ToInt32(item.Attributes("SiteID").First().Value);
                    request.TimeElapsed = Convert.ToInt32(item.Attributes("TimeElapsed").First().Value);
                    request.TimeFromLastState = Convert.ToInt32(item.Attributes("TimeFromLastState").First().Value);
                    request.URL = item.Attributes("URL").First().Value;
                    request.Verb = item.Attributes("Verb").First().Value;

                    lstWebRequest.Add(request);
                }
            }

            return lstWebRequest;
        }

        #endregion

    }
}

