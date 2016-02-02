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
using System.Security.Principal;
using System.DirectoryServices;
 

namespace MedBatch
{
    public partial class MedBatch : Form
    {
        private bool AdminRights = false;
        public MedBatch()
        {
            this.Load += new System.EventHandler(this.Form1_Load);
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
            AdminRights = CheckRights(WindowsIdentity.GetCurrent().Name);
            //lblVersion.Text = "Version: 4.0.0.0";
            lblVersion.Text = "Version: 4A";
           
        }
        public static DirectoryEntry GetDirectoryEntry()
        {
            DirectoryEntry de = new DirectoryEntry();
            de.Path = "LDAP://DC=strandmollen,DC=local";
            de.AuthenticationType = AuthenticationTypes.Secure;
            return de;
        }
        private bool CheckRights(String userAccount)
        {
            DirectoryEntry entry = GetDirectoryEntry();
            String account = userAccount.Replace(@"STRANDMOLLEN\", "");
            try
            {
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + account + ")";
                search.PropertiesToLoad.Add("displayName");
                search.PropertiesToLoad.Add("memberOf");
                SearchResultCollection results = search.FindAll();
               
                foreach (SearchResult result in results)
                {
                    ResultPropertyCollection rpc = result.Properties;

                    foreach (object value in rpc["memberOf"])
                    {
                        string[] splitter = value.ToString().Split(',');
                        foreach (string spl in splitter)
                        {
                            if (spl.StartsWith("CN") && spl.Contains("BatchAdmin"))
                            {
                                return true;
                            }
                        }
                    }
                } 
                return false;
            }
            catch (Exception ex)
            {
                string debug = ex.Message;

                return false;
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbBatch.Text != "Vælg mærke" && tbBatchID.Text.Length >0)
            {
                string prn = SetPrinter();

                float adjust = Single.Parse(cbAdjust.Text) * 8;
                float adjustX = Single.Parse(cbAdjustX.Text) * 8;
                string printme = "";
                DateTime Expire;
                DateTime Today;
                Expire = Today = DateTime.Now;
                
                if (AdminRights)
                    Expire = Today = dateTimePicker1.Value;
                                  
                if (cbBatch.SelectedIndex == 0) //Flasker < 2L
                    Expire = Expire.AddYears(1); 
                if (cbBatch.SelectedIndex == 1) //Flasker >= 2L < 4L
                    Expire = Expire.AddYears(2);
                if (cbBatch.SelectedIndex == 2) //Flasker >= 4L
                    Expire = Expire.AddYears(3);
                if (cbBatch.SelectedIndex == 3) //N2O Flasker
                    Expire = Expire.AddYears(3);
                if (cbBatch.SelectedIndex == 4) //Cryo <35L 
                    Expire = Expire.AddDays(21);
                if (cbBatch.SelectedIndex == 5) //Cryo O2 >=35L < 2000L
                    Expire = Expire.AddDays(49);
                if (cbBatch.SelectedIndex == 6) //Pharmaline
                    Expire = Expire.AddYears(3);
                string dato = Today.ToString("dd.MM.yyyy");
                
                printme = "NASC 1252:PP " + (40 + adjustX) + ",20:FT \"Swiss 721 BT\",12:PT \"Date: " + dato + "\":PP "+ (40+adjustX) + ",116:PM \"GLASS.PCX\":PP "+(58+adjustX)+",111:FT \"Swiss 721 Bold BT\",8:PT \"EXP:" + Expire.Day.ToString() + "." + Expire.Month.ToString() + "." + Expire.Year.ToString() + "\":PP "+(40 + adjustX) + ",60:FT \"Swiss 721 BT\",12:PT \"Batch_id: " + tbBatchID.Text + "\":PF";
                
                float copies = Single.Parse(cbBatchLabel.Text);
                string tmploc1 = Environment.GetEnvironmentVariable("TEMP") + "\\print1.txt";
                StreamWriter x = new StreamWriter(tmploc1, false, Encoding.GetEncoding(1252));
                printme = printme + " " + copies.ToString();
                x.WriteLine("SETUP \"FEEDADJ,STARTADJ,"+ (adjust-88) + "\"");
                x.WriteLine("SETUP \"MEDIA,MEDIA SIZE,WIDTH,376\"");
                x.WriteLine("SETUP \"MEDIA,MEDIA SIZE,LENGTH,192\"");
                x.WriteLine(printme);
                
                float copies2 = Single.Parse(cbDoc.Text);
                printme = "NASC 1252:PP "+(104+adjustX) + ",1:FT \"Swiss 721 BT\",8:PT \"Dokumentation\":PP "+(40+adjustX)+",20:FT \"Swiss 721 BT\",12:PT \"Date: " + dato + "\":PP "+(40+adjustX)+",116:PM \"GLASS.PCX\":PP "+(58+adjustX)+",111:FT \"Swiss 721 BT\",8:PT \"EXP:" + Expire.Day.ToString() + "." + Expire.Month.ToString() + "." + Expire.Year.ToString() + "\":PP "+(40+adjustX)+",60:FT \"Swiss 721 BT\",12:PT \"Batch_id: " + tbBatchID.Text + "\":PF";
                printme = printme + " " + copies2.ToString();
                x.WriteLine(printme);

                printme = "NASC 1252:PP "+(40+adjustX)+",36:FT \"Swiss 721 BT\",12:PT \"Date: " + dato + "\":PP "+(40+adjustX)+",111:FT \"Swiss 721 Bold BT\",12:PT \"DOKUMENTATION\":PP "+(40+adjustX)+",74:FT \"Swiss 721 BT\",12:PT \"Batch_id: " + tbBatchID.Text + "\":PP "+(40+adjustX)+",2:FT \"Swiss 721 BT\",12:PT \"Etiketter: " + cbBatchLabel.Text + " + " + cbDoc.Text + "\":PF";
                
                x.WriteLine(printme);

                printme = @"NASC 1252:PP78,0:BT ""CODE128"":BH 100: PB """ + tbBatchID.Text + @""":PP 95,100:FT ""Swiss 721 BT"",10:PT """ + "Batch " +tbBatchID.Text + @""":PF";
                x.WriteLine(printme);
                x.WriteLine("");
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
            cbArticle.Enabled = true;
            tb_Nordic.Enabled = true;
            tb_Nordic.Text = "";

            if (cbContent.SelectedIndex == 0 )
            {
                string[] CompressedLiters = { "1 L", "2 L", "2.5 L", "4 L", "5 L", "10 L", "20 L", "50 L", "12 x 50 L"};
                foreach (string s in CompressedLiters)
                    cbLiters.Items.Add(s);
                
                
            }
            if (cbContent.SelectedIndex == 1 )
            {
                string[] CompressedLiters = { "30 L", "36 L", "37 L", "41 L", "47 L", "175 L", "190 L"};
                foreach (string s in CompressedLiters)
                    cbLiters.Items.Add(s);

                string[] CompressedArticles = { "1064M", "1065M", "1066M", "1067M", "1068M", "1069M"};
                foreach (string s in CompressedArticles)
                    cbArticle.Items.Add(s);
            
            }
            if (cbContent.SelectedIndex == 2 )
            {
                string[] CompressedLiters = { "4 L", "10 L", "50 L"};
                foreach (string s in CompressedLiters)
                    cbLiters.Items.Add(s);

                string[] CompressedArticles = { "1704M", "1710M", "1750M"};
                foreach (string s in CompressedArticles)
                    cbArticle.Items.Add(s);
            }

        }
              

        private void PrintContent(object sender, EventArgs e)
        {
            string Liters = "Indhold: ";
            string Company = "SAS: ";
            

            if (cbContent.Text != "" && cbLiters.Text != "" && cbArticle.Text != "")
            {
                string prn = SetPrinter();
                float adjust = Single.Parse(ContentAdjustY.Text) * 8;
                float adjustX = Single.Parse(ContentAdjustX.Text) * 8;
                if (cbContent.Text == "Medical Gas Liquid N2O")
                    cbContent.Text = "Medical Gas Liquid";
                
                string printme = "NASC 1252:PP " + (1 + adjustX) + ",26:FT \"Swiss 721 Bold BT\",12:PT \"Vnr " + tb_Nordic.Text + "\":PP " + (1 + adjustX) + ",60:FT \"Swiss 721 Bold BT\",9:PT \"" + Liters + cbLiters.Text + "\":PP " + (1 + adjustX) + ",1:FT \"Swiss 721 Bold BT\",9:PT \"" + Company + cbArticle.Text + "\":PF";

                float copies = Single.Parse(cbEtiketter.Text);
                string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
                StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
                w.WriteLine("SETUP \"FEEDADJ,STARTADJ," + (adjust - 88) + "\"");
                w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,WIDTH,296\"");
                w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,LENGTH,136\"");
                printme = printme + " " + copies.ToString();

                w.WriteLine(printme);

                /*while (copies > 1)
                {
                    w.WriteLine("PF");
                    copies = copies - 1;
                }
                w.WriteLine("\n");*/
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

        }

        private void cbEtiketter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string SetPrinter()
        {
            string prn = "LPT1";

            if (rbPrnMed.Checked)
                prn = "\\\\SRV-PRN-01\\PD41Med";
            if (rbPrnTek.Checked)
                prn = "\\\\SRV-PRN-01\\PD41Tek";
            if (rbPrnTest.Checked)
                prn = "\\\\SRV-PRN-01\\PD41Test";
            if (rbPrnLju.Checked)
                prn = "\\\\SRV-PRN-01\\PD41Lju";


            return prn;
        }

        private void BatchChanged(object sender, EventArgs e)
        {
            tbBatchID.Text = "";
            if (cbBatch.Text == "N2O flasker")
            {
                tbBatchID.MaxLength = 9;
                
            }
            else
            {
                tbBatchID.MaxLength = 5;
               
            }
            if (AdminRights)
            {
                lblKontrolDato.Text = "Produktionsdato";
                lblKontrolDato.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                lblKontrolDato.Visible = false;
                dateTimePicker1.Visible = false;
            }

        }

        private void N2O_SetVnr(object sender, EventArgs e)
        {
            if (cbContent.SelectedIndex == 2)
            {
                cbArticle.SelectedIndex = cbLiters.SelectedIndex;
                cbArticle.Enabled = false;
                tb_Nordic.Enabled = false;
                switch (cbLiters.SelectedIndex)
                {
                    case 0:
                        tb_Nordic.Text = "03 21 22";
                        break;
                    case 1:
                        tb_Nordic.Text = "03 21 45";
                        break;
                    case 2:
                        tb_Nordic.Text = "03 21 79";
                        break;
                    default:
                        tb_Nordic.Text = "";
                        break;
                }
            }
            if (cbContent.SelectedIndex == 1)
            {
                cbArticle.Items.Clear();
                cbArticle.SelectedText = "";
                tb_Nordic.Enabled = false;
                switch (cbLiters.SelectedIndex)
                {
                    case 0:
                        tb_Nordic.Text = "03 19 64";
                        string[] CompressedArticles = { "1064M", "1066M" };
                        foreach (string s in CompressedArticles)
                            cbArticle.Items.Add(s);
                        cbArticle.Enabled = true;
                        break;
                    case 1:
                        tb_Nordic.Text = "03 19 86";
                        string[] CompressedArticles1 = { "1068M"};
                        foreach (string s in CompressedArticles1)
                            cbArticle.Items.Add(s);
                        cbArticle.Enabled = false;
                        break;
                    case 2:
                        tb_Nordic.Text = "03 19 98";
                        string[] CompressedArticles2 = { "1065M"};
                        foreach (string s in CompressedArticles2)
                            cbArticle.Items.Add(s);
                        cbArticle.Enabled = false;
                        break;
                    case 3:
                        tb_Nordic.Text = "03 20 20";
                        string[] CompressedArticles3 = { "1067M"};
                        foreach (string s in CompressedArticles3)
                            cbArticle.Items.Add(s);
                        cbArticle.Enabled = false;
                        break;
                    case 4:
                        tb_Nordic.Text = "03 20 31";
                        string[] CompressedArticles4 = { "1069M"};
                        foreach (string s in CompressedArticles4)
                            cbArticle.Items.Add(s);
                        cbArticle.Enabled = false;
                        break;
                    case 5:
                        tb_Nordic.Text = "03 20 53";
                        string[] CompressedArticles5 = { "1063MLT"};
                        foreach (string s in CompressedArticles5)
                            cbArticle.Items.Add(s);
                        cbArticle.Enabled = false;
                        break;
                    case 6:
                        tb_Nordic.Text = "03 20 64";
                        string[] CompressedArticles6 = { "1062MLT"};
                        foreach (string s in CompressedArticles6)
                            cbArticle.Items.Add(s);
                        cbArticle.Enabled = false;
                        break;
                    default:
                        tb_Nordic.Text = "";
                        break;
                }
                cbArticle.SelectedIndex = 0;
            }
            if (cbContent.SelectedIndex == 0)
            {
                cbArticle.Items.Clear();
                cbArticle.SelectedText = "";
                tb_Nordic.Enabled = false;
                switch (cbLiters.SelectedIndex)
                {
                    case 0:
                        tb_Nordic.Text = "03 21 90";
                        string[] CompressedArticles = { "1001M", "1001M3"};
                        foreach (string s in CompressedArticles)
                            cbArticle.Items.Add(s);
                        break;
                    case 1:
                        tb_Nordic.Text = "03 22 02";
                        string[] CompressedArticles1 = { "1002M", "1002M2", "1002M3", "1002M3Q", "1002M3Q2", "1002M4"};
                        foreach (string s in CompressedArticles1)
                            cbArticle.Items.Add(s);
                        break;
                    case 2:
                        tb_Nordic.Text = "03 22 13";
                        string[] CompressedArticles2 = { "1003M", "1003M4", "1003M41"};
                        foreach (string s in CompressedArticles2)
                            cbArticle.Items.Add(s);
                        break;
                    case 3:
                        tb_Nordic.Text = "03 22 36";
                        string[] CompressedArticles3 = { "1004M", "1004M4", "1004MQ"};
                        foreach (string s in CompressedArticles3)
                            cbArticle.Items.Add(s);
                        break;
                    case 4:
                        tb_Nordic.Text = "03 22 47";
                        string[] CompressedArticles4 = { "1005M", "1005M2", "1005M3Q2", "1005M4", "1005M6"};
                        foreach (string s in CompressedArticles4)
                            cbArticle.Items.Add(s);
                        break;
                    case 5:
                        tb_Nordic.Text = "03 22 58";
                        string[] CompressedArticles5 = {"1010M"};
                        foreach (string s in CompressedArticles5)
                            cbArticle.Items.Add(s);
                        break;
                    case 6:
                        tb_Nordic.Text = "03 22 70";
                        string[] CompressedArticles6 = {"1020M"};
                        foreach (string s in CompressedArticles6)
                            cbArticle.Items.Add(s);
                        break;
                    case 7:
                        tb_Nordic.Text = "03 22 81";
                        string[] CompressedArticles7 = {"1050M"};
                        foreach (string s in CompressedArticles7)
                            cbArticle.Items.Add(s);
                        break;
                    case 8:
                        tb_Nordic.Text = "03 23 04";
                        string[] CompressedArticles8 = {"1085M" };
                        foreach (string s in CompressedArticles8)
                            cbArticle.Items.Add(s);
                        break;
                    default:
                        tb_Nordic.Text = "";
                        break;
                }
                cbArticle.SelectedIndex = 0;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

      


    }
}