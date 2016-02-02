namespace Flaskestyring
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
            this.BottleNumberLabel = new System.Windows.Forms.Label();
            this.ItemNumberLabel = new System.Windows.Forms.Label();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.BatchLabel = new System.Windows.Forms.Label();
            this.ProductionDateLabel = new System.Windows.Forms.Label();
            this.ExpireLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.RecievedLabel = new System.Windows.Forms.Label();
            this.BottleNumberTextBox = new System.Windows.Forms.TextBox();
            this.ItemNumberDisplay = new System.Windows.Forms.Label();
            this.ItemTextDisplay = new System.Windows.Forms.Label();
            this.BatchDisplay = new System.Windows.Forms.Label();
            this.ProductionDateDisplay = new System.Windows.Forms.Label();
            this.ExpireDisplay = new System.Windows.Forms.Label();
            this.LocationDisplay = new System.Windows.Forms.Label();
            this.StatusDisplay = new System.Windows.Forms.Label();
            this.RecievedDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BottleNoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BottleNumberLabel
            // 
            this.BottleNumberLabel.Location = new System.Drawing.Point(4, 4);
            this.BottleNumberLabel.Name = "BottleNumberLabel";
            this.BottleNumberLabel.Size = new System.Drawing.Size(88, 20);
            this.BottleNumberLabel.Text = "Flaskenr:";
            // 
            // ItemNumberLabel
            // 
            this.ItemNumberLabel.Location = new System.Drawing.Point(3, 75);
            this.ItemNumberLabel.Name = "ItemNumberLabel";
            this.ItemNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.ItemNumberLabel.Text = "Varenr:";
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.Location = new System.Drawing.Point(4, 95);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(100, 20);
            this.ItemNameLabel.Text = "Varetekst:";
            // 
            // BatchLabel
            // 
            this.BatchLabel.Location = new System.Drawing.Point(4, 143);
            this.BatchLabel.Name = "BatchLabel";
            this.BatchLabel.Size = new System.Drawing.Size(100, 20);
            this.BatchLabel.Text = "Batchnr:";
            // 
            // ProductionDateLabel
            // 
            this.ProductionDateLabel.Location = new System.Drawing.Point(3, 163);
            this.ProductionDateLabel.Name = "ProductionDateLabel";
            this.ProductionDateLabel.Size = new System.Drawing.Size(100, 20);
            this.ProductionDateLabel.Text = "Prod. dato:";
            // 
            // ExpireLabel
            // 
            this.ExpireLabel.Location = new System.Drawing.Point(4, 183);
            this.ExpireLabel.Name = "ExpireLabel";
            this.ExpireLabel.Size = new System.Drawing.Size(100, 20);
            this.ExpireLabel.Text = "Udløbsdato:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Location = new System.Drawing.Point(4, 203);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(100, 20);
            this.LocationLabel.Text = "Lokation:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(4, 247);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(100, 20);
            this.StatusLabel.Text = "Status:";
            // 
            // RecievedLabel
            // 
            this.RecievedLabel.Location = new System.Drawing.Point(4, 267);
            this.RecievedLabel.Name = "RecievedLabel";
            this.RecievedLabel.Size = new System.Drawing.Size(100, 20);
            this.RecievedLabel.Text = "Modtaget:";
            // 
            // BottleNumberTextBox
            // 
            this.BottleNumberTextBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BottleNumberTextBox.Location = new System.Drawing.Point(98, 4);
            this.BottleNumberTextBox.Name = "BottleNumberTextBox";
            this.BottleNumberTextBox.Size = new System.Drawing.Size(139, 21);
            this.BottleNumberTextBox.TabIndex = 9;
            this.BottleNumberTextBox.TextChanged += new System.EventHandler(this.DataScanned);
            // 
            // ItemNumberDisplay
            // 
            this.ItemNumberDisplay.Location = new System.Drawing.Point(98, 74);
            this.ItemNumberDisplay.Name = "ItemNumberDisplay";
            this.ItemNumberDisplay.Size = new System.Drawing.Size(100, 20);
            // 
            // ItemTextDisplay
            // 
            this.ItemTextDisplay.Location = new System.Drawing.Point(98, 95);
            this.ItemTextDisplay.Name = "ItemTextDisplay";
            this.ItemTextDisplay.Size = new System.Drawing.Size(139, 48);
            // 
            // BatchDisplay
            // 
            this.BatchDisplay.Location = new System.Drawing.Point(98, 143);
            this.BatchDisplay.Name = "BatchDisplay";
            this.BatchDisplay.Size = new System.Drawing.Size(100, 20);
            // 
            // ProductionDateDisplay
            // 
            this.ProductionDateDisplay.Location = new System.Drawing.Point(98, 163);
            this.ProductionDateDisplay.Name = "ProductionDateDisplay";
            this.ProductionDateDisplay.Size = new System.Drawing.Size(100, 20);
            // 
            // ExpireDisplay
            // 
            this.ExpireDisplay.Location = new System.Drawing.Point(98, 183);
            this.ExpireDisplay.Name = "ExpireDisplay";
            this.ExpireDisplay.Size = new System.Drawing.Size(100, 20);
            // 
            // LocationDisplay
            // 
            this.LocationDisplay.Location = new System.Drawing.Point(98, 203);
            this.LocationDisplay.Name = "LocationDisplay";
            this.LocationDisplay.Size = new System.Drawing.Size(139, 44);
            // 
            // StatusDisplay
            // 
            this.StatusDisplay.Location = new System.Drawing.Point(98, 247);
            this.StatusDisplay.Name = "StatusDisplay";
            this.StatusDisplay.Size = new System.Drawing.Size(100, 20);
            // 
            // RecievedDisplay
            // 
            this.RecievedDisplay.Location = new System.Drawing.Point(98, 267);
            this.RecievedDisplay.Name = "RecievedDisplay";
            this.RecievedDisplay.Size = new System.Drawing.Size(100, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Flaske:";
            // 
            // BottleNoLbl
            // 
            this.BottleNoLbl.Location = new System.Drawing.Point(98, 45);
            this.BottleNoLbl.Name = "BottleNoLbl";
            this.BottleNoLbl.Size = new System.Drawing.Size(100, 20);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.BottleNoLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecievedDisplay);
            this.Controls.Add(this.StatusDisplay);
            this.Controls.Add(this.LocationDisplay);
            this.Controls.Add(this.ExpireDisplay);
            this.Controls.Add(this.ProductionDateDisplay);
            this.Controls.Add(this.BatchDisplay);
            this.Controls.Add(this.ItemTextDisplay);
            this.Controls.Add(this.ItemNumberDisplay);
            this.Controls.Add(this.BottleNumberTextBox);
            this.Controls.Add(this.RecievedLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ExpireLabel);
            this.Controls.Add(this.ProductionDateLabel);
            this.Controls.Add(this.BatchLabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemNumberLabel);
            this.Controls.Add(this.BottleNumberLabel);
            this.Name = "Form1";
            this.Text = "Flaskestyring";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BottleNumberLabel;
        private System.Windows.Forms.Label ItemNumberLabel;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label BatchLabel;
        private System.Windows.Forms.Label ProductionDateLabel;
        private System.Windows.Forms.Label ExpireLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label RecievedLabel;
        private System.Windows.Forms.TextBox BottleNumberTextBox;
        private System.Windows.Forms.Label ItemNumberDisplay;
        private System.Windows.Forms.Label ItemTextDisplay;
        private System.Windows.Forms.Label BatchDisplay;
        private System.Windows.Forms.Label ProductionDateDisplay;
        private System.Windows.Forms.Label ExpireDisplay;
        private System.Windows.Forms.Label LocationDisplay;
        private System.Windows.Forms.Label StatusDisplay;
        private System.Windows.Forms.Label RecievedDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BottleNoLbl;
    }
}

