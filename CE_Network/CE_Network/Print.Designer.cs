namespace CE_Network
{
    partial class Print
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
            this.BarcodePrinterLabel = new System.Windows.Forms.Label();
            this.BarcodePrinterDisplay = new System.Windows.Forms.Label();
            this.StreamerPrinterLabel = new System.Windows.Forms.Label();
            this.StreamerPrinterDisplay = new System.Windows.Forms.Label();
            this.CopiesLabel = new System.Windows.Forms.Label();
            this.CopiesComboBox = new System.Windows.Forms.ComboBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarcodePrinterLabel
            // 
            this.BarcodePrinterLabel.Location = new System.Drawing.Point(3, 14);
            this.BarcodePrinterLabel.Name = "BarcodePrinterLabel";
            this.BarcodePrinterLabel.Size = new System.Drawing.Size(96, 20);
            this.BarcodePrinterLabel.Text = "Stregkoder på:";
            // 
            // BarcodePrinterDisplay
            // 
            this.BarcodePrinterDisplay.Location = new System.Drawing.Point(105, 14);
            this.BarcodePrinterDisplay.Name = "BarcodePrinterDisplay";
            this.BarcodePrinterDisplay.Size = new System.Drawing.Size(100, 20);
            this.BarcodePrinterDisplay.Text = "label1";
            // 
            // StreamerPrinterLabel
            // 
            this.StreamerPrinterLabel.Location = new System.Drawing.Point(12, 38);
            this.StreamerPrinterLabel.Name = "StreamerPrinterLabel";
            this.StreamerPrinterLabel.Size = new System.Drawing.Size(91, 20);
            this.StreamerPrinterLabel.Text = "Streamer på:";
            // 
            // StreamerPrinterDisplay
            // 
            this.StreamerPrinterDisplay.Location = new System.Drawing.Point(105, 37);
            this.StreamerPrinterDisplay.Name = "StreamerPrinterDisplay";
            this.StreamerPrinterDisplay.Size = new System.Drawing.Size(100, 20);
            this.StreamerPrinterDisplay.Text = "label1";
            // 
            // CopiesLabel
            // 
            this.CopiesLabel.Location = new System.Drawing.Point(48, 67);
            this.CopiesLabel.Name = "CopiesLabel";
            this.CopiesLabel.Size = new System.Drawing.Size(51, 20);
            this.CopiesLabel.Text = "Kopier:";
            // 
            // CopiesComboBox
            // 
            this.CopiesComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.CopiesComboBox.Items.Add("");
            this.CopiesComboBox.Items.Add("1");
            this.CopiesComboBox.Items.Add("2");
            this.CopiesComboBox.Items.Add("3");
            this.CopiesComboBox.Items.Add("4");
            this.CopiesComboBox.Items.Add("5");
            this.CopiesComboBox.Location = new System.Drawing.Point(101, 64);
            this.CopiesComboBox.Name = "CopiesComboBox";
            this.CopiesComboBox.Size = new System.Drawing.Size(50, 24);
            this.CopiesComboBox.TabIndex = 5;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.PrintButton.Location = new System.Drawing.Point(67, 107);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(72, 20);
            this.PrintButton.TabIndex = 6;
            this.PrintButton.Text = "Udskriv";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(226, 146);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CopiesComboBox);
            this.Controls.Add(this.CopiesLabel);
            this.Controls.Add(this.StreamerPrinterDisplay);
            this.Controls.Add(this.StreamerPrinterLabel);
            this.Controls.Add(this.BarcodePrinterDisplay);
            this.Controls.Add(this.BarcodePrinterLabel);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.PrintLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BarcodePrinterLabel;
        private System.Windows.Forms.Label BarcodePrinterDisplay;
        private System.Windows.Forms.Label StreamerPrinterLabel;
        private System.Windows.Forms.Label StreamerPrinterDisplay;
        private System.Windows.Forms.Label CopiesLabel;
        private System.Windows.Forms.ComboBox CopiesComboBox;
        private System.Windows.Forms.Button PrintButton;
    }
}