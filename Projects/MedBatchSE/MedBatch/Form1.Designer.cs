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
            this.label6 = new System.Windows.Forms.Label();
            this.cbEtiketter = new System.Windows.Forms.ComboBox();
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
            this.tbBatchID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBatch = new System.Windows.Forms.ComboBox();
            this.GroupContent = new System.Windows.Forms.GroupBox();
            this.ContentAdjustX = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Nordic = new System.Windows.Forms.Label();
            this.ContentAdjustY = new System.Windows.Forms.ComboBox();
            this.tb_Nordic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_PrintContent = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLiters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbContent = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPrnLju = new System.Windows.Forms.RadioButton();
            this.Content_Chkbox = new System.Windows.Forms.CheckBox();
            this.rbPrnTek = new System.Windows.Forms.RadioButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.rbPrnTest = new System.Windows.Forms.RadioButton();
            this.rbPrnMed = new System.Windows.Forms.RadioButton();
            this.rbPrnLoc = new System.Windows.Forms.RadioButton();
            this.GroupBatch.SuspendLayout();
            this.GroupContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 155);
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
            this.cbEtiketter.Location = new System.Drawing.Point(143, 152);
            this.cbEtiketter.Name = "cbEtiketter";
            this.cbEtiketter.Size = new System.Drawing.Size(49, 21);
            this.cbEtiketter.TabIndex = 9;
            this.cbEtiketter.Text = "1";
            this.cbEtiketter.SelectedIndexChanged += new System.EventHandler(this.cbEtiketter_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(7, 177);
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
            this.GroupBatch.Controls.Add(this.tbBatchID);
            this.GroupBatch.Controls.Add(this.label4);
            this.GroupBatch.Controls.Add(this.btnPrint);
            this.GroupBatch.Controls.Add(this.cbBatch);
            this.GroupBatch.Location = new System.Drawing.Point(13, 13);
            this.GroupBatch.Name = "GroupBatch";
            this.GroupBatch.Size = new System.Drawing.Size(193, 206);
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
            this.cbAdjustX.Location = new System.Drawing.Point(81, 126);
            this.cbAdjustX.Name = "cbAdjustX";
            this.cbAdjustX.Size = new System.Drawing.Size(40, 21);
            this.cbAdjustX.TabIndex = 24;
            this.cbAdjustX.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(84, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "↔";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Visible = false;
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
            this.cbAdjust.Location = new System.Drawing.Point(142, 124);
            this.cbAdjust.Name = "cbAdjust";
            this.cbAdjust.Size = new System.Drawing.Size(39, 21);
            this.cbAdjust.TabIndex = 22;
            this.cbAdjust.Text = "0";
            // 
            // lblKontrolDato
            // 
            this.lblKontrolDato.AutoSize = true;
            this.lblKontrolDato.Location = new System.Drawing.Point(4, 77);
            this.lblKontrolDato.Name = "lblKontrolDato";
            this.lblKontrolDato.Size = new System.Drawing.Size(61, 13);
            this.lblKontrolDato.TabIndex = 18;
            this.lblKontrolDato.Text = "Kontroldato";
            this.lblKontrolDato.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(127, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "↕";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 130);
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
            this.cbDoc.Location = new System.Drawing.Point(142, 99);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(39, 21);
            this.cbDoc.TabIndex = 2;
            this.cbDoc.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 102);
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
            this.cbBatchLabel.Location = new System.Drawing.Point(120, 152);
            this.cbBatchLabel.Name = "cbBatchLabel";
            this.cbBatchLabel.Size = new System.Drawing.Size(61, 21);
            this.cbBatchLabel.TabIndex = 4;
            this.cbBatchLabel.Text = "1";
            // 
            // lbEtiket
            // 
            this.lbEtiket.AutoSize = true;
            this.lbEtiket.Location = new System.Drawing.Point(4, 155);
            this.lbEtiket.Name = "lbEtiket";
            this.lbEtiket.Size = new System.Drawing.Size(49, 13);
            this.lbEtiket.TabIndex = 13;
            this.lbEtiket.Text = "Etiketter:";
            // 
            // tbBatchID
            // 
            this.tbBatchID.Location = new System.Drawing.Point(97, 47);
            this.tbBatchID.MaxLength = 5;
            this.tbBatchID.Name = "tbBatchID";
            this.tbBatchID.Size = new System.Drawing.Size(84, 20);
            this.tbBatchID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Batch_ID";
            // 
            // cbBatch
            // 
            this.cbBatch.FormattingEnabled = true;
            this.cbBatch.Items.AddRange(new object[] {
            "O2 flasker < 2 L",
            "O2 flasker ≥ 2 L < 4 L",
            "O2 flasker ≥ 4 L",
            "N2O flasker",
            "Cryo O2 < 35 L",
            "Cryo O2 ≥ 35 L < 2000 L",
            "Pharmaline"});
            this.cbBatch.Location = new System.Drawing.Point(7, 20);
            this.cbBatch.Name = "cbBatch";
            this.cbBatch.Size = new System.Drawing.Size(174, 21);
            this.cbBatch.TabIndex = 0;
            this.cbBatch.Text = "Vælg mærke";
            this.cbBatch.SelectedIndexChanged += new System.EventHandler(this.BatchChanged);
            // 
            // GroupContent
            // 
            this.GroupContent.BackColor = System.Drawing.Color.LightGray;
            this.GroupContent.Controls.Add(this.ContentAdjustX);
            this.GroupContent.Controls.Add(this.label7);
            this.GroupContent.Controls.Add(this.lb_Nordic);
            this.GroupContent.Controls.Add(this.ContentAdjustY);
            this.GroupContent.Controls.Add(this.tb_Nordic);
            this.GroupContent.Controls.Add(this.label10);
            this.GroupContent.Controls.Add(this.btn_PrintContent);
            this.GroupContent.Controls.Add(this.label11);
            this.GroupContent.Controls.Add(this.cbArticle);
            this.GroupContent.Controls.Add(this.label3);
            this.GroupContent.Controls.Add(this.cbLiters);
            this.GroupContent.Controls.Add(this.label1);
            this.GroupContent.Controls.Add(this.label6);
            this.GroupContent.Controls.Add(this.cbEtiketter);
            this.GroupContent.Controls.Add(this.cbContent);
            this.GroupContent.Location = new System.Drawing.Point(229, 13);
            this.GroupContent.Name = "GroupContent";
            this.GroupContent.Size = new System.Drawing.Size(200, 206);
            this.GroupContent.TabIndex = 20;
            this.GroupContent.TabStop = false;
            this.GroupContent.Text = "Indholdsetiket";
            // 
            // ContentAdjustX
            // 
            this.ContentAdjustX.FormattingEnabled = true;
            this.ContentAdjustX.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.ContentAdjustX.Location = new System.Drawing.Point(86, 129);
            this.ContentAdjustX.Name = "ContentAdjustX";
            this.ContentAdjustX.Size = new System.Drawing.Size(40, 21);
            this.ContentAdjustX.TabIndex = 29;
            this.ContentAdjustX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "↔";
            // 
            // lb_Nordic
            // 
            this.lb_Nordic.AutoSize = true;
            this.lb_Nordic.Location = new System.Drawing.Point(4, 106);
            this.lb_Nordic.Name = "lb_Nordic";
            this.lb_Nordic.Size = new System.Drawing.Size(38, 13);
            this.lb_Nordic.TabIndex = 12;
            this.lb_Nordic.Text = "Nordic";
            // 
            // ContentAdjustY
            // 
            this.ContentAdjustY.FormattingEnabled = true;
            this.ContentAdjustY.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ContentAdjustY.Location = new System.Drawing.Point(147, 127);
            this.ContentAdjustY.Name = "ContentAdjustY";
            this.ContentAdjustY.Size = new System.Drawing.Size(39, 21);
            this.ContentAdjustY.TabIndex = 27;
            this.ContentAdjustY.Text = "0";
            // 
            // tb_Nordic
            // 
            this.tb_Nordic.Location = new System.Drawing.Point(77, 103);
            this.tb_Nordic.Name = "tb_Nordic";
            this.tb_Nordic.Size = new System.Drawing.Size(115, 20);
            this.tb_Nordic.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 24);
            this.label10.TabIndex = 28;
            this.label10.Text = "↕";
            // 
            // btn_PrintContent
            // 
            this.btn_PrintContent.Location = new System.Drawing.Point(7, 177);
            this.btn_PrintContent.Name = "btn_PrintContent";
            this.btn_PrintContent.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintContent.TabIndex = 10;
            this.btn_PrintContent.Text = "Print";
            this.btn_PrintContent.UseVisualStyleBackColor = true;
            this.btn_PrintContent.Click += new System.EventHandler(this.PrintContent);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Justering";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cbArticle
            // 
            this.cbArticle.FormattingEnabled = true;
            this.cbArticle.Location = new System.Drawing.Point(77, 75);
            this.cbArticle.Name = "cbArticle";
            this.cbArticle.Size = new System.Drawing.Size(115, 21);
            this.cbArticle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Article no.";
            // 
            // cbLiters
            // 
            this.cbLiters.FormattingEnabled = true;
            this.cbLiters.Location = new System.Drawing.Point(77, 47);
            this.cbLiters.Name = "cbLiters";
            this.cbLiters.Size = new System.Drawing.Size(115, 21);
            this.cbLiters.TabIndex = 7;
            this.cbLiters.SelectedIndexChanged += new System.EventHandler(this.N2O_SetVnr);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Content in L";
            // 
            // cbContent
            // 
            this.cbContent.FormattingEnabled = true;
            this.cbContent.Items.AddRange(new object[] {
            "Medical Gas Compressed",
            "Medical Gas Cryogenic",
            "Medical Gas Liquid N2O"});
            this.cbContent.Location = new System.Drawing.Point(7, 20);
            this.cbContent.Name = "cbContent";
            this.cbContent.Size = new System.Drawing.Size(185, 21);
            this.cbContent.TabIndex = 6;
            this.cbContent.SelectedIndexChanged += new System.EventHandler(this.ContentSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPrnLju);
            this.groupBox1.Controls.Add(this.Content_Chkbox);
            this.groupBox1.Controls.Add(this.rbPrnTek);
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.rbPrnTest);
            this.groupBox1.Controls.Add(this.rbPrnMed);
            this.groupBox1.Controls.Add(this.rbPrnLoc);
            this.groupBox1.Location = new System.Drawing.Point(450, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 206);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer Valg";
            // 
            // rbPrnLju
            // 
            this.rbPrnLju.AutoSize = true;
            this.rbPrnLju.Location = new System.Drawing.Point(28, 93);
            this.rbPrnLju.Name = "rbPrnLju";
            this.rbPrnLju.Size = new System.Drawing.Size(62, 17);
            this.rbPrnLju.TabIndex = 6;
            this.rbPrnLju.TabStop = true;
            this.rbPrnLju.Text = "Ljungby";
            this.rbPrnLju.UseVisualStyleBackColor = true;
            // 
            // Content_Chkbox
            // 
            this.Content_Chkbox.AutoSize = true;
            this.Content_Chkbox.Checked = true;
            this.Content_Chkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Content_Chkbox.Location = new System.Drawing.Point(28, 140);
            this.Content_Chkbox.Name = "Content_Chkbox";
            this.Content_Chkbox.Size = new System.Drawing.Size(92, 17);
            this.Content_Chkbox.TabIndex = 5;
            this.Content_Chkbox.Text = "Indholdsetiket";
            this.Content_Chkbox.UseVisualStyleBackColor = true;
            // 
            // rbPrnTek
            // 
            this.rbPrnTek.AutoSize = true;
            this.rbPrnTek.Location = new System.Drawing.Point(28, 69);
            this.rbPrnTek.Name = "rbPrnTek";
            this.rbPrnTek.Size = new System.Drawing.Size(94, 17);
            this.rbPrnTek.TabIndex = 4;
            this.rbPrnTek.Text = "Teknisk Batch";
            this.rbPrnTek.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(52, 185);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "label7";
            // 
            // rbPrnTest
            // 
            this.rbPrnTest.AutoSize = true;
            this.rbPrnTest.Location = new System.Drawing.Point(28, 116);
            this.rbPrnTest.Name = "rbPrnTest";
            this.rbPrnTest.Size = new System.Drawing.Size(59, 17);
            this.rbPrnTest.TabIndex = 2;
            this.rbPrnTest.Text = "IT Test";
            this.rbPrnTest.UseVisualStyleBackColor = true;
            // 
            // rbPrnMed
            // 
            this.rbPrnMed.AutoSize = true;
            this.rbPrnMed.Checked = true;
            this.rbPrnMed.Location = new System.Drawing.Point(28, 46);
            this.rbPrnMed.Name = "rbPrnMed";
            this.rbPrnMed.Size = new System.Drawing.Size(104, 17);
            this.rbPrnMed.TabIndex = 1;
            this.rbPrnMed.TabStop = true;
            this.rbPrnMed.Text = "Medicinsk Batch";
            this.rbPrnMed.UseVisualStyleBackColor = true;
            // 
            // rbPrnLoc
            // 
            this.rbPrnLoc.AutoSize = true;
            this.rbPrnLoc.Location = new System.Drawing.Point(28, 23);
            this.rbPrnLoc.Name = "rbPrnLoc";
            this.rbPrnLoc.Size = new System.Drawing.Size(83, 17);
            this.rbPrnLoc.TabIndex = 0;
            this.rbPrnLoc.Text = "Lokal printer";
            this.rbPrnLoc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(631, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupContent);
            this.Controls.Add(this.GroupBatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Svenske Medicinske Batchmærker";
            this.GroupBatch.ResumeLayout(false);
            this.GroupBatch.PerformLayout();
            this.GroupContent.ResumeLayout(false);
            this.GroupContent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEtiketter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox GroupBatch;
        private System.Windows.Forms.GroupBox GroupContent;
        private System.Windows.Forms.ComboBox cbArticle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLiters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbContent;
        private System.Windows.Forms.TextBox tbBatchID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBatch;
        private System.Windows.Forms.Button btn_PrintContent;
        private System.Windows.Forms.Label lbEtiket;
        private System.Windows.Forms.ComboBox cbBatchLabel;
        private System.Windows.Forms.ComboBox cbDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Nordic;
        private System.Windows.Forms.TextBox tb_Nordic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPrnTest;
        private System.Windows.Forms.RadioButton rbPrnMed;
        private System.Windows.Forms.RadioButton rbPrnLoc;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.RadioButton rbPrnTek;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblKontrolDato;
        private System.Windows.Forms.ComboBox cbAdjustX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAdjust;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ContentAdjustX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ContentAdjustY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox Content_Chkbox;
        private System.Windows.Forms.RadioButton rbPrnLju;
    }
}

