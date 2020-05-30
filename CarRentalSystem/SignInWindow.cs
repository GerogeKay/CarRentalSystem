using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;

namespace CarRentalSystem
{
    public partial class SignInWindow : Form
    {
        UserInfo userInfo = new UserInfo();
        AdminInfo adminInfo = new AdminInfo();
        public SignInWindow()
        {
            InitializeComponent();
        }

        private void buttonUserConfirm_Click(object sender, EventArgs e)
        {
            if (textUserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！", "注册提示");
                return;
            }
            if (textUserPwd.Text == "")
            {
                MessageBox.Show("登录密码不能为空！", "注册提示");
                return;
            }
            if (textUserPwd.Text.Length < 6)
            {
                MessageBox.Show("登录密码长度至少为6位！", "注册提示");
                return;
            }
            if (textUserPwd.Text.Length > 25)
            {
                MessageBox.Show("登录密码长度最多为25位！", "注册提示");
                return;
            }
            if (textUserCheckPwd.Text != textUserPwd.Text)
            {
                MessageBox.Show("登录密码两次输入不一致！", "注册提示");
                return;
            }
            if (textPayPwd.Text == "")
            {
                MessageBox.Show("支付密码不能为空！", "注册提示");
                return;
            }
            if (textPayPwd.Text.Length < 6)
            {
                MessageBox.Show("支付密码长度至少为6位！", "注册提示");
                return;
            }
            if (textPayPwd.Text.Length > 25)
            {
                MessageBox.Show("支付密码长度最多为25位！", "注册提示");
                return;
            }
            if (textUserCheckPwd.Text != textUserPwd.Text)
            {
                MessageBox.Show("支付密码两次输入不一致！", "注册提示");
                return;
            }
            if (textUserPhone.Text == "")
            {
                MessageBox.Show("请输入电话号码", "注册提示");
                return;
            }
            if (!CheckPhone(textUserPhone.Text))
            {
                MessageBox.Show("非有效电话号码", "注册提示");
                return;
            }
            if (textUserRealName.Text.Trim() == "")
            {
                MessageBox.Show("请输入真实姓名", "注册提示");
                return;
            }
            if (!userGenderBox.Items.Contains(userGenderBox.Text))
            {
                MessageBox.Show("非有效性别", "注册提示");
                return;
            }
            if (textUserAddress.Text.Trim() == "")
            {
                MessageBox.Show("请输入家庭住址", "注册提示");
                return;
            }
            if (textUserIdentity.Text == "")
            {
                MessageBox.Show("请输入身份证号码", "注册提示");
                return;
            }
            if (!CheckCidInfo(textUserIdentity.Text.Trim()))
            {
                MessageBox.Show("非有效身份证", "注册提示");
                return;
            }
            if (textDriLicsense.Text.Trim() == "")
            {
                MessageBox.Show("请输入驾驶证号码", "注册提示");
                return;
            }
        }

