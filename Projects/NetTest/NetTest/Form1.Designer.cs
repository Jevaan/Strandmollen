namespace NetTest
{
    partial class Form1
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
            this.treeViewCtr = new System.Windows.Forms.TreeView();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewCtr
            // 
            this.treeViewCtr.Location = new System.Drawing.Point(3, 3);
            this.treeViewCtr.Name = "treeViewCtr";
            this.treeViewCtr.Size = new System.Drawing.Size(200, 200);
            this.treeViewCtr.TabIndex = 0;
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.Location = new System.Drawing.Point(3, 206);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(200, 20);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(206, 243);
            this.Controls.Add(this.lblSelectedItem);
            this.Controls.Add(this.treeViewCtr);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCtr;
        private System.Windows.Forms.Label lblSelectedItem;

    }
}

