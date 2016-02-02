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

namespace MedBatchIS
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
            lblVersion.Text = "Version: 3.0.1.1";
            tbDate.Text = DateTime.Now.ToShortDateString();
            
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbBatch.Text != "Vælg mærke")
            {
                string prn = SetPrinter();

                float adjust = Single.Parse(cbAdjust.Text) * 8;
                float adjustX = Single.Parse(cbAdjustX.Text) * 8;
                string printme = "";
                DateTime Expire = DateTime.Parse(tbDate.Text);
                if (cbBatch.SelectedIndex == 0) //Flasker <2L
                    Expire = Expire.AddYears(1);
                if (cbBatch.SelectedIndex == 1) //Flasker >=2L < 4L
                    Expire = Expire.AddYears(2);
                if (cbBatch.SelectedIndex == 2) //Flasker >= 4L
                    Expire = Expire.AddYears(3);
                if (cbBatch.SelectedIndex == 3) //N2O
                    Expire = Expire.AddYears(3);
                if (cbBatch.SelectedIndex == 4) //Cryo < 35L
                    Expire = Expire.AddDays(21);
                if (cbBatch.SelectedIndex == 5) //Cryo >= 35L < 2000L
                    Expire = Expire.AddDays(49);

                printme = "NASC 1252:PP " + (40 + adjustX) + ",80:FT \"Swiss 721 Bold BT\",10:PT \"Fyrnist:" + Expire.ToString("dd.MM.yyyy") + "\":PP " + (40+adjustX) + ",40:FT \"Swiss 721 Bold BT\",10:PT \"Lotunúmer: " + tbBatchID.Text + "\":PF";

                float copies = Single.Parse(cbBatchLabel.Text);
                string tmploc1 = Environment.GetEnvironmentVariable("TEMP") + "\\print1.txt";
                StreamWriter x = new StreamWriter(tmploc1, false, Encoding.GetEncoding(1252));
                printme = printme + " " + copies.ToString();
                x.WriteLine("SETUP \"FEEDADJ,STARTADJ," + (adjust - 88) + "\"");
                x.WriteLine("SETUP \"MEDIA,MEDIA SIZE,WIDTH,376\"");
                x.WriteLine("SETUP \"MEDIA,MEDIA SIZE,LENGTH,192\"");
                x.WriteLine(printme);

                
                System.Threading.Thread.Sleep(500);

                float copies2 = Single.Parse(cbDoc.Text);
                printme = "NASC 1252:PP " + (104+adjustX) + ",1:FT \"Swiss 721 Bold BT\",8:PT \"Dokumentation\":PP " + (40 + adjustX) + ",80:FT \"Swiss 721 Bold BT\",10:PT \"Fyrnist:" + Expire.ToString("dd.MM.yyyy") + "\":PP " + (40 + adjustX) +",40:FT \"Swiss 721 Bold BT\",10:PT \"Lotunúmer: " + tbBatchID.Text + "\":PF";
                printme = printme + " " + copies2.ToString();
                x.WriteLine(printme);
                
                printme = "NASC 1252:PP " + (adjustX + 40) + ",36:FT \"Swiss 721 Bold BT\",10:PT \"Date: " + tbDate.Text + "\":PP " + (adjustX + 40) + ",111:FT \"Swiss 721 Bold BT\",12:PT \"DOKUMENTATION\":PP " + (adjustX + 40) + ",74:FT \"Swiss 721 Bold BT\",10:PT \"Batch_id: " + tbBatchID.Text + "\":PP " + (adjustX +40) + ",2:FT \"Swiss 721 Bold BT\",10:PT \"Etiketter: " + cbBatchLabel.Text + " + " + cbDoc.Text + "\":PF";
                
                x.WriteLine(printme);
                printme = @"NASC 1252:PP78,0:BT ""CODE128"":BH 100: PB """ + tbBatchID.Text + @""":PP 95,100:FT ""Swiss 721 BT"",10:PT """ + "Batch " + tbBatchID.Text + @""":PF";
                x.WriteLine(printme);
                x.Close();
                File.Move(tmploc1, prn);
                printme = "";

                if (File.Exists(tmploc1))
                    File.Delete(tmploc1);
            }
            else
            {
                MessageBox.Show("Fejl i Batchmærke!\nDu skal vælge størrelse samt indtaste batch ID", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cbBatch.Text = "Vælg mærke";
            tbBatchID.Text = "";


        }


        private void ContentSelected(object sender, EventArgs e)
        {
            cbLiters.Items.Clear();
            cbLiters.Text = "";
            cbArticle.Items.Clear();
            cbArticle.Text = "";
            tb_Nordic.Text = "";

            if (cbContent.SelectedIndex == 0)
            {
                string[] CompressedLiters = { "1 L", "2 L", "4 L", "5 L", "10 L", "20 L", "50 L", "12 x 50 L"};
                foreach (string s in CompressedLiters)
                    cbLiters.Items.Add(s);

                string[] CompressedArticles = { "1001M", "1001M3", "1002M", "1002M2", "1002M3Q2", "1002M3Q", "1002M4", "1003M", "1003M4", "1003M41", "1004M", "1004M4", "1004MQ", "1005M", "1005M2", "1005M4", "1005M3Q2", "1010M", "1020M", "1050M", "1085M" };
                foreach (string s in CompressedArticles)
                    cbArticle.Items.Add(s);
            }
            if (cbContent.SelectedIndex == 1)
            {
                string[] CompressedLiters = { "5 L", "10 L", "12 L", "20 L", "21 L", "25 L", "30 L", "31 L", "36 L", "37 L", "40 L", "41 L", "47 L", "50 L", "175 L", "200 L", "205 L", "600 L", "1000 L" };
                foreach (string s in CompressedLiters)
                    cbLiters.Items.Add(s);

                string[] CompressedArticles = { "1064M", "1065M", "1066M", "1067M", "1068M", "1069M" };
                foreach (string s in CompressedArticles)
                    cbArticle.Items.Add(s);

            }
            if (cbContent.SelectedIndex == 2)
            {
                string[] CompressedLiters = { "2 L", "4 L", "5 L", "10 L", "20 L", "40 L", "50 L", "200 L", "600 L", "1000 L" };
                foreach (string s in CompressedLiters)
                    cbLiters.Items.Add(s);

                string[] CompressedArticles = { "1704M", "1710M", "1750M" };
                foreach (string s in CompressedArticles)
                    cbArticle.Items.Add(s);
            }

        }

        private void BatchSelected(object sender, EventArgs e)
        {
            tbBatchID.Text = "";
            if (cbBatch.Text == "N2O flasker")
            {
                tbDate.Text = DateTime.Now.ToShortDateString();
                tbDate.ReadOnly = false;
                tbBatchID.MaxLength = 10;
            }
            else
            {
                tbDate.Text = DateTime.Now.ToShortDateString();
                tbDate.ReadOnly = true;
                tbBatchID.MaxLength = 5;
            }

        }

        private void PrintContent(object sender, EventArgs e)
        {
            if (cbContent.Text != "" && cbLiters.Text != "" && cbArticle.Text != "")
            {
                string prn = SetPrinter();

                if (cbContent.Text == "Medical Gas Liquid N2O")
                    cbContent.Text = "Medical Gas Liquid";
                float adjust = Single.Parse(contentAdjustY.Text) * 8;
                float adjustX = Single.Parse(contentAdjustX.Text) * 8;
                string printme = "NASC 1252:PP " + (1 + adjustX) + ",30:FT \"Swiss 721 Bold BT\",12:PT \"Vnr " + tb_Nordic.Text + "\":PP " + (1 + adjustX) + ",65:FT \"Swiss 721 Bold BT\",9:PT \"Stærð " + cbLiters.Text + "\":PP " + (1 + adjustX) + ",1:FT \"Swiss 721 Bold BT\",9:PT \"Vörunúmer " + cbArticle.Text + "\":PF";

                float copies = Single.Parse(cbEtiketter.Text);
                string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
                StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
                printme = printme + " " + copies.ToString();
                w.WriteLine("SETUP \"FEEDADJ,STARTADJ," + (adjust - 88) + "\"");
                w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,WIDTH,296\"");
                w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,LENGTH,136\"");
                w.WriteLine(printme);
                                
                w.Close();
                if (Content_Chkbox.Checked)
                    File.Move(tmploc, "\\\\SRV-PRN-01\\PD41Indh");
                else
                    File.Move(tmploc, prn);
                if (cbContent.Text == "Medical Gas Liquid")
                    cbContent.Text = "Medical Gas Liquid N2O";
            }
            else
            {
                MessageBox.Show("Fejl i indholdsetiket!\nDu skal vælge type, størrelse samt artikel", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            cbContent.Text = "";

        }

        private void cbEtiketter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Select_Vnr(object sender, EventArgs e)
        {
            tb_Nordic.Text = "";

            //Oxygen
            if (cbArticle.Text.Contains("1001"))
                tb_Nordic.Text = "03 21 90";
            if (cbArticle.Text.Contains("1002"))
                tb_Nordic.Text = "03 22 02";
            if (cbArticle.Text.Contains("1003"))
                tb_Nordic.Text = "03 22 13";
            if (cbArticle.Text.Contains("1004"))
                tb_Nordic.Text = "03 22 36";
            if (cbArticle.Text.Contains("1005"))
                tb_Nordic.Text = "03 22 47";
            if (cbArticle.Text.Contains("1010"))
                tb_Nordic.Text = "03 22 58";
            if (cbArticle.Text.Contains("1020"))
                tb_Nordic.Text = "03 22 70";
            if (cbArticle.Text.Contains("1050"))
                tb_Nordic.Text = "03 22 81";
            if (cbArticle.Text.Contains("1085"))
                tb_Nordic.Text = "03 23 04";

            //Lattergas
            if (cbArticle.Text.Contains("1704"))
                tb_Nordic.Text = "03 21 22";
            if (cbArticle.Text.Contains("1710"))
                tb_Nordic.Text = "03 21 45";
            if (cbArticle.Text.Contains("1750"))
                tb_Nordic.Text = "03 21 79";
        }

        private string SetPrinter()
        {
            string prn = "";

            if (rbPrnLocal.Checked)
                prn = "LPT1";
            if (rbPrnMed.Checked)
                prn = "\\\\SRV-PRN-01\\PD41Med";
            if (rbPrnTek.Checked)
                prn = "\\\\SRV-PRN-01\\PD41Tek";
            if (rbPrnTest.Checked)
                prn = "\\\\SRV-PRN-01\\PD41Test";

            return prn;
        }

        private void LitersSelected(object sender, EventArgs e)
        {
            cbArticle.Items.Clear();
            if(cbContent.SelectedIndex ==0)
            {
                if (cbLiters.Text == "1 L")
                {
                    string[] CompressedArticles = { "1001M3" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "2 L")
                {
                    string[] CompressedArticles = { "1002M3Q2", "1002M4" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "4 L")
                {
                    string[] CompressedArticles = { "1004M", "1004M4" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "5 L")
                {
                    string[] CompressedArticles = { "1005M", "1005M3Q2", "1005M4" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "10 L")
                {
                    string[] CompressedArticles = { "1010M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "20 L")
                {
                    string[] CompressedArticles = { "1020M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "50 L")
                {
                    string[] CompressedArticles = { "1050M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "12 x 50 L")
                {
                    string[] CompressedArticles = { "1085M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                
            }
            if (cbContent.SelectedIndex == 1)
            {
                if(cbLiters.Text == "30 L")
                {
                    string[] CompressedArticles = { "1064M", "1066M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "36 L")
                {
                    string[] CompressedArticles = { "1068M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "37 L")
                {
                    string[] CompressedArticles = { "1065M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "41 L")
                {
                    string[] CompressedArticles = { "1067M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "47 L")
                {
                    string[] CompressedArticles = { "1069M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
            }
            if (cbContent.SelectedIndex == 2)
            {
                if (cbLiters.Text == "4 L")
                {
                    string[] CompressedArticles = { "1704M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "10 L")
                {
                    string[] CompressedArticles = { "1710M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
                if (cbLiters.Text == "50 L")
                {
                    string[] CompressedArticles = { "1750M" };
                    foreach (string s in CompressedArticles)
                        cbArticle.Items.Add(s);
                }
            }

        }


    }

    
}