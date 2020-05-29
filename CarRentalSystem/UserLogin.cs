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
        public UserLogin()
        {
            InitializeComponent();
        }

        private void adminSignUpButton_Click(object sender, EventArgs e)
        {
            //让新管理员填写所需要的信息
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.signInTypeControl.SelectedIndex = 1;
            signInWindow.Show();
            //查询数据库管理员数量，如果没有管理员则直接注册，有管理员则要审核。
        }

        private void userSignUpButton_Click(object sender, EventArgs e)
        {
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.signInTypeControl.SelectedIndex = 0;
            signInWindow.Show();
        }
    }
}
