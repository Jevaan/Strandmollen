namespace Fyldningsregistrering
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblVNr = new System.Windows.Forms.Label();
            this.tbVNr = new System.Windows.Forms.TextBox();
            this.tbVNavn = new System.Windows.Forms.TextBox();
            this.lblAntal = new System.Windows.Forms.Label();
            this.tbAntal = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.rampeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fyldningDataSet = new Fyldningsregistrering.fyldningDataSet();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.rampeTableAdapter = new Fyldningsregistrering.fyldningDataSetTableAdapters.RampeTableAdapter();
            this.SuspendLayout();
            // 
            // lblVNr
            // 
            this.lblVNr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblVNr.Location = new System.Drawing.Point(12, 8);
            this.lblVNr.Name = "lblVNr";
            this.lblVNr.Size = new System.Drawing.Size(123, 20);
            this.lblVNr.Text = "Varenummer";
            // 
            // tbVNr
            // 
            this.tbVNr.Enabled = false;
            this.tbVNr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.tbVNr.Location = new System.Drawing.Point(169, 5);
            this.tbVNr.Name = "tbVNr";
            this.tbVNr.ReadOnly = true;
            this.tbVNr.Size = new System.Drawing.Size(145, 26);
            this.tbVNr.TabIndex = 99;
            this.tbVNr.TabStop = false;
            this.tbVNr.Text = "#####";
            // 
            // tbVNavn
            // 
            this.tbVNavn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tbVNavn.Location = new System.Drawing.Point(14, 34);
            this.tbVNavn.Name = "tbVNavn";
            this.tbVNavn.ReadOnly = true;
            this.tbVNavn.Size = new System.Drawing.Size(300, 26);
            this.tbVNavn.TabIndex = 99;
            this.tbVNavn.TabStop = false;
            this.tbVNavn.Text = "Varenavn";
            // 
            // lblAntal
            // 
            this.lblAntal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblAntal.Location = new System.Drawing.Point(14, 71);
            this.lblAntal.Name = "lblAntal";
            this.lblAntal.Size = new System.Drawing.Size(80, 20);
            this.lblAntal.Text = "Antal";
            // 
            // tbAntal
            // 
            this.tbAntal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tbAntal.Location = new System.Drawing.Point(169, 65);
            this.tbAntal.Name = "tbAntal";
            this.tbAntal.Size = new System.Drawing.Size(145, 26);
            this.tbAntal.TabIndex = 1;
            this.tbAntal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TriggerButton_KeyDown);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btAdd.Location = new System.Drawing.Point(194, 105);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(120, 33);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Tilføj";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btDel.Location = new System.Drawing.Point(14, 105);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(109, 33);
            this.btDel.TabIndex = 101;
            this.btDel.Text = "Fjern";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // rampeBindingSource
            // 
            this.rampeBindingSource.DataMember = "Rampe";
            this.rampeBindingSource.DataSource = this.fyldningDataSet;
            // 
            // fyldningDataSet
            // 
            this.fyldningDataSet.DataSetName = "fyldningDataSet";
            this.fyldningDataSet.Prefix = "";
            this.fyldningDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.DataSource = this.rampeBindingSource;
            this.dataGrid1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dataGrid1.Location = new System.Drawing.Point(14, 144);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(300, 114);
            this.dataGrid1.TabIndex = 104;
            this.dataGrid1.TableStyles.Add(this.dataGridTableStyle1);
            this.dataGrid1.TabStop = false;
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.MappingName = "Rampe";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.HeaderText = "Nummer";
            this.dataGridTextBoxColumn3.MappingName = "Nummer";
            this.dataGridTextBoxColumn3.Width = 64;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.HeaderText = "Produkt";
            this.dataGridTextBoxColumn1.MappingName = "Navn";
            this.dataGridTextBoxColumn1.Width = 160;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.HeaderText = "Antal";
            this.dataGridTextBoxColumn2.MappingName = "Antal";
            // 
            // rampeTableAdapter
            // 
            this.rampeTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(322, 272);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbAntal);
            this.Controls.Add(this.lblAntal);
            this.Controls.Add(this.tbVNavn);
            this.Controls.Add(this.tbVNr);
            this.Controls.Add(this.lblVNr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fyldningsregistrering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVNr;
        private System.Windows.Forms.TextBox tbVNr;
        private System.Windows.Forms.TextBox tbVNavn;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.TextBox tbAntal;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.DataGrid dataGrid1;
        private fyldningDataSet fyldningDataSet;
        private System.Windows.Forms.BindingSource rampeBindingSource;
        private Fyldningsregistrering.fyldningDataSetTableAdapters.RampeTableAdapter rampeTableAdapter;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        
    }
}

