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
        internal string _Location;
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
            Version_lbl.Text = "v. 2.2";
            _Location = "30";
            Variant = "";
            start_btn.Enabled = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("\\Program Files\\Flaskefyldning\\Data\\Config.txt", Encoding.UTF7))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split(':')[0].Trim() == "SRV")
                        NetworkStorage = line.Split(':')[1].Trim();
                }
            }
            
            DoLoad();
            ScannedNo = 0;
            ScanRunning = false;
    
        }

        public void DoLoad()
        {
            LoadForm testDialog = new LoadForm();
            testDialog.ShowDialog();
            storage_lbl.Text += " " + testDialog._Loc.Trim();
            Draft_label.Text += " " + testDialog._Draft.Trim();
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
                scanned_lbl.Text = ScannedNo.ToString() + " flasker scannet!";
            }
            if (BarcodeScanned != "" && !ScanRunning && ArticleNo_tb.Focused)
            {
                ArticleNo_tb.Text = BarcodeScanned;
            }
            

        }

        

        private void CreateVariant(object sender, EventArgs e)
        {

            bool VariantFound = false;
            variant_combo.Items.Clear();
            //List<string> list = new List<string>();
            using (StreamReader reader = new StreamReader("\\Program Files\\Flaskefyldning\\Data\\Variant.csv"))
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
                variant_combo.Enabled = false;
                Amount_lbl.Visible = true;
                Amount_tb.Visible = true;
            }
            else
            {
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
        internal bool isNumeric(string CheckNo)
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
                LastUserFilename = "\\Program Files\\Flaskefyldning\\Batch\\" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
                csvFile = new StreamWriter(LastUserFilename);
                Array.Clear(barcodes, 0, 99);
                Correction = ";0";
                ScannedNo = 0;
                List_btn.Visible = true;
                start_btn.Visible = false;
                stop_btn.Visible = true;
                ArticleNo_tb.Enabled = false;
                variant_combo.Enabled = false;
                variant_combo.Text = Variant;
                scanned_lbl.Text = "0 flasker indscannet!";
                scanned_lbl.Visible = true;
                ScanRunning = true;
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
            variant_combo.Enabled = true;
            scanned_lbl.Visible = false;
            ScanRunning = false;
            Amount_lbl.Visible = false;
            Amount_tb.Visible = false;
            Variant = "";
            if (!CopyFiles())
                MessageBox.Show("Ingen netværksforbindelse.\nBatch overføres senere");
            if (!UpdateAXData())
                MessageBox.Show("Fejl ved opdatering af stamdata");
            
        }

        private bool UpdateAXData()
        {
            try
            {

                File.Copy(NetworkStorage + "Data\\Vare.csv", "\\Program Files\\flaskefyldning\\Data\\Vare2.csv", true);
                File.Copy(NetworkStorage + "Data\\Variant.csv", "\\Program Files\\flaskefyldning\\Data\\Variant2.csv", true);
                File.Copy(NetworkStorage + "Data\\Lager-sted.csv", "\\Program Files\\flaskefyldning\\Data\\Lager-sted2.csv", true);

                //return true;
            }
            catch { return false; }
            if (File.Exists("\\Program Files\\flaskefyldning\\Data\\Vare2.csv"))
            {
                File.Copy("\\Program Files\\flaskefyldning\\Data\\Vare2.csv", "\\Program Files\\flaskefyldning\\Data\\Vare.csv", true);
                File.Delete("\\Program Files\\flaskefyldning\\Data\\Vare2.csv");
            }
            if (File.Exists("\\Program Files\\flaskefyldning\\Data\\Variant2.csv"))
            {
                File.Copy("\\Program Files\\flaskefyldning\\Data\\Variant2.csv", "\\Program Files\\flaskefyldning\\Data\\Variant.csv", true);
                File.Delete("\\Program Files\\flaskefyldning\\Data\\Variant2.csv");
            }
            if (File.Exists("\\Program Files\\flaskefyldning\\Data\\Lager-sted2.csv"))
            {
                File.Copy("\\Program Files\\flaskefyldning\\Data\\Lager-sted2.csv", "\\Program Files\\flaskefyldning\\Data\\Lager-sted.csv", true);
                File.Delete("\\Program Files\\flaskefyldning\\Data\\Lager-sted2.csv");
            }
            return true;

        }

        private bool CopyFiles()
        {
           
            try
            {
                
                int c = 0;
                DirectoryInfo di = new DirectoryInfo("\\Program Files\\flaskefyldning\\Batch\\");
                FileInfo[] rgFiles = di.GetFiles("*.csv");
                foreach (FileInfo fi in rgFiles)
                {
                    File.Copy("\\Program Files\\flaskefyldning\\Batch\\" + fi.Name, NetworkStorage + fi.Name, true);
                    File.Delete("\\Program Files\\flaskefyldning\\Batch\\" + fi.Name);
                    //MessageBox.Show(fi.Name);
                   
                    c++;
                }
                         
                
                MessageBox.Show(c.ToString() + " batch sendt.");
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
                    string formatedLine = Draft_label.Text.Split(' ')[1].Trim() + ";" + ArticleNo_tb.Text.Trim() + ";;;;" + storage_lbl.Text.Split(' ')[1].Trim() + ";" + variant_combo.Text.Trim() + ";" + barcode + ";1;" + Correction;
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
            using (StreamReader reader = new StreamReader("\\Program Files\\Flaskefyldning\\Data\\Vare.csv"))
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
            scanned_lbl.Text = "0 flasker indscannet!";
            csvFile.Close();
            File.Delete(LastUserFilename);
            LastUserFilename = "\\Program Files\\Flaskefyldning\\Batch\\" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
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
            { /*
                bcr = new BarcodeReader("AllScanners");
                bcr.ScannerEnable = true;
                bcr.BarcodeRead += new BarcodeReadEventHandler(bcr_BarcodeRead);
                bcr.ThreadedRead(true);*/

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
            if (variant_combo.Text != "")
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
            
            variant_combo.Enabled = true;
            start_btn.Visible = true;
            LastUserFilename = "\\Program Files\\Flaskefyldning\\Batch\\" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
            csvFile = new StreamWriter(LastUserFilename);
            string formatedLine = Draft_label.Text.Split(' ')[1].Trim() + ";" + ArticleNo_tb.Text.Trim() + ";;;;" + storage_lbl.Text.Split('-')[0].Trim() + ";;;" + Amount_tb.Text.Trim() + ";0";
            csvFile.WriteLine(formatedLine);
            csvFile.Close();
            List_btn.Visible = false;
            barcode_lbl.Visible = false;
            start_btn.Visible = true;
            start_btn.Enabled = false;
            stop_btn.Visible = false;
            ArticleNo_tb.Enabled = true;
            variant_combo.Enabled = true;
            scanned_lbl.Visible = false;
            ScanRunning = false;
            Variant = "";
            if (!CopyFiles())
                MessageBox.Show("Ingen netværksforbindelse.\nBatch overføres senere");
            if (!UpdateAXData())
                MessageBox.Show("Fejl ved opdatering af stamdata");
            ArticleNo_tb.Text = "";
            Amount_tb.Text = "";
            Amount_tb.Visible = false;
            Amount_lbl.Visible = false;

        }
    }
}