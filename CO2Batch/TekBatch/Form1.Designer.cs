namespace CO2Batch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDato = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEtiketter = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAdjust = new System.Windows.Forms.ComboBox();
            this.GroupPrinter = new System.Windows.Forms.GroupBox();
            this.FLVRadioButton = new System.Windows.Forms.RadioButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.rbPrnTest = new System.Windows.Forms.RadioButton();
            this.rbPrnTek = new System.Windows.Forms.RadioButton();
            this.rbPrnMed = new System.Windows.Forms.RadioButton();
            this.rbPrnLocal = new System.Windows.Forms.RadioButton();
            this.chkIncl = new System.Windows.Forms.CheckBox();
            this.chkTerra = new System.Windows.Forms.CheckBox();
            this.chkNetto = new System.Windows.Forms.CheckBox();
            this.KgLbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupPrinter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(23, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Fyldt af:";
            this.lbl1.Visible = false;
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(85, 35);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(80, 22);
            this.tb1.TabIndex = 3;
            this.tb1.Visible = false;
            this.tb1.TextChanged += new System.EventHandler(this.CheckValues);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(23, 68);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(56, 16);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Rampe:";
            this.lbl2.Visible = false;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(85, 65);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(80, 22);
            this.tb2.TabIndex = 5;
            this.tb2.Visible = false;
            this.tb2.TextChanged += new System.EventHandler(this.CheckValues);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(23, 96);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(44, 16);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Træk:";
            this.lbl3.Visible = false;
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(85, 93);
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.Size = new System.Drawing.Size(80, 22);
            this.tb3.TabIndex = 7;
            this.tb3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dato:";
            // 
            // cbDato
            // 
            this.cbDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDato.Location = new System.Drawing.Point(85, 7);
            this.cbDato.Name = "cbDato";
            this.cbDato.Size = new System.Drawing.Size(127, 22);
            this.cbDato.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Etiketter:";
            // 
            // cbEtiketter
            // 
            this.cbEtiketter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEtiketter.FormattingEnabled = true;
            this.cbEtiketter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbEtiketter.Location = new System.Drawing.Point(85, 121);
            this.cbEtiketter.Name = "cbEtiketter";
            this.cbEtiketter.Size = new System.Drawing.Size(80, 24);
            this.cbEtiketter.TabIndex = 11;
            this.cbEtiketter.Text = "1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(26, 152);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Justering (mm)";
            // 
            // cbAdjust
            // 
            this.cbAdjust.FormattingEnabled = true;
            this.cbAdjust.Items.AddRange(new object[] {
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbAdjust.Location = new System.Drawing.Point(126, 134);
            this.cbAdjust.Name = "cbAdjust";
            this.cbAdjust.Size = new System.Drawing.Size(51, 21);
            this.cbAdjust.TabIndex = 18;
            this.cbAdjust.Text = "0";
            // 
            // GroupPrinter
            // 
            this.GroupPrinter.Controls.Add(this.FLVRadioButton);
            this.GroupPrinter.Controls.Add(this.lblVersion);
            this.GroupPrinter.Controls.Add(this.rbPrnTest);
            this.GroupPrinter.Controls.Add(this.label2);
            this.GroupPrinter.Controls.Add(this.cbAdjust);
            this.GroupPrinter.Controls.Add(this.rbPrnTek);
            this.GroupPrinter.Controls.Add(this.rbPrnMed);
            this.GroupPrinter.Controls.Add(this.rbPrnLocal);
            this.GroupPrinter.Location = new System.Drawing.Point(431, 9);
            this.GroupPrinter.Name = "GroupPrinter";
            this.GroupPrinter.Size = new System.Drawing.Size(200, 192);
            this.GroupPrinter.TabIndex = 19;
            this.GroupPrinter.TabStop = false;
            this.GroupPrinter.Text = "Printer";
            // 
            // FLVRadioButton
            // 
            this.FLVRadioButton.AutoSize = true;
            this.FLVRadioButton.Checked = true;
            this.FLVRadioButton.Location = new System.Drawing.Point(38, 85);
            this.FLVRadioButton.Name = "FLVRadioButton";
            this.FLVRadioButton.Size = new System.Drawing.Size(44, 17);
            this.FLVRadioButton.TabIndex = 20;
            this.FLVRadioButton.TabStop = true;
            this.FLVRadioButton.Text = "FLV";
            this.FLVRadioButton.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(52, 161);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(81, 13);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "Version: 0.0.0.0";
            // 
            // rbPrnTest
            // 
            this.rbPrnTest.AutoSize = true;
            this.rbPrnTest.Location = new System.Drawing.Point(38, 108);
            this.rbPrnTest.Name = "rbPrnTest";
            this.rbPrnTest.Size = new System.Drawing.Size(46, 17);
            this.rbPrnTest.TabIndex = 3;
            this.rbPrnTest.Text = "CO2";
            this.rbPrnTest.UseVisualStyleBackColor = true;
            // 
            // rbPrnTek
            // 
            this.rbPrnTek.AutoSize = true;
            this.rbPrnTek.Location = new System.Drawing.Point(38, 62);
            this.rbPrnTek.Name = "rbPrnTek";
            this.rbPrnTek.Size = new System.Drawing.Size(94, 17);
            this.rbPrnTek.TabIndex = 2;
            this.rbPrnTek.Text = "Teknisk Batch";
            this.rbPrnTek.UseVisualStyleBackColor = true;
            // 
            // rbPrnMed
            // 
            this.rbPrnMed.AutoSize = true;
            this.rbPrnMed.Location = new System.Drawing.Point(38, 38);
            this.rbPrnMed.Name = "rbPrnMed";
            this.rbPrnMed.Size = new System.Drawing.Size(104, 17);
            this.rbPrnMed.TabIndex = 1;
            this.rbPrnMed.Text = "Medicinsk Batch";
            this.rbPrnMed.UseVisualStyleBackColor = true;
            // 
            // rbPrnLocal
            // 
            this.rbPrnLocal.AutoSize = true;
            this.rbPrnLocal.Location = new System.Drawing.Point(38, 14);
            this.rbPrnLocal.Name = "rbPrnLocal";
            this.rbPrnLocal.Size = new System.Drawing.Size(51, 17);
            this.rbPrnLocal.TabIndex = 0;
            this.rbPrnLocal.Text = "Lokal";
            this.rbPrnLocal.UseVisualStyleBackColor = true;
            // 
            // chkIncl
            // 
            this.chkIncl.AutoSize = true;
            this.chkIncl.Location = new System.Drawing.Point(272, 98);
            this.chkIncl.Name = "chkIncl";
            this.chkIncl.Size = new System.Drawing.Size(99, 17);
            this.chkIncl.TabIndex = 20;
            this.chkIncl.Text = "incl. Bøjlehætte";
            this.chkIncl.UseVisualStyleBackColor = true;
            this.chkIncl.CheckedChanged += new System.EventHandler(this.UpdateLabel);
            // 
            // chkTerra
            // 
            this.chkTerra.AutoSize = true;
            this.chkTerra.Location = new System.Drawing.Point(186, 39);
            this.chkTerra.Name = "chkTerra";
            this.chkTerra.Size = new System.Drawing.Size(51, 17);
            this.chkTerra.TabIndex = 21;
            this.chkTerra.Text = "Husk";
            this.chkTerra.UseVisualStyleBackColor = true;
            // 
            // chkNetto
            // 
            this.chkNetto.AutoSize = true;
            this.chkNetto.Location = new System.Drawing.Point(186, 69);
            this.chkNetto.Name = "chkNetto";
            this.chkNetto.Size = new System.Drawing.Size(51, 17);
            this.chkNetto.TabIndex = 22;
            this.chkNetto.Text = "Husk";
            this.chkNetto.UseVisualStyleBackColor = true;
            // 
            // KgLbl1
            // 
            this.KgLbl1.AutoSize = true;
            this.KgLbl1.Location = new System.Drawing.Point(162, 40);
            this.KgLbl1.Name = "KgLbl1";
            this.KgLbl1.Size = new System.Drawing.Size(20, 13);
            this.KgLbl1.TabIndex = 23;
            this.KgLbl1.Text = "Kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(643, 194);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KgLbl1);
            this.Controls.Add(this.chkNetto);
            this.Controls.Add(this.chkTerra);
            this.Controls.Add(this.chkIncl);
            this.Controls.Add(this.GroupPrinter);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbEtiketter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CO2 batchmærker";
            this.GroupPrinter.ResumeLayout(false);
            this.GroupPrinter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker cbDato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEtiketter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAdjust;
        private System.Windows.Forms.GroupBox GroupPrinter;
        private System.Windows.Forms.RadioButton rbPrnTest;
        private System.Windows.Forms.RadioButton rbPrnTek;
        private System.Windows.Forms.RadioButton rbPrnMed;
        private System.Windows.Forms.RadioButton rbPrnLocal;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.RadioButton FLVRadioButton;
        private System.Windows.Forms.CheckBox chkIncl;
        private System.Windows.Forms.CheckBox chkTerra;
        private System.Windows.Forms.CheckBox chkNetto;
        private System.Windows.Forms.Label KgLbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

