namespace Scanfejl
{
    partial class ReaderForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.ReaderDataLabel = new System.Windows.Forms.Label();
            this.ReaderBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(177, 56);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(54, 25);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Luk";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseButton_KeyDown);
            // 
            // ReaderDataLabel
            // 
            this.ReaderDataLabel.Location = new System.Drawing.Point(8, 8);
            this.ReaderDataLabel.Name = "ReaderDataLabel";
            this.ReaderDataLabel.Size = new System.Drawing.Size(149, 16);
            this.ReaderDataLabel.Text = "Registrering slettet for:";
            // 
            // ReaderBox
            // 
            this.ReaderBox.Location = new System.Drawing.Point(8, 27);
            this.ReaderBox.Name = "ReaderBox";
            this.ReaderBox.ReadOnly = true;
            this.ReaderBox.Size = new System.Drawing.Size(223, 23);
            this.ReaderBox.TabIndex = 4;
            // 
            // ReaderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(239, 90);
            this.Controls.Add(this.ReaderBox);
            this.Controls.Add(this.ReaderDataLabel);
            this.Controls.Add(this.CloseButton);
            this.Name = "ReaderForm";
            this.Text = "Fejlscanner";
            this.Load += new System.EventHandler(this.ReaderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ReaderBox;
    }
}

