using CRSBLL;
using CRSCOMMON;
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
    public partial class MainForm : Form
    {
        OtherHelper otherHelper = new OtherHelper();
        DeviceDal deviceDal = new DeviceDal();
        StoreDal storeDal = new StoreDal();
        public MainForm()
        {
            InitializeComponent();
        }

        #region 窗体加载
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadDeviceAndStore();
            
            

        }
        #endregion

        
        /// <summary>
        /// 载入用户信息
        /// </summary>
        private void LoadUserInfo()
        {
            if (StaticData.adminLocal!=null)
            {
                UserIDLabel.Text = "用户ID:" + StaticData.adminLocal.AdminId;
                UserNameLabel.Text = "用户名:" + StaticData.adminLocal.AdminName;
                UserTypeLabel.Text = "用户类型:" + "管理员";
                Moneylabel.Text = "";
                AdminManageEnabled(true);
            }
            else if (StaticData.userLocal != null)
            {
                UserIDLabel.Text = "用户ID:" + StaticData.userLocal.UserId;
                UserNameLabel.Text = "用户名:" + StaticData.userLocal.UserName;
                UserTypeLabel.Text = "用户类型:" + "用户";
                Moneylabel.Text = "余额:"+ StaticData.userLocal.RemainMoney+"￥";
                AdminManageEnabled(false);
            }
        }
        void AdminManageEnabled(bool b)
        {
            审核列表ToolStripMenuItem.Enabled = b;
            审核列表ToolStripMenuItem.Visible = b;
            店铺信息管理ToolStripMenuItem.Enabled = b;
            店铺信息管理ToolStripMenuItem.Visible = b;
            车辆信息管理ToolStripMenuItem.Enabled = b;
            车辆信息管理ToolStripMenuItem.Visible = b;
        }
        /// <summary>
        /// 载入设备和店铺信息
        /// </summary>
        private void LoadDeviceAndStore()
        {
            DeviceInfo deviceInfo = new DeviceInfo();
            string localMac = otherHelper.getMacAddrLocal();
            deviceInfo.DeviceMac = localMac;
            DeviceIDLabel.Text = "设备号:" + localMac;
            // 查看数据库里有没有这个设备，没有则添加
            deviceInfo = deviceDal.SelectByMac(deviceInfo);
            if (deviceInfo == null)
            {
                // 插入新的设备信息
                deviceInfo = new DeviceInfo();
                deviceInfo.DeviceMac = localMac;
                bool b = deviceDal.InsertDevice(deviceInfo);
                if (!b)
                {
                    deviceInfo.DeviceId = 0;
                    deviceInfo.StoreId = 0;
                    MessageBox.Show("无法添加设备到数据库！", "警告");
                }
                else
                {
                    deviceInfo = deviceDal.SelectByMac(deviceInfo);
                }
            }
            StaticData.deviceLocal = deviceInfo;
            StoreInfo storeInfo;
            if (StaticData.deviceLocal.StoreId != 0)
            {
                storeInfo = storeDal.StoreSelectById(StaticData.deviceLocal.StoreId);
            }
            else
            {
                storeInfo = new StoreInfo();
                storeInfo.StoreName = "上海电机学院分店";
                storeInfo.StoreAddress = "上海浦东新区水华路300号";
            }
            StaticData.storeLocal = storeInfo;
            storeNameLabel.Text = "所属店铺:" + StaticData.storeLocal.StoreName;
            storeAddrLabel.Text = "店铺地址:" + StaticData.storeLocal.StoreAddress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 审核列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditListForm auditListForm = new AuditListForm();
            auditListForm.Show();
        }

        private void 日志信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 车辆信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 店铺信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoreManageFrom storeManageFrom = new StoreManageFrom();
            storeManageFrom.Show();
        }
    }
}
