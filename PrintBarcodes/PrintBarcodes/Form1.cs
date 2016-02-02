using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PrintBarcodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                

        private void PrintBarcodes(object sender, MouseEventArgs e)
        {
            double StartBarcode;
            double Amount;
            try
            {
                StartBarcode = Convert.ToDouble(StartBarcode_tb.Text);
                Amount = Convert.ToDouble(Amount_tb.Text);
            }
            catch
            {
                MessageBox.Show("Fejl indtastning");
                return;
            }
            double n = 0;
           
            //StreamWriter w = new StreamWriter(tmploc, true, System.Text.Encoding.GetEncoding(1252));
            while (n < Amount)
            {
                string tmploc = @"C:\tmp" + DateTime.Now.ToString("mmMMss") + ".txt";
                StreamWriter w = new StreamWriter(tmploc, true, System.Text.Encoding.GetEncoding(1252));
                
                    w.WriteLine(@"NASC 1252:PP 50,10:FT ""Swiss 721 Bold BT"",8:PT ""NÆSTE FLASKE"":PF");
                    w.WriteLine(@"NASC 1252:PP 40,135:DIR 2:FT ""Swiss 721 Bold BT"",6:PT ""STRANDMØLLEN"":DIR 1:BF OFF:BF ""Swiss 721 BT"",8:PP78,0:BT ""EAN128"":BH 100: PB """ + StartBarcode.ToString() + @""":PP 95,100:FT ""Swiss 721 BT"",10:PT """ + StartBarcode.ToString() + @""":PF 2");
                
                StartBarcode++;
                n++;
                w.WriteLine("\n");
            //Send udskrift til printer på LPT1!
            w.Close();
            string PrinterShare = "\\\\SRV-PRN-01\\PD41Test";

            try
            {
                File.Move(tmploc, PrinterShare);
                
            }
            catch {
                MessageBox.Show("Print fejl");
                return; }
            }


            

        }
    }
}
