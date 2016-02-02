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
            this.Type_lbl = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.Initials_lbl = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.cbDato = new System.Windows.Forms.DateTimePicker();
            this.labels_lbl = new System.Windows.Forms.Label();
            this.cbEtiketter = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Batch_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Type_lbl
            // 
            this.Type_lbl.AutoSize = true;
            this.Type_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_lbl.Location = new System.Drawing.Point(12, 12);
            this.Type_lbl.Name = "Type_lbl";
            this.Type_lbl.Size = new System.Drawing.Size(47, 20);
            this.Type_lbl.TabIndex = 0;
            this.Type_lbl.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Medicinsk",
            "Teknisk"});
            this.cbType.Location = new System.Drawing.Point(83, 9);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(127, 28);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // Initials_lbl
            // 
            this.Initials_lbl.AutoSize = true;
            this.Initials_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Initials_lbl.Location = new System.Drawing.Point(12, 84);
            this.Initials_lbl.Name = "Initials_lbl";
            this.Initials_lbl.Size = new System.Drawing.Size(65, 20);
            this.Initials_lbl.TabIndex = 2;
            this.Initials_lbl.Text = "Fyldt af:";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(83, 81);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(66, 26);
            this.tb1.TabIndex = 3;
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(12, 48);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(48, 20);
            this.Date_lbl.TabIndex = 8;
            this.Date_lbl.Text = "Dato:";
            // 
            // cbDato
            // 
            this.cbDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cbDato.Location = new System.Drawing.Point(83, 45);
            this.cbDato.Name = "cbDato";
            this.cbDato.Size = new System.Drawing.Size(127, 26);
            this.cbDato.TabIndex = 9;
            // 
            // labels_lbl
            // 
            this.labels_lbl.AutoSize = true;
            this.labels_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labels_lbl.Location = new System.Drawing.Point(12, 156);
            this.labels_lbl.Name = "labels_lbl";
            this.labels_lbl.Size = new System.Drawing.Size(73, 20);
            this.labels_lbl.TabIndex = 10;
            this.labels_lbl.Text = "Etiketter:";
            // 
            // cbEtiketter
            // 
            this.cbEtiketter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbEtiketter.Location = new System.Drawing.Point(83, 153);
            this.cbEtiketter.Name = "cbEtiketter";
            this.cbEtiketter.Size = new System.Drawing.Size(66, 28);
            this.cbEtiketter.TabIndex = 11;
            this.cbEtiketter.Text = "1";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(186, 153);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 28);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Batch_lbl
            // 
            this.Batch_lbl.AutoSize = true;
            this.Batch_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batch_lbl.Location = new System.Drawing.Point(12, 121);
            this.Batch_lbl.Name = "Batch_lbl";
            this.Batch_lbl.Size = new System.Drawing.Size(50, 20);
            this.Batch_lbl.TabIndex = 13;
            this.Batch_lbl.Text = "Træk:";
            this.Batch_lbl.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 187);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Batch_lbl);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbEtiketter);
            this.Controls.Add(this.labels_lbl);
            this.Controls.Add(this.cbDato);
            this.Controls.Add(this.Date_lbl);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.Initials_lbl);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.Type_lbl);
            this.Name = "Form1";
            this.Text = "Batchmærke Klampenborg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Type_lbl;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label Initials_lbl;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.DateTimePicker cbDato;
        private System.Windows.Forms.Label labels_lbl;
        private System.Windows.Forms.ComboBox cbEtiketter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label Batch_lbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}

