using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using OpenNETCF.Net.Ftp;
using Intermec.DataCollection;

namespace Flaskefyldning
{
    public partial class Form1 : Form
    {
        private BarcodeReader bcr;
        private StreamWriter csvFile;
        private bool ScanRunning;
        private string NetworkStorage;
        private string LastUserFilename;
        private int ScannedNo;
        private bool ValidArticle;
        private string Location;
        private string Variant;
        private string Correction;
        private string[] barcodes = new string[99];
        private int ExpireMonths;
        //private int ArrayCount = 0;
        public Form1()
        {
            
            InitializeComponent();
            Error_lbl.Visible = false;
            ValidArticle = false;
            Version_lbl.Text = "v. 1.1";
            Location = "30";
            Variant = "";
            start_btn.Enabled = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("\\Program Files\\Fyllning av flaska\\Data\\Config.txt", Encoding.UTF7))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split(':')[0].Trim() == "SRV") 
                        NetworkStorage = line.Split(':')[1].Trim();
                    if (line.Split(':')[0].Trim() == "LOC")
                        Location = line.Split(':')[1].Trim(); ;
                }
            }
            DoLoad();
            ScannedNo = 0;
            ScanRunning = false;
            CreateStorage();
            //CreateArticle();
           

           
          
        }

        public void DoLoad()
        {
            LoadForm testDialog = new LoadForm();

            //Show testDialog as a modal dialog and determine if DialogResult = OK.
            //testDialog.CenterForm();
            if (testDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                

            }
            else
            {
                
            }
            testDialog.Dispose();

        }
                
        void bcr_BarcodeRead(object sender, BarcodeReadEventArgs bre)
        {
            string BarcodeScanned = "";
            try
            {
                BarcodeScanned = bre.strDataBuffer;
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            if (BarcodeScanned.Replace("]C1", "") != "" && ScanRunning)
            {
                SaveLine(BarcodeScanned.Replace("]C1", ""), ExpireMonths);
                scanned_lbl.Text = ScannedNo.ToString() + "  flaskor scannade!";
            }
            if (BarcodeScanned != "" && !ScanRunning && ArticleNo_tb.Focused)
            {
                ArticleNo_tb.Text = BarcodeScanned;
            }
            if (BarcodeScanned != "" && !ScanRunning && batchno_text.Focused)
            {
                batchno_text.Text = BarcodeScanned;
            }

        }

        private void CreateStorage()
        {
            //List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("\\Program Files\\Fyllning av flaska\\Data\\Lager-sted.csv", Encoding.UTF7))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != "" && isNumeric(line.Split(';')[0].Replace("\"", "")))
                    {
                        if ( Location == line.Split(';')[0].Replace("\"", ""))
                            Location_tb.Text = line.Split(';')[0].Replace("\"", "") + " - " + line.Split(';')[1].Replace("\"", "");
                    }
                }
            }

        }

        private void CreateVariant(object sender, EventArgs e)
        {

            bool VariantFound = false;
            variant_combo.Items.Clear();
            //List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("\\Program Files\\Fyllning av flaska\\Data\\Variant.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != "" && ArticleNo_tb.Text == line.Split(';')[0].Replace("\"", ""))
                    {
                        variant_combo.Items.Add(line.Split(';')[1].Replace("\"", ""));
                        VariantFound = true;
                    }
                }
            }
            if (!VariantFound)
            {
                batchno_text.Enabled = false;
                variant_combo.Enabled = false;
                Amount_lbl.Visible = true;
                Amount_tb.Visible = true;
            }
            else
            {
                batchno_text.Enabled = true;
                variant_combo.Enabled = true;
                Amount_lbl.Visible = false;
                Amount_tb.Visible = false;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }
        private bool isNumeric(string CheckNo)
        {
            try
            {
                double checker = Convert.ToDouble(CheckNo);
                return true;
            }
            catch {
                return false;

            }
        }
               
        private void start_click(object sender, EventArgs e)
        {
            if (ValidArticle)
            {
                LastUserFilename = "\\Program Files\\Fyllning av flaska\\Batch\\" + Location + "_" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
                csvFile = new StreamWriter(LastUserFilename);
                Array.Clear(barcodes, 0, 99);
                if (Correction_chk.Checked)
                    Correction = ";1";
                else
                    Correction = ";0";
                ScannedNo = 0;
                List_btn.Visible = true;
                start_btn.Visible = false;
                stop_btn.Visible = true;
                ArticleNo_tb.Enabled = false;
                batchno_text.Enabled = false;
                productiondate_date.Enabled = false;
                variant_combo.Enabled = false;
                variant_combo.Text = Variant;
                scanned_lbl.Text = "0  flaskor scannade!";
                scanned_lbl.Visible = true;
                ScanRunning = true;
                Correction_chk.Enabled = false;
                barcode_lbl.Text = "";
                barcode_lbl.Visible = true;
            }
            else
                MessageBox.Show("Ogiltigt varunummer!");


           
        }

        private void stop_click(object sender, EventArgs e)
        {
            csvFile.Close();
            List_btn.Visible = false;
            barcode_lbl.Visible = false;
            start_btn.Visible = true;
            start_btn.Enabled = false;
            stop_btn.Visible = false;
            ArticleNo_tb.Enabled = true;
            batchno_text.Enabled = true;
            batchno_text.Text = "";
            productiondate_date.Enabled = true;
            variant_combo.Enabled = true;
            scanned_lbl.Visible = false;
            ScanRunning = false;
            Amount_lbl.Visible = false;
            Amount_tb.Visible = false;
            Correction_chk.Enabled = true;
            Correction_chk.Checked = false;
            Variant = "";
            if (!CopyFiles())
                MessageBox.Show("Ingen nätverksförbindelse.\nBatch överförs senare");
            /*if (!UpdateAXData())
                MessageBox.Show("Fel vid uppdatering av data");*/
            
        }

        /*private bool UpdateAXData()
        {
            try
            {

                File.Copy(NetworkStorage + "Data\\Vare.csv", "\\Program Files\\Fyllning av flaska\\Data\\Vare2.csv", true);
                File.Copy(NetworkStorage + "Data\\Variant.csv", "\\Program Files\\Fyllning av flaska\\Data\\Variant2.csv", true);
                File.Copy(NetworkStorage + "Data\\Lager-sted.csv", "\\Program Files\\Fyllning av flaska\\Data\\Lager-sted2.csv", true);

                //return true;
            }
            catch { return false; }
            if (File.Exists("\\Program Files\\Fyllning av flaska\\Data\\Vare2.csv"))
            {
                File.Copy("\\Program Files\\Fyllning av flaska\\Data\\Vare2.csv", "\\Program Files\\Fyllning av flaska\\Data\\Vare.csv", true);
                File.Delete("\\Program Files\\Fyllning av flaska\\Data\\Vare2.csv");
            }
            if (File.Exists("\\Program Files\\Fyllning av flaska\\Data\\Variant2.csv"))
            {
                File.Copy("\\Program Files\\Fyllning av flaska\\Data\\Variant2.csv", "\\Program Files\\Fyllning av flaska\\Data\\Variant.csv", true);
                File.Delete("\\Program Files\\Fyllning av flaska\\Data\\Variant2.csv");
            }
            if (File.Exists("\\Program Files\\Fyllning av flaska\\Data\\Lager-sted2.csv"))
            {
                File.Copy("\\Program Files\\Fyllning av flaska\\Data\\Lager-sted2.csv", "\\Program Files\\Fyllning av flaska\\Data\\Lager-sted.csv", true);
                File.Delete("\\Program Files\\Fyllning av flaska\\Data\\Lager-sted2.csv");
            }
            return true;

        }*/

        private bool CopyFiles()
        {
            try
            {
                
                int c = 0;
                DirectoryInfo di = new DirectoryInfo("\\Program Files\\Fyllning av flaska\\Batch\\");
                FileInfo[] rgFiles = di.GetFiles("*.csv");

                
                foreach (FileInfo fi in rgFiles)
                {
                    UploadFile(fi.FullName);
                    //File.Copy("\\Program Files\\Fyllning av flaska\\Batch\\" + fi.Name, NetworkStorage + fi.Name, true);
                    File.Delete("\\Program Files\\Fyllning av flaska\\Batch\\" + fi.Name);
                                       
                    c++;
                }

               
                MessageBox.Show(c.ToString() + " batch sänt.");
                return true;
            }
            catch { return false; }

        }
        
        private bool SaveLine(string barcode, int expire)
        {
            bool AlreadySaved = false;

            try
            {
                foreach (string StoredBC in barcodes)
                {
                    if (barcode == StoredBC)
                        AlreadySaved = true;
                }
                if (!AlreadySaved)
                {
                    barcode_lbl.Text = barcode;
                    barcodes[ScannedNo] = barcode;
                    ScannedNo++;
                    string formatedLine = ArticleNo_tb.Text.Trim() + ";" + batchno_text.Text.Trim() + ";" + productiondate_date.Text.Trim().Replace("-", "") + ";" + productiondate_date.Value.AddMonths(expire).ToString("yyyyMMdd") + ";" + Location_tb.Text.Split('-')[0].Trim() + ";" + variant_combo.Text.Trim() + ";" + barcode + ";1" + Correction;
                    csvFile.WriteLine(formatedLine);
                    return true;
                }
                return false;
            }
            catch
            {
                MessageBox.Show("Fel vid registrering", "Fel!");
                return false;
            }

        }

        private void TerminateProgram(object sender, EventArgs e)
        {
            try
            {
                if (bcr != null)
                    bcr.Dispose();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            Application.Exit();
            Close();
        }

        private void CheckArticle(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("\\Program Files\\Fyllning av flaska\\Data\\Vare.csv"))
            {
                start_btn.Enabled = false;
                ValidArticle = false;
                Error_lbl.Visible = true;
                int test = 0;
                string line;
                ExpireMonths = 12;
                if (ArticleNo_tb.TextLength > 3)
                {
                    while ((line = reader.ReadLine()) != null && test < 1658)
                    {
                        if (line != "" && line.Split(';')[0].Replace("\"", "") == ArticleNo_tb.Text)
                        {
                            Error_lbl.Visible = false;
                            ValidArticle = true;
                            ExpireMonths = Convert.ToInt32(line.Split(';')[2].Replace("\"", ""));
                            CreateVariant(sender, e);

                        }
                        test++;
                    }
                }
            }

        }

        private void ArticlePicked(object sender, EventArgs e)
        {
            Variant = variant_combo.Text;
            
        }

        private void DeleteSavedBarcodes(object sender, EventArgs e)
        {
            Array.Clear(barcodes, 0, 99);
            ScannedNo = 0;
            barcode_lbl.Text = "";
            scanned_lbl.Text = "0 flaskor scannade!";
            csvFile.Close();
            File.Delete(LastUserFilename);
            LastUserFilename = "\\Program Files\\Fyllning av flaska\\Batch\\" + Location + "_" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
            csvFile = new StreamWriter(LastUserFilename);

        }

        private void DisplayList(object sender, EventArgs e)
        {
            BarcodeList ListForm = new BarcodeList(barcodes);
            ListForm.ShowDialog();
        }

        private void ActivateBCR(object sender, EventArgs e)
        {
            try
            {
                bcr = new BarcodeReader("AllScanners");
                bcr.ScannerEnable = true;
                bcr.BarcodeRead += new BarcodeReadEventHandler(bcr_BarcodeRead);
                bcr.ThreadedRead(true);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
           
        }

        private void DeactivateBCR(object sender, EventArgs e)
        {
            try
            {
                if (bcr != null)
                {
                    bcr.ScannerEnable = false;
                    bcr.Dispose();
                    bcr = null;
                }
           
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void CheckVarAndBatch(object sender, EventArgs e)
        {
            if (variant_combo.Text != "" && batchno_text.Text != "" && batchno_text.TextLength > 0)
                start_btn.Enabled = true;
            else
                start_btn.Enabled = false;
        }

        private void Correction_lbl_ParentChanged(object sender, EventArgs e)
        {

        }

        private void CheckAmount(object sender, EventArgs e)
        {
            if (isNumeric(Amount_tb.Text))
            {
                Save_btn.Visible = true;
                start_btn.Visible = false;
            }
        }

        private void SaveClicked(object sender, EventArgs e)
        {
            Save_btn.Visible = false;
            
            batchno_text.Enabled = true;
            variant_combo.Enabled = true;
            start_btn.Visible = true;
            LastUserFilename = "\\Program Files\\Fyllning av flaska\\Batch\\" + Location + "_" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
            csvFile = new StreamWriter(LastUserFilename);
            string formatedLine = ArticleNo_tb.Text.Trim() + ";" + batchno_text.Text.Trim() + ";" + productiondate_date.Text.Trim().Replace("-", "") + ";;" + Location_tb.Text.Split('-')[0].Trim() + ";;;" + Amount_tb.Text.Trim() + ";0";
            csvFile.WriteLine(formatedLine);
            csvFile.Close();
            List_btn.Visible = false;
            barcode_lbl.Visible = false;
            start_btn.Visible = true;
            start_btn.Enabled = false;
            stop_btn.Visible = false;
            ArticleNo_tb.Enabled = true;
            batchno_text.Enabled = true;
            batchno_text.Text = "";
            productiondate_date.Enabled = true;
            variant_combo.Enabled = true;
            scanned_lbl.Visible = false;
            ScanRunning = false;
            Correction_chk.Enabled = true;
            Correction_chk.Checked = false;
            Variant = "";
            if (!CopyFiles())
                MessageBox.Show("Ingen nätverksförbindelse.\nBatch överförs senare");
            /*if (!UpdateAXData())
                MessageBox.Show("Fel vid uppdatering av data");*/
            ArticleNo_tb.Text = "";
            Amount_tb.Text = "";
            Amount_tb.Visible = false;
            Amount_lbl.Visible = false;

        }

        public static bool UploadFile(string filePathName)
        {
            string host = "ftp.strandmollen.dk";
            Uri uri = null;

            string fileName = Path.GetFileName(filePathName);
            
            uri = new Uri(string.Format(@"ftp://{0}/", host));
            

            try
            {

                FtpRequestCreator creator = new FtpRequestCreator();
                WebRequest.RegisterPrefix("ftp:", creator);
                FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(uri);
                ftpWebRequest.Credentials = new NetworkCredential("SvDepot", "SvDepot.2012");
                
                // Getting the Request stream
                Stream ftpRequestStream = ftpWebRequest.GetRequestStream();

                StreamReader responseReader = new StreamReader(ftpRequestStream);
                
                // Just ignore the result, but read it.
                String responseString = responseReader.ReadToEnd();


                // Open the input file.  If the file does not exist, it's an error.
                FileStream filestream = new FileStream(filePathName, FileMode.Open);

                // Create the reader for the local file data.
                BinaryReader fileReader = new BinaryReader(filestream);


                // Opening the data connection, this must be done before we issue the command.
                Stream ftpResponseStream = ftpWebRequest.GetResponse().GetResponseStream();
                BinaryWriter dataWriter = new BinaryWriter(ftpResponseStream);

                // Prepare to send commands to the server.
                StreamWriter commandWriter = new StreamWriter(ftpRequestStream);

                // Set transfer type to IMAGE (binary).
                commandWriter.Write("TYPE I\r\n");
                commandWriter.Flush();

                // Reading the request output
                responseReader = new StreamReader(ftpRequestStream);
                responseString = responseReader.ReadToEnd();
                

                // Write the command to the request stream.
                String cmd = "stor " + fileName + "\r\n";
                commandWriter.Write(cmd);
                commandWriter.Flush();	// We MUST flush before we start reading from both response and request

                // Reading the request output
                responseString = responseReader.ReadToEnd();

                // Allocate buffer for the data, which will be written in blocks.
                int bufsize = 1024;
                byte[] buf = new byte[bufsize];
                int xcount;

                while ((xcount = fileReader.Read(buf, 0, bufsize)) > 0)
                {
                    // Send next buffer over the data connection.
                    dataWriter.Write(buf, 0, xcount);
                }

                fileReader.Close();
                filestream.Close();

                dataWriter.Close();

                responseReader.Close();


                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}