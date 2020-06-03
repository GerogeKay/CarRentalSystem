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
    public class StoreDal
    {
        DataTable dt;
        #region 添加商店信息
        public bool StoreAdd(StoreInfo storeInfo)
        {
            string sql = "STORE_ADD";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@NAME", SqlDbType.VarChar,50),
                    new SqlParameter("@ADDRESS", SqlDbType.VarChar, 200)
                };
                para[0].Value = storeInfo.StoreName;
                para[1].Value = storeInfo.StoreAddress;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region 更新商店信息
        public bool StoreUpdate(StoreInfo storeInfo)
        {
            string sql = "STORE_UPDATE";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@NAME", SqlDbType.VarChar,50),
                    new SqlParameter("@ADDRESS", SqlDbType.VarChar, 200)
                };
                para[0].Value = storeInfo.StoreId;
                para[1].Value = storeInfo.StoreName;
                para[2].Value = storeInfo.StoreAddress;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region 根据ID查询商店信息
        public StoreInfo StoreSelectById(int storeId)
        {
            string sql = "STORE_SELECT_BY_ID";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.Int),
                };
                para[0].Value = storeId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop,CommandType.StoredProcedure, sql,para))
                {
                    dt.Load(dr);
                }
                StoreInfo storeTemp = new StoreInfo();
                storeTemp.StoreId = Convert.ToInt32( dt.Rows[0]["ID"]);
                storeTemp.StoreName = Convert.ToString( dt.Rows[0]["NAME"]);
                storeTemp.StoreAddress = Convert.ToString( dt.Rows[0]["ADDRESS"]);
                return storeTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
