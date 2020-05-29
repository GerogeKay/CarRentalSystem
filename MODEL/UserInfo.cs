using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    class UserInfo
    {
        public enum GenderEnum
        {
            Privacy,
            Male,
            Female,
            Trans,
        }
        // 用户ID
        private int userId;
        // 用户名称
        private string userName;
        // 用户密码
        private string userPwd;
        // 用户支付密码
        private string userPayPwd;
        // 用户电话
        private string userPhone;
        // 用户身份证
        private string userIdentity;
        // 用户地址
        private string userAddress;
        // 用户驾照
        private string userDriLicense;
        // 性别
        private GenderEnum gender;
        // 用户头像
        private byte[] userPhoto;
        // 用户余额
        private decimal remainMoney;
        // 是否已被删除
        private bool isDelete;

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserPwd { get => userPwd; set => userPwd = value; }
        public string UserPhone { get => userPhone; set => userPhone = value; }
        public string UserIdentity { get => userIdentity; set => userIdentity = value; }
        public byte[] UserPhoto { get => userPhoto; set => userPhoto = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public string UserPayPwd { get => userPayPwd; set => userPayPwd = value; }
        public string UserDriLicense { get => userDriLicense; set => userDriLicense = value; }
        public decimal RemainMoney { get => remainMoney; set => remainMoney = value; }
        public string UserAddress { get => userAddress; set => userAddress = value; }
    }
}
