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
    public partial class ReletCarForm : Form
    {
        CarInfo carInfo;
        RentalOrder order;
        CostRuleDal ruleDal = new CostRuleDal();
        RentalOrderDal orderDal = new RentalOrderDal();
        TimeSpan remainTime;
        public ReletCarForm(CarInfo car)
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
            cbRentalType.SelectedIndex = (int)order.OrderType;
            dtEndTime.Value = order.EndTime;
            dtNewEndTime.Value = order.EndTime.AddHours(1);
            dtActualTime.Value = order.EndTime.AddHours(1);
            remainTime = order.EndTime - DateTime.Now;
        }

        private void ReletCarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbPayPwd.Text != StaticData.userLocal.UserPayPwd)
            {
                MessageBox.Show("支付密码错误");
                return;
            }
            decimal cost = CalculateCost();
            if (StaticData.userLocal.RemainMoney < cost)
            {
                MessageBox.Show("余额不足!");
                return;
            }
            order.EndTime = dtActualTime.Value;
            order.ActualTime = (int)(dtActualTime.Value - order.StartTime).TotalSeconds;
            order.Status = RentalOrder.OrderStatus.租借中;
            order.OrderCost += cost;

            if (!orderDal.UpdateOrder(order))
            {
                MessageBox.Show("续租失败");
                return;
            }
            else
            {
                StaticData.userLocal.RemainMoney -= cost;
                new UserDal().UpdateUser(StaticData.userLocal);
                carInfo.Status = CarInfo.CarStatus.借出;
                new CarDal().CarUpdate(carInfo);
                new ShowRentalOrder(order).ShowDialog();
                this.Close();
            }
        }

        private decimal CalculateCost()
        {
            if (cbRentalType.Text == "")
            {
                return 0;
            }
            CostRule costRule = ruleDal.RuleSelectByUserLevel(StaticData.userLocal.UserLevel);
            decimal totalCost = 0;
            if (costRule == null)
            {
                lbTotal.Text = "总计费用: " + "计算费用错误!";
            }
            if (cbRentalType.Text == "时租")
            {
                var timespan = dtNewEndTime.Value - dtEndTime.Value;
                decimal hours = Convert.ToDecimal(timespan.TotalHours);
                hours = Math.Ceiling(hours);
                totalCost = hours * costRule.HourCost;
                lbTotal.Text = "总计费用: " + (hours * costRule.HourCost).ToString("C");
                dtActualTime.Value = dtEndTime.Value.AddHours((double)hours);
            }
            if (cbRentalType.Text == "日租")
            {
                var timespan = dtNewEndTime.Value - dtEndTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                days = Math.Ceiling(days);
                totalCost = days * costRule.DayCost;
                lbTotal.Text = "总计费用: " + (days * costRule.DayCost).ToString("C");
                dtActualTime.Value = dtEndTime.Value.AddDays((double)days);
            }
            if (cbRentalType.Text == "周租")
            {
                var timespan = dtNewEndTime.Value - dtEndTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal weeks = days / 7;
                weeks = Math.Ceiling(weeks);
                totalCost = weeks * costRule.WeekCost;
                lbTotal.Text = "总计费用: " + (weeks * costRule.WeekCost).ToString("C");
                dtActualTime.Value = dtEndTime.Value.AddDays((double)(weeks * 7));
            }
            if (cbRentalType.Text == "月租")
            {
                var timespan = dtNewEndTime.Value - dtEndTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal months = days / 30;
                months = Math.Ceiling(months);
                totalCost = months * costRule.MonthCost;
                lbTotal.Text = "总计费用: " + (months * costRule.MonthCost).ToString("C");
                dtActualTime.Value = dtEndTime.Value.AddMonths((int)months);
            }
            if (cbRentalType.Text == "季租")
            {
                var timespan = dtNewEndTime.Value - dtEndTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal months = days / 30;
                decimal seasons = months / 3;
                seasons = Math.Ceiling(seasons);
                totalCost = seasons * costRule.SeasonCost;
                lbTotal.Text = "总计费用: " + (seasons * costRule.SeasonCost).ToString("C");
                dtActualTime.Value = dtEndTime.Value.AddMonths((int)(seasons * 3));
            }
            if (cbRentalType.Text == "年租")
            {
                var timespan = dtNewEndTime.Value - dtEndTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal years = days / 365;
                years = Math.Ceiling(years);
                totalCost = years * costRule.YearCost;
                lbTotal.Text = "总计费用: " + (years * costRule.YearCost).ToString("C");
                dtActualTime.Value = dtEndTime.Value.AddYears((int)years);
            }
            return totalCost;
        }

        private void dtNewEndTime_ValueChanged(object sender, EventArgs e)
        {
            var timespan = dtNewEndTime.Value - dtEndTime.Value;
            if (timespan.TotalHours < 1)
            {
                dtEndTime.Value = dtEndTime.Value.AddHours(1);
            }
            CalculateCost();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
