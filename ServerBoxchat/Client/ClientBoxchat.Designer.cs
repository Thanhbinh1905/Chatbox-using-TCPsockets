﻿namespace Client
{
    partial class ClientBoxchat
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
            this.listBox1.Location = new System.Drawing.Point(21, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 264);
            this.listBox1.TabIndex = 40;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // btnClearMss
            // 
            this.btnClearMss.Location = new System.Drawing.Point(513, 328);
            this.btnClearMss.Name = "btnClearMss";
            this.btnClearMss.Size = new System.Drawing.Size(75, 23);
            this.btnClearMss.TabIndex = 39;
            this.btnClearMss.Text = "Clear";
            this.btnClearMss.UseVisualStyleBackColor = true;
            this.btnClearMss.Click += new System.EventHandler(this.btnClearMss_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(55, 20);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 38;
            this.Status.Text = "Offline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Status:";
            // 
            // btnSendMss
            // 
            this.btnSendMss.Location = new System.Drawing.Point(432, 328);
            this.btnSendMss.Name = "btnSendMss";
            this.btnSendMss.Size = new System.Drawing.Size(75, 23);
            this.btnSendMss.TabIndex = 36;
            this.btnSendMss.Text = "Gui";
            this.btnSendMss.UseVisualStyleBackColor = true;
            this.btnSendMss.Click += new System.EventHandler(this.btnSendMss_Click);
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(21, 328);
            this.txtbox.Multiline = true;
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(401, 20);
            this.txtbox.TabIndex = 35;
            // 
            // btnDisCon
            // 
            this.btnDisCon.Location = new System.Drawing.Point(513, 15);
            this.btnDisCon.Name = "btnDisCon";
            this.btnDisCon.Size = new System.Drawing.Size(75, 23);
            this.btnDisCon.TabIndex = 34;
            this.btnDisCon.Text = "Disconnect";
            this.btnDisCon.UseVisualStyleBackColor = true;
            this.btnDisCon.Click += new System.EventHandler(this.btnDisCon_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(418, 15);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 41;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ClientBoxchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 370);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnClearMss);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendMss);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.btnDisCon);
            this.Name = "ClientBoxchat";
            this.Text = "ClientBoxchat";
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