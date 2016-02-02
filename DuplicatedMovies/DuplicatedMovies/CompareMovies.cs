using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DuplicatedMovies
{
    public partial class CompareMovies : Form
    {
        string MovieA;
        string MovieB;
        public CompareMovies(string MovA,string MovB)
        {
            InitializeComponent();
            MovieA = MovA;
            MovieB = MovB;
        }

        private void FormLoad(object sender, EventArgs e)
        {
            lbl_A_Name.Text = MovieA;
            lbl_B_Name.Text = MovieB;
        }

        private void btn_Keep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_A_Del_Click(object sender, EventArgs e)
        {
            try
            {
                var dir = new DirectoryInfo(MovieA);
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
                this.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_B_del_Click(object sender, EventArgs e)
        {
            try
            {
                var dir = new DirectoryInfo(MovieB);
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
                this.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
