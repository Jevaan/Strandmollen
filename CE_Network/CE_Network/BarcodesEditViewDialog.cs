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
    public partial class BarcodesEditViewDialog : Form
    {
        public BarcodesEditViewDialog()
        {
            InitializeComponent();
        }

        private void BarcodesEditViewDialog_Closing(object sender, CancelEventArgs e)
        {
            this.barcodesBindingSource.EndEdit();

        }
    }
}