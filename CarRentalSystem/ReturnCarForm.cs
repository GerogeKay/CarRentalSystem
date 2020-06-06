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
    public partial class ReturnCarForm : Form
    {
        CarInfo carInfo;
        RentalOrder order;
        CostRuleDal ruleDal = new CostRuleDal();
        RentalOrderDal orderDal = new RentalOrderDal();
        TimeSpan remainTime;
        public ReturnCarForm(CarInfo car)
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
            lbOrderType.Text += " " + order.OrderType.ToString();
            dtStartTime.Value = order.StartTime;
            dtEndTime.Value = order.EndTime;
            remainTime = order.EndTime - DateTime.Now;
            lbRemainTime.Text += " " + remainTime.ToString(@"c");
            lbOrderStatus.Text += order.Status.ToString();
        }

        private void ReturnCarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPayPwd.Text != StaticData.userLocal.UserPayPwd)
            {
                MessageBox.Show("支付密码错误");
                return;
            }
            if (remainTime.TotalMinutes < -30)
            {
                decimal extraCost;
                CostRule costRule = ruleDal.RuleSelectByUserLevel(order.UserLevel);
                var hours = Convert.ToDecimal(remainTime.TotalHours);
                hours = Math.Ceiling(hours);
                extraCost = Math.Abs(hours * costRule.HourCost);
                MessageBox.Show("你已超时还车超过30分钟, 我们将按时租价格额外收取你:" + extraCost.ToString("c"));
                StaticData.userLocal.RemainMoney -= extraCost;
                new UserDal().UpdateUser(StaticData.userLocal);
                order.OrderCost += extraCost;
            }
            order.Status = RentalOrder.OrderStatus.已完成;
            
            orderDal.UpdateOrder(order);
            carInfo.Status = CarInfo.CarStatus.在库;
            carInfo.UserId = 0;
            new CarDal().CarUpdate(carInfo);
            MessageBox.Show("已还车");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
