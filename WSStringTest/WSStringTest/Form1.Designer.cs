namespace WSStringTest
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
            this.Text_txt = new System.Windows.Forms.TextBox();
            this.Filename_txt = new System.Windows.Forms.TextBox();
            this.Location_txt = new System.Windows.Forms.TextBox();
            this.go_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_txt
            // 
            this.Text_txt.Location = new System.Drawing.Point(12, 21);
            this.Text_txt.Name = "Text_txt";
            this.Text_txt.Size = new System.Drawing.Size(144, 20);
            this.Text_txt.TabIndex = 0;
            this.Text_txt.Text = "Tekst";
            // 
            // Filename_txt
            // 
            this.Filename_txt.Location = new System.Drawing.Point(12, 47);
            this.Filename_txt.Name = "Filename_txt";
            this.Filename_txt.Size = new System.Drawing.Size(144, 20);
            this.Filename_txt.TabIndex = 1;
            this.Filename_txt.Text = "Filnavn";
            // 
            // Location_txt
            // 
            this.Location_txt.Location = new System.Drawing.Point(12, 73);
            this.Location_txt.Name = "Location_txt";
            this.Location_txt.Size = new System.Drawing.Size(144, 20);
            this.Location_txt.TabIndex = 2;
            this.Location_txt.Text = "Lokation";
            // 
            // go_btn
            // 
            this.go_btn.Location = new System.Drawing.Point(12, 99);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(75, 23);
            this.go_btn.TabIndex = 3;
            this.go_btn.Text = "Put";
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.GoGoGo);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 138);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.Location_txt);
            this.Controls.Add(this.Filename_txt);
            this.Controls.Add(this.Text_txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_txt;
        private System.Windows.Forms.TextBox Filename_txt;
        private System.Windows.Forms.TextBox Location_txt;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.Button button1;
    }
}

