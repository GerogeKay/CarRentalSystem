using CRSBLL;
using MODEL;
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

namespace CarRentalSystem
{
    public partial class UpdateCarForm : Form
    {
        CarInfo carInfo;
        private List<StoreInfo> storeInfos;
        private StoreDal storeDal = new StoreDal();
        private CarDal carDal = new CarDal();
        public UpdateCarForm(CarInfo carTemp)
        {
            InitializeComponent();
            carInfo = carTemp;
        }

        private void UpdateCarForm_Load(object sender, EventArgs e)
        {
            labelCarID.Text = "车辆ID: " + carInfo.CarId;
            textPlateNumber.Text = carInfo.CarPlateNumber;
            textCarType.Text = carInfo.CarType;
            textCarColor.Text = carInfo.Color;
            storeInfos = storeDal.GetStoreList();
            cbStoreList.Items.Clear();
            foreach (var store in storeInfos)
            {
                cbStoreList.Items.Add(store.StoreName);
                if (store.StoreId==carInfo.StoreId)
                {
                    cbStoreList.Text = store.StoreName;
                }
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (textPlateNumber.Text.Trim() == "")
            {
                MessageBox.Show("车牌号不能为空！", "提示");
                return;
            }
            if (textCarType.Text == "")
            {
                MessageBox.Show("请输入车辆型号", "提示");
                return;
            }
            if (textCarColor.Text == "")
            {
                MessageBox.Show("请输入车辆颜色", "提示");
                return;
            }
            if (cbStoreList.Text == "")
            {
                MessageBox.Show("请选择店铺！", "提示");
                return;
            }
            if (!IsVehicleNumber(textPlateNumber.Text))
            {
                MessageBox.Show("车牌号非法！", "提示");
                return;
            }
            carInfo.CarPlateNumber = textPlateNumber.Text.Trim();
            carInfo.CarType = textCarType.Text.Trim();
            carInfo.Color = textCarColor.Text.Trim();
            foreach (var item in storeInfos)
            {
                if (cbStoreList.Text == item.StoreName)
                {
                    carInfo.StoreId = item.StoreId;
                    break;
                }
            }
            if (carDal.CarUpdate(carInfo))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("修改车辆信息失败", "提示");
                return;
            }
        }

        public static bool IsVehicleNumber(string vehicleNumber)
        {
            bool result = false; if (vehicleNumber.Length == 7)
            {
                string express = @"^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领A-Z]{1}[A-Z]{1}[A-Z0-9]{4}[A-Z0-9挂学警港澳]{1}$";
                result = Regex.IsMatch(vehicleNumber, express);
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
