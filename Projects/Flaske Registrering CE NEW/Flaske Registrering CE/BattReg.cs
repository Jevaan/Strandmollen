using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Xml;

namespace FlaskeRegistreringCE
{
    public partial class BattReg : Form
    {
        string barStart = "2";
        int Bottles;
        int BottleSize;
        public BattReg(int BottleNo)
        {
            InitializeComponent();
            Bottles = BottleNo;
            switch (BottleNo)
            {
                case 8:
                    boxType.SelectedIndex = 0;
                    barStart += "08800";
                    BottleSize = 80;
                    break;
                case 9:
                    boxType.SelectedIndex = 1;
                    barStart += "09400";
                    BottleSize = 40;
                    break;
                case 12:
                    boxType.SelectedIndex = 2;
                    barStart += "12500";
                    BottleSize = 50;
                    break;
                case 20:
                    boxType.SelectedIndex = 3;
                    barStart += "20400";
                    BottleSize = 40;
                    break;
                case 32:
                    boxType.SelectedIndex = 4;
                    barStart += "32500";
                    BottleSize = 50;
                    break;
                case 36:
                    boxType.SelectedIndex = 5;
                    barStart += "36500";
                    BottleSize = 50;
                    break;
                default:
                    MessageBox.Show("Antallet af flasker stemmer\nikke overens med kendte batterier!\nBatteriet kan IKKE registreres.");
                    boxType.Enabled = true;
                //this.Close();
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql, gas;
            DateTime dtb = new DateTime();
            if (boxDyk.Checked)
                gas = boxGas.Text + " m Dykrør";
            else
                gas = boxGas.Text;
            
            float flnr = Single.Parse(boxNo.Text);
            if (flnr < 1000000)
                barStart = barStart + "0";
            if (flnr < 100000)
                barStart = barStart + "0";
            if (flnr < 10000)
                barStart = barStart + "0";
            if (flnr < 1000)
                barStart = barStart + "0";
            if (flnr < 100)
                barStart = barStart + "0";
            if (flnr < 10)
                barStart = barStart + "0";
            
            barStart += boxNo.Text;

            SqlCeConnection Myconnection3 = null;
            SqlCeDataReader dbReader3 = null;
            sql = "SELECT * FROM BottleRegistred WHERE BatteryBottle = 1";
            //MessageBox.Show(sql);
            Myconnection3 = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection3.Open();
            SqlCeCommand cmd3 = Myconnection3.CreateCommand();
            cmd3.CommandText = sql;
            dbReader3 = cmd3.ExecuteReader();
            string myConfig = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            myConfig += @"\Config.xml";

            if (!File.Exists(myConfig))
                throw new FileNotFoundException(myConfig + " could not be found.");

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(myConfig);
            XmlElement root = xdoc.DocumentElement;
            XmlNodeList nodeList = root.ChildNodes.Item(0).ChildNodes;

            string TerminalNo = "T" + nodeList.Item(0).Attributes["value"].Value;
            string AxaPath = @"Axapta" + DateTime.Now.ToString("yyyyMMddHHmmss")+ TerminalNo + ".txt";
            FileStream fs = new System.IO.FileStream(@"\My Documents\FlaskeData\" + AxaPath, System.IO.FileMode.Create);
            StreamWriter st = new System.IO.StreamWriter(fs);
            //Axapta Batteri
            string axadata = "2,\"" + Bottles.ToString() + BottleSize.ToString() + "0\",\"" + boxNo.Text + "\",\"01/" + boxDate.Text.Replace('.', '/') + "\",\"" + barStart + "\",\" \",\"" + boxGas.Text + "\",\" \",\" \",\"" + boxPressure.Text + "\",\"\"";
            st.WriteLine(axadata);

            //Axapta Flasker
            while (dbReader3.Read())
            {
                dtb = DateTime.ParseExact(dbReader3["BottleTestDate"].ToString(),"d/M/yyyy hh:mm:ss tt",null);
                axadata = "1,\"" + dbReader3["BottleSize"] + "\",\"" + dbReader3["BottleId"] + "\",\"01/" + dtb.ToString("MM/yyyy") + "\",\"" + dbReader3["BottleBarcode"] + "\",\" \",\"" + dbReader3["BottleGas"] + "\",\"" + dbReader3["BottleVendor"] + "\",\" \",\"" + dbReader3["BottlePressure"] + "\",\"" + barStart + "\"";
                st.WriteLine(axadata);
            }
            st.Close();
            fs.Close();
            
            dbReader3.Close();
            Myconnection3.Close();
            
            SqlCeConnection Myconnection = null;
            SqlCeDataReader dbReader = null;
            sql = "INSERT INTO Battery VALUES ('" + barStart + "','" + Bottles.ToString() + "','" + BottleSize.ToString() + "','" + boxNo.Text + "','" + boxDate.Text + "','" + boxGas.Text + "','" + boxPressure.Text + "', 0)";
            //MessageBox.Show(sql);
            Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection.Open();
            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = sql;
            dbReader = cmd.ExecuteReader();
            dbReader.Close();
            Myconnection.Close();

            
            SqlCeConnection Myconnection2 = null;
            SqlCeDataReader dbReader2 = null;
            sql = "UPDATE BottleRegistred SET inBattery =" + barStart + ",BatteryBottle = 0 WHERE BatteryBottle = 1";
            //MessageBox.Show(sql);
            Myconnection2 = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection2.Open();
            SqlCeCommand cmd2 = Myconnection2.CreateCommand();
            cmd2.CommandText = sql;
            dbReader2 = cmd2.ExecuteReader();
            dbReader2.Close();
            Myconnection2.Close();

            float copies = Single.Parse(boxLabels.Text);
            string tmploc = @"\My Documents\FlaskeData\Data.txt";
            StreamWriter w = new StreamWriter(tmploc, true, Encoding.GetEncoding(1252));
            w.WriteLine(@"NASC 1252:PP 40,145:DIR 2:FT ""Swiss 721 Bold BT"",6:PT ""STRANDMØLLEN"":DIR 1:BF OFF:BF ""Swiss 721 BT"",8:PP78,0:BT ""EAN128"":BH 100: PB """ + barStart + @""":PP 95,100:FT ""Swiss 721 BT"",10:PT """ + barStart + @""":PF");
            //Udskriv mere end 1 kopi?
            while (copies > 1)
            {
                w.WriteLine("PF");
                copies = copies - 1;
            }
            w.WriteLine("\n");
            //Send udskrift til printer på LPT1!
            w.Close();
                        
            this.Close();

        }

        
    }
}