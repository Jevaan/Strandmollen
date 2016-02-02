using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Reset_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCeConnection Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection.Open();
            SqlCeCommand cmd = Myconnection.CreateCommand();
            
            SqlCeDataReader dbReader = null;

            cmd.CommandText = "DELETE BottleRegistred";
            dbReader = cmd.ExecuteReader();
            dbReader.Close();
        }
    }
}