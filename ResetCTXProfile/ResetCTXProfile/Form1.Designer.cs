namespace ResetCTXProfile
{
    partial class rstctx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rstctx));
            this.from_lbl = new System.Windows.Forms.Label();
            this.from_txtbox = new System.Windows.Forms.TextBox();
            this.folderslbl = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Frombtn = new System.Windows.Forms.Button();
            this.tolbl = new System.Windows.Forms.Label();
            this.totxtbox = new System.Windows.Forms.TextBox();
            this.tobtn = new System.Windows.Forms.Button();
            this.signaturchk = new System.Windows.Forms.CheckBox();
            this.outlookchk = new System.Windows.Forms.CheckBox();
            this.favchk = new System.Windows.Forms.CheckBox();
            this.desktopchk = new System.Windows.Forms.CheckBox();
            this.documentschk = new System.Windows.Forms.CheckBox();
            this.Downloadschk = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Initials = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // from_lbl
            // 
            this.from_lbl.AutoSize = true;
            this.from_lbl.Location = new System.Drawing.Point(22, 22);
            this.from_lbl.Name = "from_lbl";
            this.from_lbl.Size = new System.Drawing.Size(25, 13);
            this.from_lbl.TabIndex = 0;
            this.from_lbl.Text = "Fra:";
            // 
            // from_txtbox
            // 
            this.from_txtbox.Location = new System.Drawing.Point(96, 19);
            this.from_txtbox.Name = "from_txtbox";
            this.from_txtbox.Size = new System.Drawing.Size(340, 20);
            this.from_txtbox.TabIndex = 1;
            // 
            // folderslbl
            // 
            this.folderslbl.AutoSize = true;
            this.folderslbl.Location = new System.Drawing.Point(22, 150);
            this.folderslbl.Name = "folderslbl";
            this.folderslbl.Size = new System.Drawing.Size(62, 13);
            this.folderslbl.TabIndex = 3;
            this.folderslbl.Text = "Indstillinger:";
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(452, 150);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 41);
            this.resetbtn.TabIndex = 6;
            this.resetbtn.Text = "Kopier";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.CopyStuff);
            // 
            // Frombtn
            // 
            this.Frombtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frombtn.Location = new System.Drawing.Point(452, 17);
            this.Frombtn.Name = "Frombtn";
            this.Frombtn.Size = new System.Drawing.Size(75, 23);
            this.Frombtn.TabIndex = 7;
            this.Frombtn.Text = "Vælg...";
            this.Frombtn.UseVisualStyleBackColor = true;
            this.Frombtn.Click += new System.EventHandler(this.fromclick);
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.Location = new System.Drawing.Point(22, 56);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(21, 13);
            this.tolbl.TabIndex = 8;
            this.tolbl.Text = "Til:";
            // 
            // totxtbox
            // 
            this.totxtbox.Location = new System.Drawing.Point(96, 53);
            this.totxtbox.Name = "totxtbox";
            this.totxtbox.Size = new System.Drawing.Size(340, 20);
            this.totxtbox.TabIndex = 9;
            // 
            // tobtn
            // 
            this.tobtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tobtn.Location = new System.Drawing.Point(452, 51);
            this.tobtn.Name = "tobtn";
            this.tobtn.Size = new System.Drawing.Size(75, 23);
            this.tobtn.TabIndex = 10;
            this.tobtn.Text = "Vælg...";
            this.tobtn.UseVisualStyleBackColor = true;
            this.tobtn.Click += new System.EventHandler(this.toclick);
            // 
            // signaturchk
            // 
            this.signaturchk.AutoSize = true;
            this.signaturchk.Checked = true;
            this.signaturchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.signaturchk.Location = new System.Drawing.Point(96, 150);
            this.signaturchk.Name = "signaturchk";
            this.signaturchk.Size = new System.Drawing.Size(65, 17);
            this.signaturchk.TabIndex = 11;
            this.signaturchk.Text = "Signatur";
            this.signaturchk.UseVisualStyleBackColor = true;
            // 
            // outlookchk
            // 
            this.outlookchk.AutoSize = true;
            this.outlookchk.Checked = true;
            this.outlookchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outlookchk.Location = new System.Drawing.Point(191, 150);
            this.outlookchk.Name = "outlookchk";
            this.outlookchk.Size = new System.Drawing.Size(112, 17);
            this.outlookchk.TabIndex = 12;
            this.outlookchk.Text = "Email adresse liste";
            this.outlookchk.UseVisualStyleBackColor = true;
            // 
            // favchk
            // 
            this.favchk.AutoSize = true;
            this.favchk.Checked = true;
            this.favchk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.favchk.Location = new System.Drawing.Point(337, 150);
            this.favchk.Name = "favchk";
            this.favchk.Size = new System.Drawing.Size(70, 17);
            this.favchk.TabIndex = 13;
            this.favchk.Text = "Favoritter";
            this.favchk.UseVisualStyleBackColor = true;
            // 
            // desktopchk
            // 
            this.desktopchk.AutoSize = true;
            this.desktopchk.Location = new System.Drawing.Point(96, 174);
            this.desktopchk.Name = "desktopchk";
            this.desktopchk.Size = new System.Drawing.Size(77, 17);
            this.desktopchk.TabIndex = 14;
            this.desktopchk.Text = "Skrivebord";
            this.desktopchk.UseVisualStyleBackColor = true;
            // 
            // documentschk
            // 
            this.documentschk.AutoSize = true;
            this.documentschk.Location = new System.Drawing.Point(191, 174);
            this.documentschk.Name = "documentschk";
            this.documentschk.Size = new System.Drawing.Size(110, 17);
            this.documentschk.TabIndex = 15;
            this.documentschk.Text = "Mine Dokumenter";
            this.documentschk.UseVisualStyleBackColor = true;
            // 
            // Downloadschk
            // 
            this.Downloadschk.AutoSize = true;
            this.Downloadschk.Location = new System.Drawing.Point(337, 174);
            this.Downloadschk.Name = "Downloadschk";
            this.Downloadschk.Size = new System.Drawing.Size(105, 17);
            this.Downloadschk.TabIndex = 16;
            this.Downloadschk.Text = "Mine Downloads";
            this.Downloadschk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Eller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username:";
            // 
            // tb_Initials
            // 
            this.tb_Initials.Location = new System.Drawing.Point(193, 95);
            this.tb_Initials.Name = "tb_Initials";
            this.tb_Initials.Size = new System.Drawing.Size(100, 20);
            this.tb_Initials.TabIndex = 19;
            // 
            // rstctx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 205);
            this.Controls.Add(this.tb_Initials);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Downloadschk);
            this.Controls.Add(this.documentschk);
            this.Controls.Add(this.desktopchk);
            this.Controls.Add(this.favchk);
            this.Controls.Add(this.outlookchk);
            this.Controls.Add(this.signaturchk);
            this.Controls.Add(this.tobtn);
            this.Controls.Add(this.totxtbox);
            this.Controls.Add(this.tolbl);
            this.Controls.Add(this.Frombtn);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.folderslbl);
            this.Controls.Add(this.from_txtbox);
            this.Controls.Add(this.from_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rstctx";
            this.Text = "Reset Citrix Profile";
            this.Load += new System.EventHandler(this.onLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label from_lbl;
        private System.Windows.Forms.TextBox from_txtbox;
        private System.Windows.Forms.Label folderslbl;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Frombtn;
        private System.Windows.Forms.Label tolbl;
        private System.Windows.Forms.TextBox totxtbox;
        private System.Windows.Forms.Button tobtn;
        private System.Windows.Forms.CheckBox signaturchk;
        private System.Windows.Forms.CheckBox outlookchk;
        private System.Windows.Forms.CheckBox favchk;
        private System.Windows.Forms.CheckBox desktopchk;
        private System.Windows.Forms.CheckBox documentschk;
        private System.Windows.Forms.CheckBox Downloadschk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Initials;
    }
}

