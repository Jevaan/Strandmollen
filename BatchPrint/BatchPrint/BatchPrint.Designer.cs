namespace BatchPrint
{
    partial class BatchPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchPrint));
            this.UserName_lbl = new System.Windows.Forms.Label();
            this.DKImg = new System.Windows.Forms.PictureBox();
            this.SEImg = new System.Windows.Forms.PictureBox();
            this.DEImg = new System.Windows.Forms.PictureBox();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.LoggedInAs_lbl = new System.Windows.Forms.Label();
            this.Admin_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DKImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEImg)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName_lbl
            // 
            this.UserName_lbl.AutoSize = true;
            this.UserName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_lbl.Location = new System.Drawing.Point(142, 98);
            this.UserName_lbl.Name = "UserName_lbl";
            this.UserName_lbl.Size = new System.Drawing.Size(75, 15);
            this.UserName_lbl.TabIndex = 5;
            this.UserName_lbl.Text = "UserName";
            // 
            // DKImg
            // 
            this.DKImg.Enabled = false;
            this.DKImg.Image = ((System.Drawing.Image)(resources.GetObject("DKImg.Image")));
            this.DKImg.Location = new System.Drawing.Point(12, 12);
            this.DKImg.Name = "DKImg";
            this.DKImg.Size = new System.Drawing.Size(64, 64);
            this.DKImg.TabIndex = 0;
            this.DKImg.TabStop = false;
            this.DKImg.Click += new System.EventHandler(this.OpenDK);
            // 
            // SEImg
            // 
            this.SEImg.Enabled = false;
            this.SEImg.Image = ((System.Drawing.Image)(resources.GetObject("SEImg.Image")));
            this.SEImg.Location = new System.Drawing.Point(133, 12);
            this.SEImg.Name = "SEImg";
            this.SEImg.Size = new System.Drawing.Size(64, 64);
            this.SEImg.TabIndex = 1;
            this.SEImg.TabStop = false;
            this.SEImg.Click += new System.EventHandler(this.OpenSE);
            // 
            // DEImg
            // 
            this.DEImg.Enabled = false;
            this.DEImg.Image = ((System.Drawing.Image)(resources.GetObject("DEImg.Image")));
            this.DEImg.Location = new System.Drawing.Point(259, 12);
            this.DEImg.Name = "DEImg";
            this.DEImg.Size = new System.Drawing.Size(64, 64);
            this.DEImg.TabIndex = 2;
            this.DEImg.TabStop = false;
            this.DEImg.Click += new System.EventHandler(this.OpenDE);
            // 
            // Version_lbl
            // 
            this.Version_lbl.AutoSize = true;
            this.Version_lbl.Location = new System.Drawing.Point(12, 141);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(69, 13);
            this.Version_lbl.TabIndex = 3;
            this.Version_lbl.Text = "Version 4.5.0";
            // 
            // LoggedInAs_lbl
            // 
            this.LoggedInAs_lbl.AutoSize = true;
            this.LoggedInAs_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAs_lbl.Location = new System.Drawing.Point(9, 98);
            this.LoggedInAs_lbl.Name = "LoggedInAs_lbl";
            this.LoggedInAs_lbl.Size = new System.Drawing.Size(127, 15);
            this.LoggedInAs_lbl.TabIndex = 4;
            this.LoggedInAs_lbl.Text = "Du er logget ind som: ";
            // 
            // Admin_btn
            // 
            this.Admin_btn.Location = new System.Drawing.Point(145, 136);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(178, 23);
            this.Admin_btn.TabIndex = 6;
            this.Admin_btn.Text = "Administration";
            this.Admin_btn.UseVisualStyleBackColor = true;
            this.Admin_btn.Visible = false;
            this.Admin_btn.Click += new System.EventHandler(this.OpenAdminModule);
            // 
            // BatchPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 167);
            this.Controls.Add(this.Admin_btn);
            this.Controls.Add(this.UserName_lbl);
            this.Controls.Add(this.LoggedInAs_lbl);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.DEImg);
            this.Controls.Add(this.SEImg);
            this.Controls.Add(this.DKImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BatchPrint";
            this.Text = "Medicinsk Batch Print";
            this.Load += new System.EventHandler(this.FormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.DKImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SEImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DKImg;
        private System.Windows.Forms.PictureBox SEImg;
        private System.Windows.Forms.PictureBox DEImg;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label LoggedInAs_lbl;
        private System.Windows.Forms.Label UserName_lbl;
        private System.Windows.Forms.Button Admin_btn;

    }
}

