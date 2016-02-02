using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCP_Client__PocketPC_
{
	public partial class Form1 : Form
	{
        string message = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TcpClient tcp_client;
			NetworkStream net_stream;
            
            try
            {
                tcp_client = new TcpClient("ppp_peer", 666);
                net_stream = tcp_client.GetStream();

                UploadData(net_stream, "Hello");
                message = DownloadData(net_stream);
                MessageBox.Show(message);

                net_stream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                net_stream = null;
                tcp_client = null;
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
					message = System.Text.Encoding.UTF8.GetString(msg_bytes_arr, 0, msg_bytes_arr.Length);

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
				byte[] msg = Encoding.UTF8.GetBytes(Data + Convert.ToChar(Convert.ToByte(3)));
				net_stream.Write(msg, 0, msg.Length);
				msg = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
            TcpClient tcp_client;
            NetworkStream net_stream;

            try
            {
                tcp_client = new TcpClient("ppp_peer", 666);
                net_stream = tcp_client.GetStream();

                UploadData(net_stream, "Bye");
                message = DownloadData(net_stream);
                net_stream.Close();
                if (message == "Bye")
                {
                    MessageBox.Show("Overførsel OK");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                net_stream = null;
                tcp_client = null;
            }
        }

        private void buttonAxa_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"\My Documents\FlaskeData\");
            FileInfo[] fileInfo = dirInfo.GetFiles("*.*");
            if (fileInfo.Length > 0)
            {
                for (int k = 0; k < fileInfo.Length; k++)
                {
                    try
                    {
                        // Create an instance of StreamReader to read from a file.
                        // The using statement also closes the StreamReader.
                        using (StreamReader sr = new StreamReader(@"\My Documents\FlaskeData\" + fileInfo[k].Name))
                        {
                            String line;
                            string allLines = null;
                            TcpClient tcp_client;
                            NetworkStream net_stream;
                            int noLines = 0;
                            
                            while ((line = sr.ReadLine()) != null)
                            {
                                allLines += line + "\r\n";
                                ++noLines;
                                
                            }
                            try
                            {
                                tcp_client = new TcpClient("ppp_peer", 666);
                                net_stream = tcp_client.GetStream();

                                UploadData(net_stream, "#" + fileInfo[k].Name + "#" + noLines.ToString() + "\r\n#" +allLines);

                                net_stream.Close();
                                


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error!\n" + ex.Message + "\n" + ex.StackTrace);
                            }
                            finally
                            {
                                net_stream = null;
                                tcp_client = null;
                            }
                            
                        }
                    }
                    catch (Exception eX)
                    {
                        MessageBox.Show("The file could not be read:" + eX.Message);
                        
                    }
                 }
            }
            
        }
	}
}