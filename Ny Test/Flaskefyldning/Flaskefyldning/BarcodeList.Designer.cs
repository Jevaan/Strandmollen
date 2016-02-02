namespace Flaskefyldning
{
    partial class BarcodeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.Barcodes_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Barcodes_tb
            // 
            this.Barcodes_tb.Location = new System.Drawing.Point(20, 19);
            this.Barcodes_tb.Multiline = true;
            this.Barcodes_tb.Name = "Barcodes_tb";
            this.Barcodes_tb.ReadOnly = true;
            this.Barcodes_tb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Barcodes_tb.Size = new System.Drawing.Size(194, 234);
            this.Barcodes_tb.TabIndex = 0;
            // 
            // BarcodeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.Barcodes_tb);
            this.Menu = this.mainMenu1;
            this.Name = "BarcodeList";
            this.Text = "BarcodeList";
            this.Activated += new System.EventHandler(this.GetBarcodes);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Barcodes_tb;
    }
}