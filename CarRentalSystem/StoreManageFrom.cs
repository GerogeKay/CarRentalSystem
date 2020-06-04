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
    public partial class StoreManageFrom : Form
    {
        StoreDal storeDal = new StoreDal();
        public StoreManageFrom()
        {
            InitializeComponent();
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            Cursor = Cursors.WaitCursor;
            lvStoreList.Items.Clear();
            lvStoreList.BeginUpdate();
            List<StoreInfo> storeInfos = storeDal.GetStoreList();
            for (int i = 0; i < storeInfos.Count; i++)
            {
                lvStoreList.Items.Add("");
                lvStoreList.Items[i].SubItems.Add("");
                lvStoreList.Items[i].SubItems.Add("");
                lvStoreList.Items[i].SubItems.Add("");
                lvStoreList.Items[i].SubItems[1].Text = storeInfos[i].StoreId.ToString();
                lvStoreList.Items[i].SubItems[2].Text = storeInfos[i].StoreName.ToString();
                lvStoreList.Items[i].SubItems[3].Text = storeInfos[i].StoreAddress.ToString();

            }
            lvStoreList.EndUpdate();
            Cursor = Cursors.Default;
        }

        private void buttonAddStore_Click(object sender, EventArgs e)
        {
            AddStoreFrom addStoreFrom = new AddStoreFrom();
            addStoreFrom.Show();
        }

        private void StoreManageFrom_Load(object sender, EventArgs e)
        {

        }

        private void StoreManageFrom_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void buttonUpdateStore_Click(object sender, EventArgs e)
        {
            if (lvStoreList.SelectedItems.Count>0)
            {
                int storeId = Convert.ToInt32(lvStoreList.SelectedItems[0].SubItems[1].Text);
                StoreInfo storeTemp = storeDal.StoreSelectById(storeId);
                UpdateStoreForm updateStoreForm = new UpdateStoreForm(storeTemp);
                updateStoreForm.Show();
            }
            else
            {
                MessageBox.Show("请先选择要修改的店铺");
            }
        }
    }
}
