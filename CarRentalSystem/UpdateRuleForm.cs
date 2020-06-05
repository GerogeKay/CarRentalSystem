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
    public partial class UpdateRuleForm : Form
    {
        CostRuleDal ruleDal = new CostRuleDal();
        CostRule rule;
        public UpdateRuleForm(CostRule ruleTemp)
        {
            InitializeComponent();
            rule = ruleTemp;
        }

        private void UpdateRuleFrom_Load(object sender, EventArgs e)
        {
            textUserLevel.Text = rule.UserLevel.ToString();
            textHourCost.Text = rule.HourCost.ToString();
            textDayCost.Text = rule.DayCost.ToString();
            textWeekCost.Text = rule.WeekCost.ToString();
            textMonthCost.Text = rule.MonthCost.ToString();
            textSeasonCost.Text = rule.SeasonCost.ToString();
            textYearCost.Text = rule.YearCost.ToString();
        }

        private void buttoncomfirm_Click(object sender, EventArgs e)
        {
            if (textUserLevel.Text.Trim() == "")
            {
                MessageBox.Show("请输入规则目标用户等级", "提示");
                return;
            }
            if (textHourCost.Text == "")
            {
                MessageBox.Show("请输入时租费用", "提示");
                return;
            }
            if (textDayCost.Text == "")
            {
                MessageBox.Show("请输入日租费用", "提示");
                return;
            }
            if (textWeekCost.Text == "")
            {
                MessageBox.Show("请输入周租费用", "提示");
                return;
            }
            if (textMonthCost.Text == "")
            {
                MessageBox.Show("请输入月租费用", "提示");
                return;
            }
            if (textSeasonCost.Text == "")
            {
                MessageBox.Show("请输入季租费用", "提示");
                return;
            }
            if (textYearCost.Text == "")
            {
                MessageBox.Show("请输入年租费用", "提示");
                return;
            }
            try
            {
                rule.UserLevel = int.Parse(textUserLevel.Text);
                rule.HourCost = decimal.Parse(textHourCost.Text);
                rule.DayCost = decimal.Parse(textDayCost.Text);
                rule.WeekCost = decimal.Parse(textWeekCost.Text);
                rule.MonthCost = decimal.Parse(textMonthCost.Text);
                rule.SeasonCost = decimal.Parse(textSeasonCost.Text);
                rule.YearCost = decimal.Parse(textYearCost.Text);
                ruleDal.UpdateRule(rule);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
