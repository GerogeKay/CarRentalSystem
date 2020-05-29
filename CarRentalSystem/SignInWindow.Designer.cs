namespace CarRentalSystem
{
    partial class SignInWindow
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
            this.signInTypeControl = new System.Windows.Forms.TabControl();
            this.userSignInPage = new System.Windows.Forms.TabPage();
            this.adminSignInPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCheckUserPwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPayPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCheckPayPwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textUserPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textUserRealName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textUserAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textUserIdentity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textDriLicsense = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonUserConfirm = new System.Windows.Forms.Button();
            this.buttonUserCancel = new System.Windows.Forms.Button();
            this.userGenderBox = new System.Windows.Forms.ComboBox();
            this.adminGenderBox = new System.Windows.Forms.ComboBox();
            this.buttonAdminCancel = new System.Windows.Forms.Button();
            this.buttonAdminConfirm = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textAdminIdentity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textAdminAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textAdminRealName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textAdminPhone = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textCheckContorlPwd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textControlPwd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textAdminCheckPwd = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textAdminPwd = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textAdminName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.signInTypeControl.SuspendLayout();
            this.userSignInPage.SuspendLayout();
            this.adminSignInPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInTypeControl
            // 
            this.signInTypeControl.Controls.Add(this.userSignInPage);
            this.signInTypeControl.Controls.Add(this.adminSignInPage);
            this.signInTypeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInTypeControl.Location = new System.Drawing.Point(0, 0);
            this.signInTypeControl.Name = "signInTypeControl";
            this.signInTypeControl.SelectedIndex = 0;
            this.signInTypeControl.Size = new System.Drawing.Size(526, 450);
            this.signInTypeControl.TabIndex = 0;
            // 
            // userSignInPage
            // 
            this.userSignInPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userSignInPage.Controls.Add(this.userGenderBox);
            this.userSignInPage.Controls.Add(this.buttonUserCancel);
            this.userSignInPage.Controls.Add(this.buttonUserConfirm);
            this.userSignInPage.Controls.Add(this.label11);
            this.userSignInPage.Controls.Add(this.textDriLicsense);
            this.userSignInPage.Controls.Add(this.label10);
            this.userSignInPage.Controls.Add(this.textUserIdentity);
            this.userSignInPage.Controls.Add(this.label9);
            this.userSignInPage.Controls.Add(this.textUserAddress);
            this.userSignInPage.Controls.Add(this.label8);
            this.userSignInPage.Controls.Add(this.textUserRealName);
            this.userSignInPage.Controls.Add(this.label7);
            this.userSignInPage.Controls.Add(this.textUserPhone);
            this.userSignInPage.Controls.Add(this.label6);
            this.userSignInPage.Controls.Add(this.textCheckPayPwd);
            this.userSignInPage.Controls.Add(this.label5);
            this.userSignInPage.Controls.Add(this.textPayPwd);
            this.userSignInPage.Controls.Add(this.label4);
            this.userSignInPage.Controls.Add(this.textCheckUserPwd);
            this.userSignInPage.Controls.Add(this.label3);
            this.userSignInPage.Controls.Add(this.textUserPwd);
            this.userSignInPage.Controls.Add(this.label2);
            this.userSignInPage.Controls.Add(this.textUserName);
            this.userSignInPage.Controls.Add(this.label1);
            this.userSignInPage.Location = new System.Drawing.Point(4, 22);
            this.userSignInPage.Name = "userSignInPage";
            this.userSignInPage.Padding = new System.Windows.Forms.Padding(3);
            this.userSignInPage.Size = new System.Drawing.Size(518, 424);
            this.userSignInPage.TabIndex = 0;
            this.userSignInPage.Text = "用户注册";
            // 
            // adminSignInPage
            // 
            this.adminSignInPage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.adminSignInPage.Controls.Add(this.adminGenderBox);
            this.adminSignInPage.Controls.Add(this.buttonAdminCancel);
            this.adminSignInPage.Controls.Add(this.buttonAdminConfirm);
            this.adminSignInPage.Controls.Add(this.label12);
            this.adminSignInPage.Controls.Add(this.textAdminIdentity);
            this.adminSignInPage.Controls.Add(this.label14);
            this.adminSignInPage.Controls.Add(this.textAdminAddress);
            this.adminSignInPage.Controls.Add(this.label15);
            this.adminSignInPage.Controls.Add(this.textAdminRealName);
            this.adminSignInPage.Controls.Add(this.label16);
            this.adminSignInPage.Controls.Add(this.textAdminPhone);
            this.adminSignInPage.Controls.Add(this.label17);
            this.adminSignInPage.Controls.Add(this.textCheckContorlPwd);
            this.adminSignInPage.Controls.Add(this.label18);
            this.adminSignInPage.Controls.Add(this.textControlPwd);
            this.adminSignInPage.Controls.Add(this.label19);
            this.adminSignInPage.Controls.Add(this.textAdminCheckPwd);
            this.adminSignInPage.Controls.Add(this.label20);
            this.adminSignInPage.Controls.Add(this.textAdminPwd);
            this.adminSignInPage.Controls.Add(this.label21);
            this.adminSignInPage.Controls.Add(this.textAdminName);
            this.adminSignInPage.Controls.Add(this.label22);
            this.adminSignInPage.Location = new System.Drawing.Point(4, 22);
            this.adminSignInPage.Name = "adminSignInPage";
            this.adminSignInPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminSignInPage.Size = new System.Drawing.Size(518, 424);
            this.adminSignInPage.TabIndex = 1;
            this.adminSignInPage.Text = "管理员注册";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(122, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用 户 名:";
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(208, 37);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(199, 21);
            this.textUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(122, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录密码:";
            // 
            // textUserPwd
            // 
            this.textUserPwd.Location = new System.Drawing.Point(208, 64);
            this.textUserPwd.Name = "textUserPwd";
            this.textUserPwd.Size = new System.Drawing.Size(199, 21);
            this.textUserPwd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(90, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认登陆密码:";
            // 
            // textCheckUserPwd
            // 
            this.textCheckUserPwd.Location = new System.Drawing.Point(208, 91);
            this.textCheckUserPwd.Name = "textCheckUserPwd";
            this.textCheckUserPwd.Size = new System.Drawing.Size(199, 21);
            this.textCheckUserPwd.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(122, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "支付密码:";
            // 
            // textPayPwd
            // 
            this.textPayPwd.Location = new System.Drawing.Point(208, 118);
            this.textPayPwd.Name = "textPayPwd";
            this.textPayPwd.Size = new System.Drawing.Size(199, 21);
            this.textPayPwd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(91, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "确认支付密码:";
            // 
            // textCheckPayPwd
            // 
            this.textCheckPayPwd.Location = new System.Drawing.Point(208, 145);
            this.textCheckPayPwd.Name = "textCheckPayPwd";
            this.textCheckPayPwd.Size = new System.Drawing.Size(199, 21);
            this.textCheckPayPwd.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(122, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "电话号码:";
            // 
            // textUserPhone
            // 
            this.textUserPhone.Location = new System.Drawing.Point(208, 172);
            this.textUserPhone.Name = "textUserPhone";
            this.textUserPhone.Size = new System.Drawing.Size(199, 21);
            this.textUserPhone.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(122, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "真实姓名:";
            // 
            // textUserRealName
            // 
            this.textUserRealName.Location = new System.Drawing.Point(208, 199);
            this.textUserRealName.Name = "textUserRealName";
            this.textUserRealName.Size = new System.Drawing.Size(199, 21);
            this.textUserRealName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(122, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "家庭住址:";
            // 
            // textUserAddress
            // 
            this.textUserAddress.Location = new System.Drawing.Point(208, 253);
            this.textUserAddress.Name = "textUserAddress";
            this.textUserAddress.Size = new System.Drawing.Size(199, 21);
            this.textUserAddress.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(106, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "身份证号码:";
            // 
            // textUserIdentity
            // 
            this.textUserIdentity.Location = new System.Drawing.Point(208, 280);
            this.textUserIdentity.Name = "textUserIdentity";
            this.textUserIdentity.Size = new System.Drawing.Size(199, 21);
            this.textUserIdentity.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(106, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "驾驶证号码:";
            // 
            // textDriLicsense
            // 
            this.textDriLicsense.Location = new System.Drawing.Point(208, 307);
            this.textDriLicsense.Name = "textDriLicsense";
            this.textDriLicsense.Size = new System.Drawing.Size(199, 21);
            this.textDriLicsense.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(122, 229);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "性    别:";
            // 
            // buttonUserConfirm
            // 
            this.buttonUserConfirm.Location = new System.Drawing.Point(128, 365);
            this.buttonUserConfirm.Name = "buttonUserConfirm";
            this.buttonUserConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonUserConfirm.TabIndex = 2;
            this.buttonUserConfirm.Text = "确 定";
            this.buttonUserConfirm.UseVisualStyleBackColor = true;
            // 
            // buttonUserCancel
            // 
            this.buttonUserCancel.Location = new System.Drawing.Point(316, 365);
            this.buttonUserCancel.Name = "buttonUserCancel";
            this.buttonUserCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonUserCancel.TabIndex = 3;
            this.buttonUserCancel.Text = "取 消";
            this.buttonUserCancel.UseVisualStyleBackColor = true;
            // 
            // userGenderBox
            // 
            this.userGenderBox.FormattingEnabled = true;
            this.userGenderBox.Items.AddRange(new object[] {
            "保密",
            "男",
            "女",
            "跨性别"});
            this.userGenderBox.Location = new System.Drawing.Point(208, 227);
            this.userGenderBox.Name = "userGenderBox";
            this.userGenderBox.Size = new System.Drawing.Size(199, 20);
            this.userGenderBox.TabIndex = 4;
            // 
            // adminGenderBox
            // 
            this.adminGenderBox.FormattingEnabled = true;
            this.adminGenderBox.Items.AddRange(new object[] {
            "保密",
            "男",
            "女",
            "跨性别"});
            this.adminGenderBox.Location = new System.Drawing.Point(208, 253);
            this.adminGenderBox.Name = "adminGenderBox";
            this.adminGenderBox.Size = new System.Drawing.Size(199, 20);
            this.adminGenderBox.TabIndex = 28;
            // 
            // buttonAdminCancel
            // 
            this.buttonAdminCancel.Location = new System.Drawing.Point(316, 365);
            this.buttonAdminCancel.Name = "buttonAdminCancel";
            this.buttonAdminCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminCancel.TabIndex = 27;
            this.buttonAdminCancel.Text = "取 消";
            this.buttonAdminCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdminConfirm
            // 
            this.buttonAdminConfirm.Location = new System.Drawing.Point(128, 365);
            this.buttonAdminConfirm.Name = "buttonAdminConfirm";
            this.buttonAdminConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonAdminConfirm.TabIndex = 26;
            this.buttonAdminConfirm.Text = "确 定";
            this.buttonAdminConfirm.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(122, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "性    别:";
            // 
            // textAdminIdentity
            // 
            this.textAdminIdentity.Location = new System.Drawing.Point(208, 306);
            this.textAdminIdentity.Name = "textAdminIdentity";
            this.textAdminIdentity.Size = new System.Drawing.Size(199, 21);
            this.textAdminIdentity.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(106, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "身份证号码:";
            // 
            // textAdminAddress
            // 
            this.textAdminAddress.Location = new System.Drawing.Point(208, 279);
            this.textAdminAddress.Name = "textAdminAddress";
            this.textAdminAddress.Size = new System.Drawing.Size(199, 21);
            this.textAdminAddress.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F);
            this.label15.Location = new System.Drawing.Point(122, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 11;
            this.label15.Text = "家庭住址:";
            // 
            // textAdminRealName
            // 
            this.textAdminRealName.Location = new System.Drawing.Point(208, 225);
            this.textAdminRealName.Name = "textAdminRealName";
            this.textAdminRealName.Size = new System.Drawing.Size(199, 21);
            this.textAdminRealName.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F);
            this.label16.Location = new System.Drawing.Point(122, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "真实姓名:";
            // 
            // textAdminPhone
            // 
            this.textAdminPhone.Location = new System.Drawing.Point(208, 198);
            this.textAdminPhone.Name = "textAdminPhone";
            this.textAdminPhone.Size = new System.Drawing.Size(199, 21);
            this.textAdminPhone.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F);
            this.label17.Location = new System.Drawing.Point(122, 201);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 10;
            this.label17.Text = "电话号码:";
            // 
            // textCheckContorlPwd
            // 
            this.textCheckContorlPwd.Location = new System.Drawing.Point(208, 171);
            this.textCheckContorlPwd.Name = "textCheckContorlPwd";
            this.textCheckContorlPwd.Size = new System.Drawing.Size(199, 21);
            this.textCheckContorlPwd.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F);
            this.label18.Location = new System.Drawing.Point(91, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(112, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "确认管理密码:";
            // 
            // textControlPwd
            // 
            this.textControlPwd.Location = new System.Drawing.Point(208, 144);
            this.textControlPwd.Name = "textControlPwd";
            this.textControlPwd.Size = new System.Drawing.Size(199, 21);
            this.textControlPwd.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F);
            this.label19.Location = new System.Drawing.Point(122, 147);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "管理密码:";
            // 
            // textAdminCheckPwd
            // 
            this.textAdminCheckPwd.Location = new System.Drawing.Point(208, 117);
            this.textAdminCheckPwd.Name = "textAdminCheckPwd";
            this.textAdminCheckPwd.Size = new System.Drawing.Size(199, 21);
            this.textAdminCheckPwd.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F);
            this.label20.Location = new System.Drawing.Point(90, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 16);
            this.label20.TabIndex = 7;
            this.label20.Text = "确认登陆密码:";
            // 
            // textAdminPwd
            // 
            this.textAdminPwd.Location = new System.Drawing.Point(208, 90);
            this.textAdminPwd.Name = "textAdminPwd";
            this.textAdminPwd.Size = new System.Drawing.Size(199, 21);
            this.textAdminPwd.TabIndex = 25;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 12F);
            this.label21.Location = new System.Drawing.Point(122, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 16);
            this.label21.TabIndex = 6;
            this.label21.Text = "登录密码:";
            // 
            // textAdminName
            // 
            this.textAdminName.Location = new System.Drawing.Point(208, 63);
            this.textAdminName.Name = "textAdminName";
            this.textAdminName.Size = new System.Drawing.Size(199, 21);
            this.textAdminName.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F);
            this.label22.Location = new System.Drawing.Point(122, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 16);
            this.label22.TabIndex = 12;
            this.label22.Text = "用 户 名:";
            // 
            // SignInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.signInTypeControl);
            this.Name = "SignInWindow";
            this.Text = "注册";
            this.signInTypeControl.ResumeLayout(false);
            this.userSignInPage.ResumeLayout(false);
            this.userSignInPage.PerformLayout();
            this.adminSignInPage.ResumeLayout(false);
            this.adminSignInPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUserCancel;
        private System.Windows.Forms.Button buttonUserConfirm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textDriLicsense;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textUserIdentity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textUserAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textUserRealName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textUserPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCheckPayPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPayPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCheckUserPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUserPwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox userGenderBox;
        private System.Windows.Forms.ComboBox adminGenderBox;
        private System.Windows.Forms.Button buttonAdminCancel;
        private System.Windows.Forms.Button buttonAdminConfirm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textAdminIdentity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textAdminAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textAdminRealName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textAdminPhone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textCheckContorlPwd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textControlPwd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textAdminCheckPwd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textAdminPwd;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textAdminName;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TabControl signInTypeControl;
        public System.Windows.Forms.TabPage userSignInPage;
        public System.Windows.Forms.TabPage adminSignInPage;
    }
}