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
    public partial class AdminRechargeForm : Form
    {
        UserDal userDal = new UserDal();
        public AdminRechargeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入要充值的用户的用户名");
                return;
            }
            if (tbMoney.Text == "")
            {
                MessageBox.Show("请输入要充值的金额");
                return;
            }
            if (tbControlPwd.Text == "")
            {
                MessageBox.Show("请输入管理员控制密码");
                return;
            }
            if(tbControlPwd.Text != StaticData.adminLocal.AdminControlPwd)
            {
                MessageBox.Show("管理员控制密码错误");
                return;
            }
            UserInfo userTemp = userDal.SelectUserByName(tbUserName.Text.Trim());
            if (userTemp == null)
            {
                MessageBox.Show("用户不存在");
                return;
            }
            try
            {
                userTemp.RemainMoney += decimal.Parse(tbMoney.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "请输入正确数字格式");
                return;
            }
            if (!userDal.UpdateUser(userTemp))
            {
                MessageBox.Show("充值失败");
                return;
            }
            MessageBox.Show("充值成功");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
