namespace ServerBoxchat
{
    partial class BoxchatAdmin
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClearMss = new System.Windows.Forms.Button();
            this.btnSendMss = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StopServer = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 264);
            this.listBox1.TabIndex = 24;
            // 
            // btnClearMss
            // 
            this.btnClearMss.Location = new System.Drawing.Point(543, 429);
            this.btnClearMss.Name = "btnClearMss";
            this.btnClearMss.Size = new System.Drawing.Size(75, 23);
            this.btnClearMss.TabIndex = 23;
            this.btnClearMss.Text = "Clear";
            this.btnClearMss.UseVisualStyleBackColor = true;
            this.btnClearMss.Click += new System.EventHandler(this.btnClearMss_Click);
            // 
            // btnSendMss
            // 
            this.btnSendMss.Location = new System.Drawing.Point(462, 429);
            this.btnSendMss.Name = "btnSendMss";
            this.btnSendMss.Size = new System.Drawing.Size(75, 23);
            this.btnSendMss.TabIndex = 20;
            this.btnSendMss.Text = "Gui";
            this.btnSendMss.UseVisualStyleBackColor = true;
            this.btnSendMss.Click += new System.EventHandler(this.btnSendMss_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(51, 429);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(401, 20);
            this.txtbox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Your nickname (Admin):";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(94, 120);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 33;
            this.lbStatus.Text = "Offline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Status:";
            // 
            // StopServer
            // 
            this.StopServer.Location = new System.Drawing.Point(361, 59);
            this.StopServer.Name = "StopServer";
            this.StopServer.Size = new System.Drawing.Size(75, 37);
            this.StopServer.TabIndex = 30;
            this.StopServer.Text = "Stop";
            this.StopServer.UseVisualStyleBackColor = true;
            this.StopServer.Click += new System.EventHandler(this.StopServer_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(361, 20);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 33);
            this.Start.TabIndex = 31;
            this.Start.Text = "Start Server";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(173, 76);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(173, 20);
            this.txtPort.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 27;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(173, 47);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(173, 20);
            this.txtIP.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Your IP\'s server:";
            // 
            // BoxchatAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 492);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StopServer);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnClearMss);
            this.Controls.Add(this.btnSendMss);
            this.Controls.Add(this.txtbox);
            this.Name = "BoxchatAdmin";
            this.Text = "BoxchatAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClearMss;
        private System.Windows.Forms.Button btnSendMss;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StopServer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}