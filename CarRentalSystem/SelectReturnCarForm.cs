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
    public partial class SelectReturnCarForm : Form
    {
        CarDal carDal = new CarDal();
        List<CarInfo> carInfos;
        private StoreDal storeDal = new StoreDal();

        public SelectReturnCarForm()
        {
            InitializeComponent();
            RefreshList();
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            carInfos = carDal.GetCarByUserId(StaticData.userLocal.UserId);
            if (carInfos != null)
            {
                Cursor = Cursors.WaitCursor;
                lvCarList.Items.Clear();
                lvCarList.BeginUpdate();
                for (int i = 0; i < carInfos.Count; i++)
                {
                    lvCarList.Items.Add("");
                    lvCarList.Items[i].SubItems.Add("");
                    lvCarList.Items[i].SubItems.Add("");
                    lvCarList.Items[i].SubItems.Add("");
                    lvCarList.Items[i].SubItems.Add("");
                    lvCarList.Items[i].SubItems.Add("");
                    //lvCarList.Items[i].SubItems.Add("");
                    lvCarList.Items[i].SubItems[1].Text = carInfos[i].StoreId.ToString();
                    lvCarList.Items[i].SubItems[2].Text = carInfos[i].CarPlateNumber;
                    lvCarList.Items[i].SubItems[3].Text = carInfos[i].CarType;
                    lvCarList.Items[i].SubItems[4].Text = carInfos[i].Color;
                    StoreInfo storeTemp = storeDal.StoreSelectById(carInfos[i].StoreId);
                    lvCarList.Items[i].SubItems[5].Text = storeTemp.StoreName;
                    lvCarList.Items[i].SubItems.Add(carInfos[i].Status.ToString());
                }
                lvCarList.EndUpdate();
                Cursor = Cursors.Default;
            }
        }

        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            if (lvCarList.SelectedItems.Count > 0)
            {
                int carID = Convert.ToInt32(lvCarList.SelectedItems[0].SubItems[1].Text);
                CarInfo carTemp = carDal.GetCarById(carID);
                new ReturnCarForm(carTemp).ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择要归还的车辆");
            }
        }
    }
}
