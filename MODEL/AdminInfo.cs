using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class AdminInfo
    {
        public enum GenderEnum
        {
            保密,
            男,
            女,
            跨性别,
        }
        // 管理员ID
        private int adminId;
        // 管理员名称
        private string adminName;
        // 管理员密码
        private string adminPwd;
        // 管理员控制密码
        private string adminControlPwd;
        // 管理员真实姓名
        private string adminRealName;
        // 管理员电话
        private string adminPhone;
        // 管理员住址
        private string adminAddress;
        // 管理员身份证
        private string adminIdentity;
        // 性别
        private GenderEnum gender;
        // 管理员头像
        private byte[] adminPhoto;
        // 是否已被删除
        private bool isDelete;

        public int AdminId { get => adminId; set => adminId = value; }
        public string AdminName { get => adminName; set => adminName = value; }
        public string AdminPwd { get => adminPwd; set => adminPwd = value; }
        public string AdminControlPwd { get => adminControlPwd; set => adminControlPwd = value; }
        public string AdminPhone { get => adminPhone; set => adminPhone = value; }
        public string AdminIdentity { get => adminIdentity; set => adminIdentity = value; }
        public byte[] AdminPhoto { get => adminPhoto; set => adminPhoto = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
        public GenderEnum Gender { get => gender; set => gender = value; }
        public string AdminRealName { get => adminRealName; set => adminRealName = value; }
        public string AdminAddress { get => adminAddress; set => adminAddress = value; }
    }
}
