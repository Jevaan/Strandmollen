using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WSStringTest.StringWriterWS;

namespace WSStringTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoGoGo(object sender, EventArgs e)
        {
            Service1SoapClient StringWS = new Service1SoapClient();

            if (StringWS.StringWriter(Text_txt.Text, Filename_txt.Text, Location_txt.Text))
                MessageBox.Show("OK");
            else
                MessageBox.Show("Fejl");

        }

        private void GetFile(object sender, EventArgs e)
        {
            Service1SoapClient StringWS = new Service1SoapClient();
            StringWriterWS.ArticleFile test = StringWS.StringReader("Vare.csv", @"\\SRV-DIV-04\CSV$\Data\");
            MessageBox.Show(test.AllLines[1]);
            MessageBox.Show(test.AllLines[2]);
            MessageBox.Show(test.Name);
            
        }
    }
}
