using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Flaskefyldning
{
    public partial class BarcodeList : Form
    {
        public string[] Barcodes;
        public BarcodeList(string[] BarcodeArray)
        {
            InitializeComponent();
            Barcodes = BarcodeArray;
        }

        private void GetBarcodes(object sender, EventArgs e)
        {
            foreach (string BC in Barcodes)
            {
                if (BC != "" && BC != null)
                    Barcodes_tb.Text += BC + "\r\n";
            }
        }
    }
}