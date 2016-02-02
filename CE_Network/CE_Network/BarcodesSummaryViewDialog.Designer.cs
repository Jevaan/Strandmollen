namespace CE_Network
{
    partial class BarcodesSummaryViewDialog
    {
        public void AttachVisibilityBindings(ControlCollection controls)
        {
            for (int i = 0; (i < controls.Count); i = (i + 1))
            {
                if ((controls[i].DataBindings["Visible"] != null))
                {
                    // Attach event handlers to auto-hide controls.
                    controls[i].DataBindings["Visible"].Format += new System.Windows.Forms.ConvertEventHandler(this.Visibility_Format);
                    controls[i].DataBindings["Visible"].DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
                }
            }

        }
    
        public void Visibility_Format(object sender, System.Windows.Forms.ConvertEventArgs e)
        {
            if ((e.Value == System.DBNull.Value))
            {
                e.Value = false;
            }
            else
            {
                e.Value = true;
            }

        }
    
        public static BarcodesSummaryViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new CE_Network.BarcodesSummaryViewDialog();
                defaultInstance.barcodesBindingSource.DataSource = bindingSource;
            }
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.barcodesBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static BarcodesSummaryViewDialog defaultInstance;
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label variantLabel;
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label testLabel;
            System.Windows.Forms.Label batTypeLabel;
            System.Windows.Forms.Label numberLabel;
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.editMenuItemMenuItem = new System.Windows.Forms.MenuItem();
            this.barcodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeLabel1 = new System.Windows.Forms.Label();
            this.sizeLabel1 = new System.Windows.Forms.Label();
            this.variantLabel1 = new System.Windows.Forms.Label();
            this.itemLabel1 = new System.Windows.Forms.Label();
            this.testLabel1 = new System.Windows.Forms.Label();
            this.batTypeLabel1 = new System.Windows.Forms.Label();
            this.numberLabel1 = new System.Windows.Forms.Label();
            this.topBorderPanel = new System.Windows.Forms.Panel();
            this.leftBorderPanel = new System.Windows.Forms.Panel();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            barcodeLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            variantLabel = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            testLabel = new System.Windows.Forms.Label();
            batTypeLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.editMenuItemMenuItem);
            // 
            // editMenuItemMenuItem
            // 
            this.editMenuItemMenuItem.Text = "Edit";
            this.editMenuItemMenuItem.Click += new System.EventHandler(this.editMenuItemMenuItem_Click);
            // 
            // barcodesBindingSource
            // 
            this.barcodesBindingSource.DataMember = "Barcodes";
            this.barcodesBindingSource.DataSource = typeof(CE_Network.BarcodeDataSet);
            // 
            // barcodeLabel
            // 
            barcodeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Barcode", true));
            barcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            barcodeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            barcodeLabel.Location = new System.Drawing.Point(4, 4);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(70, 21);
            barcodeLabel.Text = "Barcode:";
            // 
            // barcodeLabel1
            // 
            this.barcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Barcode", true));
            this.barcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Barcode", true));
            this.barcodeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeLabel1.Location = new System.Drawing.Point(4, 21);
            this.barcodeLabel1.Name = "barcodeLabel1";
            this.barcodeLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // sizeLabel
            // 
            sizeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Size", true));
            sizeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            sizeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            sizeLabel.Location = new System.Drawing.Point(4, 52);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(40, 21);
            sizeLabel.Text = "Size:";
            // 
            // sizeLabel1
            // 
            this.sizeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Size", true));
            this.sizeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Size", true));
            this.sizeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sizeLabel1.Location = new System.Drawing.Point(4, 69);
            this.sizeLabel1.Name = "sizeLabel1";
            this.sizeLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // variantLabel
            // 
            variantLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Variant", true));
            variantLabel.Dock = System.Windows.Forms.DockStyle.Top;
            variantLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            variantLabel.Location = new System.Drawing.Point(4, 100);
            variantLabel.Name = "variantLabel";
            variantLabel.Size = new System.Drawing.Size(63, 21);
            variantLabel.Text = "Variant:";
            // 
            // variantLabel1
            // 
            this.variantLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Variant", true));
            this.variantLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Variant", true));
            this.variantLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.variantLabel1.Location = new System.Drawing.Point(4, 117);
            this.variantLabel1.Name = "variantLabel1";
            this.variantLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // itemLabel
            // 
            itemLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Item", true));
            itemLabel.Dock = System.Windows.Forms.DockStyle.Top;
            itemLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            itemLabel.Location = new System.Drawing.Point(4, 148);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(47, 21);
            itemLabel.Text = "Item:";
            // 
            // itemLabel1
            // 
            this.itemLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Item", true));
            this.itemLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Item", true));
            this.itemLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemLabel1.Location = new System.Drawing.Point(4, 165);
            this.itemLabel1.Name = "itemLabel1";
            this.itemLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // testLabel
            // 
            testLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Test", true));
            testLabel.Dock = System.Windows.Forms.DockStyle.Top;
            testLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            testLabel.Location = new System.Drawing.Point(4, 196);
            testLabel.Name = "testLabel";
            testLabel.Size = new System.Drawing.Size(43, 21);
            testLabel.Text = "Test:";
            // 
            // testLabel1
            // 
            this.testLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Test", true));
            this.testLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Test", true));
            this.testLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.testLabel1.Location = new System.Drawing.Point(4, 213);
            this.testLabel1.Name = "testLabel1";
            this.testLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // batTypeLabel
            // 
            batTypeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "BatType", true));
            batTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            batTypeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            batTypeLabel.Location = new System.Drawing.Point(4, 244);
            batTypeLabel.Name = "batTypeLabel";
            batTypeLabel.Size = new System.Drawing.Size(75, 21);
            batTypeLabel.Text = "Bat Type:";
            // 
            // batTypeLabel1
            // 
            this.batTypeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "BatType", true));
            this.batTypeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "BatType", true));
            this.batTypeLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.batTypeLabel1.Location = new System.Drawing.Point(4, 261);
            this.batTypeLabel1.Name = "batTypeLabel1";
            this.batTypeLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // numberLabel
            // 
            numberLabel.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Number", true));
            numberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            numberLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            numberLabel.Location = new System.Drawing.Point(4, 292);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(69, 21);
            numberLabel.Text = "Number:";
            // 
            // numberLabel1
            // 
            this.numberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Number", true));
            this.numberLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.barcodesBindingSource, "Number", true));
            this.numberLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberLabel1.Location = new System.Drawing.Point(4, 309);
            this.numberLabel1.Name = "numberLabel1";
            this.numberLabel1.Size = new System.Drawing.Size(100, 20);
            // 
            // topBorderPanel
            // 
            this.topBorderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.topBorderPanel.Name = "topBorderPanel";
            this.topBorderPanel.Size = new System.Drawing.Size(100, 2);
            // 
            // leftBorderPanel
            // 
            this.leftBorderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.leftBorderPanel.Name = "leftBorderPanel";
            this.leftBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(4, 100);
            // 
            // BarcodesSummaryViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.numberLabel1);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.batTypeLabel1);
            this.Controls.Add(batTypeLabel);
            this.Controls.Add(this.testLabel1);
            this.Controls.Add(testLabel);
            this.Controls.Add(this.itemLabel1);
            this.Controls.Add(itemLabel);
            this.Controls.Add(this.variantLabel1);
            this.Controls.Add(variantLabel);
            this.Controls.Add(this.sizeLabel1);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.barcodeLabel1);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "BarcodesSummaryViewDialog";
            this.Text = "BarcodesSummaryViewDialog";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarcodesSummaryViewDialog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem editMenuItemMenuItem;
        private System.Windows.Forms.BindingSource barcodesBindingSource;
        private System.Windows.Forms.Label barcodeLabel1;
        private System.Windows.Forms.Label sizeLabel1;
        private System.Windows.Forms.Label variantLabel1;
        private System.Windows.Forms.Label itemLabel1;
        private System.Windows.Forms.Label testLabel1;
        private System.Windows.Forms.Label batTypeLabel1;
        private System.Windows.Forms.Label numberLabel1;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}