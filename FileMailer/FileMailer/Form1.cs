using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace FileMailer
{
    
    public partial class Form1 : Form
    {
        Timer MyTimer;
        private string MailServer;
        private string FromAdress;
        private string FromName;
        private string FileLocation;

        public Form1()
        {
            InitializeComponent();

        }

        private void SetConfig()
        {
            StreamReader ConfigReader = new StreamReader("config.ini", System.Text.Encoding.Default);
            while (ConfigReader.Peek() >= 0)
            {
                string[] Conf = ConfigReader.ReadLine().Split(';');
                if (Conf[0] == "MailServer")
                    MailServer = Conf[1];
                if (Conf[0] == "FromAdress")
                    FromAdress = FromName = Conf[1];
                if (Conf[0] == "FromName")
                    FromName = Conf[1];
                if (Conf[0] == "FileLocation")
                {
                    FileLocation = Conf[1];
                    if (!FileLocation.Trim().EndsWith(@"\"))
                        FileLocation = FileLocation + @"\";
                }
            }
            textBox1.Text ="Server " + MailServer + Environment.NewLine + "Sender " + FromAdress + Environment.NewLine + "From Name " + FromName + Environment.NewLine + "Files " + FileLocation + Environment.NewLine;
        }

        

        private void Mailer(object sender, EventArgs e)
        {
            SetConfig();
            SmtpClient MailClient = new SmtpClient(MailServer);
            MailAddress From = new MailAddress(FromAdress, FromName);
                        
            string[] EmailsToBeSent = Directory.GetFiles(FileLocation, "*.txt");
            List<string> LinesInBody = new List<string>();
            foreach (string Email in EmailsToBeSent)
            {
                textBox1.Text += "Found " + Email.ToUpper() + Environment.NewLine;
                try
                {
                    string[] lines = File.ReadAllLines(Email);
                    if (lines.Length > 0)
                    {
                        textBox1.Text += "Sending " + lines[1].Trim().ToUpper() + " to " + lines[0].ToUpper() + Environment.NewLine;
                        MailAddress To = new MailAddress(lines[0].Trim());
                        MailMessage NewMail = new MailMessage(From,To);
                        NewMail.Subject = lines[1].Trim();
                        NewMail.Body = "";
                        
                        for (int i = 2; i < lines.Length; i++)
                        {
                            NewMail.Body += lines[i].Trim() + Environment.NewLine;
                        }
                        MailClient.Send(NewMail);
                    }
                }
                catch { }
                
                if (System.IO.File.Exists(Email))
                {
                    System.IO.File.Delete(Email);
                    textBox1.Text += Environment.NewLine;
                }
            }
            MailClient = null;

        }


        private void FormLoad(object sender, EventArgs e)
        {
            MailServer = "192.168.1.218"; //Temp adresse, SetConfig overwrites to proper adress.
            SetConfig();

            MyTimer = new Timer();
            MyTimer.Interval = 30000;
            MyTimer.Start();
            MyTimer.Tick += new EventHandler(Mailer);
        }
    }
}
