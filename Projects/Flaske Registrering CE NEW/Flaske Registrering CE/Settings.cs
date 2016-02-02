using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlaskeRegistreringCE
{
    partial class Settings : System.Windows.Forms.Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        public bool[] getSettings
        {
            get
            {
                bool[] boolArray = new bool[7];
                boolArray[0] = checkBoxType.Checked;
                boolArray[1] = checkBoxSize.Checked;
                boolArray[2] = checkBoxPressureDate.Checked;
                boolArray[3] = checkBoxAir.Checked;
                boolArray[4] = checkBoxVendor.Checked;
                boolArray[5] = checkBoxProduced.Checked;
                boolArray[6] = checkBoxPressure.Checked;
                return boolArray;
            }
        }
    }
}