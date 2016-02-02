using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace CleanUserProfileFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime RightNow = DateTime.Now;
            string[] folders = System.IO.Directory.GetDirectories(@"C:\Users\");
            foreach (string path in folders)
            {
                if (RightNow.AddDays(-1) > Directory.GetLastWriteTime(path) && Directory.GetLastWriteTime(path) > RightNow.AddMonths(-12))
                {
                    try
                    {
                        DirectoryInfo ThisFolder = new DirectoryInfo(path);
                        ThisFolder.Attributes = ThisFolder.Attributes & ~FileAttributes.ReadOnly;
                        Console.WriteLine("Deleting: {0}", path);
                        ThisFolder.Delete(true);
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }        
        }
    }
}
