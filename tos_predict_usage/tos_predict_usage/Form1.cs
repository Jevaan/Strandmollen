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

namespace tos_predict_usage
{
    public partial class Form1 : Form
    {
        private string SQLConn;
        bool firstDate;
        double LastValue;
        DateTime StartDate;
        double TotalUsage;
        double TankContent;
        public Form1()
        {
            InitializeComponent();
            SQLConn = tos_predict_usage.Properties.Settings.Default.SQL_Tank;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(SQLConn))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT Company, Customernumber, Tanknumber, LastValue FROM TankStamData ORDER BY Customernumber", con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Tanks_listbox.Items.Add((reader[0].ToString() + "-" + reader[1].ToString() + "-" + reader[2].ToString()+ "-"+ reader[3].ToString()));
                        
                    }
                }
                con.Close();
            }

        }
        private void EmptyData()
        {
            Prediction_label.Text = "Indhold til ?? dage.";
            TotalUsage_label.Text = "Totalt forbrug:";
            Days_label.Text = "Antal dage:";
            AvgUse_label.Text = "Gennemsnitligt forbrug: ??";
        }

        private void Tank_Picked(object sender, EventArgs e)
        {
            EmptyData();
            firstDate = true;
            TotalUsage = 0;
            string[] TankIndex = Tanks_listbox.SelectedItem.ToString().Split('-');
            string WhereString = " Company = '" + TankIndex[0] + "' AND Customernumber = '"+ TankIndex[1] + "' AND Tanknumber ='" + TankIndex[2] + "'";
            try
            {
                TankContent = Convert.ToDouble(TankIndex[3]);
            }
            catch
            {
                TankContent = 1;
            }
            Content_label.Text = "Indhold: " + TankContent.ToString("##.#");
            using (SqlConnection con = new SqlConnection(SQLConn))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT Max(Value),DATEADD(DD,0,DATEDIFF(dd, 0, DateTime)) FROM tank.dbo.History WHERE"+WhereString +"AND Value > 0 GROUP BY DATEADD(DD,0,DATEDIFF(dd, 0, DateTime)) ORDER BY DATEADD(DD,0,DATEDIFF(dd, 0, DateTime))",con))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        CalcTotal(Convert.ToDateTime(reader[1].ToString()), Convert.ToDouble(reader[0].ToString()));
                    }
                }
                con.Close();
            }

        }

        private void CalcTotal(DateTime TimeStamp, double Value)
        {

            if (firstDate)
            {
                StartDate = TimeStamp;
                LastValue = Value;
                firstDate = false;

            }
            else
            {
                if (LastValue*1.1 > Value)
                {
                    TotalUsage += LastValue - Value;
                }
                LastValue = Value;
                Days_label.Text = "Antal dage: " + (TimeStamp - StartDate).TotalDays.ToString();
                TotalUsage_label.Text = "Totalforbrug: " + TotalUsage.ToString("##");
                AvgUse_label.Text = "Dagligt forbrug: " + (TotalUsage / (TimeStamp - StartDate).TotalDays).ToString("##.#");
                Prediction_label.Text = "Indhold til " + (TankContent/(TotalUsage / (TimeStamp - StartDate).TotalDays)).ToString("##") + " dage.";
            }
            
        }
    }
}
