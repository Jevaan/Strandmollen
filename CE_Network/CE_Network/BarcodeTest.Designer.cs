namespace CE_Network
{
    partial class BarcodeTest
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
            this.BarcodeLabel = new System.Windows.Forms.Label();
            this.BarcodeScanLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.Location = new System.Drawing.Point(13, 20);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(73, 20);
            this.BarcodeLabel.Text = "Stregkode:";
            // 
            // BarcodeScanLabel
            // 
            this.BarcodeScanLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BarcodeScanLabel.Location = new System.Drawing.Point(93, 19);
            this.BarcodeScanLabel.Name = "BarcodeScanLabel";
            this.BarcodeScanLabel.Size = new System.Drawing.Size(143, 20);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.CloseButton.Location = new System.Drawing.Point(164, 67);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(72, 20);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Luk";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(13, 66);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(72, 20);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "Udskriv";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BarcodeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 311);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BarcodeScanLabel);
            this.Controls.Add(this.BarcodeLabel);
            this.Name = "BarcodeTest";
            this.Text = "Stregkode Tester";
            this.Load += new System.EventHandler(this.EnableReader);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.CloseReader);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.Label BarcodeScanLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button PrintButton;
    }
}