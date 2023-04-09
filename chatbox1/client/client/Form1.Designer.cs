namespace client
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClearMss = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSendMss = new System.Windows.Forms.Button();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btnDisCon = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 264);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnClearMss
            // 
            this.btnClearMss.Location = new System.Drawing.Point(514, 338);
            this.btnClearMss.Name = "btnClearMss";
            this.btnClearMss.Size = new System.Drawing.Size(75, 23);
            this.btnClearMss.TabIndex = 23;
            this.btnClearMss.Text = "Clear";
            this.btnClearMss.UseVisualStyleBackColor = true;
            this.btnClearMss.Click += new System.EventHandler(this.btnClearMss_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(56, 30);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 22;
            this.Status.Text = "Offline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Status:";
            // 
            // btnSendMss
            // 
            this.btnSendMss.Location = new System.Drawing.Point(433, 338);
            this.btnSendMss.Name = "btnSendMss";
            this.btnSendMss.Size = new System.Drawing.Size(75, 23);
            this.btnSendMss.TabIndex = 20;
            this.btnSendMss.Text = "Gui";
            this.btnSendMss.UseVisualStyleBackColor = true;
            this.btnSendMss.Click += new System.EventHandler(this.btnSendMss_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(22, 338);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(401, 20);
            this.txtbox.TabIndex = 19;
            // 
            // btnDisCon
            // 
            this.btnDisCon.Location = new System.Drawing.Point(603, 75);
            this.btnDisCon.Name = "btnDisCon";
            this.btnDisCon.Size = new System.Drawing.Size(75, 23);
            this.btnDisCon.TabIndex = 18;
            this.btnDisCon.Text = "Disconnect";
            this.btnDisCon.UseVisualStyleBackColor = true;
            this.btnDisCon.Click += new System.EventHandler(this.btnDisCon_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(603, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 379);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnClearMss);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendMss);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btnDisCon);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClearMss;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSendMss;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btnDisCon;
        private System.Windows.Forms.Button btnConnect;
    }
}

