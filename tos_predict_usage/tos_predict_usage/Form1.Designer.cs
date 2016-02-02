namespace tos_predict_usage
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
            this.Tanks_listbox = new System.Windows.Forms.ListBox();
            this.Days_label = new System.Windows.Forms.Label();
            this.TotalUsage_label = new System.Windows.Forms.Label();
            this.AvgUse_label = new System.Windows.Forms.Label();
            this.Content_label = new System.Windows.Forms.Label();
            this.Prediction_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tanks_listbox
            // 
            this.Tanks_listbox.FormattingEnabled = true;
            this.Tanks_listbox.Location = new System.Drawing.Point(31, 28);
            this.Tanks_listbox.Name = "Tanks_listbox";
            this.Tanks_listbox.Size = new System.Drawing.Size(204, 95);
            this.Tanks_listbox.TabIndex = 0;
            this.Tanks_listbox.SelectedIndexChanged += new System.EventHandler(this.Tank_Picked);
            // 
            // Days_label
            // 
            this.Days_label.AutoSize = true;
            this.Days_label.Location = new System.Drawing.Point(28, 140);
            this.Days_label.Name = "Days_label";
            this.Days_label.Size = new System.Drawing.Size(36, 13);
            this.Days_label.TabIndex = 2;
            this.Days_label.Text = "Dage:";
            // 
            // TotalUsage_label
            // 
            this.TotalUsage_label.AutoSize = true;
            this.TotalUsage_label.Location = new System.Drawing.Point(184, 140);
            this.TotalUsage_label.Name = "TotalUsage_label";
            this.TotalUsage_label.Size = new System.Drawing.Size(73, 13);
            this.TotalUsage_label.TabIndex = 3;
            this.TotalUsage_label.Text = "Total Forbrug:";
            // 
            // AvgUse_label
            // 
            this.AvgUse_label.AutoSize = true;
            this.AvgUse_label.Location = new System.Drawing.Point(335, 140);
            this.AvgUse_label.Name = "AvgUse_label";
            this.AvgUse_label.Size = new System.Drawing.Size(79, 13);
            this.AvgUse_label.TabIndex = 4;
            this.AvgUse_label.Text = "Dagligt forbrug:";
            // 
            // Content_label
            // 
            this.Content_label.AutoSize = true;
            this.Content_label.Location = new System.Drawing.Point(31, 176);
            this.Content_label.Name = "Content_label";
            this.Content_label.Size = new System.Drawing.Size(48, 13);
            this.Content_label.TabIndex = 5;
            this.Content_label.Text = "Indhold: ";
            // 
            // Prediction_label
            // 
            this.Prediction_label.AutoSize = true;
            this.Prediction_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prediction_label.Location = new System.Drawing.Point(279, 61);
            this.Prediction_label.Name = "Prediction_label";
            this.Prediction_label.Size = new System.Drawing.Size(98, 20);
            this.Prediction_label.TabIndex = 6;
            this.Prediction_label.Text = "Indhold til: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 208);
            this.Controls.Add(this.Prediction_label);
            this.Controls.Add(this.Content_label);
            this.Controls.Add(this.AvgUse_label);
            this.Controls.Add(this.TotalUsage_label);
            this.Controls.Add(this.Days_label);
            this.Controls.Add(this.Tanks_listbox);
            this.Name = "Form1";
            this.Text = "Gennemsnitligt forbrug";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Tanks_listbox;
        private System.Windows.Forms.Label Days_label;
        private System.Windows.Forms.Label TotalUsage_label;
        private System.Windows.Forms.Label AvgUse_label;
        private System.Windows.Forms.Label Content_label;
        private System.Windows.Forms.Label Prediction_label;
    }
}

