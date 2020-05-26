namespace CarRentalSystem
{
    partial class UserLogin
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
            this.LoginPages = new System.Windows.Forms.TabControl();
            this.UserPage = new System.Windows.Forms.TabPage();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.userAccountLabel = new System.Windows.Forms.Label();
            this.userPwdLabel = new System.Windows.Forms.Label();
            this.userAccountTextBox = new System.Windows.Forms.TextBox();
            this.userPwdTextBox = new System.Windows.Forms.TextBox();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.userQuitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPages.SuspendLayout();
            this.UserPage.SuspendLayout();
            this.AdminPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPages
            // 
            this.LoginPages.Controls.Add(this.UserPage);
            this.LoginPages.Controls.Add(this.AdminPage);
            this.LoginPages.Location = new System.Drawing.Point(1, 1);
            this.LoginPages.Name = "LoginPages";
            this.LoginPages.SelectedIndex = 0;
            this.LoginPages.Size = new System.Drawing.Size(800, 451);
            this.LoginPages.TabIndex = 0;
            // 
            // UserPage
            // 
            this.UserPage.Controls.Add(this.userQuitButton);
            this.UserPage.Controls.Add(this.userLoginButton);
            this.UserPage.Controls.Add(this.userPwdTextBox);
            this.UserPage.Controls.Add(this.userAccountTextBox);
            this.UserPage.Controls.Add(this.userPwdLabel);
            this.UserPage.Controls.Add(this.userAccountLabel);
            this.UserPage.Location = new System.Drawing.Point(4, 22);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(792, 425);
            this.UserPage.TabIndex = 0;
            this.UserPage.Text = "用户登录";
            this.UserPage.UseVisualStyleBackColor = true;
            // 
            // AdminPage
            // 
            this.AdminPage.Controls.Add(this.button1);
            this.AdminPage.Controls.Add(this.button2);
            this.AdminPage.Controls.Add(this.textBox1);
            this.AdminPage.Controls.Add(this.textBox2);
            this.AdminPage.Controls.Add(this.label1);
            this.AdminPage.Controls.Add(this.label2);
            this.AdminPage.Location = new System.Drawing.Point(4, 22);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPage.Size = new System.Drawing.Size(792, 425);
            this.AdminPage.TabIndex = 1;
            this.AdminPage.Text = "管理员登录";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // userAccountLabel
            // 
            this.userAccountLabel.AutoSize = true;
            this.userAccountLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userAccountLabel.Location = new System.Drawing.Point(270, 135);
            this.userAccountLabel.Name = "userAccountLabel";
            this.userAccountLabel.Size = new System.Drawing.Size(56, 16);
            this.userAccountLabel.TabIndex = 0;
            this.userAccountLabel.Text = "用户名";
            // 
            // userPwdLabel
            // 
            this.userPwdLabel.AutoSize = true;
            this.userPwdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userPwdLabel.Location = new System.Drawing.Point(270, 188);
            this.userPwdLabel.Name = "userPwdLabel";
            this.userPwdLabel.Size = new System.Drawing.Size(56, 16);
            this.userPwdLabel.TabIndex = 1;
            this.userPwdLabel.Text = "密  码";
            // 
            // userAccountTextBox
            // 
            this.userAccountTextBox.Location = new System.Drawing.Point(331, 135);
            this.userAccountTextBox.Name = "userAccountTextBox";
            this.userAccountTextBox.Size = new System.Drawing.Size(169, 21);
            this.userAccountTextBox.TabIndex = 2;
            // 
            // userPwdTextBox
            // 
            this.userPwdTextBox.Location = new System.Drawing.Point(331, 188);
            this.userPwdTextBox.Name = "userPwdTextBox";
            this.userPwdTextBox.PasswordChar = '●';
            this.userPwdTextBox.Size = new System.Drawing.Size(169, 21);
            this.userPwdTextBox.TabIndex = 3;
            // 
            // userLoginButton
            // 
            this.userLoginButton.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userLoginButton.Location = new System.Drawing.Point(273, 246);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(98, 35);
            this.userLoginButton.TabIndex = 4;
            this.userLoginButton.Text = "登  录";
            this.userLoginButton.UseVisualStyleBackColor = true;
            // 
            // userQuitButton
            // 
            this.userQuitButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userQuitButton.Location = new System.Drawing.Point(407, 246);
            this.userQuitButton.Name = "userQuitButton";
            this.userQuitButton.Size = new System.Drawing.Size(93, 35);
            this.userQuitButton.TabIndex = 5;
            this.userQuitButton.Text = "退  出";
            this.userQuitButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(407, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "退  出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(273, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "登  录";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '●';
            this.textBox1.Size = new System.Drawing.Size(169, 21);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(331, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 21);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(270, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "密  码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(270, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "用户名";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginPages);
            this.Name = "UserLogin";
            this.Text = "用户登录";
            this.LoginPages.ResumeLayout(false);
            this.UserPage.ResumeLayout(false);
            this.UserPage.PerformLayout();
            this.AdminPage.ResumeLayout(false);
            this.AdminPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LoginPages;
        private System.Windows.Forms.TabPage UserPage;
        private System.Windows.Forms.TextBox userPwdTextBox;
        private System.Windows.Forms.TextBox userAccountTextBox;
        private System.Windows.Forms.Label userPwdLabel;
        private System.Windows.Forms.Label userAccountLabel;
        private System.Windows.Forms.TabPage AdminPage;
        private System.Windows.Forms.Button userQuitButton;
        private System.Windows.Forms.Button userLoginButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}