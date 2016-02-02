namespace FlaskeRegistreringCE
{
    partial class Battery
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
            this.BatteryBox = new System.Windows.Forms.ListBox();
            this.BatteryCount = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BatteryBox
            // 
            this.BatteryBox.Location = new System.Drawing.Point(18, 13);
            this.BatteryBox.Name = "BatteryBox";
            this.BatteryBox.Size = new System.Drawing.Size(194, 178);
            this.BatteryBox.TabIndex = 0;
            // 
            // BatteryCount
            // 
            this.BatteryCount.Location = new System.Drawing.Point(18, 208);
            this.BatteryCount.Name = "BatteryCount";
            this.BatteryCount.ReadOnly = true;
            this.BatteryCount.Size = new System.Drawing.Size(100, 23);
            this.BatteryCount.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(124, 207);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 24);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Fortsæt";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Battery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(241, 251);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.BatteryCount);
            this.Controls.Add(this.BatteryBox);
            this.Name = "Battery";
            this.Text = "Batteri Flasker";
            this.Load += new System.EventHandler(this.Battery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BatteryBox;
        private System.Windows.Forms.TextBox BatteryCount;
        private System.Windows.Forms.Button btnOK;
    }
}