namespace CE_Network
{
    partial class BarcodesEditViewDialog
    {
        public static BarcodesEditViewDialog Instance(System.Windows.Forms.BindingSource bindingSource)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            if ((defaultInstance == null))
            {
                defaultInstance = new CE_Network.BarcodesEditViewDialog();
                defaultInstance.barcodesBindingSource.DataSource = bindingSource;
            }
            defaultInstance.barcodeTextBox.Focus();
            defaultInstance.AutoScrollPosition = new System.Drawing.Point(0, 0);
            defaultInstance.barcodesBindingSource.Position = bindingSource.Position;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return defaultInstance;
        }
    
        private static BarcodesEditViewDialog defaultInstance;
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
            this.barcodesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.variantTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.batTypeTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
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
            // barcodesBindingSource
            // 
            this.barcodesBindingSource.DataMember = "Barcodes";
            this.barcodesBindingSource.DataSource = typeof(CE_Network.BarcodeDataSet);
            // 
            // barcodeLabel
            // 
            barcodeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            barcodeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            barcodeLabel.Location = new System.Drawing.Point(4, 4);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(70, 21);
            barcodeLabel.Text = "Barcode:";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Barcode", true));
            this.barcodeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.barcodeTextBox.Location = new System.Drawing.Point(4, 21);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.barcodeTextBox.TabIndex = 1;
            // 
            // sizeLabel
            // 
            sizeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            sizeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            sizeLabel.Location = new System.Drawing.Point(4, 55);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(40, 21);
            sizeLabel.Text = "Size:";
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Size", true));
            this.sizeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sizeTextBox.Location = new System.Drawing.Point(4, 72);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.sizeTextBox.TabIndex = 3;
            // 
            // variantLabel
            // 
            variantLabel.Dock = System.Windows.Forms.DockStyle.Top;
            variantLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            variantLabel.Location = new System.Drawing.Point(4, 106);
            variantLabel.Name = "variantLabel";
            variantLabel.Size = new System.Drawing.Size(63, 21);
            variantLabel.Text = "Variant:";
            // 
            // variantTextBox
            // 
            this.variantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Variant", true));
            this.variantTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.variantTextBox.Location = new System.Drawing.Point(4, 123);
            this.variantTextBox.Name = "variantTextBox";
            this.variantTextBox.Size = new System.Drawing.Size(100, 23);
            this.variantTextBox.TabIndex = 5;
            // 
            // itemLabel
            // 
            itemLabel.Dock = System.Windows.Forms.DockStyle.Top;
            itemLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            itemLabel.Location = new System.Drawing.Point(4, 157);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(47, 21);
            itemLabel.Text = "Item:";
            // 
            // itemTextBox
            // 
            this.itemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Item", true));
            this.itemTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemTextBox.Location = new System.Drawing.Point(4, 174);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(100, 23);
            this.itemTextBox.TabIndex = 7;
            // 
            // testLabel
            // 
            testLabel.Dock = System.Windows.Forms.DockStyle.Top;
            testLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            testLabel.Location = new System.Drawing.Point(4, 208);
            testLabel.Name = "testLabel";
            testLabel.Size = new System.Drawing.Size(43, 21);
            testLabel.Text = "Test:";
            // 
            // testTextBox
            // 
            this.testTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Test", true));
            this.testTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.testTextBox.Location = new System.Drawing.Point(4, 225);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(100, 23);
            this.testTextBox.TabIndex = 9;
            // 
            // batTypeLabel
            // 
            batTypeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            batTypeLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            batTypeLabel.Location = new System.Drawing.Point(4, 259);
            batTypeLabel.Name = "batTypeLabel";
            batTypeLabel.Size = new System.Drawing.Size(75, 21);
            batTypeLabel.Text = "Bat Type:";
            // 
            // batTypeTextBox
            // 
            this.batTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "BatType", true));
            this.batTypeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.batTypeTextBox.Location = new System.Drawing.Point(4, 276);
            this.batTypeTextBox.Name = "batTypeTextBox";
            this.batTypeTextBox.Size = new System.Drawing.Size(100, 23);
            this.batTypeTextBox.TabIndex = 11;
            // 
            // numberLabel
            // 
            numberLabel.Dock = System.Windows.Forms.DockStyle.Top;
            numberLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            numberLabel.Location = new System.Drawing.Point(4, 310);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(69, 21);
            numberLabel.Text = "Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barcodesBindingSource, "Number", true));
            this.numberTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.numberTextBox.Location = new System.Drawing.Point(4, 327);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 23);
            this.numberTextBox.TabIndex = 13;
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
            // BarcodesEditViewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.batTypeTextBox);
            this.Controls.Add(batTypeLabel);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(testLabel);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(itemLabel);
            this.Controls.Add(this.variantTextBox);
            this.Controls.Add(variantLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.topBorderPanel);
            this.Controls.Add(this.leftBorderPanel);
            this.Controls.Add(this.rightBorderPanel);
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "BarcodesEditViewDialog";
            this.Text = "BarcodesEditViewDialog";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.BarcodesEditViewDialog_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.barcodesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource barcodesBindingSource;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.TextBox variantTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.TextBox batTypeTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Panel topBorderPanel;
        private System.Windows.Forms.Panel leftBorderPanel;
        private System.Windows.Forms.Panel rightBorderPanel;
    }
}