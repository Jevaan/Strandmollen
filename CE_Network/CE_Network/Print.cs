using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CE_Network
{
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void PrintLoad(object sender, EventArgs e)
        {
            BarcodePrinterDisplay.Text = Form1.BarcodePrint;
            StreamerPrinterDisplay.Text = Form1.BatteryPrint;
            CopiesComboBox.Text = "3";
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Form1.copies = Int32.Parse(CopiesComboBox.Text);
            this.Close();
        }
    }
}