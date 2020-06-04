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
    public partial class AddStoreFrom : Form
    {
        StoreDal storeDal = new StoreDal();
        public AddStoreFrom()
        {
            InitializeComponent();
        }

        private void buttoncomfirm_Click(object sender, EventArgs e)
        {
            if (textStoreName.Text.Trim() == "")
            {
                MessageBox.Show("请填写店铺名称");
                return;
            }
            if (textStoreAddress.Text.Trim() == "")
            {
                MessageBox.Show("请填写店铺地址");
                return;
            }
            StoreInfo storeInfo = new StoreInfo();
            storeInfo.StoreName = textStoreName.Text;
            storeInfo.StoreAddress = textStoreAddress.Text;
            if (!storeDal.StoreAdd(storeInfo))
            {
                MessageBox.Show("添加店铺失败！");
            }
            else
            {
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
