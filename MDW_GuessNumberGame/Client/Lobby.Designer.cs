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
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btInvitePlayer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayers
            // 
            this.lbPlayers.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.ItemHeight = 35;
            this.lbPlayers.Location = new System.Drawing.Point(6, 18);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.Size = new System.Drawing.Size(230, 284);
            this.lbPlayers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbPlayers);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Online";
            // 
            // btInvitePlayer
            // 
            this.btInvitePlayer.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInvitePlayer.Location = new System.Drawing.Point(76, 374);
            this.btInvitePlayer.Name = "btInvitePlayer";
            this.btInvitePlayer.Size = new System.Drawing.Size(133, 63);
            this.btInvitePlayer.TabIndex = 2;
            this.btInvitePlayer.Text = "Invite";
            this.btInvitePlayer.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSendMessage);
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Controls.Add(this.lbChat);
            this.groupBox2.Font = new System.Drawing.Font("SimSun", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(389, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 445);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chat";
            // 
            // lbChat
            // 
            this.lbChat.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 14;
            this.lbChat.Location = new System.Drawing.Point(19, 21);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(444, 298);
            this.lbChat.TabIndex = 0;
            // 
            // tbMessage
            // 
            this.tbMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbMessage.Location = new System.Drawing.Point(20, 336);
            this.tbMessage.MinimumSize = new System.Drawing.Size(300, 90);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(300, 90);
            this.tbMessage.TabIndex = 1;
            // 
            // btSendMessage
            // 
            this.btSendMessage.Location = new System.Drawing.Point(346, 348);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(99, 60);
            this.btSendMessage.TabIndex = 2;
            this.btSendMessage.Text = "Send";
            this.btSendMessage.UseVisualStyleBackColor = true;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btInvitePlayer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btInvitePlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSendMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lbChat;
    }
}

