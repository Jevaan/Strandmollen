using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileToMail
{
    public partial class FileToMail : ServiceBase
    {
        public FileToMail()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("MySource"))
                System.Diagnostics.EventLog.CreateEventSource("FileToMail", "FileToMailLog");
            eventLog1.Source = "FileToMail";
            eventLog1.Log = "FileToMailLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("FileToMail Started");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("FileToMail Stopped");
        }
    }
}
