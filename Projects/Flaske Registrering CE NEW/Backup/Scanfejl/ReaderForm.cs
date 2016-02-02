using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Scanfejl
{
    public partial class ReaderForm : Form
    {
        public ReaderForm()
        {
            InitializeComponent();
        }
		private System.Windows.Forms.Button CloseButton;

		private Symbol.Barcode.Reader MyReader = null;
		private Symbol.Barcode.ReaderData MyReaderData = null;
        private System.EventHandler MyEventHandler = null;
		private System.Windows.Forms.Label ReaderDataLabel;
        public string fejlnummer;
		/// <summary>
		/// Occurs before the form is displayed for the first time.
		/// </summary>
		private void ReaderForm_Load(object sender, System.EventArgs e)
		{
			// If we can initialize the Reader
			if ( this.InitReader() )
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

			// Add MainMenu if Pocket PC
			if(Symbol.Win32.PlatformType == "PocketPC")
			{
				this.Menu = new MainMenu();
			}

		}

		/// <summary>
		/// Click from the close button
		/// </summary>
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			// Close this form
			this.Close();
		}

		/// <summary>
		/// Handles when the user selects the close button from the keyboard.
		/// </summary>
		private void CloseButton_KeyDown(object sender, KeyEventArgs e)
		{
			// Checks to see if the key pressed was the enter key (character code 13)
			if (e.KeyValue == (char)13)
				CloseButton_Click(null, e);
		}
	
		/// <summary>
		/// Application is closing
		/// </summary>
		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			// Terminate reader
			this.TermReader();

			base.OnClosing(e);
		}

		/// <summary>
		/// Initialize the reader.
		/// </summary>
		private bool InitReader()
		{
			// If reader is already present then fail initialize
			if ( this.MyReader != null )
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
			this.Activated +=new EventHandler(ReaderForm_Activated);
			this.Deactivate +=new EventHandler(ReaderForm_Deactivate);


			return true;
		}

		/// <summary>
		/// Stop reading and disable/close reader
		/// </summary>
		private void TermReader()
		{
			// If we have a reader
			if ( this.MyReader != null )
			{
				// Disable the reader
				this.MyReader.Actions.Disable();

				// Free it up
				this.MyReader.Dispose();

				// Indicate we no longer have one
				this.MyReader = null;
			}

			// If we have a reader data
			if ( this.MyReaderData != null )
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
			if ( ( this.MyReader != null ) &&
				 ( this.MyReaderData != null ) )
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
			if ( this.MyReader != null )
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
			if ( TheReaderData.Result == Symbol.Results.SUCCESS )
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
			

			fejlnummer = TheReaderData.Text;
            ReaderBox.Text = fejlnummer;

            System.IO.FileStream fs = new System.IO.FileStream(@"\My Documents\Fejl" + fejlnummer + ".err", System.IO.FileMode.Create);
            System.IO.StreamWriter st = new System.IO.StreamWriter(fs);
            st.WriteLine("Fejl ved flaske: " + fejlnummer + " fjernet d." + DateTime.Now.ToShortDateString());
            st.Close();
            fs.Close();
            System.IO.File.Move(@"\My Documents\Fejl" + fejlnummer + ".err", @"\My Documents\FlaskeData\Fejl" + fejlnummer + ".err");

            SqlCeConnection Myconnection = null;
            SqlCeDataReader dbReader = null;

            string sql = "DELETE FROM BottleRegistred WHERE BottleBarcode = '" + fejlnummer + "'";
            
            Myconnection = new SqlCeConnection(@"Data Source = '\Program Files\Flaske Registrering CE\flreg.sdf'; Password =''");
            Myconnection.Open();

            SqlCeCommand cmd = Myconnection.CreateCommand();
            cmd.CommandText = sql;
            dbReader = cmd.ExecuteReader();

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
			if ( !this.MyReaderData.IsPending )
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

		private void TriggerButton_Click(object sender, System.EventArgs e)
        {
            if (this.MyReader == null)
            {
                return;
            }
            this.MyReader.Actions.ToggleSoftTrigger();
        }
        private void TriggerButton_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks if the key pressed was an enter button (character code 13)
            if (e.KeyValue == (char)13)
                TriggerButton_Click(this, e);
        }
        
	}
}
