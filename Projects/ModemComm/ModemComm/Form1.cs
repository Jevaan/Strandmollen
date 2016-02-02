using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ModemComm
{
    public partial class Form1 : Form
    {
        SerialPort MyComm = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            MyComm.Open();
                        
            MyComm.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

            MyComm.WriteLine("AT+CMGR=20\n");
            //MyComm.WriteLine("!H \n");
            //MyComm.WriteLine("!D 0 2 0 8 5 1 1 2 2 \n");
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            textBox1.Text = textBox1.Text + MyComm.ReadExisting();
        }
    }
}