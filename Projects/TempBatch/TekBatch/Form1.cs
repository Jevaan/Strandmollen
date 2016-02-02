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

namespace TekBatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.Load += new System.EventHandler(this.Form1_Load);
            InitializeComponent();
        }
        private PictureBox LabelBox = new PictureBox();
        private void Form1_Load(object sender, System.EventArgs e)
        {
            label5.Visible = false;
            cbDato.Visible = false;
            cb1.Enabled = false;
            cb1.Visible = false;
            cb2.Enabled = false;
            cb2.Visible = false;


        }

        //Opsætning af input felter alt efter valgt batchmærke.
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewBatch();
            label5.Visible = false;
            cbDato.Visible = false;
            cb1.Visible = false;
            cb1.Enabled = false;
            cb2.Enabled = false;
            cb2.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            tb1.Visible = false;
            tb2.Visible = false;
            tb3.Visible = false;
            
            LabelBox.Dock = DockStyle.Fill;
            LabelBox.BackColor = Color.LightGray;
            LabelBox.Paint += new PaintEventHandler(this.PaintUpd);
            LabelBox.Refresh();
            this.Controls.Add(LabelBox);
        }

        private void PaintUpd(object sender, PaintEventArgs e)
        {

            // Get Graphics Object
            Graphics g = e.Graphics;
            g.Clear(Color.LightGray);

            // Method under System.Drawing.Graphics
            Pen blackpen = new Pen(Color.Black, 3);
            Rectangle Etiket = new Rectangle(240, 10, 178, 80);
            g.DrawRectangle(blackpen, Etiket);
            g.FillRectangle(new SolidBrush(Color.White), Etiket);
            if (cbType.Text == "Compressed")
            {
                Tekst("Market autorisation numberð", 10, false, 35, 100, sender, e);
                Tekst("Compressed Oxygenð", 10, false, 70, 55, sender, e);
                Tekst("IS/1/08/190/01ð", 10, true, 90, 20, sender, e);
            }
            if (cbType.Text == "Cryogenic")
            {
                Tekst("Market autorisation number", 10, false, 35, 100, sender, e);
                Tekst("Cryogenic Oxygen", 10, false, 70, 55, sender, e);
                Tekst("IS/1/08/190/02", 10, true, 90, 20, sender, e);
            }
            if (cbType.Text == "Nitrousoxide")
            {
                Tekst("Market autorisation number", 10, false, 35, 100, sender, e);
                Tekst("Nitrousoxide", 10, false, 100, 55, sender, e);
                Tekst("IS/1/08/191/01", 10, true, 90, 20, sender, e);
            }
            

        }
        private void Tekst(string Text, int str, bool bold, int x, int y, object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (bold)
                g.DrawString(Text, new Font("Arial", str, FontStyle.Bold), new SolidBrush(Color.Black), (x / 2 + 230), ((-y) / 2 + 70));
            else
                g.DrawString(Text, new Font("Arial", str), new SolidBrush(Color.Black), (x / 2 + 230), ((-y) / 2 + 70));
        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int adjust = int.Parse(cbAdjust.Text) * 8;
            string printme = "";
            string a = cbDato.Text;
            string[] elementer = a.Split(@"-".ToCharArray());
            a = elementer[2];
            float aar = Single.Parse(a);
            aar = aar + 3;
            string datoen = aar.ToString() + "-" + elementer[1];
            
            if (cbType.Text == "Compressed")
            {
                printme = "NASC 1252:PP 10," + (100 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Market autorisation number\":PP 70," + (55 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"ððCompressed Oxygen\":PP 90," + (20 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"ðIS/1/08/190/01ð\":PF";
            }
            if (cbType.Text == "Cryogenic")
            {
                printme = "NASC 1252:PP 10," + (100 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Market autorisation number\":PP 70," + (55 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Cryogenic Oxygen\":PP 90," + (20 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"IS/1/08/190/02\":PF";
            }
            if (cbType.Text == "Nitrousoxide")
            {
                printme = "NASC 1252:PP 10," + (100 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Market autorisation number\":PP 100," + (55 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Nitrousoxide\":PP 90," + (20 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"IS/1/08/191/01\":PF";
            }


            float copies = Single.Parse(cbEtiketter.Text);
            printme = printme + " " + copies.ToString();
            string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
            StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
            w.WriteLine(printme);
            cbDato.Value = DateTime.Today;
            cbDato.Text = DateTime.Today.ToShortDateString();

            /*while (copies > 1)
            {
                w.WriteLine("PF");
                copies = copies - 1;
            }
            w.WriteLine("\n");
            */
            w.Close();
            File.Move(tmploc, "\\\\127.0.0.1\\PF4i");
            //File.Move(tmploc, "C:\\print.txt");

            NewBatch();

        }

        private void NewBatch()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            cb1.Text = "";
            cb2.Text = "";
        }



    }
}