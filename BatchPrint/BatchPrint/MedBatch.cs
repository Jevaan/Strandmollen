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
using System.Data.SqlClient;

namespace BatchPrint
{
    public partial class MedBatch : Form
    {
        private bool AdminRights = false;
        private bool DK = false;
        private bool SE = false;
        private bool DE = false;
        private string CountryStart = "DK";
        public MedBatch(bool DK,bool SE,bool DE,bool AdminRights)
        {
            this.DK = DK;
            this.SE = SE;
            this.DE = DE;
            if (DE)
                CountryStart = "DE";
            if (SE)
                CountryStart = "SE";
            this.AdminRights = AdminRights;
            this.Load += new System.EventHandler(this.Form1_Load);
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, System.EventArgs e)
        {
            if (DE)
            {
                lbl_BatchID.Text = "Batch";
                lbl_ContentL.Text = "Size";
                lbl_Article.Text = "Article";
                lb_Nordic.Text = "PZN";
                while (cbBatch.Items.Count > 6)
                {
                    cbBatch.Items.RemoveAt(4);
                }
                cbBatch.Items.RemoveAt(5);
                if (cbContent.Items.Count > 3)
                {
                    cbContent.Items.RemoveAt(3);
                    cbContent.Items.RemoveAt(1);
                }


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
                if (cbBatch.SelectedIndex == 4 && !DE) //Cryo <35L 
                    Expire = Expire.AddDays(21);
                if (cbBatch.SelectedIndex == 4 && DE) //Tysk Luft
                    Expire = Expire.AddYears(5);
                if (cbBatch.SelectedIndex == 5) //Cryo O2 >=35L < 2000L
                    Expire = Expire.AddDays(49);
                if (cbBatch.SelectedIndex == 6) //Pharmaline
                    Expire = Expire.AddYears(3);
                if (cbBatch.SelectedIndex == 7) //Latox
                    Expire = Expire.AddYears(5);
                if (cbBatch.SelectedIndex == 8) //Luft
                    Expire = Expire.AddYears(5);
                if (cbBatch.SelectedIndex == 9) //Udleveringstilladelse
                    Expire = Expire.AddYears(3);

                string dato = Today.ToString("dd.MM.yyyy");
                if (false)
                    printme = "NASC 1252:PP " + (40 + adjustX) + ",80:FT \"Swiss 721 Bold BT\",10:PT \"Exp:" + Expire.ToString("dd.MM.yyyy") + "\":PP " + (40 + adjustX) + ",40:FT \"Swiss 721 Bold BT\",10:PT \"Batch: " + tbBatchID.Text + "\":PF";
                else
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
                if (false)
                    printme = "NASC 1252:PP " + (104 + adjustX) + ",1:FT \"Swiss 721 Bold BT\",8:PT \"Dokumentation\":PP " + (40 + adjustX) + ",80:FT \"Swiss 721 Bold BT\",10:PT \"Exp:" + Expire.ToString("dd.MM.yyyy") + "\":PP " + (40 + adjustX) + ",40:FT \"Swiss 721 Bold BT\",10:PT \"Batch: " + tbBatchID.Text + "\":PF";
                else
                    printme = "NASC 1252:PP " + (104 + adjustX) + ",1:FT \"Swiss 721 BT\",8:PT \"Dokumentation\":PP "+(40+adjustX)+",20:FT \"Swiss 721 BT\",12:PT \"Date: " + dato + "\":PP "+(40+adjustX)+",116:PM \"GLASS.PCX\":PP "+(58+adjustX)+",111:FT \"Swiss 721 BT\",8:PT \"EXP:" + Expire.Day.ToString() + "." + Expire.Month.ToString() + "." + Expire.Year.ToString() + "\":PP "+(40+adjustX)+",60:FT \"Swiss 721 BT\",12:PT \"Batch_id: " + tbBatchID.Text + "\":PF";
                printme = printme + " " + copies2.ToString();
                x.WriteLine(printme);

                if (false)
                    printme = "NASC 1252:PP " + (adjustX + 40) + ",36:FT \"Swiss 721 Bold BT\",10:PT \"Date: " + Today.ToString("dd-MM-yyyy") + "\":PP " + (adjustX + 40) + ",111:FT \"Swiss 721 Bold BT\",12:PT \"DOKUMENTATION\":PP " + (adjustX + 40) + ",74:FT \"Swiss 721 Bold BT\",10:PT \"Batch_id: " + tbBatchID.Text + "\":PP " + (adjustX + 40) + ",2:FT \"Swiss 721 Bold BT\",10:PT \"Etiketter: " + cbBatchLabel.Text + " + " + cbDoc.Text + "\":PF";
                else
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
            tb_Nordic.Text = "";
            string content = "";
            if (DE)
            {
                content = "0";
                if (cbContent.SelectedIndex == 1)
                    content = "2";
                if (cbContent.SelectedIndex == 2)
                    content = "4";
            }
            else 
            {
                content = cbContent.SelectedIndex.ToString();
            }
            string MySQLString = "SELECT DISTINCT Size FROM ArticleList WHERE Type=" + content + " AND " + CountryStart + "=1 ORDER BY Size";
            SqlDataReader MyReader = ReadSQL(MySQLString);
            if (MyReader!=null)
            {
                while (MyReader.Read())
                {
                    cbLiters.Items.Add(MyReader["Size"].ToString().Replace(",", ".") + "L");
                }
                MyReader.Close();
            }
            
            
        }
              

        private void PrintContent(object sender, EventArgs e)
        {
            string Liters = "Indhold: ";
            string Company = "SAS: ";
            string Vnr = "Vnr ";
            if (SE)
            {
                Liters = "Innehåll: ";
                Company = "SAB: ";
            }
            if (DE)
            {
                Liters = "Inhalt: ";
                Company = "Artikel: ";
                Vnr = "PZN ";
            }

            if (cbContent.Text != "" && cbLiters.Text != "" && cbArticle.Text != "")
            {
                string prn = SetPrinter();
                float adjust = Single.Parse(ContentAdjustY.Text) * 8;
                float adjustX = Single.Parse(ContentAdjustX.Text) * 8;
                
                string printme = "NASC 1252:PP " + (1 + adjustX) + ",26:FT \"Swiss 721 Bold BT\",12:PT \""+ Vnr + tb_Nordic.Text + "\":PP " + (1 + adjustX) + ",60:FT \"Swiss 721 Bold BT\",9:PT \"" + Liters + cbLiters.Text + "\":PP " + (1 + adjustX) + ",1:FT \"Swiss 721 Bold BT\",9:PT \"" + Company + cbArticle.Text + "\":PF";

                float copies = Single.Parse(cbEtiketter.Text);
                string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
                StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
                w.WriteLine("SETUP \"FEEDADJ,STARTADJ," + (adjust - 88) + "\"");
                w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,WIDTH,296\"");
                w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,LENGTH,136\"");
                printme = printme + " " + copies.ToString();

                w.WriteLine(printme);

                w.Close();
                if (Content_Chkbox.Checked)
                    File.Move(tmploc, "\\\\SRV-DIV-03\\PD41Indh");
                else
                    File.Move(tmploc, prn);
                
                
            }
            else
            {
                MessageBox.Show("Fejl i indholdsetiket!\nDu skal vælge type, størrelse samt artikel", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        
        private string SetPrinter()
        {
            string prn = "LPT1";

            if (rbPrnMed.Checked)
                prn = "\\\\SRV-DIV-03\\PD41Med";
            if (rbPrnTek.Checked)
                prn = "\\\\SRV-DIV-03\\PD41Tek";
            if (rbPrnTest.Checked)
                prn = "\\\\SRV-DIV-03\\PD41Test";
            if (rbPrnLju.Checked)
                prn = "\\\\SRV-DIV-03\\PD41Lju";


            return prn;
        }

        private void BatchChanged(object sender, EventArgs e)
        {
            tbBatchID.Text = "";
            tbBatchID.MaxLength = 5;
            if (cbBatch.Text == "N2O flasker")
            {
                tbBatchID.MaxLength = 9;
                
            }
            if (cbBatch.Text == "Pharmaline" || cbBatch.SelectedIndex == 9 || cbBatch.SelectedIndex < 3)
            {
                tbBatchID.MaxLength = 8;
               
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
            cbArticle.Items.Clear();
            cbArticle.Text = "";
            cbArticle.Enabled = true;
            tb_Nordic.Text = "";
            string content = "";
            if (DE)
            {
                content = "0";
                if (cbContent.SelectedIndex == 1)
                    content = "2";
                if (cbContent.SelectedIndex == 2)
                    content = "4";
            }
            else
            {
                content = cbContent.SelectedIndex.ToString();
            }
            string MySQLString = "SELECT DISTINCT ArticleNo FROM ArticleList WHERE Type=" + content + " AND Size='" + cbLiters.Text.Replace("L", "") + "' AND " + CountryStart + "=1";
            SqlDataReader MyReader = ReadSQL(MySQLString);
            if (MyReader != null)
            {
                while (MyReader.Read())
                {
                    cbArticle.Items.Add(MyReader["ArticleNo"].ToString());
                }
                MyReader.Close();
            }
           
            
        }

        private void MedBatch_Load(object sender, EventArgs e)
        {
            
            
        }

        private SqlDataReader ReadSQL(string SQLCommand)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SRV-SQL-06;Initial Catalog=BatchPrint;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string mySQL = SQLCommand;
                SqlCommand cmd = new SqlCommand(mySQL, conn);
                rdr = cmd.ExecuteReader();
                return rdr;

            }
            catch (SqlException msg)
            {
                MessageBox.Show(msg.Message);
                return rdr;
            }
        }

        private void ArticleChosen(object sender, EventArgs e)
        {
            if (DE)
            {
                string content = "0";
                if (cbContent.SelectedIndex == 1)
                    content = "2";
                if (cbContent.SelectedIndex == 2)
                    content = "4";
                string MySQLString = "SELECT DISTINCT pzn FROM ArticleList WHERE Type=" + content + " AND Size=" + cbLiters.Text.Replace("L", "") + " AND ArticleNo='" + cbArticle.Text + "'" + " AND " + CountryStart + "=1";
                SqlDataReader MyReader = ReadSQL(MySQLString);
                if (MyReader != null)
                {
                    while (MyReader.Read())
                    {
                        int Temp = Convert.ToInt32(MyReader["pzn"].ToString());
                        tb_Nordic.Text = Temp.ToString("00000000");

                    }
                    MyReader.Close();
                }
            }
            else
            {
                string MySQLString = "SELECT DISTINCT Vnr FROM ArticleList WHERE Type=" + cbContent.SelectedIndex.ToString() + " AND Size=" + cbLiters.Text.Replace("L", "") + " AND ArticleNo='" + cbArticle.Text + "'" + " AND " + CountryStart + "=1";
                SqlDataReader MyReader = ReadSQL(MySQLString);
                if (MyReader != null)
                {
                    while (MyReader.Read())
                    {
                        int Temp = Convert.ToInt32(MyReader["Vnr"].ToString());
                        tb_Nordic.Text = Temp.ToString("00 00 00");
                        
                    }
                    MyReader.Close();
                }
            }
            

        }

        

    }
}