        private void buttonAdminConfirm_Click(object sender, EventArgs e)
        {
            if (textAdminName.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空！", "注册提示");
                return;
            }
            if (textAdminPwd.Text == "")
            {
                MessageBox.Show("登录密码不能为空！", "注册提示");
                return;
            }
            if (textAdminPwd.Text.Length < 6)
            {
                MessageBox.Show("登录密码长度至少为6位！", "注册提示");
                return;
            }
            if (textAdminPwd.Text.Length > 25)
            {
                MessageBox.Show("登录密码长度最多为25位！", "注册提示");
                return;
            }
            if (textAdminCheckPwd.Text != textAdminPwd.Text)
            {
                MessageBox.Show("登录密码两次输入不一致！", "注册提示");
                return;
            }
            if (textControlPwd.Text == "")
            {
                MessageBox.Show("管理密码不能为空！", "注册提示");
                return;
            }
            if (textControlPwd.Text.Length < 6)
            {
                MessageBox.Show("管理密码长度至少为6位！", "注册提示");
                return;
            }
            if (textControlPwd.Text.Length > 25)
            {
                MessageBox.Show("管理密码长度最多为25位！", "注册提示");
                return;
            }
            if (textControlCheckPwd.Text != textControlPwd.Text)
            {
                MessageBox.Show("管理密码两次输入不一致！", "注册提示");
                return;
            }
            if (textAdminPhone.Text == "")
            {
                MessageBox.Show("请输入电话号码", "注册提示");
                return;
            }
            if (!CheckPhone(textAdminPhone.Text))
            {
                MessageBox.Show("非有效电话号码", "注册提示");
                return;
            }
            if (textAdminRealName.Text.Trim() == "")
            {
                MessageBox.Show("请输入真实姓名", "注册提示");
                return;
            }
            if (!adminGenderBox.Items.Contains(adminGenderBox.Text))
            {
                MessageBox.Show("非有效性别", "注册提示");
                return;
            }
            if (textAdminAddress.Text.Trim() == "")
            {
                MessageBox.Show("请输入家庭住址", "注册提示");
                return;
            }
            if (textAdminIdentity.Text == "")
            {
                MessageBox.Show("请输入身份证号码", "注册提示");
                return;
            }
            if (!CheckCidInfo(textAdminIdentity.Text.Trim()))
            {
                MessageBox.Show("非有效身份证", "注册提示");
                return;
            }
            
            this.Cursor = Cursors.WaitCursor;
            adminInfo.AdminName = textAdminName.Text.Trim();
            adminInfo.AdminPwd = textAdminPwd.Text;
            adminInfo.AdminControlPwd = textControlPwd.Text;
            adminInfo.AdminPhone = textAdminPhone.Text.Trim();
            adminInfo.AdminRealName = textAdminRealName.Text.Trim();
            //adminInfo.Gender = (AdminInfo.GenderEnum)Enum.Parse(typeof(AdminInfo.GenderEnum),adminGenderBox.Text);
            adminInfo.Gender = (AdminInfo.GenderEnum)adminGenderBox.SelectedIndex;
            adminInfo.AdminAddress = textAdminAddress.Text.Trim();
            adminInfo.AdminIdentity = textAdminIdentity.Text.Trim();
            // 录入管理员信息到数据库
            //b1 = userBLL.InsertUser(user);
            //bool b = new LogBLL().LogInsert(logInfo);
        }

        #region 验证手机号码
        public static bool CheckPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;
            return Regex.IsMatch(phone, @"^(13|14|15|16|17|18|19)\d{9}$");
        }
        #endregion

        #region 验证身份证号
        private bool CheckCidInfo(string cid)
        {
            string[] aCity = new string[] { null, null, null, null, null, null, null, null, null, null, null, "北京", "天津", "河北", "山西", "内蒙古", null, null, null, null, null, "辽宁", "吉林", "黑龙江", null, null, null, null, null, null, null, "上海", "江苏", "浙江", "安微", "福建", "江西", "山东", null, null, null, "河南", "湖北", "湖南", "广东", "广西", "海南", null, null, null, "重庆", "四川", "贵州", "云南", "西藏", null, null, null, null, null, null, "陕西", "甘肃", "青海", "宁夏", "新疆", null, null, null, null, null, "台湾", null, null, null, null, null, null, null, null, null, "香港", "澳门", null, null, null, null, null, null, null, null, "国外" };
            double iSum = 0;
            System.Text.RegularExpressions.Regex rg = new System.Text.RegularExpressions.Regex(@"^\d{17}(\d|X)$");
            System.Text.RegularExpressions.Match mc = rg.Match(cid);
            if (!mc.Success)
            {
                return false;
                //return "";
            }
            cid = cid.ToLower();
            cid = cid.Replace("x", "a");
            if (aCity[int.Parse(cid.Substring(0, 2))] == null)
            {
                return false;
                //return "非法地区";
            }
            try
            {
                DateTime.Parse(cid.Substring(6, 4) + "-" + cid.Substring(10, 2) + "-" + cid.Substring(12, 2));
            }
            catch
            {
                return false;
                //return "非法生日";
            }
            for (int i = 17; i >= 0; i--)
            {
                iSum += (System.Math.Pow(2, i) % 11) * int.Parse(cid[17 - i].ToString(), System.Globalization.NumberStyles.HexNumber);

            }
            if (iSum % 11 != 1)
                return false;
            //return ("非法证号");

            return true;
            //return (aCity[int.Parse(cid.Substring(0, 2))] + "," + cid.Substring(6, 4) + "-" + cid.Substring(10, 2) + "-" + cid.Substring(12, 2) + "," + (int.Parse(cid.Substring(16, 1)) % 2 == 1 ? "男" : "女"));

        }
        #endregion

        private void buttonAdminCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
