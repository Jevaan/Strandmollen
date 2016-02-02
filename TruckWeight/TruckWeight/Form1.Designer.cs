namespace TruckWeight
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
            this.ID_lbl = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Get_btn = new System.Windows.Forms.Button();
            this.Start_lbl = new System.Windows.Forms.Label();
            this.Stop_lbl = new System.Windows.Forms.Label();
            this.Start_txt = new System.Windows.Forms.TextBox();
            this.Stop_txt = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ID_lbl
            // 
            this.ID_lbl.AutoSize = true;
            this.ID_lbl.Location = new System.Drawing.Point(31, 36);
            this.ID_lbl.Name = "ID_lbl";
            this.ID_lbl.Size = new System.Drawing.Size(21, 13);
            this.ID_lbl.TabIndex = 0;
            this.ID_lbl.Text = "ID:";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(58, 33);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(100, 20);
            this.ID_txt.TabIndex = 1;
            // 
            // Get_btn
            // 
            this.Get_btn.Location = new System.Drawing.Point(164, 31);
            this.Get_btn.Name = "Get_btn";
            this.Get_btn.Size = new System.Drawing.Size(75, 23);
            this.Get_btn.TabIndex = 2;
            this.Get_btn.Text = "Hent";
            this.Get_btn.UseVisualStyleBackColor = true;
            this.Get_btn.Click += new System.EventHandler(this.Get_btn_Click);
            // 
            // Start_lbl
            // 
            this.Start_lbl.AutoSize = true;
            this.Start_lbl.Location = new System.Drawing.Point(20, 86);
            this.Start_lbl.Name = "Start_lbl";
            this.Start_lbl.Size = new System.Drawing.Size(32, 13);
            this.Start_lbl.TabIndex = 3;
            this.Start_lbl.Text = "Start:";
            // 
            // Stop_lbl
            // 
            this.Stop_lbl.AutoSize = true;
            this.Stop_lbl.Location = new System.Drawing.Point(20, 112);
            this.Stop_lbl.Name = "Stop_lbl";
            this.Stop_lbl.Size = new System.Drawing.Size(32, 13);
            this.Stop_lbl.TabIndex = 4;
            this.Stop_lbl.Text = "Stop:";
            // 
            // Start_txt
            // 
            this.Start_txt.Location = new System.Drawing.Point(58, 79);
            this.Start_txt.Name = "Start_txt";
            this.Start_txt.Size = new System.Drawing.Size(100, 20);
            this.Start_txt.TabIndex = 5;
            // 
            // Stop_txt
            // 
            this.Stop_txt.Location = new System.Drawing.Point(58, 112);
            this.Stop_txt.Name = "Stop_txt";
            this.Stop_txt.Size = new System.Drawing.Size(100, 20);
            this.Stop_txt.TabIndex = 6;
            // 
            // Save_btn
            // 
            this.Save_btn.Enabled = false;
            this.Save_btn.Location = new System.Drawing.Point(164, 77);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 55);
            this.Save_btn.TabIndex = 7;
            this.Save_btn.Text = "Gem";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Stop_txt);
            this.Controls.Add(this.Start_txt);
            this.Controls.Add(this.Stop_lbl);
            this.Controls.Add(this.Start_lbl);
            this.Controls.Add(this.Get_btn);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.ID_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Truck Weight Adjust";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID_lbl;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.Button Get_btn;
        private System.Windows.Forms.Label Start_lbl;
        private System.Windows.Forms.Label Stop_lbl;
        private System.Windows.Forms.TextBox Start_txt;
        private System.Windows.Forms.TextBox Stop_txt;
        private System.Windows.Forms.Button Save_btn;
    }
}

