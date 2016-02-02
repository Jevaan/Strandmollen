using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Data.SqlClient;

namespace ModemComm
{
    public partial class Form1 : Form
    {
        bool Ready;
        bool DialOK;
        bool PinOK;
        bool ChannelOK;
        bool Retried;
        bool[] Channels = new bool[5];
        double[] ChannelValue = new double[4];
        int ChannelCount;
        int Recalls;
        string GatheredData = "";
        string OutboxLine;
        string Prefix;
        string Inbox;
        string LastNumber;
        string Logbox;

        System.Windows.Forms.Timer CallTimer;
        System.Windows.Forms.Timer CallTimeout;
        DateTime StartTime;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Retried = false;
            Ready = true;
            Recalls = 0;
            LoadConfig();
            OutboxLine = @"\\SRV-DIV-04\c$\Staus\S2221\OutboxLine";
            Inbox = @"\\SRV-DIV-04\c$\Staus\S2221\Inbox";
            CallTimer = new System.Windows.Forms.Timer();
            CallTimer.Interval = 10000;
            CallTimer.Start();
            CallTimer.Tick += new EventHandler(ReadOutbox);

            CallTimeout = new System.Windows.Forms.Timer();
            CallTimeout.Interval = 10000;
            CallTimeout.Start();
            CallTimeout.Tick += new EventHandler(ErrorCheck);
            
         
            
            
        }

        private void LogString(string LogMe)
        {
            string FileName = @"\Modem_" + DateTime.Now.ToString("yyMMdd") + "_log.txt";
            using (StreamWriter writer = new StreamWriter(Logbox + FileName, true))
            {
                writer.WriteLine(DateTime.Now.ToShortTimeString() + ": " + LogMe);
                textBox1.Text = DateTime.Now.ToShortTimeString() + ": " + LogMe;
            }
        }

        private void LoadConfig()
        {
            string SQLGetQue = "SELECT * FROM Config";
            SqlConnection cn = new SqlConnection();
            SqlCommand comm = new SqlCommand(SQLGetQue, cn);
            cn.ConnectionString = "Data Source=SRV-SQL-06;Initial Catalog=tank;Integrated Security=True";
            comm.Connection.Open();
            SqlDataReader r = comm.ExecuteReader(CommandBehavior.CloseConnection);
            while (r.Read())
            {
                if (r["Key"].ToString() == "Prefix")
                    Prefix = r["Value"].ToString();
                if (r["Key"].ToString() == "DK_LINE_OUT")
                    OutboxLine = r["Value"].ToString();
                if (r["Key"].ToString() == "DK_IN")
                    Inbox = r["Value"].ToString();
                if (r["Key"].ToString() == "LOGBOX")
                    Logbox = r["Value"].ToString();
           

            }
            if (Prefix == "0")
                Prefix += ",";
            cn.Close();
            Outbox_tb.Text = OutboxLine;
            Inbox_tb.Text = Inbox;
            Prefix_tb.Text = Prefix;
        }
        
