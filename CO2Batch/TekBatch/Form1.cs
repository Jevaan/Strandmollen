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

namespace CO2Batch
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
            lblVersion.Text = "Version: 1.1.0.0";
            lbl1.Text = "Tara:";
            lbl2.Text = "Netto: ";
            lbl3.Text = "Brutto: ";
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            tb1.Visible = true;
            tb2.Visible = true;
            tb3.Visible = true;
            UpdateLabel(sender, e);
            

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
            Tekst("Tara: " +tb1.Text, 10, false, 120, 100, sender, e);
            Tekst("Netto: " +tb2.Text, 10, false, 120, 70, sender, e);
            Tekst("Brutto: " +tb3.Text, 10, true, 120, 40, sender, e);
            if (chkIncl.Checked)
                Tekst("(incl. Bøjlehætte)", 8, false, 110, 0, sender, e);
            

        }

        private void Tekst(string Text, int str, bool bold, int x, int y, object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (bold)
                g.DrawString(Text, new Font("Courier New", str, FontStyle.Bold), new SolidBrush(Color.Black), (x / 2 + 230), ((-y) / 2 + 70));
            else
                g.DrawString(Text, new Font("Courier New", str), new SolidBrush(Color.Black), (x / 2 + 230), ((-y) / 2 + 70));
        }
        private void Møllen(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("STRANDMØLLEN", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), 255, 27);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string prn = SetPrinter();

            int adjust = int.Parse(cbAdjust.Text) * 8;
            string printme = "";
            string a = cbDato.Text;
            string[] elementer = a.Split(@"-".ToCharArray());
            a = elementer[2];
            float aar = Single.Parse(a);
            aar = aar + 3;
            string datoen = aar.ToString() + "-" + elementer[1];
            if (chkIncl.Checked)
                printme = "NASC 1252:PP 120," + (90 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Tara: " + tb1.Text + " Kg\":PP 120," + (60 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Netto: " + tb2.Text + " Kg\":PP 120," + (30 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"Brutto: " + tb3.Text + " Kg\":PP 120," + (0 + adjust) + ":FT \"Swiss 721 BT\",8:PT \"(incl. Bøjlehætte)\":PF";
            else
                printme = "NASC 1252:PP 120," + (90 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Tara: " + tb1.Text + " Kg\":PP 120," + (60 + adjust) + ":FT \"Swiss 721 BT\",10:PT \"Netto: " + tb2.Text + " Kg\":PP 120," + (30 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"Brutto: " + tb3.Text + " Kg\":PF";


            float copies = Single.Parse(cbEtiketter.Text);
            string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
            StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
            printme = printme + " " + copies.ToString();
            w.WriteLine(printme);
            cbDato.Value = DateTime.Today;
            cbDato.Text = DateTime.Today.ToShortDateString();
            
            w.Close();
            File.Move(tmploc, prn + @"\print.txt");
            
            NewBatch();
            

        }

        private void NewBatch()
        {
            if (!chkTerra.Checked)
                tb1.Text = "";
            if (!chkNetto.Checked)
                tb2.Text = "";
            tb3.Text = "";
            
            cbDato.Value = DateTime.Now;
        }

        private string SetPrinter()
        {
            string prn = "";

            if (rbPrnLocal.Checked)
                prn = "LPT1";
            if (rbPrnMed.Checked)
                prn = "\\\\SRV-DIV-03\\PD41MED";
            if (rbPrnTek.Checked)
                prn = "\\\\SRV-DIV-03\\PD41Tek";
            if (rbPrnTest.Checked)
                prn = "\\\\SRV-DIV-03\\PD41CO2";
            if (FLVRadioButton.Checked)
                prn = "\\\\SRV-DIV-03\\PF4FLV";

            return prn;
        }

        private void CheckValues(object sender, EventArgs e)
        {
            if (isNumeric(tb1.Text) && isNumeric(tb2.Text))
            {
                double temp = Convert.ToDouble(tb1.Text) + Convert.ToDouble(tb2.Text);
                tb3.Text = temp.ToString();
            }
            else
            {
                tb3.Text = "";
            }
            UpdateLabel(sender, e);

        }
        private bool isNumeric(string Value)
        {
            try
            {
                double test = Convert.ToDouble(Value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void UpdateLabel(object sender, EventArgs e)
        {
            
            LabelBox.Dock = DockStyle.Fill;
            LabelBox.BackColor = Color.LightGray;
            LabelBox.Paint += new PaintEventHandler(this.PaintUpd);
            LabelBox.Refresh();
            this.Controls.Add(LabelBox);
        }

      

    }

 
}