using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Flaskefyldning
{
    public partial class LoadForm : Form
    {
        internal string _Loc;
        internal string _Draft;
        public LoadForm()
        {
            InitializeComponent();
            PubLocation();
            
            
        }

        private void StartClicked(object sender, EventArgs e)
        {
            if (Location_DropDown.Text != "")
            {
                _Loc = Location_DropDown.Text;
                _Draft = Draft_Textbox.Text;
                Form1 DataForm = new Form1();
                DataForm._Location = Location_DropDown.Text;
                this.Close();
            }
            else
                MessageBox.Show("Vælg lagersted!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

        }

        private void PubLocation()
        {
            Location_DropDown.Items.Clear();
            using (StreamReader reader = new StreamReader("\\Program Files\\Flaskefyldning\\Data\\Lager-sted.csv", Encoding.UTF7))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Location_DropDown.Items.Add(line.Replace('"',' ').Replace(';', '-'));
                    }
                }
            }

        }

        private void CheckNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        
       
    }


    public static class FormExtensions
    {
        public static void CenterForm(this Form theForm)
        {
            theForm.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width / 2 - theForm.Width / 2,
                Screen.PrimaryScreen.WorkingArea.Height / 2 - theForm.Height / 2);
        }
    }
}