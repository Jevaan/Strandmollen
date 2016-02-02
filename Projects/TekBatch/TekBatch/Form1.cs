using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Management;
using System.Configuration;

namespace TekBatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.Load += new System.EventHandler(this.Form1_Load);
            InitializeComponent();
        }

        protected string Printer;
        private PictureBox LabelBox = new PictureBox();
        Configuration config;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            lblVersion.Text = "Version: 2.0.9.0";
            cbType.Text = "Vælg Type";
            cb1.Enabled = false;
            cb1.Visible = false;
            cb2.Enabled = false;
            cb2.Visible = false;

            Configuration roamingConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = roamingConfig.FilePath;
                        
            config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            string sectionName = "appSettings";
            
           
            AppSettingsSection appSettingSection =
              (AppSettingsSection)config.GetSection(sectionName);
            if (appSettingSection.Settings.Count != 0)
            {
                Printer = appSettingSection.Settings["Printer"].Value;
               
            }
            else
            {
                config.AppSettings.Settings.Add("Printer", "Teknisk");
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(sectionName);
                Printer = "Teknisk";

            }
           
            appSettingSection.Settings.Remove("Printer");

            switch (Printer)
            {
                case "Mora":
                    rbPrnMora.Checked = true;
                    break;
                case "Teknisk":
                    rbPrnTek.Checked = true;
                    break;
                case "Ljungby":
                    rbPrnLju.Checked = true;
                    break;
                case "FLV":
                    FLVRadioButton.Checked = true;
                    break;
                case "Lokal":
                    rbPrnLocal.Checked = true;
                    break;
                case "Medicinsk":
                    rbPrnMed.Checked = true;
                    break;
                default:
                    rbPrnTek.Checked = true;
                    break;
            }


        }

        //Opsætning af input felter alt efter valgt batchmærke.
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewBatch();
            if (cbType.Text == "Fremmede flasker")
            {
                cb2.Items.Clear();
                cb2.Items.Add("SOM");
                cb2.Items.Add("VIL");
                cb2.Items.Add("MES");
                cb2.Items.Add("WOI");
                cb2.Items.Add("GHC");
                lbl1.Text = "Ordrenr:";
                lbl2.Text = "Leverandør:";
                lbl3.Text = "Initialer:";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = true;
                cb2.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                tb1.Visible = true;
                tb2.Visible = false;
                tb3.Visible = true;
            }
            if (cbType.Text == "Ny Medicinsk")
            {
                lbl1.Text = "Batch ID:";
                lbl2.Text = "Dokumentation:";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = true;
                cb2.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = false;
                tb3.Visible = false;
            }
            if (cbType.Text == "Varenummer")
            {
                lbl1.Text = "Artikelnr:";
                lbl2.Text = "Dokumentation:";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = false;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = false;
                tb3.Visible = false;
            }
            if (cbType.Text == "Medicinsk")
            {
                lbl1.Text = "Fyldt af:";
                lbl2.Text = "Rampe: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = false;
            }
            if (cbType.Text == "Afblæsning")
            {
                lbl1.Text = "Afblæst af:";
                lbl2.Text = "INI: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = false;
            }
            if (cbType.Text == "Tankprøve")
            {
                lbl1.Text = "Brutto:";
                lbl2.Text = "Terra: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                tb1.Visible = false;
                tb2.Visible = false;
                tb3.Visible = false;
            }
            if (cbType.Text == "Kryobeholder")
            {
                lbl1.Text = "Fyldt af:";
                lbl2.Text = "Batch ID: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = false;
            }
            if (cbType.Text == "Radiometer")
            {
                lbl1.Text = "Fyldt af:";
                lbl2.Text = "Træk: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = false;
            }
            if (cbType.Text == "Teknisk")
            {
                lbl1.Text = "Fyldt af:";
                lbl2.Text = "Rampe: ";
                lbl3.Text = "Træk: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = true;
            }
            if (cbType.Text == "Ny Teknisk")
            {
                lbl1.Text = "Batch ID:";
                lbl2.Text = "Panel:";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = false;
            }
            if (cbType.Text == "Evakueret")
            {
                lbl1.Text = "Med:";
                cb1.Visible = true;
                cb1.Enabled = true;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = false;
                lbl3.Visible = false;
                tb1.Visible = false;
                tb2.Visible = false;
                tb3.Visible = false;
            }
            if (cbType.Text == "Ambu" || cbType.Text == "Borealis")
            {
                lbl1.Text = "Med:";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                tb1.Visible = false;
                tb2.Visible = false;
                tb3.Visible = false;
            }
            if (cbType.Text == "Shipment")
            {
                lbl1.Text = "Med:";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                tb1.Visible = false;
                tb2.Visible = false;
                tb3.Visible = false;
            }
            if (cbType.Text == "Bulk")
            {
                lbl1.Text = "Batch:";
                lbl2.Text = "Dato: ";
                lbl3.Text = "INI: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = true;
                tb2.Text = DateTime.Now.ToShortDateString();
            }
            if (cbType.Text == "CO2 Netto Brutto")
            {
                lbl1.Text = "Tara: ";
                lbl2.Text = "Netto: ";
                lbl3.Text = "Brutto: ";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                tb1.Visible = true;
                tb2.Visible = true;
                tb3.Visible = true;
            }
            if (cbType.Text == "Kontrolleret")
            {
                lbl1.Text = "INI:";
                lbl2.Text = "Panel:";
                cb1.Visible = false;
                cb1.Enabled = false;
                cb2.Enabled = false;
                cb2.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = false;
                lbl3.Visible = false;
                tb1.Visible = true;
                tb2.Visible = false;
                tb3.Visible = false;
            }
            LabelBox.Dock = DockStyle.Fill;
            LabelBox.BackColor = Color.LightGray;
            LabelBox.Paint += new PaintEventHandler(this.PaintUpd);
            LabelBox.Refresh();
            this.Controls.Add(LabelBox);
        }

        private void PaintUpd(object sender, PaintEventArgs e)
        {

            // Get Graphics Object
            Graphics g = e.Graphics;
            g.Clear(Color.LightGray);

            // Method under System.Drawing.Graphics
            Pen blackpen = new Pen(Color.Black, 3);
            Rectangle Etiket = new Rectangle(240, 10, 178, 80);
            g.DrawRectangle(blackpen, Etiket);
            g.FillRectangle(new SolidBrush(Color.White), Etiket);
            if (cbType.Text == "Ambu")
            {
                Møllen(sender, e);
                Tekst("Skyllet i oxygen", 10, false, 80, 50, sender, e);
                Tekst("Resttryk 10 bar", 10, false, 80, 20, sender, e);
            }
            if (cbType.Text == "Shipment")
            {
                Møllen(sender, e);
                Tekst("Efter", 10, false, 80, 50, sender, e);
                Tekst("Shipment 23", 10, false, 80, 20, sender, e);
            }
            if (cbType.Text == "Borealis")
            {
                Tekst("Borealis", 12,false, 100, 85, sender, e);
                Tekst("without RPV", 12,false, 80, 35, sender, e);
            }
            if (cbType.Text == "Medicinsk")
            {
                Møllen(sender, e);
                Tekst("DATO", 10, false, 40, 117, sender, e);
                Tekst("UDLØB", 10, false, 230, 117, sender, e);
                Tekst("Afd. 2", 10, false, 40, 50, sender, e);
                Tekst("Rampe", 10, false, 190, 50, sender, e);
                Tekst("Fyldt af", 10, false, 40, 20, sender, e);
            }
            if (cbType.Text == "Ny Medicinsk")
            {
                Møllen(sender, e);
                Tekst("DATO", 10, false, 40, 117, sender, e);
                Tekst("UDLØB", 10, false, 230, 117, sender, e);
                Tekst("Batch_ID:", 10, false, 100, 35, sender, e);
            }
            if (cbType.Text == "Teknisk")
            {
                Møllen(sender, e);
                Tekst("DATO", 10, false, 120, 117, sender, e);
                Tekst("Afd. 2", 10, false, 40, 50, sender, e);
                Tekst("Rampe", 10, false, 158, 50, sender, e);
                Tekst("Træk", 10, false, 40, 20, sender, e);
                Tekst("Fyldt af", 10, false, 158, 20, sender, e);
            }
            if (cbType.Text == "Radiometer")
            {
                Møllen(sender, e);
                Tekst("DATO", 10, false, 120, 117, sender, e);
                Tekst("Afd. 2", 10, false, 40, 50, sender, e);
                Tekst("Træk", 10, false, 158, 50, sender, e);
                Tekst("Fyldt af", 10, false, 158, 20, sender, e);
            }
            if (cbType.Text == "Ny Teknisk")
            {
                Møllen(sender, e);
                Tekst("DATO", 10, false, 130, 117, sender, e);
                Tekst("Batch_ID:", 10, false, 100, 55, sender, e);
                Tekst("Panel", 10, false, 100, 25, sender, e);
            }
            if (cbType.Text == "Afblæsning")
            {
                Møllen(sender, e);
                Tekst("DATO", 10, false, 130, 117, sender, e);
                Tekst("Afblæsning af: ", 10, false, 60, 50, sender, e);
                Tekst("INI: ", 10, false, 60, 20, sender, e);
            }
            if (cbType.Text == "Tankprøve")
            {
                //Møllen(sender, e);
                //Tekst("DATO", 10, false, 130, 117, sender, e);
                Tekst("Godkendt til", 16, false, 60, 80, sender, e);
                Tekst("Tankprøve", 16, false, 60, 30, sender, e);
            }
            if (cbType.Text == "Varenummer")
            {
                //Møllen(sender, e);
                //Tekst("DATO", 10, false, 130, 117, sender, e);
                Tekst("Artikelnummer:", 14, false, 60, 80, sender, e);
                Tekst("xxxxxxxxxxxxxxx", 12, false, 60, 30, sender, e);
            }
            if (cbType.Text == "Kryobeholder")
            {
                Møllen(sender, e);
                Tekst("Afd. 2", 10, false, 40, 117, sender, e);
                Tekst("DATO", 10, false, 206, 117, sender, e);
                Tekst("Fyldt af", 10, false, 100, 50, sender, e);
                Tekst("Batch_ID:", 10, false, 100, 20, sender, e);
            }
            if (cbType.Text == "Evakueret")
            {
                Tekst("Evakueret med:", 12, false, 50, 85, sender, e);
                Tekst("GAS", 12, false, 100, 35, sender, e);
            }
            if (cbType.Text == "Bulk")
            {
                Møllen(sender, e);
                Tekst("Batch:", 10, false, 60, 60, sender, e);
                Tekst("Dato:", 10, false, 100, 30, sender, e);
                Tekst("INI:", 10, false, 120, 0, sender, e);

            }
            if (cbType.Text == "CO2 Netto Brutto")
            {
                //Møllen(sender, e);
                Tekst("Tara:", 10, false, 120, 100, sender, e);
                Tekst("Netto:", 10, false, 120, 70, sender, e);
                Tekst("Brutto:", 10, true, 120, 40, sender, e);
                Tekst("(incl. Bøjlehætte)", 8, false, 110, 0, sender, e);

            }
            if (cbType.Text == "Fremmede flasker")
            {
                Tekst("DATO: xxxxxx", 10, false, 60, 90, sender, e);
                Tekst("Ordernr: xxx-xxxx", 10, false, 60, 60, sender, e);
                Tekst("Leverandør: xxx", 10, false, 60, 30, sender, e);
                Tekst("Initialer: xx", 10, false, 60, 0, sender, e);

            }
            if (cbType.Text == "Kontrolleret")
            {
                Tekst("Kontrolleret", 10, true, 100, 85, sender, e);
                Tekst("DATO", 10, false, 80, 55, sender, e);
                Tekst("INI:", 10, false, 80, 25, sender, e);
            }


        }
        private void Tekst(string Text, int str, bool bold, int x, int y, object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (bold)
                g.DrawString(Text, new Font("Courier New", str, FontStyle.Bold), new SolidBrush(Color.Black), (x / 2 + 230), ((-y) / 2 + 70));
            else
                g.DrawString(Text, new Font("Courier New", str), new SolidBrush(Color.Black), (x / 2 + 230), ((-y) / 2 + 70));
        }
        private void Møllen(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("STRANDMØLLEN", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), 255, 27);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string prn = SetPrinter();

            int adjust = int.Parse(cbAdjust.Text) * 8;
            string printme = "";
            string a = cbDato.Text;
            string[] elementer = a.Split(@"-".ToCharArray());
            a = elementer[2];
            float aar = Single.Parse(a);
            aar = aar + 3;
            string datoen = aar.ToString() + "-" + elementer[1];
           
            if (cbType.Text == "Borealis")
            {
                printme = "NASC 1252:PP 110,85:FT \"Swiss 721 Bold BT\",14:PT \"Borealis\":PP 80,35:FT \"Swiss 721 Bold BT\",14:PT \"without RPV\":PF";
            }
            if (cbType.Text == "Radiometer")
            {
                printme = "NASC 1252:PP 120,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 40,50:FT \"Swiss 721 BT\",10:PT \"Afd. 2\":PP 158,50:FT \"Swiss 721 BT\",10:PT \"Træk " + tb2.Text + "\":PP 158,20:FT \"Swiss 721 BT\",10:PT \"Fyldt af " + tb1.Text + "\":PF";
            }
            if (cbType.Text == "Teknisk")
            {
                printme = "NASC 1252:PP 120,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 40,50:FT \"Swiss 721 BT\",10:PT \"Afd. 2\":PP 158,50:FT \"Swiss 721 BT\",10:PT \"Rampe " + tb2.Text + "\":PP 40,20:FT \"Swiss 721 BT\",10:PT \"Træk " + tb3.Text + "\":PP 158,20:FT \"Swiss 721 BT\",10:PT \"Fyldt af " + tb1.Text + "\":PF";
            }
            if (cbType.Text == "Ny Teknisk")
            {
                printme = "NASC 1252:PP 130,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 100,55:FT \"Swiss 721 BT\",10:PT \"Batch_ID: " + tb1.Text + "\":PP 100,25:FT \"Swiss 721 BT\",10:PT \"Panel: " + tb2.Text + "\":PF";
            }
            if (cbType.Text == "Afblæsning")
            {
                printme = "NASC 1252:PP 130,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 60,50:FT \"Swiss 721 BT\",10:PT \"Afblæsning af:  " + tb1.Text + "\":PP 60,20:FT \"Swiss 721 BT\",10:PT \"INI:  " + tb2.Text + "\":PF";
            }
            if (cbType.Text == "Tankprøve")
            {
                printme = "NASC 1252:PP 60,80:FT \"Swiss 721 Bold BT\",16:PT \"Godkendt til\":PP 60,20:FT \"Swiss 721 Bold BT\",16:PT \"Tankprøve\":PF";
            }
            if (cbType.Text == "Varenummer")
            {
                printme = "NASC 1252:PP 40,80:FT \"Swiss 721 Bold BT\",14:PT \"Artikelnummer:\":PP 40,20:FT \"Swiss 721 Bold BT\",12:PT \"" +tb1.Text+ "\":PF";
            }
            if (cbType.Text == "Kryobeholder")
            {
                printme = "NASC 1252:PP 40,117:FT \"Swiss 721 BT\",10:PT \"Afd. 2\":PP 206,117:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 100,50:FT \"Swiss 721 BT\",10:PT \"Fyldt af:  " + tb1.Text + "\":PP 100,20:FT \"Swiss 721 BT\",10:PT \"Batch ID:  " + tb2.Text + "\":PF";
            }
            if (cbType.Text == "Evakueret")
            {
                printme = "NASC 1252:PP 50,85:FT \"Swiss 721 BT\",12:PT \"Evakueret med:\":PP 100,35:FT \"Swiss 721 Bold BT\",12:PT \"" + cb1.Text + "\":PF";
            }
            if (cbType.Text == "Ambu")
            {
                printme = "NASC 1252:PP 130,117:FT \"Swiss 721 Bold BT\",10:PT \"" + cbDato.Text + "\":PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 80,50:FT \"Swiss 721 BT\",10:PT \"Skyllet i oxygen\":PP 80,20:FT \"Swiss 721 BT\",10:PT \"Resttryk 10 bar\":PF";
            }
            if (cbType.Text == "Shipment")
            {
                printme = "NASC 1252:PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 80,50:FT \"Swiss 721 BT\",10:PT \"Efter\":PP 80,20:FT \"Swiss 721 BT\",10:PT \"Shipment 23\":PF";
            }
            if (cbType.Text == "Bulk")
            {
                printme = "NASC 1252:PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"STRANDMØLLEN\":PP 70,60:FT \"Swiss 721 BT\",10:PT \"Batch: " + tb1.Text + "\":PP 70,30:FT \"Swiss 721 BT\",10:PT \"Dato: " + tb2.Text + "\":PP 120,0:FT \"Swiss 721 BT\",10:PT \"INI: " + tb3.Text + "\":PF";
            }
            if (cbType.Text == "CO2 Netto Brutto")
            {
                printme = "NASC 1252:PP 120,90:FT \"Swiss 721 BT\",10:PT \"Tara: " + tb1.Text + "\":PP 120,60:FT \"Swiss 721 BT\",10:PT \"Netto: " + tb2.Text + "\":PP 120,30:FT \"Swiss 721 Bold BT\",10:PT \"Brutto: " + tb3.Text + "\":PP 120,0:FT \"Swiss 721 BT\",8:PT \"(incl. Bøjlehætte)\":PF";
            }
            if (cbType.Text == "Fremmede flasker")
            {
                printme = "NASC 1252:PP 40,100:FT \"Swiss 721 BT\",10:PT \"DATO: " + cbDato.Text + "\":PP 40,70:FT \"Swiss 721 BT\",10:PT \"Ordrenr:  " + tb1.Text + "\":PP 40,40:FT \"Swiss 721 BT\",10:PT \"Leverandør:  "+cb2.Text+ "\":PP 40,10:FT \"Swiss 721 BT\",10:PT \"Initialer:  "+ tb3.Text +"\":PF";
            }
            if (cbType.Text == "Kontrolleret")
            {
                printme = "NASC 1252:PP 50,85:FT \"Swiss 721 Bold BT\",12:PT \"Kontrolleret\":PP 100,50:FT \"Swiss 721 BT\",10:PT \"" + cbDato.Text + "\":PP 100,20:FT \"Swiss 721 BT\",10:PT \"INI:  " + tb1.Text + "\":PF";
            }

            float copies = Single.Parse(cbEtiketter.Text);
            string tmploc = Environment.GetEnvironmentVariable("TEMP") + "\\print.txt";
            StreamWriter w = new StreamWriter(tmploc, false, Encoding.GetEncoding(1252));
            printme = printme + " " + copies.ToString();
            w.WriteLine("SETUP \"FEEDADJ,STARTADJ," + (adjust - 88) + "\"");
            w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,WIDTH,376\"");
            w.WriteLine("SETUP \"MEDIA,MEDIA SIZE,LENGTH,192\"");
            w.WriteLine(printme);
            cbDato.Value = DateTime.Today;
            cbDato.Text = DateTime.Today.ToShortDateString();
            
            if (cbType.Text == "Ny Teknisk")
            {
                printme = @"NASC 1252:PP78,0:BT ""CODE128"":BH 100: PB """ + tb1.Text + @""":PP 95,100:FT ""Swiss 721 BT"",10:PT """ + "Batch " + tb1.Text + @""":PF";
               w.WriteLine(printme);
            }
            w.Close();
            File.Move(tmploc, prn);
            
            NewBatch();
            cbType.Text = "Vælg Type";

        }

        private void NewBatch()
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            cb1.Text = "";
            cb2.Text = "";
            cb2.Items.Clear();
            cb2.Items.Add("1");
            cb2.Items.Add("2");
            cb2.Items.Add("3");
            cbDato.Value = DateTime.Now;
        }

        private string SetPrinter()
        {
            string prn = "";

            if (rbPrnLocal.Checked)
            {
                prn = "LPT1";
                Printer = "Lokal";
            }
            if (rbPrnMed.Checked)
            {
                prn = "\\\\SRV-DIV-03\\PD41Med";
                Printer = "Medicinsk";
            }
            if (rbPrnTek.Checked)
            {
                prn = "\\\\SRV-DIV-03\\PD41Tek";
                Printer = "Teknisk";
            }
            if (rbPrnMora.Checked)
            {
                prn = "\\\\SRV-DIV-03\\PD41Mora";
                Printer = "Mora";
            }
            if (FLVRadioButton.Checked)
            {
                prn = "\\\\SRV-DIV-03\\PF4FLV";
                Printer = "FLV";
            }
            if (rbPrnLju.Checked)
            {
                prn = "\\\\SRV-DIV-03\\PD41Lju";
                Printer = "Ljungby";
            }

            return prn;
        }

        private void ClosingProgram(object sender, FormClosingEventArgs e)
        {
            SetPrinter();
            config.AppSettings.Settings.Add("Printer", Printer);
            config.Save(ConfigurationSaveMode.Modified);

            
        }

    }
}