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
    public partial class BatchScan : Form
    {
        public BatchScan()
        {
            InitializeComponent();
        }

        private void StartVnrScan(object sender, EventArgs e)
        {

        }

        private void StopVnrScan(object sender, EventArgs e)
        {

        }

        private void StartBatchScan(object sender, EventArgs e)
        {

        }

        private void StopBatch(object sender, EventArgs e)
        {

        }

        private void FormLoad(object sender, EventArgs e)
        {
            variantComboBox.SelectedIndex = 0;
        }
    }
}