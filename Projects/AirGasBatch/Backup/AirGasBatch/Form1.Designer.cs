namespace AirGasBatch
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
            this.lbl3 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDato = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(30, 55);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Træk:";
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(85, 52);
            this.tb3.MaxLength = 2;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(66, 20);
            this.tb3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dato:";
            // 
            // cbDato
            // 
            this.cbDato.CustomFormat = "dd.MM.yy";
            this.cbDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cbDato.Location = new System.Drawing.Point(85, 12);
            this.cbDato.Name = "cbDato";
            this.cbDato.Size = new System.Drawing.Size(127, 22);
            this.cbDato.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(186, 86);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 122);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbDato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.lbl3);
            this.Name = "Form1";
            this.Text = "AirGas Batchmærke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker cbDato;
        private System.Windows.Forms.Button btnPrint;
    }
}