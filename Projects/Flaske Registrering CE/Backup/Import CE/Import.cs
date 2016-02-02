using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.SqlServerCe;

namespace Import_CE
{
    public partial class Import : Form
    {
        int Lines;
        public string[,] ItemRack;

        public Import()
        {
            InitializeComponent();
        }
        public string CountLinesFromFile(string filename)
        {
            string[] TempStr;
            string result, fido;
            StreamReader sr = null;
            try
            {
                int lineCount = 1;
                sr = File.OpenText(filename);
                while ((fido = sr.ReadLine()) != null)
                {
                    lineCount++;
                    TempStr = (fido + "dummy,dummy").Split(new char[] { ',' });                    
                }
                result = lineCount.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                if (sr != null) sr.Close();
            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lines = 1;
            try
            {
                Lines = Int32.Parse(CountLinesFromFile(@"\data.txt"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex);
            }

            ItemRack = new string[Lines, 14];
            int LineNo = 0;
            int ElementNo = 0;

            //Indeholder en linje, som streng.
            string linje = "";
            string element = "";

            try
            {
                //Indlæser fil i stream
                StreamReader Fil = new StreamReader(@"\data.txt");
                

                //Læser filen.
                while (Fil.Peek() > -1)
                {
                    //elementer indeholder elementerne i en linje.
                    linje = Fil.ReadLine();
                    ElementNo = 0;
                    foreach (char bogstav in linje)
                    {
                        if (bogstav == ',')
                        {
                            ItemRack[LineNo, ElementNo] = element;
                            element = "";
                            ElementNo++;
                        }
                        else
                        {
                            element += bogstav;
                        }

                    }
                    ItemRack[LineNo, ElementNo] = element;
                    element = "";
                    LineNo++;

                }

                //Lukker filen efter brug.
                Fil.Close();
                
            }
            catch (Exception Exc)
            {
                MessageBox.Show("Problemer med at læse filen \n" + Exc.ToString());

            }
            
            char charsToTrim = '"';
            char removeslash = '/';
            int toNo, fromNo, size, diameter, pressure, height;
            string strtmp;
            DateTime dt;
            

            SqlCeConnection Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection.Open();
            SqlCeCommand cmd = Myconnection.CreateCommand();
            SqlCeCommand cmd2 = Myconnection.CreateCommand();
            SqlCeDataReader dbReader = null;

            cmd.CommandText = "DELETE BottleGroupTable";
            dbReader = cmd.ExecuteReader();
            dbReader.Close();

            for (int i = 0; i < (Lines - 1); i++)
            {

                try { fromNo = Int32.Parse(ItemRack[i, 1].Replace(charsToTrim, ' ')); }
                catch (Exception) { fromNo = -2; }
                try { toNo = Int32.Parse(ItemRack[i, 2].Replace(charsToTrim, ' ')); }
                catch (Exception) { toNo = -1; }
                try { size = Int32.Parse(ItemRack[i, 0].Replace(charsToTrim, ' ')); }
                catch (Exception ex) { size = 0; }
                try { diameter = Int32.Parse(ItemRack[i, 6].Replace(charsToTrim, ' ')); }
                catch (Exception) { diameter = 0; }
                try { pressure = Int32.Parse((ItemRack[i, 8].Replace(charsToTrim, ' '))); }
                catch (Exception) { pressure = 0; }
                try { height = Int32.Parse(ItemRack[i, 12].Replace(charsToTrim, ' ')); }
                catch (Exception) { height = 0; }
                /*try { strtmp = (ItemRack[i, 13].Replace(charsToTrim, ' ').TrimEnd().TrimStart()).Replace(removeslash, '-'); dt = DateTime.ParseExact(strtmp, "yyyy/MM/dd", null); }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); dt = DateTime.Now.AddYears(-100); }*/
                strtmp = ItemRack[i, 9];
                SqlCeDataReader dbReader2 = null;
                //cmd2.CommandText = "INSERT INTO BottleGroupTable (ToBottleId, FromBottleId, BottleSize, BottleAcetyleneMassId, BottleMaterialId, BottleThreadId, BottleDiameter, BottleShapeId, BottlePressureId, BottleAirType, BottleVendorId, BottleIdVendor, BottleHeight, BottleProductionDate) VALUES (" + toNo + "," + fromNo + "," + size + "," + ItemRack[i, 3] + "," + ItemRack[i, 4] + "," + ItemRack[i, 5] + "," + diameter + "," + ItemRack[i, 7] + "," + pressure + "," + ItemRack[i, 9] + "," + ItemRack[i, 10] + "," + ItemRack[i, 11] + "," + height + ",\"" + dt.ToShortDateString() + "\")";
                cmd2.CommandText = "INSERT BottleGroupTable (FromBottleId, ToBottleId, BottleSize, BottleAcetyleneMassId, BottleMaterialId, BottleThreadId, BottleDiameter, BottleShapeId, BottlePressureId, BottleAirType, BottleVendorId, BottleIdVendor, BottleHeight) VALUES (" + toNo + "," + fromNo + "," + size + ",'" + ItemRack[i, 3] + "','" + ItemRack[i, 4] + "','" + ItemRack[i, 5] + "'," + diameter + ",'" + ItemRack[i, 7] + "'," + pressure + ",'" + ItemRack[i, 9] + "','" + ItemRack[i, 10] + "','" + ItemRack[i, 11] + "'," + height + ")";
                dbReader2 = cmd2.ExecuteReader();
                cmd2.CommandText = null;
                dbReader2.Close();
                strtmp = "";
            }

            Myconnection.Close();
            MessageBox.Show("Import fuldført!", "Import fuldført");

        }
    }
}