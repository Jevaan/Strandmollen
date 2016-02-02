using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace DeviceApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Luk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fejl_Click(object sender, EventArgs e)
        {
            bool indok = false;
            string fejlnummer = "10000000000000";
            if (Stregkode.TextLength == 13)
            {
                indok = true;
                fejlnummer = Stregkode.Text;
            }
            if (Storrelse.TextLength > 0 & Nummer.TextLength > 0)
            {
                indok = true;
                fejlnummer = "1";
                if (chkKryo.Checked)
                    fejlnummer = "4";
                if (chkByt.Checked)
                    fejlnummer = "8";
                if (chkSalg.Checked)
                    fejlnummer = "9";

                double flstr = 10 * double.Parse(Storrelse.Text.Replace(".", ","));
                if (flstr < 10000)
                    fejlnummer = fejlnummer + "0";
                if (flstr < 1000)
                    fejlnummer = fejlnummer + "0";
                if (flstr < 100)
                    fejlnummer = fejlnummer + "0";
                if (flstr < 10)
                    fejlnummer = fejlnummer + "0";

                fejlnummer = fejlnummer + flstr.ToString();

                float flnr = Single.Parse(Nummer.Text);
                if (flnr < 1000000)
                    fejlnummer = fejlnummer + "0";
                if (flnr < 100000)
                    fejlnummer = fejlnummer + "0";
                if (flnr < 10000)
                    fejlnummer = fejlnummer + "0";
                if (flnr < 1000)
                    fejlnummer = fejlnummer + "0";
                if (flnr < 100)
                    fejlnummer = fejlnummer + "0";
                if (flnr < 10)
                    fejlnummer = fejlnummer + "0";
                fejlnummer = fejlnummer + flnr.ToString();
            }
            if (indok)
            {
                MessageBox.Show("Nummer: " + fejlnummer);
                System.IO.FileStream fs = new System.IO.FileStream(@"\My Documents\Fejl" + fejlnummer + ".err", System.IO.FileMode.Create);
                System.IO.StreamWriter st = new System.IO.StreamWriter(fs);
                st.WriteLine("Fejl ved flaske: " + fejlnummer + " fjernet d." + DateTime.Now.ToShortDateString());
                st.Close();
                fs.Close();
                System.IO.File.Move(@"\My Documents\Fejl" + fejlnummer + ".err", @"\My Documents\FlaskeData\Fejl" + fejlnummer + ".err");

                SqlCeConnection Myconnection = null;
                SqlCeDataReader dbReader = null;
                
                string sql = "DELETE FROM BottleRegistred WHERE BottleBarcode = '" + fejlnummer + "'";
                
                Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
                Myconnection.Open();

                SqlCeCommand cmd = Myconnection.CreateCommand();
                cmd.CommandText = sql;
                dbReader = cmd.ExecuteReader();
                
                dbReader.Close();
                Myconnection.Close();
            }
            else
                MessageBox.Show("Fejl i indtastede oplysninger!");


        }

        private void btnBat_Click(object sender, EventArgs e)
        {
            SqlCeConnection Myconnection = null;
            SqlCeDataReader dbReader = null;

            string sql = "DELETE FROM BottleRegistred WHERE BatteryBottle = 1";

            Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = sql;
            dbReader = cmd.ExecuteReader();

            dbReader.Close();
            Myconnection.Close();

        }
    }
}