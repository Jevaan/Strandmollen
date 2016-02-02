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
            this.Loading_pb = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.DoingWhat_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // Loading_pb
            // 
            this.Loading_pb.Location = new System.Drawing.Point(32, 131);
            this.Loading_pb.Name = "Loading_pb";
            this.Loading_pb.Size = new System.Drawing.Size(174, 20);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.Text = "Starta Påfyllning av flaska...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoingWhat_lbl
            // 
            this.DoingWhat_lbl.Location = new System.Drawing.Point(32, 105);
            this.DoingWhat_lbl.Name = "DoingWhat_lbl";
            this.DoingWhat_lbl.Size = new System.Drawing.Size(174, 20);
            this.DoingWhat_lbl.Text = "Starta program...";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.LoadData);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 280);
            this.Controls.Add(this.DoingWhat_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loading_pb);
            this.Menu = this.mainMenu1;
            this.Name = "LoadForm";
            this.Text = "Starta...";
            this.GotFocus += new System.EventHandler(this.Loaded);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Loading_pb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DoingWhat_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}