using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CSV_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckArt(object sender, EventArgs e)
        {


            using (StreamReader reader = new StreamReader("Vare.csv"))
            {
                label1.Visible = false;
                int test = 0;
                string line;

                if (textBox1.TextLength > 3)
                {
                    try
                    {
                        while ((line = reader.ReadLine()) != null && test < 1658)
                        {
                            if (line != "" && line.Split(';')[0].Replace("\"", "") == textBox1.Text)
                            {
                                label1.Visible = true;

                            }
                            
                            test++;
                        }
                    }
                    catch { }
                }
            }
        }
    }
}