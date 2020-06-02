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
    public class AdminDal
    {
        DataTable dt;
        public AdminDal()
        {

        }
        #region 用户名是否已存在
        /// <summary>
        /// 用户名是否已存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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
        #endregion

        #region 查询管理员数量
        /// <summary>
        /// 返回当前数据库的管理员数量
        /// </summary>
        /// <returns></returns>
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
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.Text, sql))
                {
                    dt.Load(dr);
                }
                return dt.Rows.Count;
            }
            catch
            {
                return -1;
            }
        }
        #region 管理员登录
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="adminInfo"></param>
        /// <returns></returns>
        public AdminInfo SelectAdminByNameAndPwd(AdminInfo adminInfo)
        {
            string sql = "ADMIN_SELECT_BY_NAME_AND_PWD";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@NAME",SqlDbType.VarChar,50),
                    new SqlParameter("@PWD", SqlDbType.VarChar,50)
                };
                para[0].Value = adminInfo.AdminName;
                para[1].Value = adminInfo.AdminPwd;
                dt = new DataTable();
                using(SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    AdminInfo adminTemp = new AdminInfo();
                    adminTemp.AdminId = Convert.ToInt32(dt.Rows[0]["ID"]);
                    adminTemp.AdminName = Convert.ToString(dt.Rows[0]["NAME"]);
                    adminTemp.AdminPwd = Convert.ToString(dt.Rows[0]["PWD"]);
                    adminTemp.AdminControlPwd = Convert.ToString(dt.Rows[0]["CONTROLPWD"]);
                    adminTemp.AdminRealName = Convert.ToString(dt.Rows[0]["REALNAME"]);
                    adminTemp.AdminPhone = Convert.ToString(dt.Rows[0]["PHONE"]);
                    adminTemp.AdminAddress = Convert.ToString(dt.Rows[0]["ADDRESS"]);
                    adminTemp.AdminIdentity = Convert.ToString(dt.Rows[0]["IDENTITY"]);
                    adminTemp.Gender = (AdminInfo.GenderEnum)Convert.ToInt32(dt.Rows[0]["GENDER"]);
                    try
                    {
                        adminTemp.AdminPhoto = (byte[])dt.Rows[0]["PHOTO"];
                    }
                    catch (Exception)
                    {

                    }
                    return adminTemp;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 添加管理员信息
        /// <summary>
        /// 添加管理员信息
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool InsertAdmin(AdminInfo admin)
        {
            try
            {
                string sql = "ADMIN_ADD";
                SqlParameter[] para = new SqlParameter[]
               {
                   new SqlParameter("@NAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PWD",SqlDbType.VarChar,50),
                   new SqlParameter("@CONTROLPWD",SqlDbType.VarChar,50),
                   new SqlParameter("@REALNAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PHONE",SqlDbType.VarChar,50),
                   new SqlParameter("@ADDRESS",SqlDbType.VarChar,200),
                   new SqlParameter("@IDENTITY",SqlDbType.VarChar,50),
                   new SqlParameter("@GENDER",SqlDbType.TinyInt)
               };
                para[0].Value = admin.AdminName;
                para[1].Value = admin.AdminPwd;
                para[2].Value = admin.AdminControlPwd;
                para[3].Value = admin.AdminRealName;
                para[4].Value = admin.AdminPhone;
                para[5].Value = admin.AdminAddress;
                para[6].Value = admin.AdminIdentity;
                para[7].Value = (byte)admin.Gender;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region 更新管理员信息
        /// <summary>
        /// 更新管理员信息
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool UpdateAdmin(AdminInfo admin)
        {
            try
            {
                string sql = "ADMIN_UPDATE";
                SqlParameter[] para = new SqlParameter[]
               {
                   new SqlParameter("@ID",SqlDbType.Int),
                   new SqlParameter("@NAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PWD",SqlDbType.VarChar,50),
                   new SqlParameter("@CONTROLPWD",SqlDbType.VarChar,50),
                   new SqlParameter("@REALNAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PHONE",SqlDbType.VarChar,50),
                   new SqlParameter("@ADDRESS",SqlDbType.VarChar,200),
                   new SqlParameter("@IDENTITY",SqlDbType.VarChar,50),
                   new SqlParameter("@GENDER",SqlDbType.TinyInt),
                   new SqlParameter("@PHOTO",SqlDbType.Image)
               };
                para[0].Value = admin.AdminId;
                para[1].Value = admin.AdminName;
                para[2].Value = admin.AdminPwd;
                para[3].Value = admin.AdminControlPwd;
                para[4].Value = admin.AdminRealName;
                para[5].Value = admin.AdminPhone;
                para[6].Value = admin.AdminAddress;
                para[7].Value = admin.AdminIdentity;
                para[8].Value = (byte)admin.Gender;
                para[9].Value = admin.AdminPhoto;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion


    }
}
