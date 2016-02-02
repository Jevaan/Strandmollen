using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Export_CE
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            bool records = false;
            string sql, sql2;
            if (ExportAll.Checked)
            {
                sql = "SELECT * FROM BottleRegistred";
                sql2 = "SELECT * FROM Battery";
            }
            else
            {
                sql = "SELECT * FROM BottleRegistred WHERE Exported = 0";
                sql2 = "SELECT * FROM Battery WHERE Exported = 0";
            }

            SqlCeConnection Myconnection = null;
            SqlCeConnection Myconnection2 = null;
            SqlCeConnection Myconnection3 = null;
            SqlCeDataReader dbReader = null;
            SqlCeDataReader dbReader3 = null;


            Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection.Open();
            Myconnection3 = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection3.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = sql;
            dbReader = cmd.ExecuteReader();

            SqlCeCommand cmd3 = Myconnection3.CreateCommand();
            cmd3.CommandText = sql2;
            dbReader3 = cmd3.ExecuteReader();

            string tmp;
            string tmp2 = "0";
            string tmp4;
            float tmp3 = 0;
            Myconnection2 = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection2.Open();
            if (System.IO.File.Exists(@"\My Documents\FlaskeData\ManuelAxa.txt"))
                System.IO.File.Delete(@"\My Documents\FlaskeData\ManuelAxa.txt");
                
            System.IO.FileStream fs = new System.IO.FileStream(@"\My Documents\FlaskeData\ManuelAxa.txt",System.IO.FileMode.Create);
            System.IO.StreamWriter st = new System.IO.StreamWriter(fs);
            
            while (dbReader.Read())
            {
                if (dbReader.GetString(1) == "Flaske")
                    tmp2 = "1";
                if (dbReader.GetString(1) == "Batteri")
                    tmp2 = "2";
                if (dbReader.GetString(1) == "Container")
                    tmp2 = "3";
                if (dbReader.IsDBNull(12))
                    tmp4 = "";
                else
                    tmp4 = dbReader.GetString(12);

                tmp3 = Single.Parse(dbReader.GetString(2));
                tmp3 = (tmp3 * 10);
                
                tmp = tmp2 + ",\"" + tmp3.ToString("0000") + "\",\"" + dbReader.GetString(3) + "\",\"" + dbReader.GetDateTime(4).ToShortDateString() + "\",\"" + dbReader.GetString(0) + "\",\"" + dbReader.GetString(5) + "\",\"" + dbReader.GetString(6) + "\",\"" + dbReader.GetString(7) + "\",\"" + dbReader.GetDateTime(8).ToShortDateString() + "\",\"" + dbReader.GetString(9) + "\",\"" + tmp4 + "\"";

                st.WriteLine(tmp);
                records = true;

             }
            char char1 = '.';
            char char2 = '/';
             while (dbReader3.Read())
             {
                 tmp = "2,\"" + dbReader3["Bottles"] + dbReader3["BottleSize"] + "0\",\"" + dbReader3["SINumber"] + "\",\"01/" + dbReader3["Testdate"].ToString().Replace(char1, char2) + "\",\"" + dbReader3["Barcode"] + "\",\" \",\"" + dbReader3["Gas"] + "\",\" \",\" \",\"" + dbReader3["Testpressure"] + "\",\"\"";
                 st.WriteLine(tmp);
             }



            
            dbReader.Close();

            st.Close();
            fs.Close();
            
            dbReader.Close();
            Myconnection.Close();
            
            if (records)
            {
                string sql4 = "UPDATE BottleRegistred SET Exported = 1";
                //Myconnection = new OleDbConnection (@"Provider=Microsoft.Jet.OLEDB.4.0; User Id=Admin; Password=; Data Source=flreg.mdb"); 
                //Myconnection.Open();

                SqlCeCommand cmd2 = Myconnection2.CreateCommand();

                cmd2.CommandText = sql4;
                dbReader = cmd2.ExecuteReader();
                dbReader.Close();
            }
            
            Myconnection2.Close();
        }

    }
}