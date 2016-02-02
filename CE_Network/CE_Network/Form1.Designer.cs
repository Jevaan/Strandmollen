namespace CE_Network
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.newMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.menuWithoutBarcode = new System.Windows.Forms.MenuItem();
            this.menuWithBarcode = new System.Windows.Forms.MenuItem();
            this.menuPrintBarcode = new System.Windows.Forms.MenuItem();
            this.menuPrint = new System.Windows.Forms.MenuItem();
            this.menuItemReprint = new System.Windows.Forms.MenuItem();
            this.MenuSetup = new System.Windows.Forms.MenuItem();
            this.BottleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.BottleTypeLabel = new System.Windows.Forms.Label();
            this.BottleSizeLabel = new System.Windows.Forms.Label();
            this.BottleSizeConboBox = new System.Windows.Forms.ComboBox();
            this.BottleNumberLabel = new System.Windows.Forms.Label();
            this.BottleNumberTextBox = new System.Windows.Forms.TextBox();
            this.ItemNumberLabel = new System.Windows.Forms.Label();
            this.ItemNumberTextBox = new System.Windows.Forms.TextBox();
            this.PressureTestLabel = new System.Windows.Forms.Label();
            this.VariantLabel = new System.Windows.Forms.Label();
            this.VariantComboBox = new System.Windows.Forms.ComboBox();
            this.PressureTestComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TesterButton = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.newMenuItemMenuItem);
            this.mainMenu1.MenuItems.Add(this.menuPrint);
            this.mainMenu1.MenuItems.Add(this.menuItemReprint);
            this.mainMenu1.MenuItems.Add(this.MenuSetup);
            // 
            // newMenuItemMenuItem
            // 
            this.newMenuItemMenuItem.MenuItems.Add(this.menuWithoutBarcode);
            this.newMenuItemMenuItem.MenuItems.Add(this.menuWithBarcode);
            this.newMenuItemMenuItem.MenuItems.Add(this.menuPrintBarcode);
            this.newMenuItemMenuItem.Text = "Type";
            // 
            // menuWithoutBarcode
            // 
            this.menuWithoutBarcode.Text = "Flaske uden stregkode";
            this.menuWithoutBarcode.Click += new System.EventHandler(this.MenuWithoutBarcodeClick);
            // 
            // menuWithBarcode
            // 
            this.menuWithBarcode.Enabled = false;
            this.menuWithBarcode.Text = "Flaske med stregkode";
            this.menuWithBarcode.Click += new System.EventHandler(this.menuWithBarcodeClick);
            // 
            // menuPrintBarcode
            // 
            this.menuPrintBarcode.Enabled = false;
            this.menuPrintBarcode.Text = "Print stregkode";
            // 
            // menuPrint
            // 
            this.menuPrint.Text = "Udskriv";
            this.menuPrint.Click += new System.EventHandler(this.Docked);
            // 
            // menuItemReprint
            // 
            this.menuItemReprint.Text = "Genudskriv";
            this.menuItemReprint.Click += new System.EventHandler(this.menuItemReprint_Click);
            // 
            // MenuSetup
            // 
            this.MenuSetup.Text = "Setup";
            this.MenuSetup.Click += new System.EventHandler(this.SetupClick);
            // 
            // BottleTypeComboBox
            // 
            this.BottleTypeComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BottleTypeComboBox.Items.Add("Egen Flaske");
            this.BottleTypeComboBox.Items.Add("Batteriflaske");
            this.BottleTypeComboBox.Items.Add("Kryoflaske");
            this.BottleTypeComboBox.Items.Add("Type 5");
            this.BottleTypeComboBox.Items.Add("Type 6");
            this.BottleTypeComboBox.Location = new System.Drawing.Point(108, 33);
            this.BottleTypeComboBox.Name = "BottleTypeComboBox";
            this.BottleTypeComboBox.Size = new System.Drawing.Size(129, 24);
            this.BottleTypeComboBox.TabIndex = 0;
            // 
            // BottleTypeLabel
            // 
            this.BottleTypeLabel.Location = new System.Drawing.Point(3, 36);
            this.BottleTypeLabel.Name = "BottleTypeLabel";
            this.BottleTypeLabel.Size = new System.Drawing.Size(55, 20);
            this.BottleTypeLabel.Text = "Type:";
            // 
            // BottleSizeLabel
            // 
            this.BottleSizeLabel.Location = new System.Drawing.Point(3, 65);
            this.BottleSizeLabel.Name = "BottleSizeLabel";
            this.BottleSizeLabel.Size = new System.Drawing.Size(100, 20);
            this.BottleSizeLabel.Text = "Størrelse:";
            // 
            // BottleSizeConboBox
            // 
            this.BottleSizeConboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BottleSizeConboBox.Items.Add("0,5");
            this.BottleSizeConboBox.Items.Add("1,0");
            this.BottleSizeConboBox.Items.Add("1,5");
            this.BottleSizeConboBox.Items.Add("2,0");
            this.BottleSizeConboBox.Items.Add("2,5");
            this.BottleSizeConboBox.Items.Add("3,0");
            this.BottleSizeConboBox.Items.Add("4,0");
            this.BottleSizeConboBox.Items.Add("5,0");
            this.BottleSizeConboBox.Items.Add("7,0");
            this.BottleSizeConboBox.Items.Add("8,0");
            this.BottleSizeConboBox.Items.Add("10");
            this.BottleSizeConboBox.Items.Add("12");
            this.BottleSizeConboBox.Items.Add("13");
            this.BottleSizeConboBox.Items.Add("14");
            this.BottleSizeConboBox.Items.Add("20");
            this.BottleSizeConboBox.Items.Add("26");
            this.BottleSizeConboBox.Items.Add("40");
            this.BottleSizeConboBox.Items.Add("50");
            this.BottleSizeConboBox.Items.Add("79");
            this.BottleSizeConboBox.Items.Add("80");
            this.BottleSizeConboBox.Location = new System.Drawing.Point(108, 62);
            this.BottleSizeConboBox.Name = "BottleSizeConboBox";
            this.BottleSizeConboBox.Size = new System.Drawing.Size(129, 24);
            this.BottleSizeConboBox.TabIndex = 3;
            // 
            // BottleNumberLabel
            // 
            this.BottleNumberLabel.Location = new System.Drawing.Point(3, 94);
            this.BottleNumberLabel.Name = "BottleNumberLabel";
            this.BottleNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.BottleNumberLabel.Text = "Flaskenummer:";
            // 
            // BottleNumberTextBox
            // 
            this.BottleNumberTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.BottleNumberTextBox.Location = new System.Drawing.Point(109, 91);
            this.BottleNumberTextBox.MaxLength = 7;
            this.BottleNumberTextBox.Name = "BottleNumberTextBox";
            this.BottleNumberTextBox.Size = new System.Drawing.Size(128, 23);
            this.BottleNumberTextBox.TabIndex = 5;
            // 
            // ItemNumberLabel
            // 
            this.ItemNumberLabel.Location = new System.Drawing.Point(3, 123);
            this.ItemNumberLabel.Name = "ItemNumberLabel";
            this.ItemNumberLabel.Size = new System.Drawing.Size(100, 20);
            this.ItemNumberLabel.Text = "Varenummer:";
            // 
            // ItemNumberTextBox
            // 
            this.ItemNumberTextBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.ItemNumberTextBox.Location = new System.Drawing.Point(109, 120);
            this.ItemNumberTextBox.MaxLength = 30;
            this.ItemNumberTextBox.Name = "ItemNumberTextBox";
            this.ItemNumberTextBox.Size = new System.Drawing.Size(128, 23);
            this.ItemNumberTextBox.TabIndex = 7;
            // 
            // PressureTestLabel
            // 
            this.PressureTestLabel.Location = new System.Drawing.Point(3, 152);
            this.PressureTestLabel.Name = "PressureTestLabel";
            this.PressureTestLabel.Size = new System.Drawing.Size(100, 20);
            this.PressureTestLabel.Text = "Trykprøvning:";
            // 
            // VariantLabel
            // 
            this.VariantLabel.Location = new System.Drawing.Point(3, 181);
            this.VariantLabel.Name = "VariantLabel";
            this.VariantLabel.Size = new System.Drawing.Size(69, 20);
            this.VariantLabel.Text = "Variant:";
            // 
            // VariantComboBox
            // 
            this.VariantComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.VariantComboBox.Items.Add("DK-SV");
            this.VariantComboBox.Items.Add("IS");
            this.VariantComboBox.Location = new System.Drawing.Point(108, 178);
            this.VariantComboBox.Name = "VariantComboBox";
            this.VariantComboBox.Size = new System.Drawing.Size(129, 24);
            this.VariantComboBox.TabIndex = 11;
            // 
            // PressureTestComboBox
            // 
            this.PressureTestComboBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.PressureTestComboBox.Location = new System.Drawing.Point(108, 149);
            this.PressureTestComboBox.Name = "PressureTestComboBox";
            this.PressureTestComboBox.Size = new System.Drawing.Size(129, 24);
            this.PressureTestComboBox.TabIndex = 18;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SaveButton.Location = new System.Drawing.Point(156, 216);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 20);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Gem";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TesterButton
            // 
            this.TesterButton.Location = new System.Drawing.Point(21, 216);
            this.TesterButton.Name = "TesterButton";
            this.TesterButton.Size = new System.Drawing.Size(72, 20);
            this.TesterButton.TabIndex = 26;
            this.TesterButton.Text = "Scanner";
            this.TesterButton.Click += new System.EventHandler(this.TesterButton_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(102, 216);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(45, 20);
            this.Close_btn.TabIndex = 33;
            this.Close_btn.Text = "Luk";
            this.Close_btn.Click += new System.EventHandler(this.CloseFlReg);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.TesterButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PressureTestComboBox);
            this.Controls.Add(this.VariantComboBox);
            this.Controls.Add(this.VariantLabel);
            this.Controls.Add(this.PressureTestLabel);
            this.Controls.Add(this.ItemNumberTextBox);
            this.Controls.Add(this.ItemNumberLabel);
            this.Controls.Add(this.BottleNumberTextBox);
            this.Controls.Add(this.BottleNumberLabel);
            this.Controls.Add(this.BottleSizeConboBox);
            this.Controls.Add(this.BottleSizeLabel);
            this.Controls.Add(this.BottleTypeLabel);
            this.Controls.Add(this.BottleTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Flaskeregistrering";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ProgramClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem newMenuItemMenuItem;
        //private CE_Network.BarcodeDataSetTableAdapters.BarcodeListTableAdapter barcodeListTableAdapter1;
        private System.Windows.Forms.MenuItem menuWithoutBarcode;
        private System.Windows.Forms.MenuItem menuWithBarcode;
        private System.Windows.Forms.MenuItem menuPrintBarcode;
        private System.Windows.Forms.MenuItem menuPrint;
        private System.Windows.Forms.MenuItem MenuSetup;
        public static System.Windows.Forms.Label BarcodePrinterLabel;
        public static System.Windows.Forms.Label BatteryPrinterLabel;
        private System.Windows.Forms.ComboBox BottleTypeComboBox;
        private System.Windows.Forms.Label BottleTypeLabel;
        private System.Windows.Forms.Label BottleSizeLabel;
        private System.Windows.Forms.ComboBox BottleSizeConboBox;
        private System.Windows.Forms.Label BottleNumberLabel;
        private System.Windows.Forms.TextBox BottleNumberTextBox;
        private System.Windows.Forms.Label ItemNumberLabel;
        private System.Windows.Forms.TextBox ItemNumberTextBox;
        private System.Windows.Forms.Label PressureTestLabel;
        private System.Windows.Forms.Label VariantLabel;
        private System.Windows.Forms.ComboBox VariantComboBox;
        private System.Windows.Forms.ComboBox PressureTestComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.MenuItem menuItemReprint;
        private System.Windows.Forms.Button TesterButton;
        private System.Windows.Forms.Button Close_btn;
    }
}

