using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WSString
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://srv-web-03/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
       
        public class ArticleFile
        {
            public string Name { get; set; }
            public List<string> AllLines = new List<string>();
        }


        [WebMethod(Description = "Skriver string til fil.")]
        public bool StringWriter(string WriteMe,string Filename, string Location)
        {
            try
            {
                if (File.Exists(Location + Filename))
                {
                    using (StreamReader sr = new StreamReader(Location + Filename, System.Text.Encoding.Default, true))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line == WriteMe && line != "")
                                return false; ;
                        }
                    }

                }
            }
            catch { }
           
            try
            {

                using (StreamWriter writer = new StreamWriter(Location + Filename, true))
                {
                    writer.WriteLine(WriteMe);
                }
                return true;
            }
            catch { return false; }
            
        }
        [WebMethod(Description = "Skriver string til fil og kontrollere at string ikke findes allerede.")]
        public bool StringWriterChecked(string WriteMe, string Filename, string Location)
        {
            try
            {
                if (File.Exists(Location + Filename))
                {
                    using (StreamReader sr = new StreamReader(Location + Filename, System.Text.Encoding.Default, true))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line == WriteMe && line != "")
                                return false; ;
                        }
                    }

                }
            }
            catch { }
            try
            {

                using (StreamWriter writer = new StreamWriter(Location + Filename, true))
                {
                    writer.WriteLine(WriteMe);
                }
                return true;
            }
            catch { return false; }

        }

        [WebMethod(Description = "Læser fil fra forspurgt lokation.")]
        public ArticleFile StringReader(string Filename, string Location)
        {
            ArticleFile newFile = new ArticleFile();
            newFile.Name = Filename;
            
            try
            {
                using (StreamReader sr = new StreamReader(Location + Filename, System.Text.Encoding.Default,true))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        newFile.AllLines.Add(line);
                    }
                }
                return newFile;
            }
            catch { return null; }

        }
    }
}
