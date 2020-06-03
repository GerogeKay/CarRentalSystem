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
    public class UserDal
    {
        DataTable dt;
        public UserDal()
        {

        }
        #region 用户名是否已存在
        /// <summary>
        /// 用户名是否已存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsExistUser(string name)
        {
            try
            {
                string sql = "USER_SELECT_BY_NAME";
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@NAME", name)
                };
                para[0].Value = name;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        #endregion

        #region 查询用户数量
        /// <summary>
        /// 返回当前数据库的用户数量
        /// </summary>
        /// <returns></returns>
        public int CountUser()
        {
            try
            {
                string sql = "SELECT * FROM USER_INFO";
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
        #endregion
        #region 用户登录
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public UserInfo SelectUserByNameAndPwd(UserInfo userInfo)
        {
            string sql = "USER_SELECT_BY_NAME_AND_PWD";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@NAME",SqlDbType.VarChar,50),
                    new SqlParameter("@PWD", SqlDbType.VarChar,50)
                };
                para[0].Value = userInfo.UserName;
                para[1].Value = userInfo.UserPwd;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                else
                {
                    UserInfo userTemp = new UserInfo();
                    userTemp.UserId = Convert.ToInt32(dt.Rows[0]["ID"]);
                    userTemp.UserName = Convert.ToString(dt.Rows[0]["NAME"]);
                    userTemp.UserPwd = Convert.ToString(dt.Rows[0]["PWD"]);
                    userTemp.UserPayPwd = Convert.ToString(dt.Rows[0]["PAYPWD"]);
                    userTemp.UserRealName = Convert.ToString(dt.Rows[0]["REALNAME"]);
                    userTemp.UserPhone = Convert.ToString(dt.Rows[0]["PHONE"]);
                    userTemp.UserAddress = Convert.ToString(dt.Rows[0]["ADDRESS"]);
                    userTemp.UserIdentity = Convert.ToString(dt.Rows[0]["IDENTITY"]);
                    userTemp.Gender = (UserInfo.GenderEnum)Convert.ToInt32(dt.Rows[0]["GENDER"]);
                    userTemp.UserLevel = Convert.ToInt32(dt.Rows[0]["USERLEVEL"]);
                    userTemp.RemainMoney = Convert.ToDecimal(dt.Rows[0]["REMAINMONEY"]);
                    userTemp.UserDriLicense = Convert.ToString(dt.Rows[0]["DRILICENSE"]);

                    try
                    {
                        userTemp.UserPhoto = (byte[])dt.Rows[0]["PHOTO"];
                    }
                    catch (Exception)
                    {

                    }
                    return userTemp;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 添加用户信息
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool InsertUser(UserInfo user)
        {
            try
            {
                string sql = "USER_ADD";
                SqlParameter[] para = new SqlParameter[]
               {
                   new SqlParameter("@NAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PWD",SqlDbType.VarChar,50),
                   new SqlParameter("@PAYPWD",SqlDbType.VarChar,50),
                   new SqlParameter("@REALNAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PHONE",SqlDbType.VarChar,50),
                   new SqlParameter("@ADDRESS",SqlDbType.VarChar,200),
                   new SqlParameter("@IDENTITY",SqlDbType.VarChar,50),
                   new SqlParameter("@DRILICENSE",SqlDbType.VarChar,50),
                   new SqlParameter("@GENDER",SqlDbType.TinyInt)
               };
                para[0].Value = user.UserName;
                para[1].Value = user.UserPwd;
                para[2].Value = user.UserPayPwd;
                para[3].Value = user.UserRealName;
                para[4].Value = user.UserPhone;
                para[5].Value = user.UserAddress;
                para[6].Value = user.UserIdentity;
                para[7].Value = user.UserDriLicense;
                para[8].Value = (byte)user.Gender;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region 更新用户信息
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UpdateUser(UserInfo user)
        {
            try
            {
                string sql = "USER_UPDATE";
                SqlParameter[] para = new SqlParameter[]
               {
                   new SqlParameter("@ID",SqlDbType.Int),
                   new SqlParameter("@NAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PWD",SqlDbType.VarChar,50),
                   new SqlParameter("@PAYPWD",SqlDbType.VarChar,50),
                   new SqlParameter("@REALNAME",SqlDbType.VarChar,50),
                   new SqlParameter("@PHONE",SqlDbType.VarChar,50),
                   new SqlParameter("@ADDRESS",SqlDbType.VarChar,200),
                   new SqlParameter("@IDENTITY",SqlDbType.VarChar,50),
                   new SqlParameter("@DRILICENSE",SqlDbType.VarChar,50),
                   new SqlParameter("@GENDER",SqlDbType.TinyInt),
                   new SqlParameter("@REMAINMONEY",SqlDbType.Decimal),
                   new SqlParameter("@USERLEVEL",SqlDbType.Int),
                   new SqlParameter("@PHOTO",SqlDbType.Image)
               };
                para[0].Value = user.UserId;
                para[1].Value = user.UserName;
                para[2].Value = user.UserPwd;
                para[3].Value = user.UserPayPwd;
                para[4].Value = user.UserRealName;
                para[5].Value = user.UserPhone;
                para[6].Value = user.UserAddress;
                para[7].Value = user.UserIdentity;
                para[8].Value = user.UserDriLicense;
                para[9].Value = (byte)user.Gender;
                para[10].Value = user.RemainMoney;
                para[11].Value = user.UserLevel;
                para[12].Value = user.UserPhoto;
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
