using CRSBLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class UserLogin : Form
    {
        AdminInfo adminInfo;
        UserInfo userInfo;
        AdminDal adminDal;
        LogDal logDal = new LogDal();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void adminSignUpButton_Click(object sender, EventArgs e)
        {
            //弹出注册窗口
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.signInTypeControl.SelectedIndex = 1;
            signInWindow.Show();
        }

        private void userSignUpButton_Click(object sender, EventArgs e)
        {
            //弹出注册窗口
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.signInTypeControl.SelectedIndex = 0;
            signInWindow.Show();
        }
        #region 管理员登录点击事件
        /// <summary>
        /// 管理员登录点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            if (adminNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名！", "登录提示");
                return;
            }
            else if(adminPwdTextBox.Text == "")
            {
                MessageBox.Show("请输入用户密码！", "登录提示");
                return;
            }
            adminInfo = new AdminInfo();
            adminInfo.AdminName = adminNameTextBox.Text.Trim();
            adminInfo.AdminPwd = adminPwdTextBox.Text;
            adminInfo = adminDal.SelectAdminByNameAndPwd(adminInfo);
            if (adminInfo != null)
            {
                this.Hide();
                LogInfo logInfo = new LogInfo();
                logInfo.AdminId = adminInfo.AdminId;
                logInfo.LogTime = DateTime.Now;
                logInfo.Content = "管理员" + adminInfo.AdminName + "登录了系统";
                bool b = logDal.LogInsert(logInfo);
                StaticData.adminLocal = adminInfo;
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "登录提示");
            }
        }
        #endregion
    }
}
