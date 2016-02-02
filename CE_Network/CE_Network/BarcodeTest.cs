using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Intermec.DataCollection;


namespace CE_Network
{
    public partial class BarcodeTest : Form
    {
        private Form1 MainForm;
        private BarcodeReader bcr;
        public BarcodeTest(Form1 frm)
        {
            InitializeComponent();
            MainForm = frm;
        }

        //private Symbol.Barcode.Reader MyReader = null;
        //private Symbol.Barcode.ReaderData MyReaderData = null;
        //private System.EventHandler MyEventHandler = null;
       
        private void EnableReader(object sender, EventArgs e)
        {

            try
            {
                bcr = new BarcodeReader("AllScanners");
                bcr.ScannerEnable = true;
                bcr.BarcodeRead += new BarcodeReadEventHandler(HandleData);
                bcr.ThreadedRead(true);

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }




        private void HandleData(object sender, BarcodeReadEventArgs bre)
        {
            BarcodeScanLabel.Text = bre.strDataBuffer;

        }

        private void CloseReader(object sender, CancelEventArgs e)
        {
            try
            {
                if (bcr != null)
                {
                    bcr.ScannerEnable = false;
                    bcr.Dispose();
                    bcr = null;
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
       

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MainForm.AddBarcode(BarcodeScanLabel.Text);
            MessageBox.Show("Scannet stregkode bliver udskrevet med næste sæt");
        }

        
    }
}