using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace FlaskeRegistreringCE
{
    public partial class Battery : Form
    {
        public Battery()
        {
            InitializeComponent();
        }

        private void Battery_Load(object sender, System.EventArgs e)
        {
            SqlCeConnection Myconnection = null;
            SqlCeDataReader dbReader = null;

            string sql = "SELECT BottleBarcode FROM BottleRegistred WHERE BatteryBottle = 1";
            
            Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = sql;
            dbReader = cmd.ExecuteReader();

            while (dbReader.Read())
                BatteryBox.Items.Add(dbReader.GetString(0));

            dbReader.Close();
            Myconnection.Close();
            
            BatteryCount.Text = BatteryBox.Items.Count.ToString() +
                " Flasker";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int GetBottles()
        {
            return BatteryBox.Items.Count;
        }
    }
}