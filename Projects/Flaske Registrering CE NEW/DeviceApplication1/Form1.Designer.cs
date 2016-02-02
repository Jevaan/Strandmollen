namespace DeviceApplication1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stregkode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Storrelse = new System.Windows.Forms.TextBox();
            this.Nummer = new System.Windows.Forms.TextBox();
            this.Luk = new System.Windows.Forms.Button();
            this.Fejl = new System.Windows.Forms.Button();
            this.btnBat = new System.Windows.Forms.Button();
            this.chkSalg = new System.Windows.Forms.CheckBox();
            this.chkByt = new System.Windows.Forms.CheckBox();
            this.chkKryo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Indtast den fejlregistrerede flaskes stregkode eller størrelse og nummer.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.Text = "Stregkode";
            // 
            // Stregkode
            // 
            this.Stregkode.Location = new System.Drawing.Point(74, 51);
            this.Stregkode.MaxLength = 13;
            this.Stregkode.Name = "Stregkode";
            this.Stregkode.Size = new System.Drawing.Size(157, 23);
            this.Stregkode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(94, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.Text = "eller";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.Text = "Størrelse";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.Text = "Nummer";
            // 
            // Storrelse
            // 
            this.Storrelse.Location = new System.Drawing.Point(74, 160);
            this.Storrelse.Name = "Storrelse";
            this.Storrelse.Size = new System.Drawing.Size(100, 23);
            this.Storrelse.TabIndex = 6;
            // 
            // Nummer
            // 
            this.Nummer.Location = new System.Drawing.Point(74, 189);
            this.Nummer.Name = "Nummer";
            this.Nummer.Size = new System.Drawing.Size(100, 23);
            this.Nummer.TabIndex = 7;
            // 
            // Luk
            // 
            this.Luk.Location = new System.Drawing.Point(3, 218);
            this.Luk.Name = "Luk";
            this.Luk.Size = new System.Drawing.Size(72, 20);
            this.Luk.TabIndex = 8;
            this.Luk.Text = "Luk";
            this.Luk.Click += new System.EventHandler(this.Luk_Click);
            // 
            // Fejl
            // 
            this.Fejl.Location = new System.Drawing.Point(164, 218);
            this.Fejl.Name = "Fejl";
            this.Fejl.Size = new System.Drawing.Size(72, 20);
            this.Fejl.TabIndex = 9;
            this.Fejl.Text = "Ret Fejl";
            this.Fejl.Click += new System.EventHandler(this.Fejl_Click);
            // 
            // btnBat
            // 
            this.btnBat.Location = new System.Drawing.Point(81, 218);
            this.btnBat.Name = "btnBat";
            this.btnBat.Size = new System.Drawing.Size(77, 20);
            this.btnBat.TabIndex = 14;
            this.btnBat.Text = "Ryd Batteri";
            this.btnBat.Click += new System.EventHandler(this.btnBat_Click);
            // 
            // chkSalg
            // 
            this.chkSalg.Location = new System.Drawing.Point(74, 137);
            this.chkSalg.Name = "chkSalg";
            this.chkSalg.Size = new System.Drawing.Size(100, 20);
            this.chkSalg.TabIndex = 19;
            this.chkSalg.Text = "Salgsflaske";
            // 
            // chkByt
            // 
            this.chkByt.Location = new System.Drawing.Point(74, 116);
            this.chkByt.Name = "chkByt";
            this.chkByt.Size = new System.Drawing.Size(122, 20);
            this.chkByt.TabIndex = 20;
            this.chkByt.Text = "Fremmedflaske";
            // 
            // chkKryo
            // 
            this.chkKryo.Location = new System.Drawing.Point(74, 96);
            this.chkKryo.Name = "chkKryo";
            this.chkKryo.Size = new System.Drawing.Size(100, 20);
            this.chkKryo.TabIndex = 21;
            this.chkKryo.Text = "Kryoflaske";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(239, 243);
            this.Controls.Add(this.chkKryo);
            this.Controls.Add(this.chkByt);
            this.Controls.Add(this.chkSalg);
            this.Controls.Add(this.btnBat);
            this.Controls.Add(this.Fejl);
            this.Controls.Add(this.Luk);
            this.Controls.Add(this.Nummer);
            this.Controls.Add(this.Storrelse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Stregkode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Fejl Registrering";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Stregkode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Storrelse;
        private System.Windows.Forms.TextBox Nummer;
        private System.Windows.Forms.Button Luk;
        private System.Windows.Forms.Button Fejl;
        private System.Windows.Forms.Button btnBat;
        private System.Windows.Forms.CheckBox chkSalg;
        private System.Windows.Forms.CheckBox chkByt;
        private System.Windows.Forms.CheckBox chkKryo;
    }
}

