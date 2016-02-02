namespace BatchPrint
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.Type_dropdown = new System.Windows.Forms.ComboBox();
            this.Type_lbl = new System.Windows.Forms.Label();
            this.Liters_textbox = new System.Windows.Forms.TextBox();
            this.Liters_lbl = new System.Windows.Forms.Label();
            this.ArticleNo_lbl = new System.Windows.Forms.Label();
            this.ArticleNo_textbox = new System.Windows.Forms.TextBox();
            this.Vnr_lbl = new System.Windows.Forms.Label();
            this.Vnr_textbox = new System.Windows.Forms.TextBox();
            this.AddVnr_btn = new System.Windows.Forms.Button();
            this.DK_chk = new System.Windows.Forms.CheckBox();
            this.SE_chk = new System.Windows.Forms.CheckBox();
            this.DE_chk = new System.Windows.Forms.CheckBox();
            this.Articles_box = new System.Windows.Forms.ListBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pzn_lbl = new System.Windows.Forms.Label();
            this.pzn_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type_dropdown
            // 
            this.Type_dropdown.FormattingEnabled = true;
            this.Type_dropdown.Items.AddRange(new object[] {
            "Medical Gas Oxygen Compressed",
            "Medical Gas Oxygen Cryogenic",
            "Medical Gas Liquid N2O",
            "Medical Gas Latox Compressed",
            "Medical Gas Luft Compressed"});
            this.Type_dropdown.Location = new System.Drawing.Point(80, 19);
            this.Type_dropdown.Name = "Type_dropdown";
            this.Type_dropdown.Size = new System.Drawing.Size(121, 21);
            this.Type_dropdown.TabIndex = 0;
            this.Type_dropdown.Text = "Vælg type";
            // 
            // Type_lbl
            // 
            this.Type_lbl.AutoSize = true;
            this.Type_lbl.Location = new System.Drawing.Point(6, 22);
            this.Type_lbl.Name = "Type_lbl";
            this.Type_lbl.Size = new System.Drawing.Size(31, 13);
            this.Type_lbl.TabIndex = 1;
            this.Type_lbl.Text = "Type";
            // 
            // Liters_textbox
            // 
            this.Liters_textbox.Location = new System.Drawing.Point(80, 46);
            this.Liters_textbox.Name = "Liters_textbox";
            this.Liters_textbox.Size = new System.Drawing.Size(121, 20);
            this.Liters_textbox.TabIndex = 1;
            this.Liters_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckLiterInput);
            // 
            // Liters_lbl
            // 
            this.Liters_lbl.AutoSize = true;
            this.Liters_lbl.Location = new System.Drawing.Point(6, 49);
            this.Liters_lbl.Name = "Liters_lbl";
            this.Liters_lbl.Size = new System.Drawing.Size(27, 13);
            this.Liters_lbl.TabIndex = 3;
            this.Liters_lbl.Text = "Liter";
            // 
            // ArticleNo_lbl
            // 
            this.ArticleNo_lbl.AutoSize = true;
            this.ArticleNo_lbl.Location = new System.Drawing.Point(6, 75);
            this.ArticleNo_lbl.Name = "ArticleNo_lbl";
            this.ArticleNo_lbl.Size = new System.Drawing.Size(66, 13);
            this.ArticleNo_lbl.TabIndex = 4;
            this.ArticleNo_lbl.Text = "Varenummer";
            // 
            // ArticleNo_textbox
            // 
            this.ArticleNo_textbox.Location = new System.Drawing.Point(80, 72);
            this.ArticleNo_textbox.Name = "ArticleNo_textbox";
            this.ArticleNo_textbox.Size = new System.Drawing.Size(121, 20);
            this.ArticleNo_textbox.TabIndex = 2;
            // 
            // Vnr_lbl
            // 
            this.Vnr_lbl.AutoSize = true;
            this.Vnr_lbl.Location = new System.Drawing.Point(6, 101);
            this.Vnr_lbl.Name = "Vnr_lbl";
            this.Vnr_lbl.Size = new System.Drawing.Size(26, 13);
            this.Vnr_lbl.TabIndex = 6;
            this.Vnr_lbl.Text = "Vnr.";
            // 
            // Vnr_textbox
            // 
            this.Vnr_textbox.Location = new System.Drawing.Point(80, 98);
            this.Vnr_textbox.Name = "Vnr_textbox";
            this.Vnr_textbox.Size = new System.Drawing.Size(121, 20);
            this.Vnr_textbox.TabIndex = 3;
            // 
            // AddVnr_btn
            // 
            this.AddVnr_btn.Location = new System.Drawing.Point(126, 173);
            this.AddVnr_btn.Name = "AddVnr_btn";
            this.AddVnr_btn.Size = new System.Drawing.Size(75, 23);
            this.AddVnr_btn.TabIndex = 7;
            this.AddVnr_btn.Text = "Tilføj";
            this.AddVnr_btn.UseVisualStyleBackColor = true;
            this.AddVnr_btn.Click += new System.EventHandler(this.AddVnr_btn_Click);
            // 
            // DK_chk
            // 
            this.DK_chk.AutoSize = true;
            this.DK_chk.Location = new System.Drawing.Point(80, 150);
            this.DK_chk.Name = "DK_chk";
            this.DK_chk.Size = new System.Drawing.Size(41, 17);
            this.DK_chk.TabIndex = 4;
            this.DK_chk.Text = "DK";
            this.DK_chk.UseVisualStyleBackColor = true;
            // 
            // SE_chk
            // 
            this.SE_chk.AutoSize = true;
            this.SE_chk.Location = new System.Drawing.Point(126, 150);
            this.SE_chk.Name = "SE_chk";
            this.SE_chk.Size = new System.Drawing.Size(40, 17);
            this.SE_chk.TabIndex = 5;
            this.SE_chk.Text = "SE";
            this.SE_chk.UseVisualStyleBackColor = true;
            // 
            // DE_chk
            // 
            this.DE_chk.AutoSize = true;
            this.DE_chk.Location = new System.Drawing.Point(172, 150);
            this.DE_chk.Name = "DE_chk";
            this.DE_chk.Size = new System.Drawing.Size(41, 17);
            this.DE_chk.TabIndex = 6;
            this.DE_chk.Text = "DE";
            this.DE_chk.UseVisualStyleBackColor = true;
            // 
            // Articles_box
            // 
            this.Articles_box.FormattingEnabled = true;
            this.Articles_box.Location = new System.Drawing.Point(255, 31);
            this.Articles_box.Name = "Articles_box";
            this.Articles_box.Size = new System.Drawing.Size(186, 147);
            this.Articles_box.TabIndex = 20;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(119, 173);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 23);
            this.Delete_btn.TabIndex = 21;
            this.Delete_btn.Text = "Slet";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pzn_textbox);
            this.groupBox1.Controls.Add(this.pzn_lbl);
            this.groupBox1.Controls.Add(this.Type_dropdown);
            this.groupBox1.Controls.Add(this.AddVnr_btn);
            this.groupBox1.Controls.Add(this.Type_lbl);
            this.groupBox1.Controls.Add(this.Liters_lbl);
            this.groupBox1.Controls.Add(this.ArticleNo_lbl);
            this.groupBox1.Controls.Add(this.Liters_textbox);
            this.groupBox1.Controls.Add(this.ArticleNo_textbox);
            this.groupBox1.Controls.Add(this.Vnr_lbl);
            this.groupBox1.Controls.Add(this.Vnr_textbox);
            this.groupBox1.Controls.Add(this.SE_chk);
            this.groupBox1.Controls.Add(this.DE_chk);
            this.groupBox1.Controls.Add(this.DK_chk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 205);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tilføj Varenummer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Delete_btn);
            this.groupBox2.Location = new System.Drawing.Point(247, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 205);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eksisterende varenumre";
            // 
            // pzn_lbl
            // 
            this.pzn_lbl.AutoSize = true;
            this.pzn_lbl.Location = new System.Drawing.Point(6, 131);
            this.pzn_lbl.Name = "pzn_lbl";
            this.pzn_lbl.Size = new System.Drawing.Size(29, 13);
            this.pzn_lbl.TabIndex = 8;
            this.pzn_lbl.Text = "PZN";
            // 
            // pzn_textbox
            // 
            this.pzn_textbox.Location = new System.Drawing.Point(80, 124);
            this.pzn_textbox.MaxLength = 8;
            this.pzn_textbox.Name = "pzn_textbox";
            this.pzn_textbox.Size = new System.Drawing.Size(121, 20);
            this.pzn_textbox.TabIndex = 9;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 224);
            this.Controls.Add(this.Articles_box);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Administration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Type_dropdown;
        private System.Windows.Forms.Label Type_lbl;
        private System.Windows.Forms.TextBox Liters_textbox;
        private System.Windows.Forms.Label Liters_lbl;
        private System.Windows.Forms.Label ArticleNo_lbl;
        private System.Windows.Forms.TextBox ArticleNo_textbox;
        private System.Windows.Forms.Label Vnr_lbl;
        private System.Windows.Forms.TextBox Vnr_textbox;
        private System.Windows.Forms.Button AddVnr_btn;
        private System.Windows.Forms.CheckBox DK_chk;
        private System.Windows.Forms.CheckBox SE_chk;
        private System.Windows.Forms.CheckBox DE_chk;
        private System.Windows.Forms.ListBox Articles_box;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox pzn_textbox;
        private System.Windows.Forms.Label pzn_lbl;
    }
}