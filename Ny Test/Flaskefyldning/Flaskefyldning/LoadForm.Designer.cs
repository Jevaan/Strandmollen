namespace Flaskefyldning
{
    partial class LoadForm
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
            this.Draft_label = new System.Windows.Forms.Label();
            this.Draft_Textbox = new System.Windows.Forms.TextBox();
            this.Location_Label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Location_DropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Draft_label
            // 
            this.Draft_label.Location = new System.Drawing.Point(22, 25);
            this.Draft_label.Name = "Draft_label";
            this.Draft_label.Size = new System.Drawing.Size(59, 20);
            this.Draft_label.Text = "Kladde";
            // 
            // Draft_Textbox
            // 
            this.Draft_Textbox.Location = new System.Drawing.Point(87, 24);
            this.Draft_Textbox.MaxLength = 7;
            this.Draft_Textbox.Name = "Draft_Textbox";
            this.Draft_Textbox.Size = new System.Drawing.Size(122, 21);
            this.Draft_Textbox.TabIndex = 1;
            this.Draft_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumbers);
            // 
            // Location_Label
            // 
            this.Location_Label.Location = new System.Drawing.Point(22, 53);
            this.Location_Label.Name = "Location_Label";
            this.Location_Label.Size = new System.Drawing.Size(59, 20);
            this.Location_Label.Text = "Lagersted";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(12, 117);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(213, 67);
            this.Start_button.TabIndex = 4;
            this.Start_button.Text = "Start";
            this.Start_button.Click += new System.EventHandler(this.StartClicked);
            // 
            // Location_DropDown
            // 
            this.Location_DropDown.Location = new System.Drawing.Point(22, 76);
            this.Location_DropDown.Name = "Location_DropDown";
            this.Location_DropDown.Size = new System.Drawing.Size(187, 22);
            this.Location_DropDown.TabIndex = 7;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 280);
            this.Controls.Add(this.Location_DropDown);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Location_Label);
            this.Controls.Add(this.Draft_Textbox);
            this.Controls.Add(this.Draft_label);
            this.Menu = this.mainMenu1;
            this.Name = "LoadForm";
            this.Text = "Kladde...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Draft_label;
        private System.Windows.Forms.TextBox Draft_Textbox;
        private System.Windows.Forms.Label Location_Label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.ComboBox Location_DropDown;

    }
}