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

namespace Batchmærke
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
            
        }

        //Opsætning af input felter alt efter valgt batchmærke.
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.Text == "Ny Medicinsk")
            {
                Initials_lbl.Text = "Batch ID:";
                Initials_lbl.Visible = true;
                tb1.Visible = true;
            }
            if (cbType.Text == "Medicinsk")
            {
                Initials_lbl.Text = "Fyldt af:";
                Initials_lbl.Visible = true;
                tb1.Visible = true;
                Batch_lbl.Visible = false;
                textBox1.Visible = false;
            }
            if (cbType.Text == "Teknisk")
            {
                Initials_lbl.Text = "Fyldt af:";
                Initials_lbl.Visible = true;
                tb1.Visible = true;
                Batch_lbl.Visible = true;
                textBox1.Visible = true;
            }
            if (cbType.Text == "Ny Teknisk")
            {
                Initials_lbl.Text = "Batch ID:";
                Initials_lbl.Visible = true;
                tb1.Visible = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string printme = "";
            string a = cbDato.Text;
            string[] elementer = a.Split(@"-".ToCharArray());
            a = elementer[2];
            float aar = Single.Parse(a);
            aar = aar + 3;
            string datoen = aar.ToString() + "-" + elementer[1];
            if (cbType.Text == "Medicinsk" )
            {
                printme = "NASC 1252:PP 15,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 187,122:FT \"Swiss 721 BT\",10:PM \"GLASS.PCX\":PP 205,117:FT \"Swiss 721 BT\",10:PT \"" + datoen + "\":PP 25,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 25,50:FT \"Swiss 721 BT\",10:PT \"Afd. 1\":PP 165,50:FT \"Swiss 721 BT\",10:PT \"Fyldt af " + tb1.Text + "\":PF";
            }
            if (cbType.Text == "Teknisk")
            {
                printme = "NASC 1252:PP 105,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 25,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 25,50:FT \"Swiss 721 BT\",10:PT \"Afd. 1\":PP 25,20:FT \"Swiss 721 BT\",10:PT \"Træk "+ textBox1.Text +"\":PP 165,50:FT \"Swiss 721 BT\",10:PT \"Fyldt af " + tb1.Text + "\":PF";
            }
            if (cbType.Text == "Test")
            {
                printme = "NASC 1252:PP 15,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 187,122:FT \"Swiss 721 BT\",10:PM \"GLASS.PCX\":PP 205,117:FT \"Swiss 721 BT\",10:PT \"" + datoen + "\":PP 25,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 25,50:FT \"Swiss 721 BT\",10:PT \"Afd. 1\":PF";
            }
            
            float copies = Single.Parse(cbEtiketter.Text);
            string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
            StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
            w.WriteLine(printme);
            cbDato.Value = DateTime.Today;
            cbDato.Text = DateTime.Today.ToShortDateString();
            
            while (copies > 1)
            {
                w.WriteLine("PF");
                copies = copies - 1;
            }
            w.WriteLine("\n");
            w.Close();
            File.Move(tmploc, "LPT1");
            //File.Move(tmploc, "C:\\print.txt");

            tb1.Text = "";
            
        }
        

    }
}