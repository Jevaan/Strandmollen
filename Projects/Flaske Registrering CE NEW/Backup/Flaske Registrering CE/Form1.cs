using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Xml;


namespace FlaskeRegistreringCE
{
    public partial class FlRegCE : Form
    {
        public bool[] settingsArray = new bool[7];
        public string printed;
        public bool firstBox = true;
        public bool newClick;
        public bool DataWritten = false;
        public bool DatoInput = false;
        public int BatteryBottles = 0;
        const bool debug = true;
        public bool VendorDatoInput = false;
        public string AxaPath;
        public System.IO.FileStream fs;
        public System.IO.StreamWriter st;
        public string message = null;
        public string TerminalNo = null;

        public FlRegCE()
        {
            
            InitializeComponent();
            settingsArray[0] = true;
            settingsArray[1] = true;
            settingsArray[2] = false;
            settingsArray[3] = false;
            settingsArray[4] = false;
            settingsArray[5] = false;
            settingsArray[6] = false;
        }

        
        private void inNo_LostFocus(object sender, System.EventArgs e)
        {
            if (inNo.TextLength > 0 && inSize.Text != "")
            {
                if (debug)
                {
                    SqlCeConnection Myconnection = null;
                    SqlCeDataReader dbReader = null;
                    SqlCeDataReader dbReader2 = null;
                    string sql = "";
                    string tmpDate = "";
                    barcode_create();
                    char[] charsToTrim = { '"' };

                    Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
                    Myconnection.Open();

                    SqlCeCommand cmd = Myconnection.CreateCommand();
                    SqlCeCommand cmd2 = Myconnection.CreateCommand();
                    sql = "WHERE BottleBarcode = '" + printed + "'";
                    cmd2.CommandText = "SELECT * FROM BottleRegistred " + sql;
                    dbReader2 = cmd2.ExecuteReader();
                    //sql = "WHERE FromBottleId <= " + inNo.Text + " AND ToBottleId >= " + inNo.Text + " AND BottleSize = " + inSize.Text + "0" ;
                    sql = "WHERE FromBottleId>=" + inNo.Text + " AND ToBottleId<=" + inNo.Text + " AND BottleSize=" + inSize.Text + "0";
                    cmd.CommandText = "SELECT * FROM BottleGroupTable " + sql;
                    dbReader = cmd.ExecuteReader();
                    if (inVendor.Text.Length < 2)
                        inVendor.Text = "-";
                    if (inVendorDate.Text.Length < 2)
                        inVendorDate.Text = "";
                    if (dbReader2.Read())
                    {
                        VendorDatoInput = true;
                        firstBox = false;
                        MessageBox.Show("Tidligere registreret flaske!");
                        inVendor.Enabled = false;
                        inVendorDate.Enabled = false;
                        inDate.Text = "";
                        inVendor.Text = (string)dbReader2.GetValue(7);
                        inVendorDate.Text = "";
                        tmpDate = Regex.Replace((dbReader2.GetDateTime(8).ToString().Substring(3, 7)), "/", ".");
                        if (10 > Convert.ToInt32(tmpDate.Substring(5)))
                            inVendorDate.Text = "0";

                        inVendorDate.Text = inVendorDate.Text + tmpDate.Substring(6, 1) + tmpDate.Substring(0, 5);
                        
                        if (!settingsArray[3])
                            inAir.Text = (string)dbReader2.GetValue(6);
                        inPressure.Text = (string)dbReader2.GetValue(9);
                        tmpDate = Regex.Replace((dbReader2.GetDateTime(4).ToString().Substring(3, 7)), "/", ".");
                        if (10 > Convert.ToInt32(tmpDate.Substring(5)))
                            inDate.Text = "0";

                        inDate.Text = inDate.Text + tmpDate.Substring(6, 1) + tmpDate.Substring(0, 5);
                    }
                    else
                    {
                        if (dbReader.Read())
                        {
                            //MessageBox.Show("[0]" + dbReader.GetValue(0) + "\n[1] " + dbReader.GetValue(1) + " \n[8] " + dbReader.GetInt32(8));
                            inVendor.Enabled = true;
                            inVendorDate.Enabled = true;
                            inPressure.Enabled = true;
                            inVendor.Text = dbReader.GetString(10).TrimStart(charsToTrim).TrimEnd(charsToTrim);
                            //inVendorDate.Text = dbReader.GetDateTime(13).ToShortDateString().Replace("-", "/").Remove(0, 3);
                            if (!settingsArray[3])
                                inAir.Text = dbReader.GetString(9).TrimStart(charsToTrim).TrimEnd(charsToTrim);
                            inPressure.Text = dbReader.GetInt32(8).ToString();
                        }
                        else
                        {
                            inVendor.Enabled = true;
                            inVendorDate.Enabled = true;
                            inPressure.Enabled = true;

                        }

                    }

                    dbReader.Close();
                    Myconnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Ikke muligt at lave opslag\nStørrelse: " + inSize.Text + "\nNummer: " + inNo.Text);
            }
        }
        private void barcode_create()
        {
            if (cbType.Text == "Egen Flaske" || cbType.Text == "Batteriflaske")
                printed = "1";
            if (cbType.Text == "Kryoflaske")
                printed = "4";
            if (cbType.Text == "Fremmed Flaske")
                printed = "8";
            if (cbType.Text == "Salgs Flaske")
                printed = "9";
            double flstr = 10 * double.Parse(inSize.Text.Replace(".", ","));
            if (flstr < 10000)
                printed = printed + "0";
            if (flstr < 1000)
                printed = printed + "0";
            if (flstr < 100)
                printed = printed + "0";
            if (flstr < 10)
                printed = printed + "0";

            printed = printed + flstr.ToString();

            float flnr = Single.Parse(inNo.Text);
            if (flnr < 1000000)
                printed = printed + "0";
            if (flnr < 100000)
                printed = printed + "0";
            if (flnr < 10000)
                printed = printed + "0";
            if (flnr < 1000)
                printed = printed + "0";
            if (flnr < 100)
                printed = printed + "0";
            if (flnr < 10)
                printed = printed + "0";
            printed = printed + flnr.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inNo.TextLength > 0 && VendorDatoInput && DatoInput)
            {
                string db_store;
                string dato = "";
                string btVendor = "";
                string btPressure = "";
                DateTime btDate;
                barcode_create();

                db_store = "'" + printed + "'";
                db_store = db_store + ",'Flaske'";
                db_store = db_store + ",'" + inSize.Text + "'";
                db_store = db_store + ",'" + inNo.Text + "'";

                dato = "01/" + inDate.Text;
                
                btVendor = inVendor.Text;
                btDate = DateTime.Parse("01/" + inVendorDate.Text);
                btPressure = inPressure.Text;

                db_store = db_store + ",'" + dato + "'";
                db_store = db_store + ",'" + " "/*inVendorNo.Text*/ + "'";
                db_store = db_store + ",'" + inAir.Text + "'";
                db_store = db_store + ",'" + btVendor + "'";
                db_store = db_store + ",'" + btDate + "'";
                db_store = db_store + ",'" + btPressure + "'";
                db_store = db_store + ",0";
                if (cbType.Text == "Batteriflaske")
                    db_store = db_store + ",1";
                else
                    db_store = db_store + ",0";
                db_store = db_store + ",''";//Batterinummer
                if (debug)
                {
                    //Udskriv første kopi
                    float copies = Single.Parse(inLabels.Text);
                    string tmploc = @"\My Documents\FlaskeData\Data.txt";
                    StreamWriter w = new StreamWriter(tmploc, true, Encoding.GetEncoding(1252));
                    w.WriteLine(@"NASC 1252:PP 40,145:DIR 2:FT ""Swiss 721 Bold BT"",6:PT ""STRANDMØLLEN"":DIR 1:BF OFF:BF ""Swiss 721 BT"",8:PP78,0:BT ""EAN128"":BH 100: PB """ + printed + @""":PP 95,100:FT ""Swiss 721 BT"",10:PT """ + printed + @""":PF");
                    //Udskriv mere end 1 kopi?
                    while (copies > 1)
                    {
                        w.WriteLine("PF");
                        copies = copies - 1;
                    }
                    w.WriteLine("\n");
                    //Send udskrift til printer på LPT1!
                    w.Close();


                    SqlCeConnection Myconnection = null;
                    SqlCeDataReader dbReader = null;
                    string sql = "";
                    int chkBattery;
                    if (chkBat.Checked)
                        chkBattery = 1;
                    else
                        chkBattery = 0;
                    //Data gemmes efter udskrift
                    if (inVendor.Enabled)
                        sql = "INSERT INTO BottleRegistred VALUES (" + db_store + ")";
                    else
                        sql = "UPDATE BottleRegistred SET BottleTestDate = '"+ dato+"', BottleGas = '"+ inAir.Text +"', BottlePressure = '"+ inPressure.Text +"', BatteryBottle = "+ chkBattery +" WHERE BottleBarcode = " + printed + "";
                    
                    
                    ///MessageBox.Show(sql);
                    Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
                    Myconnection.Open();

                    SqlCeCommand cmd = Myconnection.CreateCommand();
                    cmd.CommandText = sql;
                    dbReader = cmd.ExecuteReader();


                    dbReader.Close();
                    Myconnection.Close();
                    if (!chkBat.Checked)
                    {
                        double size = Double.Parse(inSize.Text) * 10;
                        string axadata = "1,\"" + size.ToString("0000") + "\",\"" + inNo.Text + "\",\"01/" + inDate.Text.Replace('.', '/') + "\",\"" + printed + "\",\" \",\"" + inAir.Text + "\",\"" + inVendor.Text + "\",\"01/" + inVendorDate.Text.Replace('.', '/') + "\",\"" + inPressure.Text + "\",\"\"";
                        st.WriteLine(axadata);
                        DataWritten = true;
                    }
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Inkorrekte oplysninger\nCheck datofelter");
            }
        }

        private void label9_ParentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings dd = new Settings();
            dd.Show();
            dd.Closing += new CancelEventHandler(dd_Closing);
        }

        private void dd_Closing(object sender, CancelEventArgs e)
        {

            settingsArray = ((Settings)sender).getSettings;
        }

        private void Clear()
        {
            
            if (!settingsArray[1])
                inSize.Text = "";
            if (!settingsArray[2])
                inDate.Text = "";
            if (!settingsArray[3])
                inAir.Text = "";
            if (!settingsArray[4])
                inVendor.Text = "";
            if (!settingsArray[5])
                inVendorDate.Text = "";
            if (!settingsArray[6])
                inPressure.Text = "";

            inNo.Text = "";

            
        }

        private void Date_LostFocus(object sender, System.EventArgs e)
        {
            string[] inDateChk = inDate.Text.Split('.');
            int Dato, Aar;
            try { Dato = Int32.Parse(inDateChk[0]); Aar = Int32.Parse(inDateChk[1]); }
            catch (Exception) { Dato = 15; Aar = 1000; }

            if (Dato > 12 || Aar > 2020 || Aar < 1900)
            {
                if (firstBox)
                    MessageBox.Show("Fejl i Trykprøvningsdato\nFormat: MM.ÅÅÅÅ\nF.eks 01.2000");
                inDate.Focus();
                inDate.SelectAll();
                firstBox = false;
            }
            else { DatoInput = true; }
        }

        private void VendorDate_LostFocus(object sender, System.EventArgs e)
        {
            string[] inDateChk = inVendorDate.Text.Split('.');
            int Dato, Aar;
            try { Dato = Int32.Parse(inDateChk[0]); Aar = Int32.Parse(inDateChk[1]); }
            catch (Exception) { Dato = 15; Aar = 1000; }

            if (Dato > 12 || Aar > 2020 || Aar < 1900)
            {
                if (firstBox)
                    MessageBox.Show("Fejl i Produktionsdato\nFormat: MM.ÅÅÅÅ\nF.eks 01.2000");
                inVendorDate.Focus();
                inVendorDate.SelectAll();
                firstBox = false;
            }
            else { VendorDatoInput = true; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (debug)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.EnableRaisingEvents = false;
                proc.StartInfo.FileName = @"\Program Files\Export_CE\Export CE.exe";
                proc.Start();
            }
        }

        private void FlRegCE_Load(object sender, EventArgs e)
        {
            string myConfig = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            myConfig += @"\Config.xml";

            if (!File.Exists(myConfig))
                throw new FileNotFoundException( myConfig + " could not be found.");

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(myConfig);
            XmlElement root = xdoc.DocumentElement;
            XmlNodeList nodeList = root.ChildNodes.Item(0).ChildNodes;

            TerminalNo = "T" + nodeList.Item(0).Attributes["value"].Value;
            TNo.Text = TerminalNo;
            Prepare_Files();
        }

        private void Prepare_Files()
        {
            AxaPath = @"Axapta" + DateTime.Now.ToString("yyyyMMddHHmmss") + TerminalNo + ".txt";
            fs = new System.IO.FileStream(@"\My Documents\FlaskeData\" + AxaPath, System.IO.FileMode.Create);
            st = new System.IO.StreamWriter(fs);
        }

        private void Delete_Files()
        {
            string[] fileList = Directory.GetFiles(@"\My Documents\FlaskeData\");
            foreach (string myFile in fileList)
            {
                if (File.Exists(myFile))
                {
                    System.IO.File.Delete(myFile);
                }
            }
        }

        private void Close_Files()
        {
            try
            {
                st.Close();
                st = null;
                fs.Close();
                fs = null;
            }
            catch
            {  }
        
        }

        private void FlRegCE_Close(object sender, EventArgs e)
        {
            if (debug)
            {
                Close_Files();
                               
                
                string[] fileList = Directory.GetFiles(@"\My Documents\FlaskeData\");
                foreach(string myFile in fileList)
                {
                  if(File.Exists(myFile))
                  {
                    FileInfo finfo = new FileInfo(myFile);
                    //finfo.Length returns the File size. 
                    if (finfo.Length < 10 && finfo.Extension == "txt")
                        System.IO.File.Delete(myFile);
                  }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                newClick = true;
                if (inSize.Focused & newClick)
                {
                    inNo.Focus();
                    inSize.SelectedIndex = inSize.SelectedIndex - 1;
                    newClick = false;
                }
                if (inNo.Focused & newClick)
                {
                    inDate.Focus();
                    newClick = false;
                }
                if (inDate.Focused & newClick)
                {
                    inAir.Focus();
                    newClick = false;
                }
                if (inAir.Focused & newClick)
                {
                    inPressure.Focus();
                    inAir.SelectedIndex += -1;
                    newClick = false;
                }
                if (inPressure.Focused & newClick)
                {
                    inVendor.Focus();
                    inPressure.SelectedIndex += -1;
                    newClick = false;
                }
                if (inVendor.Focused & newClick)
                {
                    inVendorDate.Focus();
                    inVendor.SelectedIndex += -1;
                    newClick = false;
                }
                if (inVendorDate.Focused & newClick)
                {
                    btnSave.Focus();
                    newClick = false;
                }
                if (btnSave.Focused & newClick)
                {
                    btnClear.Focus();
                    newClick = false;
                }
                if (btnClear.Focused & newClick)
                {
                    inSize.Focus();
                    newClick = false;
                }

                
            }
            if (e.KeyCode == Keys.Up)
            {
                newClick = true;
                if (inSize.Focused & newClick)
                {
                    btnClear.Focus();
                    inSize.SelectedIndex = inSize.SelectedIndex + 1;
                    newClick = false;
                }
                if (inNo.Focused & newClick)
                {
                    inSize.Focus();
                    newClick = false;
                }
                if (inDate.Focused & newClick)
                {
                    inNo.Focus();
                    newClick = false;
                }
                if (inAir.Focused & newClick)
                {
                    inDate.Focus();
                    inAir.SelectedIndex +=  +1;
                    newClick = false;
                }
                if (inPressure.Focused & newClick)
                {
                    inAir.Focus();
                    inPressure.SelectedIndex = inPressure.SelectedIndex + 1;
                    newClick = false;
                }
                if (inVendor.Focused & newClick)
                {
                    inPressure.Focus();
                    inVendor.SelectedIndex += +1;
                    newClick = false;
                }
                if (inVendorDate.Focused & newClick)
                {
                    inVendor.Focus();
                    newClick = false;
                }
                if (btnSave.Focused & newClick)
                {
                    inVendorDate.Focus();
                    newClick = false;
                }
                if (btnClear.Focused & newClick)
                {
                    btnSave.Focus();
                    newClick = false;
                }               
            }
        }

        private void btnBat_Click(object sender, EventArgs e)
        {
            Battery Batt = new Battery();
            Batt.Show();
            Batt.Closing += new CancelEventHandler(Batt_Closing);
        }

        void Batt_Closing(object sender, CancelEventArgs e)
        {
            BatteryBottles = ((Battery)sender).GetBottles();
            BattReg BatteryReg = new BattReg(BatteryBottles);
            BatteryReg.Show();
        }

        private string DownloadData(NetworkStream net_stream)
        {
            string message = "";
            byte[] read_buffer = new byte[1024];
            List<byte> msg_bytes = new List<byte>();
            try
            {
                if (net_stream.CanRead)
                {
                    int n = 0;
                    bool working = true;
                    while (working)
                    {
                        n = net_stream.Read(read_buffer, 0, read_buffer.Length);
                        if (Array.IndexOf<byte>(read_buffer, Convert.ToByte(3)) > -1)
                        {
                            n--;
                            working = false;
                        }
                        for (int i = 0; i < n; i++)
                            msg_bytes.Add(read_buffer[i]);
                        Application.DoEvents();
                    }
                    byte[] msg_bytes_arr = msg_bytes.ToArray();
                    message = System.Text.Encoding.UTF8.GetString(msg_bytes_arr, 0, msg_bytes_arr.Length);

                    msg_bytes_arr = null;
                }
            }
            catch
            {
                //MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                read_buffer = null;
                msg_bytes = null;
            }
            return message;
        }

        private void UploadData(NetworkStream net_stream, string Data)
        {
            try
            {
                byte[] msg = Encoding.GetEncoding(1252).GetBytes(Data + Convert.ToChar(Convert.ToByte(3)));
                net_stream.Write(msg, 0, msg.Length);
                msg = null;
                
            }
            catch
            {
                //MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btnDock_click(object sender, EventArgs e)
        {
            Close_Files();
            bool OK = false;
            DirectoryInfo dirInfo = new DirectoryInfo(@"\My Documents\FlaskeData\");
            FileInfo[] fileInfo = dirInfo.GetFiles("*.*");
            if (fileInfo.Length > 0)
            {
                for (int k = 0; k < fileInfo.Length; k++)
                {
                    if (fileInfo[k].Length > 50)
                    {
                        try
                        {
                            // Create an instance of StreamReader to read from a file.
                            // The using statement also closes the StreamReader.
                            using (StreamReader sr = new StreamReader(@"\My Documents\FlaskeData\" + fileInfo[k].Name, Encoding.GetEncoding(1252)))
                            {
                                String line;
                                string allLines = null;
                                TcpClient tcp_client;
                                NetworkStream net_stream;
                                int noLines = 0;

                                while ((line = sr.ReadLine()) != null)
                                {
                                    allLines += line + "\r\n";
                                    ++noLines;

                                }
                                try
                                {
                                    tcp_client = new TcpClient("ppp_peer", 666);
                                    net_stream = tcp_client.GetStream();

                                    UploadData(net_stream, "#" + fileInfo[k].Name + "#" + allLines);

                                    net_stream.Close();



                                }
                                catch
                                {
                                    //MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
                                }
                                finally
                                {
                                    net_stream = null;
                                    tcp_client = null;
                                }


                            }
                        }
                        catch (Exception eX)
                        {
                            MessageBox.Show("Kunne ikke åbne filen:" + eX.Message);

                        }
                    }
                }
            }

            TcpClient tcp_client2;
            NetworkStream net_stream2;
            
            try
            {
                tcp_client2 = new TcpClient("ppp_peer", 666);
                net_stream2 = tcp_client2.GetStream();

                UploadData(net_stream2, "Done");
                string message = DownloadData(net_stream2);
                if (message == "OK")
                {
                    //MessageBox.Show("OK Modtaget");
                    OK = true;
                }
                else
                {
                    MessageBox.Show("Flaske server programmet \r\nkører ikke på PCen");
                }
                net_stream2.Close();
                


            }
            catch
            {
                MessageBox.Show("Terminalen skal sidde i docken\r\nfør der kan udskrives etiketter.");
                //MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                net_stream2 = null;
                tcp_client2 = null;
            }
            if (OK)
            {
                Delete_Files();
                Prepare_Files();
               
            }
        }
        
    }
}