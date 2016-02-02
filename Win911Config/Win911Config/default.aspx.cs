using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.ServiceProcess;
using System.IO;

namespace Win911Config
{
    
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void DK_btn_Click(object sender, EventArgs e)
        {
            ServiceAction("Stop");
            SetConfig("DK");
            ServiceAction("Start");
        }

        protected void SE_btn_Click(object sender, EventArgs e)
        {
            ServiceAction("Stop");
            SetConfig("SE");
            ServiceAction("Start");
        }


        protected bool ServiceAction(string Action)
        {
            ServiceController sc = new ServiceController("911SRV");
            if (Action == "Start")
            {
                if (sc.Status == ServiceControllerStatus.Stopped)
                {
                    sc.Start();
                    System.Threading.Thread.Sleep(2000);
                    return true;
                }
            }
            if (Action == "Stop")
            {
                if (sc.Status == ServiceControllerStatus.Running)
                {
                    sc.Stop();
                    System.Threading.Thread.Sleep(2000);
                    return true;
                }
            }
            return false;
        }
        protected string GetConfig()
        {
            try
            {
                string line;
                using (StreamReader file = new StreamReader(@"C:\Program Files (x86)\Specter Instruments\WIN-911 V7\WIN-911.INI"))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.StartsWith("ConfigurationFile"))
                        {
                            string confFile = ((line.Split('\\')).Last().Split('.'))[0];
                            return confFile;
                        }
                    }
                    return "String not found";
                }
            }
            catch
            {
                return "Error";
            }
        }
        protected bool SetConfig(string Conf)
        {
            if (Conf == "")
                Conf = "RSView Ljungby SMS1";
            string pathToFile = @"C:\Program Files (x86)\Specter Instruments\WIN-911 V7\WIN-911.INI";
            string[] arrLine = File.ReadAllLines(pathToFile);
            arrLine[1] = @"ConfigurationFile=C:\Program Files (x86)\Specter Instruments\WIN-911 V7\Configuration Files\" + Conf + ".MDB";
            File.WriteAllLines(pathToFile, arrLine);
            System.Threading.Thread.Sleep(2000);
            return true;
        }

        protected void UpdateTick(object sender, EventArgs e)
        {
            string Config = GetConfig();
            ServiceController sc = new ServiceController("911SRV");
            StatusLabel.Text = string.Format("Mobile 911 is {0}<BR>",sc.Status.ToString());
            ConfigLabel.Text = string.Format("Config: {0}<BR>", Config);
            
        }

        protected void SE_Shutdown_btn_Click(object sender, EventArgs e)
        {
            ServiceAction("Stop");
            SetConfig("Bagvagt");
            ServiceAction("Start");
        }

        protected void Stop_btn_Click(object sender, EventArgs e)
        {
            ServiceAction("Stop");
            System.Threading.Thread.Sleep(2000);

        }
    }
}