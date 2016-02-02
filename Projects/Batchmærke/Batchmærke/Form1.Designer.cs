namespace Batchmærke
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
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
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Ambu",
            "Borealis",
            "Medicinsk",
            "Ny Medicinsk",
            "Teknisk",
            "Ny Teknisk",
            "Kryo",
            "Kryo Terra",
            "Kryobeholder",
            "Evakueret",
            "Tara Netto Brutto"});
            this.cbType.Location = new System.Drawing.Point(80, 9);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(127, 28);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(30, 98);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Fyldt af:";
            this.lbl1.Visible = false;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(85, 95);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(66, 20);
            this.tb1.TabIndex = 3;
            this.tb1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(30, 135);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Rampe:";
            this.lbl2.Visible = false;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(85, 132);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(66, 20);
            this.tb2.TabIndex = 5;
            this.tb2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(30, 170);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Træk:";
            this.lbl3.Visible = false;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(85, 167);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(66, 20);
            this.tb3.TabIndex = 7;
            this.tb3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dato:";
            // 
            // cbDato
            // 
            this.cbDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDato.Location = new System.Drawing.Point(80, 48);
            this.cbDato.Name = "cbDato";
            this.cbDato.Size = new System.Drawing.Size(127, 26);
            this.cbDato.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Etiketter:";
            // 
            // cbEtiketter
            // 
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
            this.cbEtiketter.Location = new System.Drawing.Point(80, 200);
            this.cbEtiketter.Name = "cbEtiketter";
            this.cbEtiketter.Size = new System.Drawing.Size(66, 21);
            this.cbEtiketter.TabIndex = 11;
            this.cbEtiketter.Text = "1";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(175, 198);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cb1
            // 
            this.cb1.Enabled = false;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "ARGON",
            "NITROGEN",
            "CO2",
            "OXYGEN"});
            this.cb1.Location = new System.Drawing.Point(80, 95);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(127, 21);
            this.cb1.TabIndex = 15;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb2.Location = new System.Drawing.Point(141, 131);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(66, 21);
            this.cb2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(433, 230);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbEtiketter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Batchmærke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
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
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
    }
}

