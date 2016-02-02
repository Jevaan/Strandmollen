namespace Export_CE
{
    partial class Export
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
            this.ExportCE = new System.Windows.Forms.Panel();
            this.ExportAll = new System.Windows.Forms.RadioButton();
            this.ExportNew = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.ExportCE.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportCE
            // 
            this.ExportCE.Controls.Add(this.ExportNew);
            this.ExportCE.Controls.Add(this.ExportAll);
            this.ExportCE.Location = new System.Drawing.Point(3, 3);
            this.ExportCE.Name = "ExportCE";
            this.ExportCE.Size = new System.Drawing.Size(200, 69);
            // 
            // ExportAll
            // 
            this.ExportAll.Location = new System.Drawing.Point(15, 12);
            this.ExportAll.Name = "ExportAll";
            this.ExportAll.Size = new System.Drawing.Size(172, 20);
            this.ExportAll.TabIndex = 0;
            this.ExportAll.Text = "Alle registrerede flasker";
            // 
            // ExportNew
            // 
            this.ExportNew.Location = new System.Drawing.Point(15, 38);
            this.ExportNew.Name = "ExportNew";
            this.ExportNew.Size = new System.Drawing.Size(172, 20);
            this.ExportNew.TabIndex = 1;
            this.ExportNew.Text = "Nye flasker siden sidst";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 20);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Afslut";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(130, 77);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(72, 20);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Eksporter";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(207, 105);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ExportCE);
            this.Name = "Export";
            this.Text = "Flaske Eksportering";
            this.ExportCE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ExportCE;
        private System.Windows.Forms.RadioButton ExportNew;
        private System.Windows.Forms.RadioButton ExportAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExport;
    }
}

