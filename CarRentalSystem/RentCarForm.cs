using CRSBLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class RentCarForm : Form
    {
        CarInfo carInfo;
        CostRuleDal ruleDal = new CostRuleDal();
        RentalOrderDal orderDal = new RentalOrderDal();
        public RentCarForm(CarInfo car)
        {
            InitializeComponent();
            carInfo = car;
            dtStartTime.Value = DateTime.Now.AddMinutes(10);
            dtEndTime.Value = dtStartTime.Value.AddHours(1);
            timer1.Enabled = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbRentalType.Text == "")
            {
                MessageBox.Show("请选择租借类型");
                return;
            }
            if(dtStartTime.Value < DateTime.Now)
            {
                MessageBox.Show("开始时间不能早于目前时间");
                return;
            }
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
            RentalOrder order = new RentalOrder();
            order.UserID = StaticData.userLocal.UserId;
            order.StoreID = StaticData.storeLocal.StoreId;
            order.CarID = carInfo.CarId;
            order.StartTime = dtStartTime.Value;
            order.EndTime = dtActualTime.Value;
            order.ActualTime = (int)(dtActualTime.Value - dtStartTime.Value).TotalSeconds;
            order.Status = RentalOrder.OrderStatus.租借中;
            order.OrderType = (RentalOrder.RentalType)cbRentalType.SelectedIndex;
            order.UserLevel = StaticData.userLocal.UserLevel;
            order.OrderCost = cost;

            if (!orderDal.MakeOrder(order))
            {
                MessageBox.Show("租车失败");
                return;
            }
            else
            {
                StaticData.userLocal.RemainMoney -= cost;
                new UserDal().UpdateUser(StaticData.userLocal);
                carInfo.Status = CarInfo.CarStatus.借出;
                carInfo.UserId = order.UserID;
                new CarDal().CarUpdate(carInfo);
                new ShowRentalOrder(order).ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtStartTime_ValueChanged(object sender, EventArgs e)
        {
            var timespan = dtEndTime.Value - dtStartTime.Value;
            if(timespan.TotalHours < 1)
            {
                dtEndTime.Value = dtStartTime.Value.AddHours(1);
            }
            CalculateCost();
        }

        private void dtEndTime_ValueChanged(object sender, EventArgs e)
        {
            var timespan = dtEndTime.Value - dtStartTime.Value;
            if (timespan.TotalHours < 1)
            {
                dtEndTime.Value = dtStartTime.Value.AddHours(1);
            }
            CalculateCost();
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
                var timespan = dtEndTime.Value - dtStartTime.Value;
                decimal hours = Convert.ToDecimal(timespan.TotalHours);
                hours = Math.Ceiling(hours);
                totalCost = hours * costRule.HourCost;
                lbTotal.Text = "总计费用: " + (hours*costRule.HourCost).ToString("C");
                dtActualTime.Value = dtStartTime.Value.AddHours((double)hours);
            }
            if (cbRentalType.Text == "日租")
            {
                var timespan = dtEndTime.Value - dtStartTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                days = Math.Ceiling(days);
                totalCost = days * costRule.DayCost;
                lbTotal.Text = "总计费用: " + (days * costRule.DayCost).ToString("C");
                dtActualTime.Value = dtStartTime.Value.AddDays((double)days);
            }
            if (cbRentalType.Text == "周租")
            {
                var timespan = dtEndTime.Value - dtStartTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal weeks = days / 7;
                weeks = Math.Ceiling(weeks);
                totalCost = weeks * costRule.WeekCost;
                lbTotal.Text = "总计费用: " + (weeks * costRule.WeekCost).ToString("C");
                dtActualTime.Value = dtStartTime.Value.AddDays((double)(weeks * 7));
            }
            if (cbRentalType.Text == "月租")
            {
                var timespan = dtEndTime.Value - dtStartTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal months = days / 30;
                months = Math.Ceiling(months);
                totalCost = months * costRule.MonthCost;
                lbTotal.Text = "总计费用: " + (months * costRule.MonthCost).ToString("C");
                dtActualTime.Value = dtStartTime.Value.AddMonths((int)months);
            }
            if (cbRentalType.Text == "季租")
            {
                var timespan = dtEndTime.Value - dtStartTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal months = days / 30;
                decimal seasons = months / 3;
                seasons = Math.Ceiling(seasons);
                totalCost = seasons * costRule.SeasonCost;
                lbTotal.Text = "总计费用: " + (seasons * costRule.SeasonCost).ToString("C");
                dtActualTime.Value = dtStartTime.Value.AddMonths((int)(seasons * 3));
            }
            if (cbRentalType.Text == "年租")
            {
                var timespan = dtEndTime.Value - dtStartTime.Value;
                decimal days = Convert.ToDecimal(timespan.TotalDays);
                decimal years = days / 365;
                years = Math.Ceiling(years);
                totalCost = years * costRule.YearCost;
                lbTotal.Text = "总计费用: " + (years * costRule.YearCost).ToString("C");
                dtActualTime.Value = dtStartTime.Value.AddYears((int)years);
            }
            return totalCost;
        }

        private void cbRentalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(cbRentalType.SelectedIndex);
            CalculateCost();
        }

        private void RentCarForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtStartTime.Value = DateTime.Now.AddMinutes(10);
        }
    }
}