        private void ReadOutbox(object sender, EventArgs e)
        {
            
            string[] CallList = Directory.GetFiles(OutboxLine, "*.txt");//
            List<string> SQL = new List<string>();
            try
            {
                foreach (string Call in CallList)
                {
                    if (Ready)
                    {
                        StartCall(Call.Replace(OutboxLine + @"\", "").Replace("+45","").Replace(".txt", ""));

                        if (System.IO.File.Exists(Call))
                        {
                            System.IO.File.Delete(Call);
                        }
                    }

                }
            }
            catch { }
        }


        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(1000);
            string DataFromModem;
            
            DataFromModem = ReceiveData();
            GatheredData += DataFromModem;
            LogString("Data From Modem: " + DataFromModem);
            if (DataFromModem.Contains("B"))
            {
                try
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("*#,!H" + "\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                    Thread.Sleep(5000);
                    Ready = true;
                    ComModem.Close();

                }
                catch
                {
                }
                return;
            }
            if (DataFromModem.Contains("O"))
            {
                try
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("*#,!H" + "\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                    Thread.Sleep(5000);
                    Ready = true;
                    ComModem.Close();

                }
                catch
                {
                }
                return;
            }
            
            if (ChannelOK && DialOK)
            {
                DialOK = false;
                try
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("*#,!H" + "\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                    

                }
                catch
                {
                }
                
                string[] ChannelData = GatheredData.Replace('#', ' ').Trim().Split(' ');
                ChannelValue[0] = Double.Parse(ChannelData[0])/50;
                ChannelValue[1] = Double.Parse(ChannelData[1])/50;
                ChannelValue[2] = Double.Parse(ChannelData[2])/50;
                ChannelValue[3] = Double.Parse(ChannelData[3])/50;
                
                WriteFile(ChannelValue[0], ChannelValue[1], ChannelValue[2], ChannelValue[3]);
                Thread.Sleep(1000);


            }
            
            if (DataFromModem.Contains("#") && DialOK && PinOK && !ChannelOK)
            {
                
                ++ChannelCount;
                try
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("*0**1*1*" + ChannelCount.ToString() + "*#" + "\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                }
                catch
                {
                }
                
                if (ChannelCount == 4)
                    ChannelOK = true;
                
            }

            if (DataFromModem.Contains("#") && DialOK && !PinOK)
            {
                LogString("PIN OK");
                
                PinOK = true;
                try
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("*0**1*1*1*#\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                    ChannelCount = 1;
                    
                }
                catch
                {
                    MessageBox.Show("Pin FEJL!");
                }
                
            }

            if (DataFromModem.Contains("#") && !DialOK && !PinOK)
            {
                
                DialOK = true;
                
                try
                {
                    byte[] buffer = Encoding.ASCII.GetBytes("*0000#" + "\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                }
                catch
                {
                }
            }
        }

        public string ReceiveData()
        {
            if (!this.ComModem.IsOpen)
                throw new Exception("Port not open.");

            try
            {
                StringBuilder result = new StringBuilder();

                if (ComModem.BytesToRead == 0)
                {
                    int retries = 0;
                    while (retries < 5)
                    {
                        Thread.Sleep(150);
                        if (ComModem.BytesToRead > 0) break;
                        retries++;
                    }
                }

                while (ComModem.BytesToRead > 0)
                {
                    byte[] buffer = new byte[ComModem.BytesToRead];
                    int numRead = ComModem.Read(buffer, 0, buffer.Length);
                    if (numRead != 0)
                        result.Append(Encoding.ASCII.GetString(buffer, 0, numRead));
                    else
                        break;
                    Thread.Sleep(150);
                }
                return result.ToString();
            }
            catch (TimeoutException)
            {
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

       
        private double ValueTomA(double inputV)
        {
            double mA;
            mA = inputV / 50;
            return mA;
        }

        private double ReadChannel(int ChannelNo)
        {
            double ChannelData = 0.0;
            try
            {
                LogString("Reading Channel " + ChannelNo.ToString());
                byte[] buffer = Encoding.ASCII.GetBytes("*0**1*1*" + ChannelNo.ToString() + "*#" + "\r\n");
                ComModem.Write(buffer, 0, buffer.Length);
            }
            catch
            {
            }
            return ChannelData;
        }

        private void WriteFile(double CH1, double CH2, double CH3, double CH4)
        {
            if (!Ready)
            {
                string CH1st = DoubleToString(CH1);
                string CH2st = DoubleToString(CH2);
                string CH3st = DoubleToString(CH3);
                string CH4st = DoubleToString(CH4);
                
                string DateAndTime = DateTime.Now.ToString("dd-MM-yy") + "," + DateTime.Now.ToString("HH:mm:ss");
                string sGateFile = "+45" + LastNumber + "," + DateAndTime + ",0," + CH1st + "," + CH2st + "," + CH3st + "," + CH4st;
                char[] MyChar = { ':', '-' };
                using (StreamWriter writer = new StreamWriter(Inbox + @"\+45" + LastNumber + "_" + DateTime.Now.ToString("ddMMyy") + "_" + DateTime.Now.ToString("HHmmss") + ".txt", false, Encoding.UTF8))
                {
                    writer.Write(sGateFile);
                    Retried = false;
                }
            }
            ComModem.Close();
            Thread.Sleep(5000);
            Ready = true;
                // FORMAT: "+4530917264,02-11-06,08:25:00,24.0,12.34, 7.89,0,0"
        }

        private string DoubleToString(double inMA)
        {
            string ReturnMe = "x.xx";
            if (inMA > 1)
                ReturnMe = inMA.ToString().Replace(',', '.');
            return ReturnMe;
                
        }

        private void StartCall(string PhoneNumber)
        {
            LoadConfig();
            if (Ready)
            {
                StartTime = DateTime.Now;
                LastNumber = PhoneNumber;
                //LastNumber = LastNumber.Replace(OutboxLine+@"\", "");
                DialOK = false;
                PinOK = false;
                ChannelOK = false;
                if (!ComModem.IsOpen)
                {
                    try
                    {
                        ComModem.Open();
                    }
                    catch { LogString("Error 1"); }
                }
                ComModem.DiscardInBuffer();
                ComModem.DiscardOutBuffer();

                GatheredData = "";
                ChannelCount = 0;

                string CallString = ("!D " + Prefix + PhoneNumber).Replace(OutboxLine+ @"\", "");

                try
                {
                    LogString("Calling: " + CallString);
                    byte[] buffer = Encoding.ASCII.GetBytes(CallString + "\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                }
                catch
                {
                    LogString("Error 508");
                }
                Ready = false;
            }
            else
                LogString("Not ready...");
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            ComModem.Close();
        }
              

        private void ErrorCheck(object sender, EventArgs e)
        {
            TimeSpan Duration = DateTime.Now - StartTime;
            if (Duration.TotalSeconds > 18 && !Ready && !DialOK && !Retried)
            {
                try
                {
                    Retried = true;
                    LogString("Timeout!");
                    byte[] buffer = Encoding.ASCII.GetBytes("*#,!H" + "\r\n");
                    ComModem.Write(buffer, 0, buffer.Length);
                    Ready = true;
                    ComModem.Close();


                }
                catch
                {
                    LogString("Error 519");
                }
                Thread.Sleep(30000);
                if (Recalls < 3)
                {
                    LogString("Redo Call: " + LastNumber);
                    if (System.IO.File.Exists(OutboxLine + @"\" + LastNumber + ".txt"))
                    {
                        System.IO.File.Delete(OutboxLine + @"\" + LastNumber + ".txt");
                    }
                    try
                    {
                        using (System.IO.FileStream fs = System.IO.File.Create(OutboxLine + @"\" + LastNumber + ".txt", 1024))
                        {
                            byte[] SMS = new System.Text.UTF8Encoding(true).GetBytes(LastNumber + ",GET POLL");
                            fs.Write(SMS, 0, SMS.Length);
                        }
                        Recalls++;
                    }
                    catch { LogString("Error 522"); }
                }
                else { Recalls = 0; }
            }
        }
    }
}