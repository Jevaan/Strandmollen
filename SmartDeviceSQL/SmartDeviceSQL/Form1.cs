using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceSQL.srv_div_02;

namespace SmartDeviceSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetBarcode GetBarCodes = new GetBarcode();
            GetBarCodes.Credentials = System.Net.CredentialCache.DefaultCredentials;

            DataSet ds = ((DataSet)GetBarCodes.BottleList);

            dataGrid1.DataSource = ds;
        }
    }
}