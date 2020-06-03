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
    public class DeviceDal
    {
        DataTable dt;
        #region 根据mac地址获取设备信息
        public DeviceInfo SelectByMac(DeviceInfo deviceInfo)
        {
            string sql = "DEVICE_SELECT_BY_MAC";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@MAC", SqlDbType.VarChar, 50)
                };
                para[0].Value = deviceInfo.DeviceMac;
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
                    deviceInfo.DeviceId = Convert.ToInt32(dt.Rows[0]["ID"]);
                    deviceInfo.DeviceMac = Convert.ToString(dt.Rows[0]["MAC"]);
                    deviceInfo.StoreId = Convert.ToInt32(dt.Rows[0]["STORE_ID"]);
                    return deviceInfo;
                }
            }
            catch (Exception)
            {
                return null;
            }
           
        }
        #endregion

        #region 添加设备
        public bool InsertDevice(DeviceInfo deviceInfo)
        {
            string sql = "DEVICE_ADD";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@MAC", SqlDbType.VarChar, 50),
                    new SqlParameter("@STORE_ID", SqlDbType.Int)
                };
                para[0].Value = deviceInfo.DeviceMac;
                para[1].Value = deviceInfo.StoreId;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion

        #region 更新设备信息
        public bool UpdateDevice(DeviceInfo deviceInfo)
        {
            string sql = "DEVICE_UPDATE";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.VarChar, 50),
                    new SqlParameter("@STORE_ID", SqlDbType.Int)
                };
                para[0].Value = deviceInfo.DeviceId;
                para[1].Value = deviceInfo.StoreId;
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
