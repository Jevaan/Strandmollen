using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace FastnetOpkald
{
    class Program
    {
        static SerialPort _serialPort;
        static string Outbox;
        static string Inbox;
        static bool _continue;

        static void Main(string[] args)
        {
            Outbox = @"C:\Fastnet\Outbox";
            Inbox = @"C:\Fastnet\Inbox";
            CheckOutbox();
            
        }

        static void CheckOutbox()
        {
            string[] OutgoingCall = Directory.GetFiles(Outbox, "*.txt");//
            foreach (string Call in OutgoingCall)
            {
                System.IO.StreamReader CallReader = new System.IO.StreamReader(Call);
                string line = CallReader.ReadLine();
                CallReader.Close();

                string[] splitFile = line.Split(',');

                CallNumber(splitFile[0]);
            }
        }

        static bool CallNumber(string Phonenumber)
        {
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;


           /* string Dial = "!D " + Phonenumber + "\n";
            Console.WriteLine(Dial);
            System.Threading.Thread.Sleep(5000);
            string Code = "*0000#";
            Console.WriteLine(Code);
            System.Threading.Thread.Sleep(2000);
            string Channel1 = "*0**1*1*1*#";
            string Channel2 = "*0**1*1*2*#";
            Console.WriteLine(Channel1 + " ... " + Channel2);
            System.Threading.Thread.Sleep(2000);
            string Disconnect = "#!H";
            Console.WriteLine(Disconnect);
            System.Threading.Thread.Sleep(2000);
            WriteInbox(Phonenumber, "ch1", "ch2");*/
                        
            _serialPort = new SerialPort();

            _serialPort.PortName = "COM3";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.RequestToSendXOnXOff;
            _serialPort.ReceivedBytesThreshold = 1;
            _serialPort.DtrEnable = true;
            _serialPort.RtsEnable = true;
            

            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(Read); 
            
            _serialPort.Open();
            _continue = true;

            _serialPort.WriteLine(" !D " + Phonenumber);

            while (_continue)
            {
                message = Console.ReadKey().KeyChar.ToString();

                if (stringComparer.Equals("q", message))
                {
                    _continue = false;

                }
                else
                {
                    _serialPort.Write(message);
                        //String.Format(" {0}", message));
                }
            }

            _serialPort.Close();


            return true;
        }

        private static void Read(object sender, SerialDataReceivedEventArgs e)
        {
            string InChar = "";
            while (_serialPort.BytesToRead > 0)
            {
                InChar = _serialPort.ReadExisting();
                if (InChar == "N")
                    break;
                if (InChar == "#")
                    Console.Write(".");
                else
                    Console.Write(InChar);
            }
        }

        
        


        static void WriteInbox(string Phonenumber, string ch1, string ch2)
        {
            using (StreamWriter sw = new StreamWriter(Inbox + @"\" + Phonenumber + ".txt"))
            {
                sw.WriteLine(Phonenumber + "," + DateTime.Now.ToShortDateString() + "," + DateTime.Now.ToLongTimeString() + ", , " + ch1 + ", " + ch2 + ", x.xx, x.xx");
            }


        }

    }
}
