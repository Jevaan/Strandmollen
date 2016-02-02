using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CEscan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            barcode1.EnableScanner = true;
            
            
        }

        private void UpdateText(object sender, Symbol.Barcode.ReaderData readerData)
        {
            textBox1.Text = readerData.Text;
        }
    }
}