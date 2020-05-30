using CRSCOMMON;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRSBLL
{
    public class AdminDal
    {
        DataTable dt;
        public AdminDal()
        {

        }

        public bool IsExistAdmin(string name)
        {
            try
            {
                string sql = "ADMIN_SELECT_BY_NAME";
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@NAME", name)
                };
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, param))
                {
                    dt.Load(dr);
                }
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

        public int CountAdmin()
        {
            try
            {
                string sql = "SELECT * FROM ADMIN_INFO";
                //SqlParameter[] param = new SqlParameter[]
                //{
                //    new SqlParameter("@NAME", name)
                //};
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql))
                {
                    dt.Load(dr);
                }
                return dt.Rows.Count;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
