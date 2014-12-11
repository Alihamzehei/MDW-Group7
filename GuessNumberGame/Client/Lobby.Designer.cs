namespace Client
{
    partial class Lobby
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
            this.lbOnlinePlayers = new System.Windows.Forms.ListBox();
            this.gbOnline = new System.Windows.Forms.GroupBox();
            this.btInvite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.gbOnline.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOnlinePlayers
            // 
            this.lbOnlinePlayers.FormattingEnabled = true;
            this.lbOnlinePlayers.ItemHeight = 12;
            this.lbOnlinePlayers.Location = new System.Drawing.Point(6, 20);
            this.lbOnlinePlayers.Name = "lbOnlinePlayers";
            this.lbOnlinePlayers.Size = new System.Drawing.Size(313, 316);
            this.lbOnlinePlayers.TabIndex = 0;
            // 
            // gbOnline
            // 
            this.gbOnline.Controls.Add(this.lbOnlinePlayers);
            this.gbOnline.Location = new System.Drawing.Point(25, 12);
            this.gbOnline.Name = "gbOnline";
            this.gbOnline.Size = new System.Drawing.Size(335, 351);
            this.gbOnline.TabIndex = 1;
            this.gbOnline.TabStop = false;
            this.gbOnline.Text = "Online Players";
            // 
            // btInvite
            // 
            this.btInvite.Location = new System.Drawing.Point(106, 369);
            this.btInvite.Name = "btInvite";
            this.btInvite.Size = new System.Drawing.Size(100, 68);
            this.btInvite.TabIndex = 2;
            this.btInvite.Text = "Invite";
            this.btInvite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSend);
            this.groupBox1.Controls.Add(this.tbMessage);
            this.groupBox1.Controls.Add(this.lbChat);
            this.groupBox1.Location = new System.Drawing.Point(400, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 415);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 12;
            this.lbChat.Location = new System.Drawing.Point(14, 22);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(316, 316);
            this.lbChat.TabIndex = 0;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(16, 348);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(167, 54);
            this.tbMessage.TabIndex = 1;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(201, 350);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(97, 51);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btInvite);
            this.Controls.Add(this.gbOnline);
            this.Name = "Lobby";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.gbOnline.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOnlinePlayers;
        private System.Windows.Forms.GroupBox gbOnline;
        private System.Windows.Forms.Button btInvite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lbChat;
    }
}

