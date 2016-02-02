using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace CE_Network
{
    public partial class Setup : Form
    {
        public string connStr = "Data Source=" + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)) + "\\Barcode.sdf; Password =''";
        public Setup(object Sender)
        {
            
            InitializeComponent();
        }

        private void SetupOK_Clicked(object sender, EventArgs e)
        {
            if (ItemCheckbox.Checked)
            {
                Form1.ReqItem = true;
            }
            else
            {
                Form1.ReqItem = false;
            }
            Form1.BarcodePrint = BarcodePrinterComboBox.Text;
            Form1.BatteryPrint = BatteryPrinterComboBox.Text;
            
            
            this.Close();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            
            ReadSetup();
            string path = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)) + "\\printers.txt";
            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    string tmp;
                    while (sr.Peek() >= 0)
                    {
                        tmp = sr.ReadLine();
                        if (!tmp.StartsWith("#"))
                            BarcodePrinterComboBox.Items.Add(tmp);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The process failed: {0}", ex.ToString());
            }
            /*if (Form1.ReqItem)
                ItemCheckbox.Checked = true;*/
        }

        private bool ReadSetup()
        {
            SqlCeConnection Myconnection = null;
            SqlCeDataReader dbReader = null;
            
            Myconnection = new SqlCeConnection( connStr );
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();

            cmd.CommandText = "SELECT * FROM Setup";
            dbReader = cmd.ExecuteReader();
            
            if (dbReader.Read())
            {
                if (dbReader.GetString(0) == "False")
                    ItemCheckbox.Checked = false;
                else
                    ItemCheckbox.Checked = true;
                
                BarcodePrinterComboBox.Text = dbReader.GetString(1);
                BatteryPrinterComboBox.Text = dbReader.GetString(2);
                Myconnection.Close();
                return true;
                
            }
            Myconnection.Close();
            return false;
 
        }

        private void SetupClosing(object sender, CancelEventArgs e)
        {
            SqlCeConnection Myconnection = null;
            
            Myconnection = new SqlCeConnection(connStr);
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();

            cmd.CommandText = "UPDATE Setup SET ItemRequired = '" + ItemCheckbox.Checked.ToString() + "', BarcodePrinter = '" + BarcodePrinterComboBox.Text + "', BatteryPrinter = '" + BatteryPrinterComboBox.Text + "'";
            cmd.ExecuteNonQuery();

        }
    }
}