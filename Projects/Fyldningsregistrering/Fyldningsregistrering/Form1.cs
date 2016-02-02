using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Fyldningsregistrering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private Symbol.Barcode.Reader MyReader = null;
        private Symbol.Barcode.ReaderData MyReaderData = null;
        private System.EventHandler MyEventHandler = null;
        private string Varenummer;
        private DataRow DelRow = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fyldningDataSet.Rampe' table. You can move, or remove it, as needed.
            this.rampeTableAdapter.Fill(this.fyldningDataSet.Rampe);
            
            if (this.InitReader())
            {
                // Start a read on the reader
                this.StartRead();
            }
            else
            {
                // If not, close this form
                this.Close();

                return;
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

            // Attach to activate and deactivate events
            this.Activated += new EventHandler(ReaderForm_Activated);
            this.Deactivate += new EventHandler(ReaderForm_Deactivate);


            return true;
        }

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


            Varenummer = TheReaderData.Text;
            tbVNr.Text = Varenummer;

            SqlCeConnection Myconnection = null;
            SqlCeDataReader dbReader = null;

            string sql = "SELECT * FROM Produkter WHERE Nummer = '" + Varenummer + "'";

            Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Fyldningsregistrering\fyldning.sdf'; Password =''");
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = sql;
            dbReader = cmd.ExecuteReader();
            tbVNavn.Text = "Ukendt";
            while (dbReader.Read())
                tbVNavn.Text = dbReader.GetString(1);
            dbReader.Close();
            Myconnection.Close();
            
        }

        /// <summary>
        ///  Handler for when the form is actived.  This would occur when this application becomes the current
        ///  application
        /// </summary>
        private void ReaderForm_Activated(object sender, EventArgs e)
        {
            // If there are no reads pending on MyReader start a new read
            if (!this.MyReaderData.IsPending)
                this.StartRead();
        }

        /// <summary>
        ///  Handler for when the form is deactivated.  This would be called if another application became the current
        ///  application. This stops the reading of data from the reader.
        /// </summary>
        private void ReaderForm_Deactivate(object sender, EventArgs e)
        {
            this.StopRead();
        }
        
        private void TriggerButton_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks if the key pressed was an enter button (character code 13)
            if (e.KeyValue == (char)13)
                btAdd_Click(this.btAdd, EventArgs.Empty);
                
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            fyldningDataSet.RampeRow nyFyldning = fyldningDataSet.Rampe.NewRampeRow();
            nyFyldning.Antal = byte.Parse(tbAntal.Text);
            nyFyldning.Nummer = tbVNr.Text;
            nyFyldning.Navn = tbVNavn.Text;
            fyldningDataSet.Rampe.Rows.Add(nyFyldning);
            
            tbAntal.Text = "";
            tbAntal.Focus();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            DelRow = fyldningDataSet.Rampe.Rows[dataGrid1.CurrentCell.RowNumber];
            DelRow.Delete();
            try
            {
                rampeTableAdapter.Update(this.fyldningDataSet.Rampe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            tbAntal.Text = "";
            tbAntal.Focus();
           
        }

    }
}