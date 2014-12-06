namespace Client
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_repassword = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.label_error_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Password";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(166, 84);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(167, 21);
            this.tb_username.TabIndex = 3;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(166, 130);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(167, 21);
            this.tb_password.TabIndex = 4;
            // 
            // tb_repassword
            // 
            this.tb_repassword.Location = new System.Drawing.Point(166, 190);
            this.tb_repassword.Name = "tb_repassword";
            this.tb_repassword.Size = new System.Drawing.Size(167, 21);
            this.tb_repassword.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(127, 262);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(108, 43);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label_error_message
            // 
            this.label_error_message.AutoSize = true;
            this.label_error_message.ForeColor = System.Drawing.Color.Crimson;
            this.label_error_message.Location = new System.Drawing.Point(35, 35);
            this.label_error_message.Name = "label_error_message";
            this.label_error_message.Size = new System.Drawing.Size(329, 12);
            this.label_error_message.TabIndex = 7;
            this.label_error_message.Text = "Username Exist!Please try again with another username!";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 366);
            this.Controls.Add(this.label_error_message);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_repassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_repassword;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label_error_message;
    }
}