namespace DuplicatedMovies
{
    partial class DupMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DupMovie));
            this.grp_MovieFolder = new System.Windows.Forms.GroupBox();
            this.btn_PickFolder = new System.Windows.Forms.Button();
            this.tbox_LibraryFolder = new System.Windows.Forms.TextBox();
            this.chk_InclSubFolders = new System.Windows.Forms.CheckBox();
            this.folderBrowser_Movie = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_FindDups = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.grp_MovieFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_MovieFolder
            // 
            this.grp_MovieFolder.Controls.Add(this.btn_PickFolder);
            this.grp_MovieFolder.Controls.Add(this.tbox_LibraryFolder);
            this.grp_MovieFolder.Controls.Add(this.chk_InclSubFolders);
            this.grp_MovieFolder.Location = new System.Drawing.Point(12, 12);
            this.grp_MovieFolder.Name = "grp_MovieFolder";
            this.grp_MovieFolder.Size = new System.Drawing.Size(251, 80);
            this.grp_MovieFolder.TabIndex = 0;
            this.grp_MovieFolder.TabStop = false;
            this.grp_MovieFolder.Text = "Movie Library Folder";
            // 
            // btn_PickFolder
            // 
            this.btn_PickFolder.Location = new System.Drawing.Point(167, 51);
            this.btn_PickFolder.Name = "btn_PickFolder";
            this.btn_PickFolder.Size = new System.Drawing.Size(75, 23);
            this.btn_PickFolder.TabIndex = 2;
            this.btn_PickFolder.Text = "Locate";
            this.btn_PickFolder.UseVisualStyleBackColor = true;
            this.btn_PickFolder.Click += new System.EventHandler(this.btn_PickFolder_Click);
            // 
            // tbox_LibraryFolder
            // 
            this.tbox_LibraryFolder.Location = new System.Drawing.Point(7, 20);
            this.tbox_LibraryFolder.Name = "tbox_LibraryFolder";
            this.tbox_LibraryFolder.Size = new System.Drawing.Size(236, 20);
            this.tbox_LibraryFolder.TabIndex = 1;
            // 
            // chk_InclSubFolders
            // 
            this.chk_InclSubFolders.AutoSize = true;
            this.chk_InclSubFolders.Checked = true;
            this.chk_InclSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_InclSubFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chk_InclSubFolders.Location = new System.Drawing.Point(7, 57);
            this.chk_InclSubFolders.Name = "chk_InclSubFolders";
            this.chk_InclSubFolders.Size = new System.Drawing.Size(114, 17);
            this.chk_InclSubFolders.TabIndex = 0;
            this.chk_InclSubFolders.Text = "Include Subfolders";
            this.chk_InclSubFolders.UseVisualStyleBackColor = true;
            // 
            // btn_FindDups
            // 
            this.btn_FindDups.Location = new System.Drawing.Point(19, 102);
            this.btn_FindDups.Name = "btn_FindDups";
            this.btn_FindDups.Size = new System.Drawing.Size(75, 23);
            this.btn_FindDups.TabIndex = 1;
            this.btn_FindDups.Text = "Find Dups";
            this.btn_FindDups.UseVisualStyleBackColor = true;
            this.btn_FindDups.Click += new System.EventHandler(this.btn_FindDups_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(178, 102);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // DupMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 137);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_FindDups);
            this.Controls.Add(this.grp_MovieFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DupMovie";
            this.Text = "Duplicated Movies v0.1";
            this.Load += new System.EventHandler(this.FormLoad);
            this.grp_MovieFolder.ResumeLayout(false);
            this.grp_MovieFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_MovieFolder;
        private System.Windows.Forms.CheckBox chk_InclSubFolders;
        private System.Windows.Forms.Button btn_PickFolder;
        private System.Windows.Forms.TextBox tbox_LibraryFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser_Movie;
        private System.Windows.Forms.Button btn_FindDups;
        private System.Windows.Forms.Button btn_Close;
    }
}

