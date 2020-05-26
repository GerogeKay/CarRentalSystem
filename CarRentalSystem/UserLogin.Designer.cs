﻿namespace CarRentalSystem
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
            this.userQuitButton = new System.Windows.Forms.Button();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.userPwdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userPwdLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.AdminPage = new System.Windows.Forms.TabPage();
            this.adminQuitButton = new System.Windows.Forms.Button();
            this.adminLoginButton = new System.Windows.Forms.Button();
            this.adminPwdTextBox = new System.Windows.Forms.TextBox();
            this.adminNameTextBox = new System.Windows.Forms.TextBox();
            this.adminPwdLabel = new System.Windows.Forms.Label();
            this.adminNameLabel = new System.Windows.Forms.Label();
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
            this.UserPage.Controls.Add(this.userNameTextBox);
            this.UserPage.Controls.Add(this.userPwdLabel);
            this.UserPage.Controls.Add(this.userNameLabel);
            this.UserPage.Location = new System.Drawing.Point(4, 22);
            this.UserPage.Name = "UserPage";
            this.UserPage.Padding = new System.Windows.Forms.Padding(3);
            this.UserPage.Size = new System.Drawing.Size(792, 425);
            this.UserPage.TabIndex = 0;
            this.UserPage.Text = "用户登录";
            this.UserPage.UseVisualStyleBackColor = true;
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
            // userPwdTextBox
            // 
            this.userPwdTextBox.Location = new System.Drawing.Point(331, 188);
            this.userPwdTextBox.Name = "userPwdTextBox";
            this.userPwdTextBox.PasswordChar = '●';
            this.userPwdTextBox.Size = new System.Drawing.Size(169, 21);
            this.userPwdTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(331, 135);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(169, 21);
            this.userNameTextBox.TabIndex = 2;
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
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userNameLabel.Location = new System.Drawing.Point(270, 135);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(56, 16);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "用户名";
            // 
            // AdminPage
            // 
            this.AdminPage.Controls.Add(this.adminQuitButton);
            this.AdminPage.Controls.Add(this.adminLoginButton);
            this.AdminPage.Controls.Add(this.adminPwdTextBox);
            this.AdminPage.Controls.Add(this.adminNameTextBox);
            this.AdminPage.Controls.Add(this.adminPwdLabel);
            this.AdminPage.Controls.Add(this.adminNameLabel);
            this.AdminPage.Location = new System.Drawing.Point(4, 22);
            this.AdminPage.Name = "AdminPage";
            this.AdminPage.Padding = new System.Windows.Forms.Padding(3);
            this.AdminPage.Size = new System.Drawing.Size(792, 425);
            this.AdminPage.TabIndex = 1;
            this.AdminPage.Text = "管理员登录";
            this.AdminPage.UseVisualStyleBackColor = true;
            // 
            // adminQuitButton
            // 
            this.adminQuitButton.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminQuitButton.Location = new System.Drawing.Point(407, 246);
            this.adminQuitButton.Name = "adminQuitButton";
            this.adminQuitButton.Size = new System.Drawing.Size(93, 35);
            this.adminQuitButton.TabIndex = 11;
            this.adminQuitButton.Text = "退  出";
            this.adminQuitButton.UseVisualStyleBackColor = true;
            // 
            // adminLoginButton
            // 
            this.adminLoginButton.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminLoginButton.Location = new System.Drawing.Point(273, 246);
            this.adminLoginButton.Name = "adminLoginButton";
            this.adminLoginButton.Size = new System.Drawing.Size(98, 35);
            this.adminLoginButton.TabIndex = 10;
            this.adminLoginButton.Text = "登  录";
            this.adminLoginButton.UseVisualStyleBackColor = true;
            // 
            // adminPwdTextBox
            // 
            this.adminPwdTextBox.Location = new System.Drawing.Point(331, 188);
            this.adminPwdTextBox.Name = "adminPwdTextBox";
            this.adminPwdTextBox.PasswordChar = '●';
            this.adminPwdTextBox.Size = new System.Drawing.Size(169, 21);
            this.adminPwdTextBox.TabIndex = 9;
            // 
            // adminNameTextBox
            // 
            this.adminNameTextBox.Location = new System.Drawing.Point(331, 135);
            this.adminNameTextBox.Name = "adminNameTextBox";
            this.adminNameTextBox.Size = new System.Drawing.Size(169, 21);
            this.adminNameTextBox.TabIndex = 8;
            // 
            // adminPwdLabel
            // 
            this.adminPwdLabel.AutoSize = true;
            this.adminPwdLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminPwdLabel.Location = new System.Drawing.Point(270, 188);
            this.adminPwdLabel.Name = "adminPwdLabel";
            this.adminPwdLabel.Size = new System.Drawing.Size(56, 16);
            this.adminPwdLabel.TabIndex = 7;
            this.adminPwdLabel.Text = "密  码";
            // 
            // adminNameLabel
            // 
            this.adminNameLabel.AutoSize = true;
            this.adminNameLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.adminNameLabel.Location = new System.Drawing.Point(270, 135);
            this.adminNameLabel.Name = "adminNameLabel";
            this.adminNameLabel.Size = new System.Drawing.Size(56, 16);
            this.adminNameLabel.TabIndex = 6;
            this.adminNameLabel.Text = "用户名";
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
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userPwdLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TabPage AdminPage;
        private System.Windows.Forms.Button userQuitButton;
        private System.Windows.Forms.Button userLoginButton;
        private System.Windows.Forms.Button adminQuitButton;
        private System.Windows.Forms.Button adminLoginButton;
        private System.Windows.Forms.TextBox adminPwdTextBox;
        private System.Windows.Forms.TextBox adminNameTextBox;
        private System.Windows.Forms.Label adminPwdLabel;
        private System.Windows.Forms.Label adminNameLabel;
    }
}