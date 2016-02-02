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
            tbDate.Text = DateTime.Now.ToShortDateString();
            cbBatch.SelectedIndex = 1;
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbBatch.Text != "")
            {
                float adjust = Single.Parse(cbAdjust.Text) * 8;
                string printme = "";
                DateTime Expire = DateTime.Parse(tbDate.Text);
                if (cbBatch.SelectedIndex == 0) //Flasker <2L
                    Expire = Expire.AddYears(1);
                if (cbBatch.SelectedIndex == 1) //Flasker >=2L
                    Expire = Expire.AddYears(2);
                if (cbBatch.SelectedIndex == 2) //Cryo <35L
                    Expire = Expire.AddDays(21);
                if (cbBatch.SelectedIndex == 3) //Cryo >35L <2000L
                    Expire = Expire.AddDays(49);
                if (cbBatch.SelectedIndex == 4) // N2O
                    Expire = Expire.AddYears(3);

                printme = "NASC 1252:PP 52," + (80 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"Fyrnist:" + Expire.ToShortDateString() + "\":PP 52," + (40 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"Lotunúmer: " + tbBatchID.Text + "\":PF";

                float copies = Single.Parse(cbBatchLabel.Text);
                string tmploc1 = Environment.GetEnvironmentVariable("TEMP") + "\\print1.txt";
                StreamWriter x = new StreamWriter(tmploc1, false, Encoding.GetEncoding(1252));
                printme = printme + " " + copies.ToString();
                x.WriteLine(printme);

                
                System.Threading.Thread.Sleep(500);

                float copies2 = Single.Parse(cbDoc.Text);
                printme = "NASC 1252:PP 104," + (1 + adjust) + ":FT \"Swiss 721 Bold BT\",8:PT \"Dokumentation\":PP 52," + (80 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"Fyrnist:" + Expire.ToShortDateString() + "\":PP 52," + (40 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"Lotunúmer: " + tbBatchID.Text + "\":PF";
                printme = printme + " " + copies2.ToString();
                x.WriteLine(printme);
                
                printme = "NASC 1252:PP 72," + (36 + adjust) + ":FT \"Swiss 721 Bold BT\",12:PT \"Date: " + tbDate.Text + "\":PP 72," + (111 + adjust) + ":FT \"Swiss 721 Bold BT\",12:PT \"DOKUMENTATION\":PP 72," + (74 + adjust) + ":FT \"Swiss 721 Bold BT\",12:PT \"Batch_id: " + tbBatchID.Text + "\":PP 72," + (2 + adjust) + ":FT \"Swiss 721 Bold BT\",12:PT \"Etiketter: " + cbBatchLabel.Text + " + " + cbDoc.Text + "\":PF";
                
                x.WriteLine(printme);
                x.Close();
                File.Move(tmploc1, "LPT1");
                printme = "";

                if (File.Exists(tmploc1))
                    File.Delete(tmploc1);
            }
            else
            {
                MessageBox.Show("Fejl i Batchmærke!\nDu skal vælge størrelse samt indtaste batch ID", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void ContentSelected(object sender, EventArgs e)
        {
            cbLiters.Items.Clear();
            cbLiters.Text = "";
            cbArticle.Items.Clear();
            cbArticle.Text = "";

            if (cbContent.SelectedIndex == 0)
            {
                string[] CompressedLiters = { "1 L", "2 L", "2.5 L", "3 L", "4 L", "5 L", "10 L", "20 L", "50 L", "80 L", "12 x 50 L", "8 x 80 L", "32 x 50 L" };
                foreach (string s in CompressedLiters)
                    cbLiters.Items.Add(s);

                string[] CompressedArticles = { "1001M", "1001M3", "1002M", "1002M2", "1002M3Q2", "1002M3", "1002M3Q", "1002M4", "1003M", "1003M4", "1003M41", "1004M", "1004MQ", "1005M", "1005M2", "1005M4", "1005M3Q2", "1010M", "1020M", "1050M", "1085M" };
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
            if (cbBatch.Text == "N2O")
                tbBatchID.MaxLength = 10;
            else
                tbBatchID.MaxLength = 5;

        }

        private void PrintContent(object sender, EventArgs e)
        {
            if (cbContent.Text != "" && cbLiters.Text != "" && cbArticle.Text != "")
            {
                if (cbContent.Text == "Medical Gas Liquid N2O")
                    cbContent.Text = "Medical Gas Liquid";
                int adjust = 0;
                string printme = "NASC 1252:PP 20," + (30 + adjust) + ":FT \"Swiss 721 Bold BT\",10:PT \"Vnr " + tb_Nordic.Text + "\":PP 20," + (60 + adjust) + ":FT \"Swiss 721 Bold BT\",9:PT \"Stærð " + cbLiters.Text + "\":PP 20," + (1 + adjust) + ":FT \"Swiss 721 Bold BT\",9:PT \"Vörunúmer " + cbArticle.Text + "\":PF";

                float copies = Single.Parse(cbEtiketter.Text);
                string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
                StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
                printme = printme + " " + copies.ToString();

                w.WriteLine(printme);
                                
                w.Close();
                File.Move(tmploc, "LPT1");
                if (cbContent.Text == "Medical Gas Liquid")
                    cbContent.Text = "Medical Gas Liquid N2O";
            }
            else
            {
                MessageBox.Show("Fejl i indholdsetiket!\nDu skal vælge type, størrelse samt artikel", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

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




    }
}