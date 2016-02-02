using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TCP_Server__PC_
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			timer.Tick += new EventHandler(timer_Tick);
		}

		TcpListener tcp_server;
		Timer timer = new Timer();
		/*private void button1_Click(object sender, EventArgs e)
		{
			if (tcp_server == null)
			{
				tcp_server = new TcpListener(new IPEndPoint(IPAddress.Any, 666));
				tcp_server.Start();

				timer.Interval = 500;
				timer.Start();

				button1.Text = "Stop server";
			}
			else
			{
				timer.Stop();

				tcp_server.Stop();
				tcp_server = null;

				button1.Text = "Start server";
			}
		}*/
		private void timer_Tick(object sender, EventArgs e)
		{
			if (tcp_server == null) return;

			if (tcp_server.Pending())
				ProcessTcpClient(tcp_server.AcceptTcpClient());
		}
		private void ProcessTcpClient(TcpClient tcp_client)
		{
			if (tcp_client == null) return;

			NetworkStream net_stream;
			try
			{
				net_stream = tcp_client.GetStream();
				string message = DownloadData(net_stream);
                if (message == "Done")
                {
                    UploadData(net_stream, "OK");
                    
                   
                }
                else
                {
                    string[] rString = message.Split(new char[] { '#' });

                    // *** Write to file ***

                    // Create a new stream to write to the file
                    StreamWriter sw = new StreamWriter(rString[1], false, Encoding.GetEncoding(1252));

                    // Write a string to the file
                    sw.Write(rString[2]);

                    // Close StreamWriter
                    sw.Close();

                    if (File.Exists("Data.txt"))
                    {
                        try
                        {
                            File.Copy("Data.txt", "LPT1");
                            if (File.Exists("DataOld.txt"))
                                File.Delete("DataOld.txt");
                            File.Move("Data.txt", "DataOld.txt");
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Fejl ved udskrivning:\r\n" + e.Message);
                        }
                        bool test = File.Exists("Data.txt");
                    }

                    if (File.Exists(rString[1]))
                    {
                        try
                        {

                            File.Move(rString[1], @"\\Srstrand-02-sql\Flaskeregistrering\Exportdata\" + rString[1]);
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("Ingen kontakt til SQL server:\r\n" + e.Message);
                        }
                    }
                }
				                
				net_stream.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
			}
			finally
			{
				net_stream = null;
			}
		}
		private string DownloadData(NetworkStream net_stream)
		{
			string message = "";
			byte[] read_buffer = new byte[1024];
			List<byte> msg_bytes = new List<byte>();
			try
			{
				if (net_stream.CanRead)
				{
					int n = 0;
					bool working = true;
					while (working)
					{
						n = net_stream.Read(read_buffer, 0, read_buffer.Length);
						if (Array.IndexOf<byte>(read_buffer, Convert.ToByte(3)) > -1)
						{
							n--;
							working = false;
						}
						for (int i = 0; i < n; i++)
							msg_bytes.Add(read_buffer[i]);
						Application.DoEvents();
					}
					byte[] msg_bytes_arr = msg_bytes.ToArray();
					message = System.Text.Encoding.GetEncoding(1252).GetString(msg_bytes_arr, 0, msg_bytes_arr.Length);

					msg_bytes_arr = null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
			}
			finally
			{
				read_buffer = null;
				msg_bytes = null;
			}
			return message;
		}
		private void UploadData(NetworkStream net_stream, string Data)
		{
			try
			{
				byte[] msg = Encoding.GetEncoding(1252).GetBytes(Data + Convert.ToChar(Convert.ToByte(3)));
				net_stream.Write(msg, 0, msg.Length);
				msg = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
			}
		}

        private void StartServer(object sender, EventArgs e)
        {
            tcp_server = new TcpListener(new IPEndPoint(IPAddress.Any, 666));
            tcp_server.Start();

            timer.Interval = 500;
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Copy("DataOld.txt", "LPT1");
        }

        
	}
}