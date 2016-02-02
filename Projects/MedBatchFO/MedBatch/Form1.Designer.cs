namespace MedBatch
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.GroupBatch = new System.Windows.Forms.GroupBox();
            this.cbAdjustX = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbAdjust = new System.Windows.Forms.ComboBox();
            this.lblKontrolDato = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBatchLabel = new System.Windows.Forms.ComboBox();
            this.lbEtiket = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printersCB = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.GroupBatch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(13, 150);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // GroupBatch
            // 
            this.GroupBatch.BackColor = System.Drawing.Color.LightGray;
            this.GroupBatch.Controls.Add(this.lblSize);
            this.GroupBatch.Controls.Add(this.cbSize);
            this.GroupBatch.Controls.Add(this.cbAdjustX);
            this.GroupBatch.Controls.Add(this.label9);
            this.GroupBatch.Controls.Add(this.dateTimePicker1);
            this.GroupBatch.Controls.Add(this.cbAdjust);
            this.GroupBatch.Controls.Add(this.lblKontrolDato);
            this.GroupBatch.Controls.Add(this.label8);
            this.GroupBatch.Controls.Add(this.label5);
            this.GroupBatch.Controls.Add(this.cbDoc);
            this.GroupBatch.Controls.Add(this.label2);
            this.GroupBatch.Controls.Add(this.cbBatchLabel);
            this.GroupBatch.Controls.Add(this.lbEtiket);
            this.GroupBatch.Controls.Add(this.btnPrint);
            this.GroupBatch.Location = new System.Drawing.Point(13, 13);
            this.GroupBatch.Name = "GroupBatch";
            this.GroupBatch.Size = new System.Drawing.Size(193, 183);
            this.GroupBatch.TabIndex = 19;
            this.GroupBatch.TabStop = false;
            this.GroupBatch.Text = "Batchmærke";
            // 
            // cbAdjustX
            // 
            this.cbAdjustX.FormattingEnabled = true;
            this.cbAdjustX.Items.AddRange(new object[] {
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
            this.cbAdjustX.Location = new System.Drawing.Point(87, 99);
            this.cbAdjustX.Name = "cbAdjustX";
            this.cbAdjustX.Size = new System.Drawing.Size(40, 21);
            this.cbAdjustX.TabIndex = 24;
            this.cbAdjustX.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "↔";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // cbAdjust
            // 
            this.cbAdjust.FormattingEnabled = true;
            this.cbAdjust.Items.AddRange(new object[] {
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3"});
            this.cbAdjust.Location = new System.Drawing.Point(148, 97);
            this.cbAdjust.Name = "cbAdjust";
            this.cbAdjust.Size = new System.Drawing.Size(39, 21);
            this.cbAdjust.TabIndex = 22;
            this.cbAdjust.Text = "0";
            // 
            // lblKontrolDato
            // 
            this.lblKontrolDato.AutoSize = true;
            this.lblKontrolDato.Location = new System.Drawing.Point(10, 50);
            this.lblKontrolDato.Name = "lblKontrolDato";
            this.lblKontrolDato.Size = new System.Drawing.Size(53, 13);
            this.lblKontrolDato.TabIndex = 18;
            this.lblKontrolDato.Text = "Fyldedato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "↕";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Justering";
            // 
            // cbDoc
            // 
            this.cbDoc.FormattingEnabled = true;
            this.cbDoc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbDoc.Location = new System.Drawing.Point(148, 72);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(39, 21);
            this.cbDoc.TabIndex = 2;
            this.cbDoc.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dokumentation";
            // 
            // cbBatchLabel
            // 
            this.cbBatchLabel.FormattingEnabled = true;
            this.cbBatchLabel.Items.AddRange(new object[] {
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
            this.cbBatchLabel.Location = new System.Drawing.Point(126, 125);
            this.cbBatchLabel.Name = "cbBatchLabel";
            this.cbBatchLabel.Size = new System.Drawing.Size(61, 21);
            this.cbBatchLabel.TabIndex = 4;
            this.cbBatchLabel.Text = "1";
            // 
            // lbEtiket
            // 
            this.lbEtiket.AutoSize = true;
            this.lbEtiket.Location = new System.Drawing.Point(10, 128);
            this.lbEtiket.Name = "lbEtiket";
            this.lbEtiket.Size = new System.Drawing.Size(49, 13);
            this.lbEtiket.TabIndex = 13;
            this.lbEtiket.Text = "Etiketter:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.printersCB);
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Location = new System.Drawing.Point(220, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 183);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer Valg";
            // 
            // printersCB
            // 
            this.printersCB.FormattingEnabled = true;
            this.printersCB.Location = new System.Drawing.Point(28, 20);
            this.printersCB.Name = "printersCB";
            this.printersCB.Size = new System.Drawing.Size(121, 21);
            this.printersCB.TabIndex = 4;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(46, 158);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "label7";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "<1L",
            "1-4L",
            ">4L"});
            this.cbSize.Location = new System.Drawing.Point(137, 20);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(50, 21);
            this.cbSize.TabIndex = 26;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(10, 26);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(48, 13);
            this.lblSize.TabIndex = 27;
            this.lblSize.Text = "Størrelse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(405, 205);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Batch Fønix";
            this.GroupBatch.ResumeLayout(false);
            this.GroupBatch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox GroupBatch;
        private System.Windows.Forms.Label lbEtiket;
        private System.Windows.Forms.ComboBox cbBatchLabel;
        private System.Windows.Forms.ComboBox cbDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblKontrolDato;
        private System.Windows.Forms.ComboBox cbAdjustX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAdjust;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox printersCB;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cbSize;
    }
}

