using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRSCOMMON;
using MODEL;

namespace CRSBLL
{
    /// <summary>
    /// 用来提交审核信息的数据库访问类
    /// </summary>
    public class AuditDal
    {
        #region 提交审核信息
        /// <summary>
        /// 提交审核信息
        /// </summary>
        /// <param name="auditRequest"></param>
        /// <returns></returns>
        public bool CommitRequest(AuditRequest auditRequest)
        {
            try
            {
                string sql = "AUDIT_COMMIT";
                SqlParameter[] para = new SqlParameter[]
               {
                   new SqlParameter("@AUDIT_TYPE",SqlDbType.VarChar,20),
                   new SqlParameter("@CONTENT",SqlDbType.NVarChar,4000),
                   new SqlParameter("@AUDITOR_ID",SqlDbType.Int),
                   new SqlParameter("@IS_PASS",SqlDbType.Bit),
                   new SqlParameter("@CHECKED",SqlDbType.Bit),
               };
                para[0].Value = auditRequest.AuditType;
                para[1].Value = auditRequest.Content;
                para[2].Value = auditRequest.AuditorId;
                para[3].Value = auditRequest.IsPass;
                para[4].Value = auditRequest.Check;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}
