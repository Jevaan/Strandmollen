namespace ModemComm
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
            this.ComModem = new System.IO.Ports.SerialPort(this.components);
            this.Inbox_tb = new System.Windows.Forms.TextBox();
            this.Outbox_tb = new System.Windows.Forms.TextBox();
            this.Prefix_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComModem
            // 
            this.ComModem.DtrEnable = true;
            this.ComModem.Handshake = System.IO.Ports.Handshake.XOnXOff;
            this.ComModem.PortName = "COM3";
            this.ComModem.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // Inbox_tb
            // 
            this.Inbox_tb.Location = new System.Drawing.Point(12, 12);
            this.Inbox_tb.Name = "Inbox_tb";
            this.Inbox_tb.ReadOnly = true;
            this.Inbox_tb.Size = new System.Drawing.Size(207, 20);
            this.Inbox_tb.TabIndex = 0;
            // 
            // Outbox_tb
            // 
            this.Outbox_tb.Location = new System.Drawing.Point(13, 39);
            this.Outbox_tb.Name = "Outbox_tb";
            this.Outbox_tb.ReadOnly = true;
            this.Outbox_tb.Size = new System.Drawing.Size(206, 20);
            this.Outbox_tb.TabIndex = 1;
            // 
            // Prefix_tb
            // 
            this.Prefix_tb.Location = new System.Drawing.Point(12, 66);
            this.Prefix_tb.Name = "Prefix_tb";
            this.Prefix_tb.ReadOnly = true;
            this.Prefix_tb.Size = new System.Drawing.Size(100, 20);
            this.Prefix_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last log:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 110);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 48);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 170);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prefix_tb);
            this.Controls.Add(this.Outbox_tb);
            this.Controls.Add(this.Inbox_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort ComModem;
        private System.Windows.Forms.TextBox Inbox_tb;
        private System.Windows.Forms.TextBox Outbox_tb;
        private System.Windows.Forms.TextBox Prefix_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

