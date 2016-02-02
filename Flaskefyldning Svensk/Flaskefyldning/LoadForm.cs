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
        
        
        public LoadForm()
        {
            InitializeComponent();
            
            
        }

        public void LoadData(object sender, EventArgs e)
        {
            
            DoingWhat_lbl.Text = "Starta program...";
            DoingWhat_lbl.Update();
            int n = 1;

            while (n < 100)
            {
                Loading_pb.Value = n;
                Thread.Sleep(100);
                n=n+4;
            }

            DoingWhat_lbl.Text = "Komplett";
            DoingWhat_lbl.Update();
            Loading_pb.Value = 100;
            Thread.Sleep(300);
            timer1.Enabled = false;
            this.Close();
        }

        private void Loaded(object sender, EventArgs e)
        {
            timer1.Enabled = true;
                       
            
           

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