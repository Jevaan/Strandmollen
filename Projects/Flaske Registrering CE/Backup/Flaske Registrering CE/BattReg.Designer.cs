namespace FlaskeRegistreringCE
{
    partial class BattReg
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
            this.boxType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.boxGas = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.boxDate = new System.Windows.Forms.TextBox();
            this.boxDyk = new System.Windows.Forms.CheckBox();
            this.lblLabels = new System.Windows.Forms.Label();
            this.boxLabels = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.boxNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxPressure = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxType
            // 
            this.boxType.Enabled = false;
            this.boxType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.boxType.Items.Add("8x80");
            this.boxType.Items.Add("9x40");
            this.boxType.Items.Add("12x50");
            this.boxType.Items.Add("20x40");
            this.boxType.Items.Add("32x50");
            this.boxType.Items.Add("36x50");
            this.boxType.Location = new System.Drawing.Point(98, 3);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(116, 26);
            this.boxType.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(3, 8);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 20);
            this.lblType.Text = "Type";
            // 
            // lblGas
            // 
            this.lblGas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblGas.Location = new System.Drawing.Point(3, 69);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(53, 20);
            this.lblGas.Text = "Gas";
            // 
            // boxGas
            // 
            this.boxGas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.boxGas.Items.Add("Acetylen");
            this.boxGas.Items.Add("Brandbar");
            this.boxGas.Items.Add("CO2");
            this.boxGas.Items.Add("Gasmix");
            this.boxGas.Items.Add("H2");
            this.boxGas.Items.Add("Inaktiv");
            this.boxGas.Items.Add("Oxyderende");
            this.boxGas.Location = new System.Drawing.Point(98, 63);
            this.boxGas.Name = "boxGas";
            this.boxGas.Size = new System.Drawing.Size(116, 26);
            this.boxGas.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(3, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 20);
            this.lblDate.Text = "Tryk Dato";
            // 
            // boxDate
            // 
            this.boxDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.boxDate.Location = new System.Drawing.Point(98, 94);
            this.boxDate.Name = "boxDate";
            this.boxDate.Size = new System.Drawing.Size(116, 26);
            this.boxDate.TabIndex = 5;
            // 
            // boxDyk
            // 
            this.boxDyk.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.boxDyk.Location = new System.Drawing.Point(98, 151);
            this.boxDyk.Name = "boxDyk";
            this.boxDyk.Size = new System.Drawing.Size(116, 20);
            this.boxDyk.TabIndex = 6;
            this.boxDyk.Text = "Dykrør";
            // 
            // lblLabels
            // 
            this.lblLabels.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblLabels.Location = new System.Drawing.Point(3, 178);
            this.lblLabels.Name = "lblLabels";
            this.lblLabels.Size = new System.Drawing.Size(82, 20);
            this.lblLabels.Text = "Labels";
            // 
            // boxLabels
            // 
            this.boxLabels.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.boxLabels.Items.Add("1");
            this.boxLabels.Items.Add("2");
            this.boxLabels.Items.Add("3");
            this.boxLabels.Items.Add("4");
            this.boxLabels.Items.Add("5");
            this.boxLabels.Items.Add("6");
            this.boxLabels.Items.Add("7");
            this.boxLabels.Items.Add("8");
            this.boxLabels.Location = new System.Drawing.Point(98, 175);
            this.boxLabels.Name = "boxLabels";
            this.boxLabels.Size = new System.Drawing.Size(48, 26);
            this.boxLabels.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(126, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 20);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Gem";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNo
            // 
            this.lblNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNo.Location = new System.Drawing.Point(3, 36);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(82, 20);
            this.lblNo.Text = "Nummer";
            // 
            // boxNo
            // 
            this.boxNo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.boxNo.Location = new System.Drawing.Point(98, 33);
            this.boxNo.Name = "boxNo";
            this.boxNo.Size = new System.Drawing.Size(116, 26);
            this.boxNo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.Text = "Prøvetryk";
            // 
            // boxPressure
            // 
            this.boxPressure.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.boxPressure.Location = new System.Drawing.Point(98, 122);
            this.boxPressure.Name = "boxPressure";
            this.boxPressure.Size = new System.Drawing.Size(116, 26);
            this.boxPressure.TabIndex = 17;
            // 
            // BattReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(217, 237);
            this.Controls.Add(this.boxPressure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNo);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.boxLabels);
            this.Controls.Add(this.lblLabels);
            this.Controls.Add(this.boxDyk);
            this.Controls.Add(this.boxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.boxGas);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.boxType);
            this.Name = "BattReg";
            this.Text = "Batteri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox boxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.ComboBox boxGas;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox boxDate;
        private System.Windows.Forms.CheckBox boxDyk;
        private System.Windows.Forms.Label lblLabels;
        private System.Windows.Forms.ComboBox boxLabels;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox boxNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxPressure;
    }
}