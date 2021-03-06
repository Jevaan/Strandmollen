﻿namespace Flaskefyldning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.variant_combo = new System.Windows.Forms.ComboBox();
            this.articleno_lbl = new System.Windows.Forms.Label();
            this.storage_lbl = new System.Windows.Forms.Label();
            this.variant_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.scanned_lbl = new System.Windows.Forms.Label();
            this.barcode_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.ArticleNo_tb = new System.Windows.Forms.TextBox();
            this.Error_lbl = new System.Windows.Forms.Label();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.List_btn = new System.Windows.Forms.Button();
            this.Version_lbl = new System.Windows.Forms.Label();
            this.Amount_lbl = new System.Windows.Forms.Label();
            this.Amount_tb = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Draft_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // variant_combo
            // 
            this.variant_combo.Location = new System.Drawing.Point(96, 114);
            this.variant_combo.Name = "variant_combo";
            this.variant_combo.Size = new System.Drawing.Size(126, 22);
            this.variant_combo.TabIndex = 5;
            this.variant_combo.SelectedIndexChanged += new System.EventHandler(this.CheckVarAndBatch);
            this.variant_combo.TextChanged += new System.EventHandler(this.ArticlePicked);
            // 
            // articleno_lbl
            // 
            this.articleno_lbl.Location = new System.Drawing.Point(4, 92);
            this.articleno_lbl.Name = "articleno_lbl";
            this.articleno_lbl.Size = new System.Drawing.Size(86, 20);
            this.articleno_lbl.Text = "Varenummer";
            // 
            // storage_lbl
            // 
            this.storage_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.storage_lbl.Location = new System.Drawing.Point(4, 7);
            this.storage_lbl.Name = "storage_lbl";
            this.storage_lbl.Size = new System.Drawing.Size(233, 20);
            this.storage_lbl.Text = "Lagersted";
            // 
            // variant_lbl
            // 
            this.variant_lbl.Location = new System.Drawing.Point(4, 115);
            this.variant_lbl.Name = "variant_lbl";
            this.variant_lbl.Size = new System.Drawing.Size(86, 20);
            this.variant_lbl.Text = "Variant";
            // 
            // start_btn
            // 
            this.start_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.start_btn.Location = new System.Drawing.Point(62, 197);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(104, 48);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Start";
            this.start_btn.Click += new System.EventHandler(this.start_click);
            // 
            // stop_btn
            // 
            this.stop_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.stop_btn.Location = new System.Drawing.Point(62, 197);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(104, 48);
            this.stop_btn.TabIndex = 6;
            this.stop_btn.Text = "Afslut";
            this.stop_btn.Visible = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_click);
            // 
            // scanned_lbl
            // 
            this.scanned_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.scanned_lbl.Location = new System.Drawing.Point(4, 174);
            this.scanned_lbl.Name = "scanned_lbl";
            this.scanned_lbl.Size = new System.Drawing.Size(218, 20);
            this.scanned_lbl.Text = "scanned_lbl";
            this.scanned_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scanned_lbl.Visible = false;
            // 
            // barcode_lbl
            // 
            this.barcode_lbl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.barcode_lbl.Location = new System.Drawing.Point(4, 151);
            this.barcode_lbl.Name = "barcode_lbl";
            this.barcode_lbl.Size = new System.Drawing.Size(218, 20);
            this.barcode_lbl.Text = "barcode_lbl";
            this.barcode_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.barcode_lbl.Visible = false;
            // 
            // close_btn
            // 
            this.close_btn.Location = new System.Drawing.Point(192, 225);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(45, 20);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "LUK";
            this.close_btn.Click += new System.EventHandler(this.TerminateProgram);
            // 
            // ArticleNo_tb
            // 
            this.ArticleNo_tb.Location = new System.Drawing.Point(96, 91);
            this.ArticleNo_tb.Name = "ArticleNo_tb";
            this.ArticleNo_tb.Size = new System.Drawing.Size(126, 21);
            this.ArticleNo_tb.TabIndex = 1;
            this.ArticleNo_tb.TextChanged += new System.EventHandler(this.CheckArticle);
            this.ArticleNo_tb.LostFocus += new System.EventHandler(this.CreateVariant);
            // 
            // Error_lbl
            // 
            this.Error_lbl.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Bold);
            this.Error_lbl.ForeColor = System.Drawing.Color.DarkRed;
            this.Error_lbl.Location = new System.Drawing.Point(85, 93);
            this.Error_lbl.Name = "Error_lbl";
            this.Error_lbl.Size = new System.Drawing.Size(25, 20);
            this.Error_lbl.Text = "X";
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(6, 224);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(38, 20);
            this.Delete_btn.TabIndex = 15;
            this.Delete_btn.Text = "Slet";
            this.Delete_btn.Click += new System.EventHandler(this.DeleteSavedBarcodes);
            // 
            // List_btn
            // 
            this.List_btn.Location = new System.Drawing.Point(6, 197);
            this.List_btn.Name = "List_btn";
            this.List_btn.Size = new System.Drawing.Size(38, 20);
            this.List_btn.TabIndex = 16;
            this.List_btn.Text = "Liste";
            this.List_btn.Visible = false;
            this.List_btn.Click += new System.EventHandler(this.DisplayList);
            // 
            // Version_lbl
            // 
            this.Version_lbl.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.Version_lbl.Location = new System.Drawing.Point(137, 248);
            this.Version_lbl.Name = "Version_lbl";
            this.Version_lbl.Size = new System.Drawing.Size(100, 20);
            this.Version_lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Amount_lbl
            // 
            this.Amount_lbl.Location = new System.Drawing.Point(4, 142);
            this.Amount_lbl.Name = "Amount_lbl";
            this.Amount_lbl.Size = new System.Drawing.Size(61, 20);
            this.Amount_lbl.Text = "Antal";
            this.Amount_lbl.Visible = false;
            // 
            // Amount_tb
            // 
            this.Amount_tb.Location = new System.Drawing.Point(96, 141);
            this.Amount_tb.Name = "Amount_tb";
            this.Amount_tb.Size = new System.Drawing.Size(125, 21);
            this.Amount_tb.TabIndex = 36;
            this.Amount_tb.Visible = false;
            this.Amount_tb.TextChanged += new System.EventHandler(this.CheckAmount);
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Save_btn.Location = new System.Drawing.Point(62, 196);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(104, 48);
            this.Save_btn.TabIndex = 37;
            this.Save_btn.Text = "Gem";
            this.Save_btn.Visible = false;
            this.Save_btn.Click += new System.EventHandler(this.SaveClicked);
            // 
            // Draft_label
            // 
            this.Draft_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Draft_label.Location = new System.Drawing.Point(4, 31);
            this.Draft_label.Name = "Draft_label";
            this.Draft_label.Size = new System.Drawing.Size(233, 20);
            this.Draft_label.Text = "Kladde";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Draft_label);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Amount_tb);
            this.Controls.Add(this.Amount_lbl);
            this.Controls.Add(this.Version_lbl);
            this.Controls.Add(this.List_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.ArticleNo_tb);
            this.Controls.Add(this.Error_lbl);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.barcode_lbl);
            this.Controls.Add(this.scanned_lbl);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.variant_lbl);
            this.Controls.Add(this.storage_lbl);
            this.Controls.Add(this.articleno_lbl);
            this.Controls.Add(this.variant_combo);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Flaskefyldning";
            this.Deactivate += new System.EventHandler(this.DeactivateBCR);
            this.Load += new System.EventHandler(this.Form_Load);
            this.Activated += new System.EventHandler(this.ActivateBCR);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox variant_combo;
        private System.Windows.Forms.Label articleno_lbl;
        private System.Windows.Forms.Label storage_lbl;
        private System.Windows.Forms.Label variant_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label scanned_lbl;
        private System.Windows.Forms.Label barcode_lbl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox ArticleNo_tb;
        private System.Windows.Forms.Label Error_lbl;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button List_btn;
        private System.Windows.Forms.Label Version_lbl;
        private System.Windows.Forms.Label Amount_lbl;
        private System.Windows.Forms.TextBox Amount_tb;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label Draft_label;
    }
}

