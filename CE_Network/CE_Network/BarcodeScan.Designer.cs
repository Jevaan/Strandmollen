namespace CE_Network
{
    partial class BarcodeScan
    {
        public static BarcodeScan Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new CE_Network.BarcodeScan();
                
            }
            
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }

        private static BarcodeScan defaultInstance;
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
            this.StregkodeTextBox = new System.Windows.Forms.TextBox();
            this.TestLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.Variantlabel = new System.Windows.Forms.Label();
            this.VariantComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BarcodeLabel
            // 
            this.BarcodeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BarcodeLabel.Location = new System.Drawing.Point(12, 12);
            this.BarcodeLabel.Name = "BarcodeLabel";
            this.BarcodeLabel.Size = new System.Drawing.Size(100, 20);
            this.BarcodeLabel.Text = "Stregkode:";
            // 
            // StregkodeTextBox
            // 
            this.StregkodeTextBox.Location = new System.Drawing.Point(118, 9);
            this.StregkodeTextBox.MaxLength = 13;
            this.StregkodeTextBox.Name = "StregkodeTextBox";
            this.StregkodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.StregkodeTextBox.TabIndex = 1;
            //this.StregkodeTextBox.GotFocus += new System.EventHandler(this.EnableReader);
            //this.StregkodeTextBox.LostFocus += new System.EventHandler(this.SearchBarcode);
            // 
            // TestLabel
            // 
            this.TestLabel.Location = new System.Drawing.Point(22, 106);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(187, 20);
            this.TestLabel.Text = "tt";
            // 
            // ItemLabel
            // 
            this.ItemLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ItemLabel.Location = new System.Drawing.Point(12, 41);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(100, 20);
            this.ItemLabel.Text = "Varenummer:";
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Location = new System.Drawing.Point(118, 38);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(100, 23);
            this.ItemTextBox.TabIndex = 4;
            //this.ItemTextBox.LostFocus += new System.EventHandler(this.CloseReader);
            // 
            // Variantlabel
            // 
            this.Variantlabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Variantlabel.Location = new System.Drawing.Point(12, 70);
            this.Variantlabel.Name = "Variantlabel";
            this.Variantlabel.Size = new System.Drawing.Size(100, 20);
            this.Variantlabel.Text = "Variant:";
            // 
            // VariantComboBox
            // 
            this.VariantComboBox.Items.Add("");
            this.VariantComboBox.Items.Add("DK-SV");
            this.VariantComboBox.Items.Add("IS");
            this.VariantComboBox.Location = new System.Drawing.Point(118, 67);
            this.VariantComboBox.Name = "VariantComboBox";
            this.VariantComboBox.Size = new System.Drawing.Size(100, 23);
            this.VariantComboBox.TabIndex = 6;
            // 
            // BarcodeScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(258, 190);
            this.Controls.Add(this.VariantComboBox);
            this.Controls.Add(this.Variantlabel);
            this.Controls.Add(this.ItemTextBox);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.StregkodeTextBox);
            this.Controls.Add(this.BarcodeLabel);
            this.Name = "BarcodeScan";
            this.Text = "BarcodeScan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BarcodeLabel;
        private System.Windows.Forms.TextBox StregkodeTextBox;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.TextBox ItemTextBox;
        private System.Windows.Forms.Label Variantlabel;
        private System.Windows.Forms.ComboBox VariantComboBox;
    }
}