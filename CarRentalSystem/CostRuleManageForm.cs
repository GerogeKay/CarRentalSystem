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
    public partial class CostRuleManageForm : Form
    {
        CostRuleDal costRuleDal = new CostRuleDal();
        public CostRuleManageForm()
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
            lvRuleList.Items.Clear();
            lvRuleList.BeginUpdate();
            List<CostRule> rules = costRuleDal.GetRuleList();
            for (int i = 0; i < rules.Count; i++)
            {
                lvRuleList.Items.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems.Add("");
                lvRuleList.Items[i].SubItems[1].Text = rules[i].UserLevel.ToString();
                lvRuleList.Items[i].SubItems[2].Text = rules[i].HourCost.ToString("C");
                lvRuleList.Items[i].SubItems[3].Text = rules[i].DayCost.ToString("C");
                lvRuleList.Items[i].SubItems[4].Text = rules[i].WeekCost.ToString("C");
                lvRuleList.Items[i].SubItems[5].Text = rules[i].MonthCost.ToString("C");
                lvRuleList.Items[i].SubItems[6].Text = rules[i].SeasonCost.ToString("C");
                lvRuleList.Items[i].SubItems[7].Text = rules[i].YearCost.ToString("C");

            }
            lvRuleList.EndUpdate();
            Cursor = Cursors.Default;
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            AddRuleForm addRuleForm = new AddRuleForm();
            addRuleForm.ShowDialog();
        }

        private void btnUpdateRule_Click(object sender, EventArgs e)
        {
            if (lvRuleList.SelectedItems.Count > 0)
            {
                int UserLevel = Convert.ToInt32(lvRuleList.SelectedItems[0].SubItems[1].Text);
                CostRule ruleTemp = costRuleDal.RuleSelectByUserLevel(UserLevel);
                UpdateRuleForm updateRuleForm = new UpdateRuleForm(ruleTemp);
                updateRuleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择要修改的规则");
            }
        }

        private void CostRuleManageForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void CostRuleManageForm_Activated(object sender, EventArgs e)
        {
            RefreshList();
        }
    }
}
