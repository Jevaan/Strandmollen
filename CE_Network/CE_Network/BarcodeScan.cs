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
    public partial class BarcodeScan : Form
    {
        public BarcodeScan()
        {
            InitializeComponent();
        }
       
        private void SearchBarcode(object sender, EventArgs e)
        {
            string SearchString = "Barcode = '" + StregkodeTextBox.Text + "'";
            /*DataSet MyDS = new BarcodeDataSet();
            DataTable MyDT = MyDS.Tables["Barcodes"];
            DataRow[] MyRows = MyDT.Select(SearchString);
            

            MessageBox.Show(MyRows.Length.ToString());*/
           
            
        }/*
        private void EnableReader(object sender, EventArgs e)
        {
            
            if (this.InitReader())
            {
                // Start a read on the reader
                this.StartRead();
            }

        }
        private bool InitReader()
        {
            // If reader is already present then fail initialize
            if (this.MyReader != null)
            {
                return false;
            }

            // Create new reader, first available reader will be used.
            this.MyReader = new Symbol.Barcode.Reader();

            // Create reader data
            this.MyReaderData = new Symbol.Barcode.ReaderData(
                Symbol.Barcode.ReaderDataTypes.Text,
                Symbol.Barcode.ReaderDataLengths.MaximumLabel);

            // Create event handler delegate
            this.MyEventHandler = new EventHandler(MyReader_ReadNotify);

            // Enable reader, with wait cursor
            this.MyReader.Actions.Enable();

            this.MyReader.Parameters.Feedback.Success.BeepTime = 0;
            this.MyReader.Parameters.Feedback.Success.WaveFile = "\\windows\\alarm3.wav";

            return true;
        }

        /// <summary>
        /// Stop reading and disable/close reader
        /// </summary>
        private void TermReader()
        {
            // If we have a reader
            if (this.MyReader != null)
            {
                // Disable the reader
                this.MyReader.Actions.Disable();

                // Free it up
                this.MyReader.Dispose();

                // Indicate we no longer have one
                this.MyReader = null;
            }

            // If we have a reader data
            if (this.MyReaderData != null)
            {
                // Free it up
                this.MyReaderData.Dispose();

                // Indicate we no longer have one
                this.MyReaderData = null;
            }
        }

        /// <summary>
        /// Start a read on the reader
        /// </summary>
        private void StartRead()
        {
            // If we have both a reader and a reader data
            if ((this.MyReader != null) &&
                 (this.MyReaderData != null))
            {
                // Submit a read
                this.MyReader.ReadNotify += this.MyEventHandler;
                this.MyReader.Actions.Read(this.MyReaderData);
            }
        }

        /// <summary>
        /// Stop all reads on the reader
        /// </summary>
        private void StopRead()
        {
            // If we have a reader
            if (this.MyReader != null)
            {
                // Flush (Cancel all pending reads)
                this.MyReader.ReadNotify -= this.MyEventHandler;
                this.MyReader.Actions.Flush();
            }
        }

        /// <summary>
        /// Read complete or failure notification
        /// </summary>
        private void MyReader_ReadNotify(object sender, EventArgs e)
        {
            Symbol.Barcode.ReaderData TheReaderData = this.MyReader.GetNextReaderData();

            // If it is a successful read (as opposed to a failed one)
            if (TheReaderData.Result == Symbol.Results.SUCCESS)
            {
                // Handle the data from this read
                this.HandleData(TheReaderData);

                // Start the next read
                this.StartRead();
            }
        }

        /// <summary>
        /// Handle data from the reader
        /// </summary>
        private void HandleData(Symbol.Barcode.ReaderData TheReaderData)
        {
            StregkodeTextBox.Text = TheReaderData.Text;

        }

        private void CloseReader(object sender, EventArgs e)
        {
            StopRead();
            TermReader();
        }*/
    }
}