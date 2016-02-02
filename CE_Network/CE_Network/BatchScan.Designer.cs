namespace CE_Network
{
    partial class BatchScan
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
            this.VarenummerLabel = new System.Windows.Forms.Label();
            this.VariantLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.variantComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.AfslutButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VarenummerLabel
            // 
            this.VarenummerLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.VarenummerLabel.Location = new System.Drawing.Point(3, 16);
            this.VarenummerLabel.Name = "VarenummerLabel";
            this.VarenummerLabel.Size = new System.Drawing.Size(100, 20);
            this.VarenummerLabel.Text = "Varenummer:";
            // 
            // VariantLabel
            // 
            this.VariantLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.VariantLabel.Location = new System.Drawing.Point(3, 46);
            this.VariantLabel.Name = "VariantLabel";
            this.VariantLabel.Size = new System.Drawing.Size(100, 20);
            this.VariantLabel.Text = "Variant:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.GotFocus += new System.EventHandler(this.StartVnrScan);
            this.textBox1.LostFocus += new System.EventHandler(this.StopVnrScan);
            // 
            // variantComboBox
            // 
            this.variantComboBox.Items.Add("DK-SV");
            this.variantComboBox.Items.Add("IS");
            this.variantComboBox.Location = new System.Drawing.Point(124, 42);
            this.variantComboBox.Name = "variantComboBox";
            this.variantComboBox.Size = new System.Drawing.Size(134, 23);
            this.variantComboBox.TabIndex = 3;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.StartButton.Location = new System.Drawing.Point(12, 109);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(72, 20);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.Click += new System.EventHandler(this.StartBatchScan);
            // 
            // AfslutButton
            // 
            this.AfslutButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.AfslutButton.Location = new System.Drawing.Point(187, 109);
            this.AfslutButton.Name = "AfslutButton";
            this.AfslutButton.Size = new System.Drawing.Size(72, 20);
            this.AfslutButton.TabIndex = 5;
            this.AfslutButton.Text = "Afslut";
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.StopButton.Location = new System.Drawing.Point(100, 109);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(72, 20);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.Click += new System.EventHandler(this.StopBatch);
            // 
            // BatchScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(272, 144);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.AfslutButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.variantComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VariantLabel);
            this.Controls.Add(this.VarenummerLabel);
            this.Menu = this.mainMenu1;
            this.Name = "BatchScan";
            this.Text = "BatchScan";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label VarenummerLabel;
        private System.Windows.Forms.Label VariantLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox variantComboBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AfslutButton;
        private System.Windows.Forms.Button StopButton;
    }
}