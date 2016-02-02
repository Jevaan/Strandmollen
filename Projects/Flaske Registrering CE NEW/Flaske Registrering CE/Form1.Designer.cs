namespace FlaskeRegistreringCE
{
    partial class FlRegCE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlRegCE));
            this.label1 = new System.Windows.Forms.Label();
            this.inSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inAir = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.TNo = new System.Windows.Forms.Label();
            this.btnBat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.inLabels = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.inVendor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inPressure = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBat = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.Text = "Størrelse";
            // 
            // inSize
            // 
            this.inSize.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.inSize.Items.Add("");
            this.inSize.Items.Add("0.5");
            this.inSize.Items.Add("1");
            this.inSize.Items.Add("1.5");
            this.inSize.Items.Add("2");
            this.inSize.Items.Add("2.5");
            this.inSize.Items.Add("3");
            this.inSize.Items.Add("4");
            this.inSize.Items.Add("5");
            this.inSize.Items.Add("7");
            this.inSize.Items.Add("8");
            this.inSize.Items.Add("10");
            this.inSize.Items.Add("12");
            this.inSize.Items.Add("13");
            this.inSize.Items.Add("14");
            this.inSize.Items.Add("20");
            this.inSize.Items.Add("40");
            this.inSize.Items.Add("50");
            this.inSize.Items.Add("79");
            this.inSize.Items.Add("80");
            this.inSize.Items.Add("100");
            this.inSize.Items.Add("140");
            this.inSize.Items.Add("176");
            this.inSize.Items.Add("200");
            this.inSize.Items.Add("400");
            this.inSize.Items.Add("500");
            this.inSize.Location = new System.Drawing.Point(156, 32);
            this.inSize.Name = "inSize";
            this.inSize.Size = new System.Drawing.Size(156, 23);
            this.inSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.Text = "Nummer";
            // 
            // inNo
            // 
            this.inNo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.inNo.Location = new System.Drawing.Point(156, 61);
            this.inNo.MaxLength = 7;
            this.inNo.Name = "inNo";
            this.inNo.Size = new System.Drawing.Size(156, 23);
            this.inNo.TabIndex = 2;
            this.inNo.LostFocus += new System.EventHandler(this.inNo_LostFocus);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inAir);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.TNo);
            this.panel2.Controls.Add(this.btnBat);
            this.panel2.Controls.Add(this.inSize);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.inLabels);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.inVendor);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.inPressure);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.inDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.inNo);
            this.panel2.Controls.Add(this.chkBat);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 270);
            // 
            // inAir
            // 
            this.inAir.Location = new System.Drawing.Point(156, 113);
            this.inAir.Name = "inAir";
            this.inAir.Size = new System.Drawing.Size(156, 23);
            this.inAir.TabIndex = 48;
            this.inAir.GotFocus += new System.EventHandler(this.EnableReader);
            this.inAir.LostFocus += new System.EventHandler(this.CloseReader);
            // 
            // cbType
            // 
            this.cbType.Items.Add("Egen Flaske");
            this.cbType.Items.Add("Batteriflaske");
            this.cbType.Items.Add("Kryoflaske");
            this.cbType.Items.Add("Fremmed Flaske");
            this.cbType.Items.Add("Salgs Flaske");
            this.cbType.Location = new System.Drawing.Point(156, 5);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(156, 23);
            this.cbType.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(3, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 20);
            this.lblType.Text = "Flasketype";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Dock";
            this.button2.Click += new System.EventHandler(this.btnDock_click);
            // 
            // TNo
            // 
            this.TNo.Location = new System.Drawing.Point(238, 215);
            this.TNo.Name = "TNo";
            this.TNo.Size = new System.Drawing.Size(44, 23);
            // 
            // btnBat
            // 
            this.btnBat.Location = new System.Drawing.Point(113, 242);
            this.btnBat.Name = "btnBat";
            this.btnBat.Size = new System.Drawing.Size(54, 23);
            this.btnBat.TabIndex = 20;
            this.btnBat.Text = "Batteri";
            this.btnBat.Click += new System.EventHandler(this.btnBat_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(113, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 22);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "Export";
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // inLabels
            // 
            this.inLabels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.inLabels.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.inLabels.Items.Add("1");
            this.inLabels.Items.Add("2");
            this.inLabels.Items.Add("3");
            this.inLabels.Items.Add("4");
            this.inLabels.Items.Add("5");
            this.inLabels.Location = new System.Drawing.Point(156, 215);
            this.inLabels.Name = "inLabels";
            this.inLabels.Size = new System.Drawing.Size(64, 23);
            this.inLabels.TabIndex = 10;
            this.inLabels.TabStop = false;
            this.inLabels.Text = "3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 22);
            this.button3.TabIndex = 11;
            this.button3.TabStop = false;
            this.button3.Text = "Setup";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.Text = "Etiketter";
            this.label9.ParentChanged += new System.EventHandler(this.label9_ParentChanged);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(0, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(49, 22);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Slet";
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(249, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 22);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Gem";
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // inVendor
            // 
            this.inVendor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.inVendor.Items.Add("");
            this.inVendor.Items.Add("DK-SV");
            this.inVendor.Items.Add("IS");
            this.inVendor.Location = new System.Drawing.Point(156, 164);
            this.inVendor.Name = "inVendor";
            this.inVendor.Size = new System.Drawing.Size(156, 23);
            this.inVendor.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.Text = "Variant";
            // 
            // inPressure
            // 
            this.inPressure.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.inPressure.Items.Add("");
            this.inPressure.Items.Add("30");
            this.inPressure.Items.Add("32");
            this.inPressure.Items.Add("100");
            this.inPressure.Items.Add("150");
            this.inPressure.Items.Add("200");
            this.inPressure.Items.Add("225");
            this.inPressure.Items.Add("300");
            this.inPressure.Items.Add("346");
            this.inPressure.Items.Add("450");
            this.inPressure.Location = new System.Drawing.Point(156, 138);
            this.inPressure.Name = "inPressure";
            this.inPressure.Size = new System.Drawing.Size(156, 23);
            this.inPressure.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(3, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.Text = "Prøvetryk";
            // 
            // inDate
            // 
            this.inDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.inDate.Location = new System.Drawing.Point(156, 87);
            this.inDate.MaxLength = 7;
            this.inDate.Name = "inDate";
            this.inDate.Size = new System.Drawing.Size(156, 23);
            this.inDate.TabIndex = 3;
            this.inDate.LostFocus += new System.EventHandler(this.Date_LostFocus);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.Text = "Prøvedato";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.Text = "Varenummer";
            // 
            // chkBat
            // 
            this.chkBat.Enabled = false;
            this.chkBat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.chkBat.Location = new System.Drawing.Point(42, 216);
            this.chkBat.Name = "chkBat";
            this.chkBat.Size = new System.Drawing.Size(125, 20);
            this.chkBat.TabIndex = 29;
            this.chkBat.Text = "Batteriflaske";
            this.chkBat.Visible = false;
            // 
            // FlRegCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FlRegCE";
            this.Text = "Flaske Registrering CE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FlRegCE_Load);
            this.Closed += new System.EventHandler(this.FlRegCE_Close);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox inSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox inVendor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox inPressure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox inLabels;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBat;
        private System.Windows.Forms.CheckBox chkBat;
        private System.Windows.Forms.Label TNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox inAir;
        
    }
}

