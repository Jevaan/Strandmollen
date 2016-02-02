using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceTest.WebService1;

namespace ServiceTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            
            Service1SoapClient MyService = new Service1SoapClient();
            
            DataSet ds = MyService.GetData();
            
            dataGrid.DataSource = ds.Tables["Barcodes"];
        }
    }
}
