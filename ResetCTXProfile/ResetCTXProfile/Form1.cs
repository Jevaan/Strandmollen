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

namespace ResetCTXProfile
{
    public partial class rstctx : Form
    {
        public static int filecopies;
        public rstctx()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {

        }

        
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
                filecopies++;
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void fromclick(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = @"\\ctxprofiles\ctxprofiles$\";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                from_txtbox.Text = folderBrowserDialog1.SelectedPath;
                char[] MyChar = { 'b', 'a', 'k', 'g', 'e', 'm', 'c', 'o', 'l', 'd', '.' };
                
                if (Directory.Exists(from_txtbox.Text.TrimEnd(MyChar)))
                    totxtbox.Text = folderBrowserDialog1.SelectedPath = from_txtbox.Text.TrimEnd(MyChar);
            }
        }

        private void toclick(object sender, EventArgs e)
        {
            char[] MyChar = {'b','a','k','g','e','m','c','o','l','d', '.' };
            
            folderBrowserDialog1.SelectedPath = from_txtbox.Text.TrimEnd(MyChar);
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
                totxtbox.Text = folderBrowserDialog1.SelectedPath;

        }

        private void CopyStuff(object sender, EventArgs e)
        {
            filecopies = 0;
            string sigA = @"\AppData\Roaming\Microsoft\Signaturer";
            string sigB = @"\AppData\Roaming\Microsoft\Signatures";
            string outlook = @"\AppData\Roaming\Microsoft\Outlook";
            //\\ctxprofiles\ctxprofiles$\at.STRANDMOLLEN.V2
            if (tb_Initials.Text != "")
            {
                from_txtbox.Text = @"\\ctxprofiles\ctxprofiles$\" + tb_Initials.Text + @".STRANDMOLLEN.V2.gem";
                totxtbox.Text = @"\\ctxprofiles\ctxprofiles$\" + tb_Initials.Text + @".STRANDMOLLEN.V2";
            }
            try
            {
                FileInfo PrinterFiler = new FileInfo(from_txtbox.Text + @"\DefaultPrinter.reg");
                string temppath = @"\\ctxprofiles\ctxprofiles$\" + tb_Initials.Text + @".STRANDMOLLEN.V2\" + PrinterFiler.Name;
                PrinterFiler.CopyTo(temppath, true);
                filecopies++;
            }
            catch
            {
                MessageBox.Show("Error setting default printer.");
            }
            if (outlookchk.Checked)
                DirectoryCopy(from_txtbox.Text + outlook, totxtbox.Text + outlook, true);
            if (signaturchk.Checked)
            {
                try
                {
                    DirectoryCopy(from_txtbox.Text + sigA, totxtbox.Text + sigA, true);
                }
                catch { }
                try
                {
                    DirectoryCopy(from_txtbox.Text + sigB, totxtbox.Text + sigB, true);
                }
                catch { }
            }
            if(favchk.Checked)
                DirectoryCopy(from_txtbox.Text + @"\favorites", totxtbox.Text + @"\favorites", true);
            if(desktopchk.Checked)
                DirectoryCopy(from_txtbox.Text + @"\desktop", totxtbox.Text + @"\desktop", true);
            if(documentschk.Checked)
                DirectoryCopy(from_txtbox.Text + @"\documents", totxtbox.Text + @"\documents", true);
            if(Downloadschk.Checked)
                DirectoryCopy(from_txtbox.Text + @"\downloads", totxtbox.Text + @"\downloads", true);

            MessageBox.Show(filecopies.ToString() + " filer kopieret", "Fuldført", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
