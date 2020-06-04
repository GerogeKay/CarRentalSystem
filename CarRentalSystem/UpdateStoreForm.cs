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
    public partial class UpdateStoreForm : Form
    {
        StoreInfo store;
        StoreDal storeDal = new StoreDal();
        public UpdateStoreForm(StoreInfo storeInfo)
        {
            InitializeComponent();
            store = storeInfo;
            labelStoreID.Text = "店铺ID: " + store.StoreId;
            textStoreName.Text = store.StoreName;
            textStoreAddress.Text = store.StoreAddress;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textStoreName.Text.Trim() == "")
            {
                MessageBox.Show("店铺名称不能为空！");
                return;
            }
            if (textStoreAddress.Text.Trim() == "")
            {
                MessageBox.Show("店铺地址不能为空！");
                return;
            }
            store.StoreName = textStoreName.Text.Trim();
            store.StoreAddress = textStoreAddress.Text.Trim();
            if (storeDal.StoreUpdate(store))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("店铺信息更改失败！");
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
