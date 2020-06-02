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
    public class LogDal
    {
        DataTable dt;
        public LogDal()
        {

        }

        #region 日志添加
        public bool LogInsert(LogInfo log)
        {
            int result;
            try
            {
                string sql = "LOG_INSERT";
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ADMINID",SqlDbType.Int),
                    new SqlParameter("@USERID",SqlDbType.Int),
                    new SqlParameter("@CONTENT",SqlDbType.VarChar,50),
                    new SqlParameter("@LOGTIME",SqlDbType.DateTime)

                };
                para[0].Value = log.AdminId;
                para[1].Value = log.UserId;
                para[2].Value = log.Content;
                para[3].Value = log.LogTime;
                result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion

        #region 根据LOGID获得日志

        #endregion

        #region 根据AdminId获得日志

        #endregion

        #region 根据UserId获得日志

        #endregion

        #region 获取所有日志

        #endregion
        #region 获取一段时间所有日志

        #endregion

    }
}
