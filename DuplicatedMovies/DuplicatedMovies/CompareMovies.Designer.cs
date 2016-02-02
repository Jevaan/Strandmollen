namespace DuplicatedMovies
{
    partial class CompareMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompareMovies));
            this.grp_A = new System.Windows.Forms.GroupBox();
            this.grp_B = new System.Windows.Forms.GroupBox();
            this.lbl_A_Name = new System.Windows.Forms.Label();
            this.lbl_B_Name = new System.Windows.Forms.Label();
            this.btn_A_Del = new System.Windows.Forms.Button();
            this.btn_B_del = new System.Windows.Forms.Button();
            this.btn_Keep = new System.Windows.Forms.Button();
            this.grp_A.SuspendLayout();
            this.grp_B.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_A
            // 
            this.grp_A.Controls.Add(this.lbl_A_Name);
            this.grp_A.Location = new System.Drawing.Point(34, 23);
            this.grp_A.Name = "grp_A";
            this.grp_A.Size = new System.Drawing.Size(400, 200);
            this.grp_A.TabIndex = 0;
            this.grp_A.TabStop = false;
            this.grp_A.Text = "Movie A";
            // 
            // grp_B
            // 
            this.grp_B.Controls.Add(this.lbl_B_Name);
            this.grp_B.Location = new System.Drawing.Point(440, 23);
            this.grp_B.Name = "grp_B";
            this.grp_B.Size = new System.Drawing.Size(400, 200);
            this.grp_B.TabIndex = 1;
            this.grp_B.TabStop = false;
            this.grp_B.Text = "Movie B";
            // 
            // lbl_A_Name
            // 
            this.lbl_A_Name.AutoSize = true;
            this.lbl_A_Name.Location = new System.Drawing.Point(7, 20);
            this.lbl_A_Name.Name = "lbl_A_Name";
            this.lbl_A_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_A_Name.TabIndex = 0;
            this.lbl_A_Name.Text = "label1";
            // 
            // lbl_B_Name
            // 
            this.lbl_B_Name.AutoSize = true;
            this.lbl_B_Name.Location = new System.Drawing.Point(7, 20);
            this.lbl_B_Name.Name = "lbl_B_Name";
            this.lbl_B_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_B_Name.TabIndex = 0;
            this.lbl_B_Name.Text = "label2";
            // 
            // btn_A_Del
            // 
            this.btn_A_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_A_Del.Location = new System.Drawing.Point(34, 230);
            this.btn_A_Del.Name = "btn_A_Del";
            this.btn_A_Del.Size = new System.Drawing.Size(125, 30);
            this.btn_A_Del.TabIndex = 2;
            this.btn_A_Del.Text = "Delete A";
            this.btn_A_Del.UseVisualStyleBackColor = true;
            this.btn_A_Del.Click += new System.EventHandler(this.btn_A_Del_Click);
            // 
            // btn_B_del
            // 
            this.btn_B_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_B_del.Location = new System.Drawing.Point(715, 229);
            this.btn_B_del.Name = "btn_B_del";
            this.btn_B_del.Size = new System.Drawing.Size(125, 30);
            this.btn_B_del.TabIndex = 3;
            this.btn_B_del.Text = "Delete B";
            this.btn_B_del.UseVisualStyleBackColor = true;
            this.btn_B_del.Click += new System.EventHandler(this.btn_B_del_Click);
            // 
            // btn_Keep
            // 
            this.btn_Keep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Keep.Location = new System.Drawing.Point(374, 229);
            this.btn_Keep.Name = "btn_Keep";
            this.btn_Keep.Size = new System.Drawing.Size(125, 30);
            this.btn_Keep.TabIndex = 4;
            this.btn_Keep.Text = "Keep Both";
            this.btn_Keep.UseVisualStyleBackColor = true;
            this.btn_Keep.Click += new System.EventHandler(this.btn_Keep_Click);
            // 
            // CompareMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 300);
            this.Controls.Add(this.btn_Keep);
            this.Controls.Add(this.btn_B_del);
            this.Controls.Add(this.btn_A_Del);
            this.Controls.Add(this.grp_B);
            this.Controls.Add(this.grp_A);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompareMovies";
            this.Text = "Compare Movies";
            this.Load += new System.EventHandler(this.FormLoad);
            this.grp_A.ResumeLayout(false);
            this.grp_A.PerformLayout();
            this.grp_B.ResumeLayout(false);
            this.grp_B.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_A;
        private System.Windows.Forms.Label lbl_A_Name;
        private System.Windows.Forms.GroupBox grp_B;
        private System.Windows.Forms.Label lbl_B_Name;
        private System.Windows.Forms.Button btn_A_Del;
        private System.Windows.Forms.Button btn_B_del;
        private System.Windows.Forms.Button btn_Keep;
    }
}