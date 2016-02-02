using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace AirGasBatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {            
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            cbDato.Value = DateTime.Today;
            cbDato.Text = DateTime.Today.ToShortDateString();
            string printme = "";
            string datoen = cbDato.Text;
                        
            string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
            StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));

            printme = "NASC 1252:PP 25,100:FT \"Swiss 721 BT\",10:PT \"Dato: " + cbDato.Text + "\":PP 25,50:FT \"Swiss 721 BT\",10:PT \"R: 90\":PP 25,20:FT \"Swiss 721 BT\",10:PT \"P: Batchlog \":PP 120,50:FT \"Swiss 721 BT\",10:PT \"T: " + tb3.Text + "\":PF";
            w.WriteLine(printme);
            printme = "NASC 1252:PP 25,100:FT \"Swiss 721 BT\",10:PT \"Dato: " + cbDato.Text + "\":PP 25,50:FT \"Swiss 721 BT\",10:PT \"R: 90\":PP 25,20:FT \"Swiss 721 BT\",10:PT \"P: Lotlog \":PP 120,50:FT \"Swiss 721 BT\",10:PT \"T: " + tb3.Text + "\":PF";
            w.WriteLine(printme);
            printme = "NASC 1252:PP 25,100:FT \"Swiss 721 BT\",10:PT \"Dato: " + cbDato.Text + "\":PP 25,50:FT \"Swiss 721 BT\",10:PT \"R: 90\":PP 25,20:FT \"Swiss 721 BT\",10:PT \"P: Ramme \":PP 120,50:FT \"Swiss 721 BT\",10:PT \"T: " + tb3.Text + "\":PF";
            w.WriteLine(printme);
            int copies = 1;
            while (copies < 97)
            {
                printme = "NASC 1252:PP 25,100:FT \"Swiss 721 BT\",10:PT \"Dato: " + cbDato.Text + "\":PP 25,50:FT \"Swiss 721 BT\",10:PT \"R: 90\":PP 25,20:FT \"Swiss 721 BT\",10:PT \"P: " + copies.ToString() + "\":PP 120,50:FT \"Swiss 721 BT\",10:PT \"T: " + tb3.Text + "\":PF";
                w.WriteLine(printme);
                copies++;
            }
            w.WriteLine("\n");
            w.Close();
            File.Move(tmploc, "LPT1");
            
            tb3.Text = "";
        }
    }
}