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
    public partial class DupMovie : Form
    {
        string LastTitle = "";
        string LastFolder = "";
        int LastYear = 1901;
        public DupMovie()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.folderBrowser_Movie.ShowNewFolderButton = false;
            this.folderBrowser_Movie.RootFolder = System.Environment.SpecialFolder.MyComputer;
        }

        private void btn_PickFolder_Click(object sender, EventArgs e)
        {
            DialogResult Result = this.folderBrowser_Movie.ShowDialog();
            if (Result == DialogResult.OK)
            {
                tbox_LibraryFolder.Text = folderBrowser_Movie.SelectedPath.ToString();

            }
        }

        private void btn_FindDups_Click(object sender, EventArgs e)
        {
            foreach (string Dir in Directory.GetDirectories(folderBrowser_Movie.SelectedPath))
            {
                string Folder = Dir.Replace(folderBrowser_Movie.SelectedPath.ToString() + @"\", "");
                string[] Title = Folder.Split('.');
                string ThisTitle = MovieTitle(Title);
                if (ThisTitle == LastTitle)
                {
                    CompareMovies CompareDialog = new CompareMovies(Dir, LastFolder);
                    var dialogresult = CompareDialog.ShowDialog();
                }
                LastFolder = Dir;
                LastTitle = ThisTitle;
            }

        }
        private string MovieTitle(string[] Title)
        {
            string FixedTitle = "";
            foreach (string part in Title)
            {
                if (isYear(part))
                    break;
                else
                    FixedTitle += part + " ";
            }
            return FixedTitle;
        }
        private bool isYear(string Year)
        {
            try
            {
                LastYear = Int32.Parse(Year);
                if(LastYear < DateTime.Now.Year && LastYear > 1900)
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
