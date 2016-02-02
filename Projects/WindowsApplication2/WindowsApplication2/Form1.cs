using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        private int WM_KEYDOWN = 0x100;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                switch (ActiveControl.TabIndex)
                {
                    case 0:
                        textBox2.Focus();
                        break;
                    case 1:
                        textBox3.Focus();
                        break;
                    case 2:
                        textBox1.Focus();
                        break;
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                switch (ActiveControl.TabIndex)
                {
                    case 0:
                        textBox3.Focus();
                        break;
                    case 1:
                        textBox1.Focus();
                        break;
                    case 2:
                        textBox2.Focus();
                        break;
                }
            }

 //               MessageBox.Show(e.KeyCode.ToString());
        }
    }
}