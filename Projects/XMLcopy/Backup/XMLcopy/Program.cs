using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Collections;


namespace XMLcopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int errors = 0;
            bool firstrun = false;
            StreamReader re = null;
            DateTime Lastrun = DateTime.Now;
            try
            {
                re = File.OpenText("XMLCopy.log");
            }
            catch 
            {              
                firstrun = true;
            }
            
            string input = null;
            if (!firstrun)
            {
                while ((input = re.ReadLine()) != null)
                {
                    if ((input.StartsWith("#Start")))
                    {
                        Lastrun = Convert.ToDateTime(input.Substring(7, 19));

                        bool tst = (input.Substring(7, 10) == DateTime.Now.Date.ToString());
                        Console.WriteLine("{0} equals {1} is {2}", input.Substring(7, 10), DateTime.Now.ToShortDateString().ToString(), tst);
                    }
                }
                re.Close();
            }
            else
            {
                Lastrun = DateTime.Now.AddYears(-50);
            }
            Console.WriteLine("Lastrun: {0}", Lastrun.ToString());

            string starttime = DateTime.Now.ToString();
            
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            string ft, src, dst,startup;
            ft = appSettings.Get("FileType");
            src = appSettings.Get("Source");
            dst = appSettings.Get("Destination");
            startup = appSettings.Get("StartTime");

            char[] splitter = { ',' }; 
            string[] srcAr = src.Split(splitter);
            string[] dstAr = dst.Split(splitter);
            int filecount = 0;
            int dstCount = 0;
            DirectoryInfo dir = null;
            
            foreach (string strSrc in srcAr)
            {
                if (Directory.Exists(strSrc))
                {
                    if (strSrc.Contains("logger"))
                    {
                        dir = new DirectoryInfo(strSrc);
                        FileInfo[] srcfiles = dir.GetFiles("*." + ft);
                        Console.WriteLine(" --- LOGGER --- ");
                        Console.WriteLine(strSrc + " --> " + dstAr[dstCount]);
                        
                        DateTime LogMap = DateTime.Now.AddHours(-8);
                        
                        Console.WriteLine(LogMap.ToString());
                        foreach (FileInfo f in srcfiles)
                        {
                            if (Lastrun.AddDays(-1) < f.LastWriteTime && f.LastWriteTime < LogMap)
                            {
                                //Console.WriteLine(f.CreationTime);
                                Console.WriteLine("Name: {0} - Write time: {1}", f.Name, f.LastWriteTime);
                                File.Copy(strSrc + f.Name, dstAr[dstCount] + f.Name, true);
                                filecount++;
                            }
                            

                        }
                        
                    }
                    else
                    {
                        dir = new DirectoryInfo(strSrc);
                        FileInfo[] srcfiles = dir.GetFiles("*." + ft);
                        Console.WriteLine(" --- IKKE LOGGER --- ");
                        Console.WriteLine(strSrc + " --> " + dstAr[dstCount]);
                        foreach (FileInfo f in srcfiles)
                        {
                            if (Lastrun < f.LastWriteTime)
                            {
                                //Console.WriteLine(f.CreationTime);
                                Console.WriteLine("Name: {0} - Write time: {1}", f.Name, f.LastWriteTime);
                                File.Copy(strSrc + f.Name, dstAr[dstCount] + f.Name, true);
                                filecount++;
                            }

                        }
                    }
                    filecount--;
                    dstCount++;
                }
                else { Console.WriteLine("*** " + strSrc + " findes ikke ***"); errors++; }
            }

            if (filecount < 0)
                filecount = 0;
            
            using(StreamWriter sw = new StreamWriter("XMLCopy.log"))
            {
                sw.WriteLine("[Configuration]");
                sw.WriteLine("#Source={0}", src);
                sw.WriteLine("#Destination={0}", dst);
                sw.WriteLine("#Filetype={0}", ft);
                sw.WriteLine("#Files={0}", filecount);
                sw.WriteLine("#Start={0}", starttime);
                sw.WriteLine("#Stop={0}", DateTime.Now.ToString());
                sw.WriteLine("#Errors={0}", errors);
                sw.Close();
            }
        }
    }
}
