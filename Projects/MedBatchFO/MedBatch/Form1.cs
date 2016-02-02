using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Management;

namespace MedBatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Load += new System.EventHandler(this.Form1_Load);
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
            
            lblVersion.Text = "Version: 1.0.0.5";
            string path = "printers.ini";
            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    string tmp;
                    while (sr.Peek() >= 0)
                    {
                        tmp = sr.ReadLine();
                        if(!tmp.StartsWith("#"))
                        printersCB.Items.Add(tmp);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The process failed: {0}", ex.ToString());
            }
        }
           
        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            string prn = SetPrinter();

            float adjust = Single.Parse(cbAdjust.Text) * 8;
            float adjustX = Single.Parse(cbAdjustX.Text) * 8;
            string printme = "";
            DateTime Expire = DateTime.Now;
            DateTime Today = DateTime.Now;                                    
            
            Today = dateTimePicker1.Value;
            Expire = dateTimePicker1.Value;
            if (cbSize.SelectedIndex == 0)
                Expire = Expire.AddYears(1);
            if (cbSize.SelectedIndex == 1)
                Expire = Expire.AddYears(2);
            if(cbSize.SelectedIndex == 2)
                Expire = Expire.AddYears(3);
            
            string dato = Today.ToString("yyyyMMdd");
            string expire = Expire.ToString("yyyy-MM-dd");

            printme = "NASC 1252:PP " + (40 + adjustX) + ",100:FT \"Swiss 721 Bold BT\",10:PT \"Fonix\":PP " + (40 + adjustX) + ",60:FT \"Swiss 721 BT\",12:PT \"Expiry:" + expire + "\":PP " + (40 + adjustX) + ",10:FT \"Swiss 721 BT\",12:PT \"Batch: " + dato + "\":PF";
            
            float copies = Single.Parse(cbBatchLabel.Text);
            string tmploc1 = Environment.GetEnvironmentVariable("TEMP") + "\\print1.txt";
            StreamWriter x = new StreamWriter(tmploc1, false, Encoding.GetEncoding(1252));
            printme = printme + " " + copies.ToString();
            x.WriteLine("SETUP \"FEEDADJ,STARTADJ,"+ (adjust-88) + "\"");
            x.WriteLine("SETUP \"MEDIA,MEDIA SIZE,WIDTH,376\"");
            x.WriteLine("SETUP \"MEDIA,MEDIA SIZE,LENGTH,192\"");
            x.WriteLine(printme);
            
            float copies2 = Single.Parse(cbDoc.Text);
            printme = "NASC 1252:PP " + (104 + adjustX) + ",1:FT \"Swiss 721 BT\",8:PT \"Dokumentation\":PP " + (40 + adjustX) + ",40:FT \"Swiss 721 BT\",12:PT \"Batch: " + dato + "\":PP " + (40 + adjustX) + ",90:FT \"Swiss 721 BT\",12:PT \"Expiry: " + expire + "\":PF";
            printme = printme + " " + copies2.ToString();
            x.WriteLine(printme);

            printme = "NASC 1252:PP " + (40 + adjustX) + ",36:FT \"Swiss 721 BT\",12:PT \"Batch: " + dato + "\":PP " + (40 + adjustX) + ",111:FT \"Swiss 721 Bold BT\",12:PT \"DOKUMENTATION\":PP " + (40 + adjustX) + ",74:FT \"Swiss 721 BT\",12:PT \"Expiry: " + expire + "\":PP " + (40 + adjustX) + ",2:FT \"Swiss 721 BT\",12:PT \"Etiketter: " + cbBatchLabel.Text + " + " + cbDoc.Text + "\":PF";
            
            x.WriteLine(printme);    
            x.WriteLine("");
            x.Close();
            //File.Move(tmploc1, prn);
            printme = "";

            if (File.Exists(tmploc1))
                File.Delete(tmploc1);
            
        }
              
        private string SetPrinter()
        {
            string prn = "LPT1";

            try { prn = printersCB.Text; }
            catch { }

            return prn;
        }

        private void BatchChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker1.Value = DateTime.Now;
        
        }



    }
}