using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TruckWeight
{
    public partial class Form1 : Form
    {
        string ConnStr = @"Data Source=SRV-BKS-02;Initial Catalog=AMCS;User id=sa;Password=Wrc-04-Rally";
        public Form1()
        {
            InitializeComponent();
        }

        private void Get_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();

                string mySQL = "SELECT ID,TruckWeightStart,TruckWeightFinish FROM FillingRecord WHERE ID =" + ID_txt.Text;
                SqlCommand cmd = new SqlCommand(mySQL, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Start_txt.Text = rdr["TruckWeightStart"].ToString();
                    Stop_txt.Text = rdr["TruckWeightFinish"].ToString();
                    ID_txt.Enabled = false;
                    Save_btn.Enabled = true;
                }

                
            }
            
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConnStr))
            {
                conn.Open();

                string mySQL = "UPDATE FillingRecord SET TruckWeightStart = '" + Start_txt.Text + "', TruckWeightFinish='" + Stop_txt.Text + "' WHERE ID =" + ID_txt.Text;
                SqlCommand cmd = new SqlCommand(mySQL, conn);
                cmd.ExecuteNonQuery();
                ID_txt.Enabled = true;
                Save_btn.Enabled = false;
                Stop_txt.Text = "";
                Start_txt.Text = "";

            }
            
        }
    }
}
