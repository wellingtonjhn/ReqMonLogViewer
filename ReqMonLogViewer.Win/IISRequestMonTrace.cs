using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReqMonLogViewer.Win
{

    [Serializable]
    public class IISRequestMonTrace
    {
        public DateTime RunDate { get; set; }
        public string RunCmd { get; set; }
        public List<ApplicationPool> ApplicationPoolList { get; set; }

        public IISRequestMonTrace()
        {
            this.ApplicationPoolList = new List<ApplicationPool>();
        }
    }

    [Serializable]
    public class ApplicationPool
    {
        public string AppPoolId { get; set; }
        public List<WorkerProcess> WorkerProcessList { get; set; }

        public ApplicationPool()
        {
            this.WorkerProcessList = new List<WorkerProcess>();
        }
    }

    [Serializable]
    public class WorkerProcess
    {
        public int ProcessID { get; set; }
        public List<WebRequest> WebRequestList { get; set; }

        public WorkerProcess()
        {
            this.WebRequestList = new List<WebRequest>();
        }
    }

    [Serializable]
    public class WebRequest
    {
        [CsvColumnNameAttribute(Name = "ContextID", Order = 1)]    
        public string ContextID { get; set; }
        
        [CsvColumnNameAttribute(Name = "SiteID", Order = 2)]    
        public int SiteID { get; set; }
        
        [CsvColumnNameAttribute(Name = "LocalIPAddr", Order = 3)]    
        public string LocalIPAddr { get; set; }
        
        [CsvColumnNameAttribute(Name = "LocalPort", Order = 4)]    
        public int LocalPort { get; set; }
        
        [CsvColumnNameAttribute(Name = "HostName", Order = 5)]    
        public string HostName { get; set; }
        
        [CsvColumnNameAttribute(Name = "ConnectionID", Order = 6)]    
        public string ConnectionID { get; set; }
        
        [CsvColumnNameAttribute(Name = "ClientIPAddr", Order = 7)]    
        public string ClientIPAddr { get; set; }
        
        [CsvColumnNameAttribute(Name = "Verb", Order = 8)]    
        public string Verb { get; set; }
        
        [CsvColumnNameAttribute(Name = "URL", Order = 9)]    
        public string URL { get; set; }
        
        [CsvColumnNameAttribute(Name = "ProcessingState", Order = 10)]    
        public string ProcessingState { get; set; }
        
        [CsvColumnNameAttribute(Name = "TimeElapsed", Order = 11)]    
        public int TimeElapsed { get; set; }
        
        [CsvColumnNameAttribute(Name = "TimeFromLastState", Order = 12)]    
        public int TimeFromLastState { get; set; }
    }
}
