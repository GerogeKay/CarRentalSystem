using CRSCOMMON;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRSBLL
{
    public class CostRuleDal
    {
        DataTable dt;
        #region 添加收费规则
        public bool AddCostRule(CostRule rule)
        {
            string sql = "ADD_COST_RULE";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@USER_LEVEL", SqlDbType.Int),
                    new SqlParameter("@HOUR_COST", SqlDbType.Decimal),
                    new SqlParameter("@DAY_COST", SqlDbType.Decimal),
                    new SqlParameter("@WEEK_COST", SqlDbType.Decimal),
                    new SqlParameter("@MONTH_COST", SqlDbType.Decimal),
                    new SqlParameter("@SEASON_COST", SqlDbType.Decimal),
                    new SqlParameter("@YEAR_COST", SqlDbType.Decimal),
                };
                para[0].Value = rule.UserLevel;
                para[1].Value = rule.HourCost;
                para[2].Value = rule.DayCost;
                para[3].Value = rule.WeekCost;
                para[4].Value = rule.MonthCost;
                para[5].Value = rule.SeasonCost;
                para[6].Value = rule.YearCost;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure,sql,para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        #region 更改收费规则
        public bool UpdateRule(CostRule rule)
        {
            string sql = "UPDATE_COST_RULE";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@USER_LEVEL", SqlDbType.Int),
                    new SqlParameter("@HOUR_COST", SqlDbType.Decimal),
                    new SqlParameter("@DAY_COST", SqlDbType.Decimal),
                    new SqlParameter("@WEEK_COST", SqlDbType.Decimal),
                    new SqlParameter("@MONTH_COST", SqlDbType.Decimal),
                    new SqlParameter("@SEASON_COST", SqlDbType.Decimal),
                    new SqlParameter("@YEAR_COST", SqlDbType.Decimal),
                };
                para[0].Value = rule.Id;
                para[1].Value = rule.UserLevel;
                para[2].Value = rule.HourCost;
                para[3].Value = rule.DayCost;
                para[4].Value = rule.WeekCost;
                para[5].Value = rule.MonthCost;
                para[6].Value = rule.SeasonCost;
                para[7].Value = rule.YearCost;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region 根据用户等级返回收费规则
        public CostRule RuleSelectByUserLevel(int userLevel)
        {
            string sql = "SELECT_COST_RULE_BY_USER_LEVEL";
            CostRule rule = new CostRule();
            try
            {
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql))
                {
                    dt.Load(dr);
                }
                rule.Id = Convert.ToInt32(dt.Rows[0]["ID"]);
                rule.UserLevel = Convert.ToInt32(dt.Rows[0]["USER_LEVEL"]);
                rule.HourCost = Convert.ToDecimal(dt.Rows[0]["HOUR_COST"]);
                rule.DayCost = Convert.ToDecimal(dt.Rows[0]["DAY_COST"]);
                rule.WeekCost = Convert.ToDecimal(dt.Rows[0]["WEEK_COST"]);
                rule.MonthCost = Convert.ToDecimal(dt.Rows[0]["MONTH_COST"]);
                rule.SeasonCost = Convert.ToDecimal(dt.Rows[0]["SEASON_COST"]);
                rule.YearCost = Convert.ToDecimal(dt.Rows[0]["YEAR_COST"]);
                return rule;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 获取全部收费规则的信息
        public List<CostRule> GetRuleList()
        {
            string sql = "GET_COST_RULE";
            List<CostRule> costRules = new List<CostRule>();
            try
            {
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CostRule rule = new CostRule();
                    rule.Id = Convert.ToInt32(dt.Rows[i]["ID"]);
                    rule.UserLevel = Convert.ToInt32(dt.Rows[i]["USER_LEVEL"]);
                    rule.HourCost = Convert.ToDecimal(dt.Rows[i]["HOUR_COST"]);
                    rule.DayCost = Convert.ToDecimal(dt.Rows[i]["DAY_COST"]);
                    rule.WeekCost = Convert.ToDecimal(dt.Rows[i]["WEEK_COST"]);
                    rule.MonthCost = Convert.ToDecimal(dt.Rows[i]["MONTH_COST"]);
                    rule.SeasonCost = Convert.ToDecimal(dt.Rows[i]["SEASON_COST"]);
                    rule.YearCost = Convert.ToDecimal(dt.Rows[i]["YEAR_COST"]);
                    costRules.Add(rule);
                }
                return costRules;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
