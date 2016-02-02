namespace PrintBarcodes
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
            this.StartBarcode_tb = new System.Windows.Forms.TextBox();
            this.Amount_tb = new System.Windows.Forms.TextBox();
            this.StartBarcode_lbl = new System.Windows.Forms.Label();
            this.Amount_lbl = new System.Windows.Forms.Label();
            this.Print_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartBarcode_tb
            // 
            this.StartBarcode_tb.Location = new System.Drawing.Point(172, 12);
            this.StartBarcode_tb.Name = "StartBarcode_tb";
            this.StartBarcode_tb.Size = new System.Drawing.Size(100, 20);
            this.StartBarcode_tb.TabIndex = 0;
            // 
            // Amount_tb
            // 
            this.Amount_tb.Location = new System.Drawing.Point(172, 39);
            this.Amount_tb.Name = "Amount_tb";
            this.Amount_tb.Size = new System.Drawing.Size(100, 20);
            this.Amount_tb.TabIndex = 1;
            // 
            // StartBarcode_lbl
            // 
            this.StartBarcode_lbl.AutoSize = true;
            this.StartBarcode_lbl.Location = new System.Drawing.Point(13, 18);
            this.StartBarcode_lbl.Name = "StartBarcode_lbl";
            this.StartBarcode_lbl.Size = new System.Drawing.Size(79, 13);
            this.StartBarcode_lbl.TabIndex = 2;
            this.StartBarcode_lbl.Text = "Start stregkode";
            // 
            // Amount_lbl
            // 
            this.Amount_lbl.AutoSize = true;
            this.Amount_lbl.Location = new System.Drawing.Point(13, 45);
            this.Amount_lbl.Name = "Amount_lbl";
            this.Amount_lbl.Size = new System.Drawing.Size(31, 13);
            this.Amount_lbl.TabIndex = 3;
            this.Amount_lbl.Text = "Antal";
            // 
            // Print_btn
            // 
            this.Print_btn.Location = new System.Drawing.Point(95, 74);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(75, 23);
            this.Print_btn.TabIndex = 4;
            this.Print_btn.Text = "Print";
            this.Print_btn.UseVisualStyleBackColor = true;
            this.Print_btn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrintBarcodes);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Print_btn);
            this.Controls.Add(this.Amount_lbl);
            this.Controls.Add(this.StartBarcode_lbl);
            this.Controls.Add(this.Amount_tb);
            this.Controls.Add(this.StartBarcode_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartBarcode_tb;
        private System.Windows.Forms.TextBox Amount_tb;
        private System.Windows.Forms.Label StartBarcode_lbl;
        private System.Windows.Forms.Label Amount_lbl;
        private System.Windows.Forms.Button Print_btn;
    }
}

