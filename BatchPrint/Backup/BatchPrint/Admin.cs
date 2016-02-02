using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BatchPrint
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            UpdateArticleBox();
           
        }

        private void ResetInput()
        {
            Type_dropdown.Text = "Vælg type";
            Liters_textbox.Text = "";
            ArticleNo_textbox.Text = "";
            Vnr_textbox.Text = "";
            pzn_textbox.Text = "";
            DK_chk.Checked = false;
            SE_chk.Checked = false;
            DE_chk.Checked = false;
        }

        private void UpdateArticleBox()
        {
            Articles_box.Items.Clear();
            
            SqlConnection conn = new SqlConnection(@"Data Source=SRV-SQL-06;Initial Catalog=BatchPrint;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                string mySQL = "SELECT * FROM ArticleList ORDER BY ArticleNo";
                SqlCommand cmd = new SqlCommand(mySQL, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int Vnr = Convert.ToInt32(rdr["Vnr"].ToString());
                   // int pzn = Convert.ToInt32(rdr["pzn"].ToString());
                    string country = "";
                    if (rdr["DK"].ToString() == "1")
                        country += "DK ";
                    if (rdr["SE"].ToString() == "1")
                        country += "SE ";
                    if (rdr["DE"].ToString() == "1")
                        country += "DE ";
                    Articles_box.Items.Add(country + "- " + Vnr.ToString("00 00 00") + " - " + rdr["pzn"].ToString() + " - " + rdr["ArticleNo"].ToString());
                }
            }
            catch { }
            
        }
        
        private void AddVnr_btn_Click(object sender, EventArgs e)
        {
            if (!DK_chk.Checked && !SE_chk.Checked && !DE_chk.Checked)
            {
                MessageBox.Show("Vælg mindst et land","Fejl!");
            }
            else
            {
                string FormatedSQL = "INSERT INTO ArticleList (Vnr, ArticleNo, DK, SE, DE, Size, Type, pzn) VALUES";
                FormatedSQL += "(" + Vnr_textbox.Text.Replace(" ", "") + ", '" + ArticleNo_textbox.Text.Trim() + "', "
                        + Convert.ToInt32(DK_chk.Checked).ToString() + ", " + Convert.ToInt32(SE_chk.Checked).ToString()
                        + ", " + Convert.ToInt32(DE_chk.Checked).ToString() + ", '" + Liters_textbox.Text.Trim().Replace(",",".")
                        + "', " + Type_dropdown.SelectedIndex
                        + ", " + pzn_textbox.Text.Replace(" ", "") + ")";
                SqlConnection conn = new SqlConnection(@"Data Source=SRV-SQL-06;Initial Catalog=BatchPrint;Integrated Security=SSPI");

                DoSQLNoQ(FormatedSQL);
                
                ResetInput();
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            string Vnr;
            string Article;
            string[] Splitter = Articles_box.SelectedItem.ToString().Split('-');
            Vnr = Splitter[1].Trim().Replace(" ","");
            Article = Splitter[3].Trim();
            string FormatedSQL = "DELETE FROM ArticleList WHERE Vnr=" + Vnr + " AND ArticleNo='" + Article + "'";
            if (MessageBox.Show("Fjern varenummer " + Article+ "?", "Bekræft sletning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DoSQLNoQ(FormatedSQL);
            }
           
            
            
        }

        private void DoSQLNoQ(string SQLStr)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SRV-SQL-06;Initial Catalog=BatchPrint;Integrated Security=SSPI");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(SQLStr, conn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {

                conn.Close();
            }
            UpdateArticleBox();

        }

        private void CheckLiterInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 'x')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
            // only allow one x
            if (e.KeyChar == 'x' && (sender as TextBox).Text.IndexOf('x') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
