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
    public partial class LostCarForm : Form
    {
        CarInfo carInfo;
        RentalOrder order;
        CostRuleDal ruleDal = new CostRuleDal();
        RentalOrderDal orderDal = new RentalOrderDal();
        decimal LiquidatedDmg = 2000;
        public LostCarForm(CarInfo car)
        {
            InitializeComponent();
            carInfo = car;
            order = orderDal.GetOrder(car.CarId, RentalOrder.OrderStatus.租借中);
            if (order == null)
            {
                order = orderDal.GetOrder(car.CarId, RentalOrder.OrderStatus.到期未还);
            }
            if (order == null)
            {
                btnConfirm.Enabled = false;
                return;
            }
            lbCarID.Text += car.CarId;
            lbCarPlateNumber.Text += car.CarPlateNumber;
            lbCarType.Text += car.CarType;
            lbCarColor.Text += car.Color;
            lbCarStatus.Text += car.Status;
            lbLiquidatedDmg.Text += LiquidatedDmg.ToString("c");
        }

        private void LostCarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPayPwd.Text != StaticData.userLocal.UserPayPwd)
            {
                MessageBox.Show("支付密码错误");
                return;
            }
            var result = MessageBox.Show("你将要支付一笔违约金，请谨慎操作", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                order.EndTime = DateTime.Now;
                order.ActualTime = (int)(order.EndTime - order.StartTime).TotalSeconds;
                order.Status = RentalOrder.OrderStatus.已完成;
                order.OrderCost += LiquidatedDmg;
                if (!orderDal.UpdateOrder(order))
                {
                    MessageBox.Show("挂失失败");
                    return;
                }
                else
                {
                    StaticData.userLocal.RemainMoney -= LiquidatedDmg;
                    new UserDal().UpdateUser(StaticData.userLocal);
                    carInfo.Status = CarInfo.CarStatus.挂失;
                    carInfo.UserId = 0;
                    new CarDal().CarUpdate(carInfo);
                    new ShowRentalOrder(order).ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
