using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Net;
//using System.Net.Sockets;
using System.Data.SqlServerCe;
using CE_Network.local.strandmollen.barcode;
using Intermec.DataCollection;


namespace CE_Network
{
    public partial class Form1 : Form
    {
        //private Symbol.Barcode.Reader MyReader = null;
        //private Symbol.Barcode.ReaderData MyReaderData = null;
        //private System.EventHandler MyEventHandler = null;
        public static bool ReqItem;
        public static string BarcodePrint;
        public static string BatteryPrint;
        public static int copies;
        public bool Connected;
        public bool Printed;
        public bool LastState;
        public DataSet ds;
        public DataSet RePrint;
        public string connStr = "Data Source=" + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)) + "\\Barcode.sdf; Password =''";
        public Form1()
        {
            InitializeComponent();
            Connected = false;
            Printed = false;
            LastState = false;
            ds = new DataSet();
            RePrint = new DataSet();
            
            
        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            PrepareDataSet();
            try
            {
                ds.ReadXml("Data.xml");
            }
            catch { }
            ReqItem = false;
            BarcodePrint = "";
            BatteryPrint = "";
            CE_Network.Setup SetupDialog = new CE_Network.Setup(sender);
            SetupDialog.ShowDialog();
            SetupClose();
            VariantComboBox.SelectedIndex = 0;
            for (int i = 0; i <= 10; i++)
            {
                PressureTestComboBox.Items.Add((DateTime.Now.Year+i).ToString());
            }
            
            
        }

        public void SetupClose()
        {
            ItemNumberTextBox.Enabled = ReqItem;  
        }

        private void Docked(object sender, EventArgs e)
        {
            DateTime CallTime = DateTime.ParseExact("28-10-2014 09:45:00", "dd-MM-yyyy HH:mm:ss", null);
            Print MyPrintDialog = new Print();
            MyPrintDialog.ShowDialog();
            // Init MyService to the Web Service
            bc MyService = new bc(); 
            SqlCeConnection Myconnection = null;
            SqlCeDataReader dbReader = null;
            Myconnection = new SqlCeConnection(connStr);
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = "SELECT LastUpdate FROM Setup";
            dbReader = cmd.ExecuteReader();
            
            if (dbReader.Read())
            {
                try
                {
                    CallTime = dbReader.GetDateTime(0);
                }
                catch
                {
                    MessageBox.Show("Fejl i dato");
                }
            }
            try
            {
                DataSet CentralList = MyService.StoreData(ds, copies, BarcodePrint, CallTime.ToUniversalTime());
                MessageBox.Show(CentralList.Tables[0].Rows.Count.ToString() + " stregkoder hentet");
                SyncDatabase(CentralList);
                
            }
            catch {
                MessageBox.Show("Kommunikations fejl");
            
            }
            try
            {
                CallTime = DateTime.Now;
                string LastSync = CallTime.AddHours(-3).ToString("MM/dd/yy HH:mm:ss");
                cmd.CommandText = "UPDATE Setup SET LastUpdate = '" + LastSync + "'";
                cmd.ExecuteNonQuery();
                FlushLocalData();
                Myconnection.Close();
                dbReader.Close();
                Myconnection = null;
                dbReader = null;
            }
            catch {
                MessageBox.Show("Fejl ved opdatering af data");
            }
            
            
        }

        private void FlushLocalData()
        {
            SqlCeConnection Myconnection = null;
            Myconnection = new SqlCeConnection(connStr);
            Myconnection.Open();
            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = "DELETE FROM Barcodes";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch { }
            Myconnection.Close();
            RePrint = ds.Copy();
            ds.Tables[0].Clear();

        }
        
        private void SetupClick(object sender, EventArgs e)
        {
            CE_Network.Setup SetupDialog = new CE_Network.Setup(sender);
            SetupDialog.ShowDialog();
            SetupClose();

        }

        private void MenuWithoutBarcodeClick(object sender, EventArgs e)
        {
            

        }

        private void menuWithBarcodeClick(object sender, EventArgs e)
        {
            

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckBottleWithoutBarcode())
            {
                string Barcode = CreateBarcode();
                SqlCeConnection Myconnection = null;
                SqlCeDataReader MyReader = null;
                
                Myconnection = new SqlCeConnection(connStr);
                Myconnection.Open();

                SqlCeCommand cmd = Myconnection.CreateCommand();
                cmd.CommandText = "SELECT Barcode FROM Registred WHERE Barcode = '" + Barcode + "'";
                MyReader = cmd.ExecuteReader();
                if (MyReader.Read())
                    MessageBox.Show(Barcode + " findes allerede!", "OBS!");
                
                cmd.CommandText = "INSERT INTO Barcodes (Barcode, Size, Number, Variant, Item, Test) VALUES ('" +
                    Barcode + "','" + BottleSizeConboBox.Text + "','" + BottleNumberTextBox.Text + "','" +
                    VariantComboBox.Text + "','" + ItemNumberTextBox.Text + "','" + PressureTestComboBox.Text + "'" +
                    ")";
                    try
                    {
                        ds.Tables[0].Rows.Add(Barcode, BottleSizeConboBox.Text, BottleNumberTextBox.Text, VariantComboBox.Text,ItemNumberTextBox.Text, PressureTestComboBox.Text, null);
                        cmd.ExecuteNonQuery();
                        
                    }
                    catch
                    {
                        MessageBox.Show("Fejl ved lagering af data", "Fejl!");
                    }

                
                Myconnection.Close();
                MyReader = null;
                Myconnection = null;
                
                BottleNumberTextBox.Text = "";
                PressureTestComboBox.Text = "";
            }
            

        }

        private bool CheckBottleWithoutBarcode()
        {
            bool Checked = true;
            if (BottleTypeComboBox.Text == "")
            {
                MessageBox.Show("Vælg Type");
                Checked = false;
            }
            if (BottleSizeConboBox.Text == "")
            {
                MessageBox.Show("Vælg Størrelse");
                Checked = false;
            }
            if (BottleNumberTextBox.Text == "")
            {
                MessageBox.Show("Indtast Nummer");
                Checked = false;
            }
            if (ItemNumberTextBox.Text == "" && ReqItem)
            {
                MessageBox.Show("Indtast Varenummer");
                Checked = false;
            }
            if (PressureTestComboBox.Text == "")
            {
                MessageBox.Show("Vælg Trykprøvning");
                Checked = false;
            }
            if (VariantComboBox.Text == "")
            {
                MessageBox.Show("Vælg Variant");
                Checked = false;
            }
            return Checked;
        }

        private string CreateBarcode()
        {
            string Barcode = "";
            if (BottleTypeComboBox.Text == "Egen Flaske" || BottleTypeComboBox.Text == "Batteriflaske")
                Barcode = "1";
            if (BottleTypeComboBox.Text == "Kryoflaske")
                Barcode = "7";
            if (BottleTypeComboBox.Text == "Fremmed Flaske")
                Barcode = "8";
            if (BottleTypeComboBox.Text == "Brugt Flaske")
                Barcode = "3";
            if (BottleTypeComboBox.Text == "Type 5")
                Barcode = "5";
            if (BottleTypeComboBox.Text == "Type 6")
                Barcode = "6";
            Barcode += String.Format("{0:00000}",(10*Double.Parse(BottleSizeConboBox.Text)));
            Barcode += String.Format("{0:0000000}", Double.Parse(BottleNumberTextBox.Text));
            return Barcode;
        }

        private void PrepareDataSet()
        {
            DataTable Barcode = new DataTable();
            Barcode.Columns.Add("Barcode", typeof(string));
            Barcode.Columns.Add("Size", typeof(string));
            Barcode.Columns.Add("Number", typeof(string));
            Barcode.Columns.Add("Variant", typeof(string));
            Barcode.Columns.Add("Item", typeof(string));
            Barcode.Columns.Add("Test", typeof(string));
            Barcode.Columns.Add("BatType", typeof(string));
            ds.Tables.Add(Barcode);
            //RePrint.Tables.Add(Barcode);
        }

        private void SyncDatabase(DataSet ds)
        {
            SqlCeConnection Myconnection = null;
            
            Myconnection = new SqlCeConnection(connStr);
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cmd.CommandText = "INSERT INTO Registred (Barcode) VALUES ('" + dr[0].ToString() + "')";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    //MessageBox.Show("Fejl ved lagering af data for " + dr[0].ToString(), "Fejl!");
                }
            }
            Myconnection.Close();
            
        }
     
        private void ProgramClose(object sender, CancelEventArgs e)
        {
            ds.WriteXml("Data.xml");
        }

        private void menuItemReprint_Click(object sender, EventArgs e)
        {

            bc MyService = new bc();
            if (MyService.RePrint(RePrint, copies, BarcodePrint))
                MessageBox.Show("Stregkoder bliver udskrevet...");
            else
                MessageBox.Show("Stregkoder bliver udskrevet...");

        }

        public void AddBarcode(string OldBarcode)
        {
            ds.Tables[0].Rows.Add(OldBarcode, "", "", "", "", "", null);
        }

        private void TesterButton_Click(object sender, EventArgs e)
        {
            BarcodeTest MyTester = new BarcodeTest(this);
            MyTester.ShowDialog();
        }

        private void CloseFlReg(object sender, EventArgs e)
        {
            /*try
            {
                if (bcr != null)
                    bcr.Dispose();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }*/
            Application.Exit();
            Close();

        }
    }

}