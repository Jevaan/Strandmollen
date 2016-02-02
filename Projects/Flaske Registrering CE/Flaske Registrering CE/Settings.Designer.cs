namespace FlaskeRegistreringCE
{
    partial class Settings
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
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.checkBoxSize = new System.Windows.Forms.CheckBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.checkBoxPressure = new System.Windows.Forms.CheckBox();
            this.checkBoxProduced = new System.Windows.Forms.CheckBox();
            this.checkBoxVendor = new System.Windows.Forms.CheckBox();
            this.checkBoxAir = new System.Windows.Forms.CheckBox();
            this.checkBoxPressureDate = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSize);
            this.groupBox1.Controls.Add(this.checkBoxType);
            this.groupBox1.Location = new System.Drawing.Point(175, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 74);
            // 
            // checkBoxSize
            // 
            this.checkBoxSize.Checked = true;
            this.checkBoxSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSize.Location = new System.Drawing.Point(14, 44);
            this.checkBoxSize.Name = "checkBoxSize";
            this.checkBoxSize.Size = new System.Drawing.Size(63, 17);
            this.checkBoxSize.TabIndex = 1;
            this.checkBoxSize.Text = "Liter";
            // 
            // checkBoxType
            // 
            this.checkBoxType.Checked = true;
            this.checkBoxType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxType.Location = new System.Drawing.Point(14, 20);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(74, 17);
            this.checkBoxType.TabIndex = 0;
            this.checkBoxType.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPressure);
            this.groupBox2.Controls.Add(this.checkBoxProduced);
            this.groupBox2.Controls.Add(this.checkBoxVendor);
            this.groupBox2.Controls.Add(this.checkBoxAir);
            this.groupBox2.Controls.Add(this.checkBoxPressureDate);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 144);
            // 
            // checkBoxPressure
            // 
            this.checkBoxPressure.Location = new System.Drawing.Point(7, 116);
            this.checkBoxPressure.Name = "checkBoxPressure";
            this.checkBoxPressure.Size = new System.Drawing.Size(103, 17);
            this.checkBoxPressure.TabIndex = 4;
            this.checkBoxPressure.Text = "Prøvetryk";
            // 
            // checkBoxProduced
            // 
            this.checkBoxProduced.Location = new System.Drawing.Point(7, 92);
            this.checkBoxProduced.Name = "checkBoxProduced";
            this.checkBoxProduced.Size = new System.Drawing.Size(126, 17);
            this.checkBoxProduced.TabIndex = 3;
            this.checkBoxProduced.Text = "Produktionsdato";
            // 
            // checkBoxVendor
            // 
            this.checkBoxVendor.Location = new System.Drawing.Point(7, 68);
            this.checkBoxVendor.Name = "checkBoxVendor";
            this.checkBoxVendor.Size = new System.Drawing.Size(103, 17);
            this.checkBoxVendor.TabIndex = 2;
            this.checkBoxVendor.Text = "Producent";
            // 
            // checkBoxAir
            // 
            this.checkBoxAir.Location = new System.Drawing.Point(7, 44);
            this.checkBoxAir.Name = "checkBoxAir";
            this.checkBoxAir.Size = new System.Drawing.Size(56, 17);
            this.checkBoxAir.TabIndex = 1;
            this.checkBoxAir.Text = "Luftart";
            // 
            // checkBoxPressureDate
            // 
            this.checkBoxPressureDate.Location = new System.Drawing.Point(7, 20);
            this.checkBoxPressureDate.Name = "checkBoxPressureDate";
            this.checkBoxPressureDate.Size = new System.Drawing.Size(147, 17);
            this.checkBoxPressureDate.TabIndex = 0;
            this.checkBoxPressureDate.Text = "Trykprøvningsdato";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(13, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(243, 54);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Angiv hvilke informationer der skal gemmes mellem hver indtastning af flasker";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Gem";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fortryd";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(285, 221);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Settings";
            this.Text = "Indstillinger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSize;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPressure;
        private System.Windows.Forms.CheckBox checkBoxProduced;
        private System.Windows.Forms.CheckBox checkBoxVendor;
        private System.Windows.Forms.CheckBox checkBoxAir;
        private System.Windows.Forms.CheckBox checkBoxPressureDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}