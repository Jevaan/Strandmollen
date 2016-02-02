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
using Intermec.DataCollection;
using System.Net;
using Flaskefyldning.webservices;

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
        private string DataFolder;
        private string BatchFolder;
        private int ExpireMonths;
        private bool NoBRC_Test = false;
        private string dfvnr;
        private bool MDK = false;
        private string ForceConf = "0";
        public Form1()
        {
            
            InitializeComponent();
            Error_lbl.Visible = false;
            ValidArticle = false;
            Version_lbl.Text = "v. 3.2.6";
            Location = "30";
            Variant = "";
            start_btn.Enabled = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DataFolder = "\\Program Files\\flaskefyldning\\Data\\";
            BatchFolder = "\\Program Files\\flaskefyldning\\Batch\\";
            dfvnr = "";
            using (StreamReader reader = new StreamReader(DataFolder + "Config.txt", Encoding.UTF7))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split(':')[0].Trim() == "SRV") 
                        NetworkStorage = line.Split(':')[1].Trim();
                    if (line.Split(':')[0].Trim() == "LOC")
                        Location = line.Split(':')[1].Trim(); 
                    if (line.Split(':')[0].Trim() == "FORCE")
                        ForceConf = line.Split(':')[1].Trim();
                }
            }
            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostEntry(host);
            int IPNet = Convert.ToInt32((ip.AddressList[0].ToString().Split('.'))[2]);
            if (ip.AddressList[0].ToString().Split('.')[0] == "192" && ip.AddressList[0].ToString().Split('.')[1] == "168" && ForceConf == "0")
            {
                IPNet = Convert.ToInt32((ip.AddressList[0].ToString().Split('.'))[2]);
                switch (IPNet)
                {
                    case 1:
                        Location = "10";
                        break;
                    case 10:
                        Location = "10";
                        break;
                    case 4:
                        Location = "30";
                        break;
                    case 40:
                        Location = "30";
                        break;
                    case 14:
                        Location = "30";
                        NetworkStorage += @"MDK\";
                        break;
                    case 12:
                        Location = "30";
                        NetworkStorage += @"MDK\";
                        break;
                    case 11:
                        Location = "10";
                        NetworkStorage += @"MDK\";
                        break;

                }
            }
            try
            {
                if (ip.AddressList[1].ToString().Split('.')[0] == "192" && ip.AddressList[1].ToString().Split('.')[1] == "168" && ForceConf == "0")
                {
                    IPNet = Convert.ToInt32((ip.AddressList[1].ToString().Split('.'))[2]);
                    switch (IPNet)
                    {
                        case 1:
                            Location = "10";
                            break;
                        case 10:
                            Location = "10";
                            break;
                        case 4:
                            Location = "30";
                            break;
                        case 40:
                            Location = "30";
                            break;
                        case 14:
                            Location = "30";
                            NetworkStorage += @"MDK\";
                            break;
                        case 12:
                            Location = "30";
                            NetworkStorage += @"MDK\";
                            break;
                        case 11:
                            Location = "10";
                            NetworkStorage += @"MDK\";
                            break;

                    }
                }

            }
            catch { }
            if (NetworkStorage.ToUpper().Contains("MDK"))
                MDK = true;
            
            DoLoad();
            //UpdateAXData();
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
            if (!NoBRC_Test)
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
                    scanned_lbl.Text = ScannedNo.ToString() + " flasker scannet!";
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

        }

        private void CreateStorage()
        {
            //List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader(DataFolder + "Lager-sted.csv", Encoding.UTF7))
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
            using (StreamReader reader = new StreamReader(DataFolder + "Variant.csv"))
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
            if (!MDK)
            {
                if (!VariantFound)
                {
                    batchno_text.Enabled = false;
                    variant_combo.Enabled = false;
                    Amount_lbl.Visible = true;
                    Amount_tb.Visible = true;
                }
                else
                {
                    variant_combo.Text = dfvnr;
                    batchno_text.Enabled = true;
                    variant_combo.Enabled = true;
                    Amount_lbl.Visible = false;
                    Amount_tb.Visible = false;
                }
            }
            if (MDK)
            {
                if (!VariantFound)
                {
                    batchno_text.Enabled = false;
                    variant_combo.Enabled = false;
                    Amount_lbl.Visible = false;
                    Amount_tb.Visible = false;
                    start_btn.Enabled = true;
                }
                else
                {
                    variant_combo.Text = dfvnr;
                    batchno_text.Enabled = true;
                    variant_combo.Enabled = true;
                    Amount_lbl.Visible = false;
                    Amount_tb.Visible = false;
                }
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
                LastUserFilename = BatchFolder + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
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
                scanned_lbl.Text = "0 flasker indscannet!";
                scanned_lbl.Visible = true;
                ScanRunning = true;
                Correction_chk.Enabled = false;
                barcode_lbl.Text = "";
                barcode_lbl.Visible = true;
            }
            else
                MessageBox.Show("Ugyldigt Varenummer!");


           
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
                MessageBox.Show("Ingen netværksforbindelse.\nBatch overføres senere");
            
            
        }

        private bool UpdateAXData()
        {
            SaveFile("Vare.csv", DataFolder, NetworkStorage + @"Data\");
            SaveFile("Variant.csv", DataFolder, NetworkStorage + @"Data\");
            SaveFile("Lager-sted.csv", DataFolder, NetworkStorage + @"Data\");
            return true;

        }

        private bool SaveFile(string name,string to,string from)
        {

            webservices.Service1 ReadFile = new Flaskefyldning.webservices.Service1();

            ArticleFile GetFile = ReadFile.StringReader(name, from);

            using (StreamWriter writer = new StreamWriter(to + name + "x", true))
            {
                int i = 0;
                while (i < GetFile.AllLines.Count())
                {
                    writer.WriteLine(GetFile.AllLines[i]);
                    i++;
                }
                
            }
            if (File.Exists(DataFolder + name + "x"))
            {
                if (File.Exists(DataFolder + name))
                    File.Delete(DataFolder + name);
                File.Copy(DataFolder + name + "x", DataFolder + name);
                File.Delete(DataFolder + name + "x");
            }


            return true;

        }

        private bool CopyFiles()
        {
           
            try
            {
                
                int c = 0;
                DirectoryInfo di = new DirectoryInfo(BatchFolder);
                FileInfo[] rgFiles = di.GetFiles("*.csv");
                foreach (FileInfo fi in rgFiles)
                {
                    webservices.Service1 StoreFile = new Flaskefyldning.webservices.Service1();
                    using (StreamReader reader = new StreamReader(BatchFolder + fi.Name, Encoding.UTF7))
                    {
                        bool AlreadySaved = false;
                        int LineCount = 0;
                        string[] SavedLines = new string[99];
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            foreach (string SavedLine in SavedLines)
                            {
                                if (line == SavedLine)
                                    AlreadySaved = true;
                            }
                            if (!AlreadySaved)
                            {
                                SavedLines[LineCount] = line;
                                LineCount++;
                                StoreFile.StringWriter(line, fi.Name, NetworkStorage);
                            }
                        }
                    }
                    File.Delete(BatchFolder + fi.Name);
                    c++;
                }
                         
                
                MessageBox.Show(c.ToString() + " batch sendt.");
                return true;
            }
            catch {
                return false; }

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
                MessageBox.Show("Fejl ved registrering", "Fejl!");
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
            using (StreamReader reader = new StreamReader(DataFolder + "Vare.csv"))
            {
                start_btn.Enabled = false;
                ValidArticle = false;
                Error_lbl.Visible = true;
                int test = 0;
                string line;
                ExpireMonths = 12;
                if (ArticleNo_tb.TextLength > 3)
                {
                    while ((line = reader.ReadLine()) != null) //&& test < 1858
                    {
                        if (line != "" && line.Split(';')[0].Replace("\"", "") == ArticleNo_tb.Text)
                        {
                            dfvnr = "";
                            try
                            {
                                dfvnr = line.Split(';')[6].Replace("\"", "");
                            }
                            catch
                            {
                            }
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
            try
            {
                Array.Clear(barcodes, 0, 99);
            }
            catch { MessageBox.Show("Der er intet at slette"); }
            ScannedNo = 0;
            barcode_lbl.Text = "";
            scanned_lbl.Text = "0 flasker indscannet!";
            try
            {
                csvFile.Close();
                File.Delete(LastUserFilename);
            }
            catch { MessageBox.Show("Der er intet at slette"); }
            LastUserFilename = BatchFolder + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
            csvFile = new StreamWriter(LastUserFilename);

        }

        private void DisplayList(object sender, EventArgs e)
        {
            BarcodeList ListForm = new BarcodeList(barcodes);
            ListForm.ShowDialog();
        }

        private void ActivateBCR(object sender, EventArgs e)
        {
            if (!NoBRC_Test)
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
           
        }

        private void DeactivateBCR(object sender, EventArgs e)
        {
            if (!NoBRC_Test)
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
            LastUserFilename = BatchFolder + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
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
                MessageBox.Show("Ingen netværksforbindelse.\nBatch overføres senere");
            ArticleNo_tb.Text = "";
            Amount_tb.Text = "";
            Amount_tb.Visible = false;
            Amount_lbl.Visible = false;

        }
    }
}