using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void PaintUpd(object sender, PaintEventArgs e)
        {

            // Get Graphics Object
            Graphics g = e.Graphics;
            g.Clear(Color.LightGray);

            // Method under System.Drawing.Graphics
            Pen blackpen = new Pen(Color.Black, 3);
            Rectangle Etiket = new Rectangle(270, 20, 178, 80);
            g.DrawRectangle(blackpen,Etiket);
            g.FillRectangle(new SolidBrush(Color.White), Etiket);
            g.DrawString("STRANDMØLLEN", new Font("Arial", 12, FontStyle.Bold), new SolidBrush(Color.Black), 285, 25);
            if (comboBox1.Text == "Skyllet")
            {
                g.DrawString("Skyllet i oxygen", new Font("Arial", 12), new SolidBrush(Color.Black), 295, 50);
                g.DrawString("Resttryk 10 bar", new Font("Arial", 12), new SolidBrush(Color.Black), 295, 70);
 
            }
            

        }

        private void Updated(object sender, EventArgs e)
        {
            

        }
        private PictureBox LabelBox = new PictureBox();
        private void PaintNow(object sender, EventArgs e)
        {
            LabelBox.Dock = DockStyle.Fill;
            LabelBox.BackColor = Color.LightGray;
            LabelBox.Paint +=new PaintEventHandler(this.PaintUpd);
            LabelBox.Refresh();
            this.Controls.Add(LabelBox);

        }
        
    }
}