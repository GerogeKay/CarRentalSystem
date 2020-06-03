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
        DataTable dt;
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

        #region 根据审核类型选择审核信息
        public List<AuditRequest> GetAuditRequests(string audit_type)
        {
            string sql = "SELECT_AUDIT_BY_TYPE";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@AUDIT_TYPE", SqlDbType.VarChar, 20)
                };
                para[0].Value = audit_type;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                List<AuditRequest> auditRequests = new List<AuditRequest>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    AuditRequest request = new AuditRequest();
                    request.AuditorId = Convert.ToInt32(dt.Rows[i]["AUDITOR_ID"]);
                    request.AuditType = dt.Rows[i]["AUDIT_TYPE"].ToString();
                    request.Content = dt.Rows[i]["CONTENT"].ToString();
                    request.Id = Convert.ToInt64(dt.Rows[i]["ID"]);
                    request.Check = Convert.ToBoolean(dt.Rows[i]["CHECKED"]);
                    request.IsPass = Convert.ToBoolean(dt.Rows[i]["IS_PASS"]);
                    auditRequests.Add(request);
                }
                return auditRequests;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public AuditRequest GetAuditRequestById(int auditId)
        {
            string sql = "SELECT_AUDIT_BY_ID";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.Int)
                };
                para[0].Value = auditId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                AuditRequest request = new AuditRequest();
                request.AuditorId = Convert.ToInt32(dt.Rows[0]["AUDITOR_ID"]);
                request.AuditType = dt.Rows[0]["AUDIT_TYPE"].ToString();
                request.Content = dt.Rows[0]["CONTENT"].ToString();
                request.Id = Convert.ToInt64(dt.Rows[0]["ID"]);
                request.Check = Convert.ToBoolean(dt.Rows[0]["CHECKED"]);
                request.IsPass = Convert.ToBoolean(dt.Rows[0]["IS_PASS"]);
                return request;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 审核处理
        public bool Audit_Check(AuditRequest request)
        {
            string sql = "AUDIT_CHECK";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.Int),
                    new SqlParameter("@AUDITOR_ID", SqlDbType.Int),
                    new SqlParameter("@IS_PASS", SqlDbType.Bit)
                };
                para[0].Value = request.Id;
                para[1].Value = request.AuditorId;
                para[2].Value = request.IsPass;
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
