using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace KillProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (string arg in args)
            {
                foreach (Process theprocess in processlist)
                {
                    if (theprocess.ProcessName.StartsWith(arg))
                    {
                        Console.WriteLine("Process: {0} ID: {1} killed!", theprocess.ProcessName, theprocess.Id);
                        theprocess.Kill();
                    }
                }
                //Console.WriteLine("Arg: {0}", arg);
            }
            
        }
    }
}
