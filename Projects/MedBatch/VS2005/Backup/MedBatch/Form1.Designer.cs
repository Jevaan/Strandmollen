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
            this.cbAdjust = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBatchLabel = new System.Windows.Forms.ComboBox();
            this.lbEtiket = new System.Windows.Forms.Label();
            this.tbBatchID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBatch = new System.Windows.Forms.ComboBox();
            this.GroupContent = new System.Windows.Forms.GroupBox();
            this.lb_Nordic = new System.Windows.Forms.Label();
            this.tb_Nordic = new System.Windows.Forms.TextBox();
            this.btn_PrintContent = new System.Windows.Forms.Button();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLiters = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbContent = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPrnTest = new System.Windows.Forms.RadioButton();
            this.rbPrnMed = new System.Windows.Forms.RadioButton();
            this.rbPrnLoc = new System.Windows.Forms.RadioButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.GroupBatch.SuspendLayout();
            this.GroupContent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 134);
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
            this.cbEtiketter.Location = new System.Drawing.Point(77, 131);
            this.cbEtiketter.Name = "cbEtiketter";
            this.cbEtiketter.Size = new System.Drawing.Size(49, 21);
            this.cbEtiketter.TabIndex = 9;
            this.cbEtiketter.Text = "1";
            this.cbEtiketter.SelectedIndexChanged += new System.EventHandler(this.cbEtiketter_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(7, 158);
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
            this.GroupBatch.Controls.Add(this.cbAdjust);
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
            this.GroupBatch.Size = new System.Drawing.Size(193, 187);
            this.GroupBatch.TabIndex = 19;
            this.GroupBatch.TabStop = false;
            this.GroupBatch.Text = "Batchmærke";
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
            this.cbAdjust.Location = new System.Drawing.Point(89, 106);
            this.cbAdjust.Name = "cbAdjust";
            this.cbAdjust.Size = new System.Drawing.Size(39, 21);
            this.cbAdjust.TabIndex = 3;
            this.cbAdjust.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 109);
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
            this.cbDoc.Location = new System.Drawing.Point(89, 75);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(39, 21);
            this.cbDoc.TabIndex = 2;
            this.cbDoc.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 78);
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
            this.cbBatchLabel.Location = new System.Drawing.Point(67, 131);
            this.cbBatchLabel.Name = "cbBatchLabel";
            this.cbBatchLabel.Size = new System.Drawing.Size(61, 21);
            this.cbBatchLabel.TabIndex = 4;
            this.cbBatchLabel.Text = "1";
            // 
            // lbEtiket
            // 
            this.lbEtiket.AutoSize = true;
            this.lbEtiket.Location = new System.Drawing.Point(4, 134);
            this.lbEtiket.Name = "lbEtiket";
            this.lbEtiket.Size = new System.Drawing.Size(49, 13);
            this.lbEtiket.TabIndex = 13;
            this.lbEtiket.Text = "Etiketter:";
            // 
            // tbBatchID
            // 
            this.tbBatchID.Location = new System.Drawing.Point(67, 47);
            this.tbBatchID.MaxLength = 5;
            this.tbBatchID.Name = "tbBatchID";
            this.tbBatchID.Size = new System.Drawing.Size(61, 20);
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
            "Flasker < 1L",
            "Flasker > 1L",
            "N2O",
            "Cryo O2 <35L",
            "Cryo O2 >35L <2000L"});
            this.cbBatch.Location = new System.Drawing.Point(7, 20);
            this.cbBatch.Name = "cbBatch";
            this.cbBatch.Size = new System.Drawing.Size(121, 21);
            this.cbBatch.TabIndex = 0;
            this.cbBatch.SelectedIndexChanged += new System.EventHandler(this.BatchSelected);
            // 
            // GroupContent
            // 
            this.GroupContent.BackColor = System.Drawing.Color.LightGray;
            this.GroupContent.Controls.Add(this.lb_Nordic);
            this.GroupContent.Controls.Add(this.tb_Nordic);
            this.GroupContent.Controls.Add(this.btn_PrintContent);
            this.GroupContent.Controls.Add(this.cbArticle);
            this.GroupContent.Controls.Add(this.label3);
            this.GroupContent.Controls.Add(this.cbLiters);
            this.GroupContent.Controls.Add(this.label1);
            this.GroupContent.Controls.Add(this.label6);
            this.GroupContent.Controls.Add(this.cbEtiketter);
            this.GroupContent.Controls.Add(this.cbContent);
            this.GroupContent.Location = new System.Drawing.Point(229, 13);
            this.GroupContent.Name = "GroupContent";
            this.GroupContent.Size = new System.Drawing.Size(200, 187);
            this.GroupContent.TabIndex = 20;
            this.GroupContent.TabStop = false;
            this.GroupContent.Text = "Indholdsetiket";
            // 
            // lb_Nordic
            // 
            this.lb_Nordic.AutoSize = true;
            this.lb_Nordic.Location = new System.Drawing.Point(9, 107);
            this.lb_Nordic.Name = "lb_Nordic";
            this.lb_Nordic.Size = new System.Drawing.Size(38, 13);
            this.lb_Nordic.TabIndex = 12;
            this.lb_Nordic.Text = "Nordic";
            // 
            // tb_Nordic
            // 
            this.tb_Nordic.Location = new System.Drawing.Point(77, 103);
            this.tb_Nordic.Name = "tb_Nordic";
            this.tb_Nordic.Size = new System.Drawing.Size(115, 20);
            this.tb_Nordic.TabIndex = 11;
            // 
            // btn_PrintContent
            // 
            this.btn_PrintContent.Location = new System.Drawing.Point(9, 158);
            this.btn_PrintContent.Name = "btn_PrintContent";
            this.btn_PrintContent.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintContent.TabIndex = 10;
            this.btn_PrintContent.Text = "Print";
            this.btn_PrintContent.UseVisualStyleBackColor = true;
            this.btn_PrintContent.Click += new System.EventHandler(this.PrintContent);
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
            this.label3.Location = new System.Drawing.Point(6, 78);
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
            this.groupBox1.Controls.Add(this.lblVersion);
            this.groupBox1.Controls.Add(this.rbPrnTest);
            this.groupBox1.Controls.Add(this.rbPrnMed);
            this.groupBox1.Controls.Add(this.rbPrnLoc);
            this.groupBox1.Location = new System.Drawing.Point(450, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 187);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printer Valg";
            // 
            // rbPrnTest
            // 
            this.rbPrnTest.AutoSize = true;
            this.rbPrnTest.Enabled = false;
            this.rbPrnTest.Location = new System.Drawing.Point(28, 69);
            this.rbPrnTest.Name = "rbPrnTest";
            this.rbPrnTest.Size = new System.Drawing.Size(59, 17);
            this.rbPrnTest.TabIndex = 2;
            this.rbPrnTest.Text = "IT Test";
            this.rbPrnTest.UseVisualStyleBackColor = true;
            // 
            // rbPrnMed
            // 
            this.rbPrnMed.AutoSize = true;
            this.rbPrnMed.Enabled = false;
            this.rbPrnMed.Location = new System.Drawing.Point(28, 46);
            this.rbPrnMed.Name = "rbPrnMed";
            this.rbPrnMed.Size = new System.Drawing.Size(104, 17);
            this.rbPrnMed.TabIndex = 1;
            this.rbPrnMed.Text = "Medicinsk Batch";
            this.rbPrnMed.UseVisualStyleBackColor = true;
            // 
            // rbPrnLoc
            // 
            this.rbPrnLoc.AutoSize = true;
            this.rbPrnLoc.Checked = true;
            this.rbPrnLoc.Location = new System.Drawing.Point(28, 23);
            this.rbPrnLoc.Name = "rbPrnLoc";
            this.rbPrnLoc.Size = new System.Drawing.Size(83, 17);
            this.rbPrnLoc.TabIndex = 0;
            this.rbPrnLoc.TabStop = true;
            this.rbPrnLoc.Text = "Lokal printer";
            this.rbPrnLoc.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(50, 168);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(35, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(631, 212);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupContent);
            this.Controls.Add(this.GroupBatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Medicinske Batchmærker";
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
        private System.Windows.Forms.ComboBox cbAdjust;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_Nordic;
        private System.Windows.Forms.TextBox tb_Nordic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPrnTest;
        private System.Windows.Forms.RadioButton rbPrnMed;
        private System.Windows.Forms.RadioButton rbPrnLoc;
        private System.Windows.Forms.Label lblVersion;
    }
}

