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
    public partial class CarManageForm : Form
    {
        CarDal carDal = new CarDal();
        StoreDal storeDal = new StoreDal();
        UserDal userDal = new UserDal();

        public CarManageForm()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            addCarForm.ShowDialog();
        }
        /// <summary>
        /// 刷新列表
        /// </summary>
        private void RefreshList()
        {
            Cursor = Cursors.WaitCursor;
            lvCarList.Items.Clear();
            lvCarList.BeginUpdate();
            List<CarInfo> carInfos = new List<CarInfo>();
            if (cbSelectType.Text == "全部车辆")
            {
                carInfos = carDal.GetCarList();
            }
            else if (cbSelectType.Text == "当前店铺")
            {
                carInfos = carDal.GetCarByStoreId(StaticData.storeLocal.StoreId);
            }
            //else if (select_type == "当前用户")
            //{
            //    if (StaticData.userLocal != null)
            //    {
            //        carInfos = carDal.GetCarByUserId(StaticData.userLocal.UserId);
            //    }
            //}
            for (int i = 0; i < carInfos.Count; i++)
            {
                lvCarList.Items.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems.Add("");
                lvCarList.Items[i].SubItems[1].Text = carInfos[i].StoreId.ToString();
                lvCarList.Items[i].SubItems[2].Text = carInfos[i].CarPlateNumber;
                lvCarList.Items[i].SubItems[3].Text = carInfos[i].CarType;
                lvCarList.Items[i].SubItems[4].Text = carInfos[i].Color;
                StoreInfo storeTemp = storeDal.StoreSelectById(carInfos[i].StoreId);
                lvCarList.Items[i].SubItems[5].Text = storeTemp.StoreName;
                lvCarList.Items[i].SubItems[6].Text = carInfos[i].UserId.ToString();
                lvCarList.Items[i].SubItems[7].Text = carInfos[i].Status.ToString();

            }
            lvCarList.EndUpdate();
            Cursor = Cursors.Default;
        }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (lvCarList.SelectedItems.Count>0)
            {
                int carID = Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[1].Text);
                CarInfo carTemp = carDal.GetCarById(carID);
                UpdateCarForm updateCarForm = new UpdateCarForm(carTemp);
                updateCarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择要修改的车辆");
            }
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void cbSelectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
