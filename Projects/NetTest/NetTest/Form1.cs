using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace NetTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeViewCtr.Nodes.Clear();
            TreeNode node = new TreeNode();
            if (Directory.Exists(@"\"))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"\");
                DirectoryInfo[] subdirInfo = dirInfo.GetDirectories();
                if (subdirInfo.Length > 0)
                {
                    foreach (DirectoryInfo dri in subdirInfo)
                    {
                        node = treeViewCtr.Nodes.Add(dri.Name);
                        GetFiles(dri, node);
                    }
                }
                FileInfo[] fileInfo = dirInfo.GetFiles("*.*");
                if (fileInfo.Length > 0)
                {
                    for (int k = 0; k < fileInfo.Length; k++)
                    {
                        treeViewCtr.Nodes.Add(fileInfo[k].Name);
                    }
                }
            }
            
        }
        //
        //  GetFiles is a method which gets all the files and subfolders from a Directory info.
        //

        private void GetFiles(DirectoryInfo dri, TreeNode node)
        {
            DirectoryInfo[] dInfo = dri.GetDirectories();
            if (dInfo.Length > 0)
            {
                TreeNode treeNode = new TreeNode();
                foreach (DirectoryInfo driSub in dInfo)
                {
                    treeNode = node.Nodes.Add(driSub.Name);
                    GetFiles(driSub, treeNode);
                }
            }
            FileInfo[] subfileInfo = dri.GetFiles("*.*");
            if (subfileInfo.Length > 0)
            {
                for (int j = 0; j < subfileInfo.Length; j++)
                {
                    node.Nodes.Add(subfileInfo[j].Name);
                }
            }
        }

        //
        // This code executed when the tree node is selested. Write this code in the Tree view controls After_Selected Event.
        //

        private void treeViewCtr_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblSelectedItem.Text = @"\" + FixPath(e.Node).ToString();
            lblSelectedItem.Refresh();
        }


        //
        // The FillPath Methos CAlled the about After_Select Event is to get the selected file or Directory FullPath.
        // FillPath() Method

        public string FixPath(TreeNode treeNode)
        {
            string setReturn = "";
            try
            {
                setReturn = treeNode.FullPath;
                int index = setReturn.IndexOf("\\\\");
                if (index > 1)
                {
                    setReturn = treeNode.FullPath.Remove(index, 1);
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
            return setReturn;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int result = 0;

            result = InetState.InternetGetConnectedStateEx(result, sb, 254, 0);
            if (result == 1)
            {
                MessageBox.Show("Connected using: " + sb.ToString());
            }
            else
            {
                MessageBox.Show("Not connected");
            }
        }

        public class InetState
        {
            [DllImport("wininet.dll")]
            public static extern int InternetGetConnectedStateEx(int lpdwFlags, StringBuilder lpszConnectionName, int dwNameLen, long dwReserved);
        }
    }
    


}
