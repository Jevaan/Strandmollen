namespace CE_Network
{
    partial class Setup
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
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ItemCheckbox = new System.Windows.Forms.CheckBox();
            this.BarcodePrinterComboBox = new System.Windows.Forms.ComboBox();
            this.BarcodePrinterLabel = new System.Windows.Forms.Label();
            this.BatteryPrinterLabel = new System.Windows.Forms.Label();
            this.BatteryPrinterComboBox = new System.Windows.Forms.ComboBox();
            this.SetupOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemLabel
            // 
            this.ItemLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ItemLabel.Location = new System.Drawing.Point(17, 56);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(171, 20);
            this.ItemLabel.Text = "Kræves varenummer?";
            // 
            // ItemCheckbox
            // 
            this.ItemCheckbox.Location = new System.Drawing.Point(181, 56);
            this.ItemCheckbox.Name = "ItemCheckbox";
            this.ItemCheckbox.Size = new System.Drawing.Size(46, 20);
            this.ItemCheckbox.TabIndex = 1;
            // 
            // BarcodePrinterComboBox
            // 
            this.BarcodePrinterComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BarcodePrinterComboBox.Location = new System.Drawing.Point(152, 84);
            this.BarcodePrinterComboBox.Name = "BarcodePrinterComboBox";
            this.BarcodePrinterComboBox.Size = new System.Drawing.Size(75, 24);
            this.BarcodePrinterComboBox.TabIndex = 2;
            // 
            // BarcodePrinterLabel
            // 
            this.BarcodePrinterLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BarcodePrinterLabel.Location = new System.Drawing.Point(17, 87);
            this.BarcodePrinterLabel.Name = "BarcodePrinterLabel";
            this.BarcodePrinterLabel.Size = new System.Drawing.Size(129, 20);
            this.BarcodePrinterLabel.Text = "Stregkodeprinter:";
            // 
            // BatteryPrinterLabel
            // 
            this.BatteryPrinterLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BatteryPrinterLabel.Location = new System.Drawing.Point(17, 116);
            this.BatteryPrinterLabel.Name = "BatteryPrinterLabel";
            this.BatteryPrinterLabel.Size = new System.Drawing.Size(121, 20);
            this.BatteryPrinterLabel.Text = "Batteri printer:";
            // 
            // BatteryPrinterComboBox
            // 
            this.BatteryPrinterComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BatteryPrinterComboBox.Items.Add("-");
            this.BatteryPrinterComboBox.Location = new System.Drawing.Point(152, 113);
            this.BatteryPrinterComboBox.Name = "BatteryPrinterComboBox";
            this.BatteryPrinterComboBox.Size = new System.Drawing.Size(75, 24);
            this.BatteryPrinterComboBox.TabIndex = 5;
            // 
            // SetupOKButton
            // 
            this.SetupOKButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SetupOKButton.Location = new System.Drawing.Point(74, 154);
            this.SetupOKButton.Name = "SetupOKButton";
            this.SetupOKButton.Size = new System.Drawing.Size(72, 20);
            this.SetupOKButton.TabIndex = 6;
            this.SetupOKButton.Text = "OK";
            this.SetupOKButton.Click += new System.EventHandler(this.SetupOK_Clicked);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.SetupOKButton);
            this.Controls.Add(this.BatteryPrinterComboBox);
            this.Controls.Add(this.BatteryPrinterLabel);
            this.Controls.Add(this.BarcodePrinterLabel);
            this.Controls.Add(this.BarcodePrinterComboBox);
            this.Controls.Add(this.ItemCheckbox);
            this.Controls.Add(this.ItemLabel);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Setup";
            this.Text = "Setup";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLoad);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.SetupClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.CheckBox ItemCheckbox;
        private System.Windows.Forms.ComboBox BarcodePrinterComboBox;
        private System.Windows.Forms.Label BarcodePrinterLabel;
        private System.Windows.Forms.Label BatteryPrinterLabel;
        private System.Windows.Forms.ComboBox BatteryPrinterComboBox;
        private System.Windows.Forms.Button SetupOKButton;
    }
}