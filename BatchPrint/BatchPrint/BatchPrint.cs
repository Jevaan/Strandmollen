using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Principal;
using System.DirectoryServices;

namespace BatchPrint
{
    public partial class BatchPrint : Form
    {
        private bool AdminRights = false;
        private string UserName = "Ukendt";
        private string TestString = "";
        public BatchPrint()
        {
            InitializeComponent();

            
            
        }
        public static DirectoryEntry GetDirectoryEntry()
        {
            DirectoryEntry de = new DirectoryEntry();
            de.Path = "LDAP://DC=strandmollen,DC=local";
            de.AuthenticationType = AuthenticationTypes.Secure;
            return de;
        }
        private bool CheckRights(String userAccount)
        {
            bool Admin = false;
            DirectoryEntry entry = GetDirectoryEntry();
            String account = userAccount.Replace(@"STRANDMOLLEN\", "");
            TestString += account;
            try
            {
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + account + ")";
                search.PropertiesToLoad.Add("displayName");
                search.PropertiesToLoad.Add("memberOf");
                SearchResultCollection results = search.FindAll();

                foreach (SearchResult result in results)
                {
                    ResultPropertyCollection rpc = result.Properties;
                    foreach (object value in rpc["displayName"])
                    {
                        TestString += "\n" + value.ToString();
                        if(value.ToString().Length > 4)
                            UserName = value.ToString();

                    }

                    foreach (object value in rpc["memberOf"])
                    {
                        TestString += "\n" + value.ToString();
                        
                        string[] splitter = value.ToString().Split(',');
                        foreach (string spl in splitter)
                        {
                            
                            if (spl.Contains("Citrix_MedBatch"))
                            {
                                DKImg.Enabled = true;
                            }
                            if (spl.Contains("Citrix_MedBatchSE"))
                            {
                                SEImg.Enabled = true;
                            }
                            if (spl.Contains("Citrix_MedBatchDE"))
                            {
                                DEImg.Enabled = true;
                            }
                            if (spl.Contains("BatchAdmin"))
                            {
                                DKImg.Enabled = true;
                                SEImg.Enabled = true;
                                DEImg.Enabled = true;
                                Admin = true;
                            }
                            
                        }
                        //return Admin;
                    }
                   
                }
                return Admin;
            }
            catch (Exception ex)
            {
                string debug = ex.Message;

                return false;
            }
        }

        private void FormLoad(object sender, EventArgs e)
        {
            ToolTip dktt = new ToolTip();
            dktt.SetToolTip(DKImg, "DK Batch");
            ToolTip sett = new ToolTip();
            sett.SetToolTip(SEImg, "SE Batch");
            ToolTip dett = new ToolTip();
            dett.SetToolTip(DEImg, "DE Batch");
            AdminRights = CheckRights(WindowsIdentity.GetCurrent().Name);
            UserName_lbl.Text = UserName;
            //MessageBox.Show(TestString);
            if (AdminRights)
                Admin_btn.Visible = true;
            if (!DKImg.Enabled)
                DKImg.Image = ConvertToGrayscale(DKImg.Image);
            if (!SEImg.Enabled)
                SEImg.Image = ConvertToGrayscale(SEImg.Image);
            if (!DEImg.Enabled)
                DEImg.Image = ConvertToGrayscale(DEImg.Image);
        }

        private void OpenAdminModule(object sender, EventArgs e)
        {
            Admin AdminForm = new Admin();
            AdminForm.Show();
        }

        private void OpenDK(object sender, EventArgs e)
        {
            Icon ico = new Icon("DK.ico");
            MedBatch MyDKWindow = new MedBatch(true, false, false, AdminRights);
            MyDKWindow.Icon = ico;
            MyDKWindow.Text = "Dansk Batch";
            MyDKWindow.Show();
        }

        private void OpenSE(object sender, EventArgs e)
        {
            Icon ico = new Icon("SWE.ico");
            MedBatch MySEWindow = new MedBatch(false, true, false, AdminRights);
            MySEWindow.Icon = ico;
            MySEWindow.Text = "Svensk Batch";
            MySEWindow.Show();

        }
                
        private void OpenDE(object sender, EventArgs e)
        {
            Icon ico = new Icon("DE.ico");
            MedBatch MyDEWindow = new MedBatch(false, false, true, AdminRights);
            MyDEWindow.Text = "Tysk Batch";
            MyDEWindow.Icon = ico;
            MyDEWindow.Show();
        }
        
        public Image ConvertToGrayscale(Image image)
        {
            Image grayscaleImage = new Bitmap(image.Width, image.Height, image.PixelFormat);

            // Create the ImageAttributes object and apply the ColorMatrix
            ImageAttributes attributes = new System.Drawing.Imaging.ImageAttributes();
            ColorMatrix grayscaleMatrix = new ColorMatrix(new float[][]{
        new float[] {0.299f, 0.299f, 0.299f, 0, 0},
        new float[] {0.587f, 0.587f, 0.587f, 0, 0},
        new float[] {0.114f, 0.114f, 0.114f, 0, 0},
        new float[] {     0,      0,      0, 1, 0},
        new float[] {     0,      0,      0, 0, 1}
        });
            attributes.SetColorMatrix(grayscaleMatrix);

            // Use a new Graphics object from the new image.
            using (Graphics g = Graphics.FromImage(grayscaleImage))
            {
                // Draw the original image using the ImageAttributes created above.
                g.DrawImage(image,
                            new Rectangle(0, 0, grayscaleImage.Width, grayscaleImage.Height),
                            0, 0, grayscaleImage.Width, grayscaleImage.Height,
                            GraphicsUnit.Pixel,
                            attributes);
            }

            return grayscaleImage;
        }
       
    }
}
