using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Flaskestyring
{
    public partial class Form1 : Form
    {
        private string TestString;
        private string LastInput;
        public Form1()
        {
            InitializeComponent();
            LastInput = "]";
        }

        private void SetDate(string ItemNumber, string ItemName, string Batch, string ProdDate, string ExpireDate, string Location, string Status, string Received, string BottleNo)
        {
            ItemNumberDisplay.Text = ItemNumber;
            ItemTextDisplay.Text = ItemName;
            BatchDisplay.Text = Batch;
            ProductionDateDisplay.Text = ProdDate;
            ExpireDisplay.Text = ExpireDate;
            LocationDisplay.Text = Location;
            StatusDisplay.Text = Status;
            RecievedDisplay.Text = Received;
            BottleNoLbl.Text = BottleNo;
            BottleNumberTextBox.Text = "";

        }

        private void NumberEntered()
        {
            if (LastInput == "" || LastInput == null)
                LastInput = "]";
            TestString += BottleNumberTextBox.Text.Replace(LastInput, "");
            LastInput = BottleNumberTextBox.Text;
            //BottleNumberTextBox.Text = Regex.Replace(BottleNumberTextBox.Text, "[^0-9]", "");
            if (TestString.Length > 13)
                TestString = TestString.Remove(0, 1);
            if (TestString.Length == 13)
            {
                /*if (TestString != "1000500017003" && TestString != "1000200032288")
                    SetDate("Ukendt", "Ukendt", "Ukendt", "Ukendt", "Ukendt", "Ukendt", "Ukendt", "Ukendt","Ukendt");*/
                if (TestString == "1000500017003")
                    SetDate("1005M3Q2", "Oxygen MED LINE KVIK-TOP/Alu 5L 200 bar", "7766", "30.09.2009", "30.09.2011", "1028 Slagelse Sygehus afd. D3", "OK", "19.10.2009", "1000500017003");
                if (TestString == "1000200032288")
                    SetDate("1002M3Q2", "OXYGEN MED LINE Kvik-Top/Alu 2l 200 Bar", "7766", "30.09.2009", "30.09.2011", "1026 Slagelse Sygehus afd. B1", "OK", "26.10.2009", "1000200032288");
                
            }


        }
                

        private void DataScanned(object sender, EventArgs e)
        {
            if (StatusDisplay.Text == "OK" && StatusDisplay.Text == "Ukendt")
            {
                BottleNumberTextBox.Text = "";
                SetDate("", "", "", "", "", "", "", "","");
            }
            NumberEntered();
        }
        
    }
}