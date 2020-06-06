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
    public class CarDal
    {
        DataTable dt;
        #region 添加车辆信息
        public bool CarAdd(CarInfo carInfo)
        {
            string sql = "CAR_ADD";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@PLATENUMBER", SqlDbType.VarChar,20),
                    new SqlParameter("@TYPE", SqlDbType.VarChar, 50),
                    new SqlParameter("@COLOR", SqlDbType.VarChar, 20),
                    new SqlParameter("@STORE_ID", SqlDbType.Int),
                    new SqlParameter("@USER_ID", SqlDbType.Int),
                    new SqlParameter("@STATUS", SqlDbType.Int),
                };
                para[0].Value = carInfo.CarPlateNumber;
                para[1].Value = carInfo.CarType;
                para[2].Value = carInfo.Color;
                para[3].Value = carInfo.StoreId;
                para[4].Value = carInfo.UserId;
                para[5].Value = (int)carInfo.Status;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region 更新车辆信息
        public bool CarUpdate(CarInfo carInfo)
        {
            string sql = "CAR_UPDATE";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@PLATENUMBER", SqlDbType.VarChar,20),
                    new SqlParameter("@TYPE", SqlDbType.VarChar, 50),
                    new SqlParameter("@COLOR", SqlDbType.VarChar, 20),
                    new SqlParameter("@STORE_ID", SqlDbType.Int),
                    new SqlParameter("@USER_ID", SqlDbType.Int),
                    new SqlParameter("@STATUS", SqlDbType.Int),
                    new SqlParameter("@ID", SqlDbType.Int)
                };
                para[0].Value = carInfo.CarPlateNumber;
                para[1].Value = carInfo.CarType;
                para[2].Value = carInfo.Color;
                para[3].Value = carInfo.StoreId;
                para[4].Value = carInfo.UserId;
                para[5].Value = (int)carInfo.Status;
                para[6].Value = carInfo.CarId;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region 根据ID查询车辆信息
        public CarInfo CarSelectById(int carId)
        {
            string sql = "SELECT_CAR_BY_ID";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", SqlDbType.Int),
                };
                para[0].Value = carId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                CarInfo carTemp = new CarInfo();
                carTemp.CarId = Convert.ToInt32(dt.Rows[0]["ID"]);
                carTemp.CarPlateNumber = Convert.ToString(dt.Rows[0]["PLATENUMBER"]);
                carTemp.CarType = Convert.ToString(dt.Rows[0]["TYPE"]);
                carTemp.Color = Convert.ToString(dt.Rows[0]["COLOR"]);
                carTemp.StoreId = Convert.ToInt32(dt.Rows[0]["STORE_ID"]);
                carTemp.UserId = Convert.ToInt32(dt.Rows[0]["USER_ID"]);
                carTemp.Status = (CarInfo.CarStatus)Convert.ToInt32(dt.Rows[0]["STATUS"]);
                return carTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region 获取全部店铺的信息
        public List<CarInfo> GetCarList()
        {
            string sql = "SELECT * FROM CAR_INFO WHERE ISDELETE=0";
            List<CarInfo> carInfos = new List<CarInfo>();
            try
            {
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.Text, sql))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CarInfo carTemp = new CarInfo();
                    carTemp.CarId = Convert.ToInt32(dt.Rows[i]["ID"]);
                    carTemp.CarPlateNumber = Convert.ToString(dt.Rows[i]["PLATENUMBER"]);
                    carTemp.CarType = Convert.ToString(dt.Rows[i]["TYPE"]);
                    carTemp.Color = Convert.ToString(dt.Rows[i]["COLOR"]);
                    carTemp.StoreId = Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    carTemp.UserId = Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    carTemp.Status = (CarInfo.CarStatus)Convert.ToInt32(dt.Rows[i]["STATUS"]);
                    carInfos.Add(carTemp);
                }
                return carInfos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 根据店铺id获取车辆信息
        public List<CarInfo> GetCarByStoreId(int storeId)
        {
            string sql = "SELECT_CAR_BY_STORE_ID";
            List<CarInfo> carInfos = new List<CarInfo>();
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@STORE_ID", SqlDbType.Int),
                };
                para[0].Value = storeId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CarInfo carTemp = new CarInfo();
                    carTemp.CarId = Convert.ToInt32(dt.Rows[i]["ID"]);
                    carTemp.CarPlateNumber = Convert.ToString(dt.Rows[i]["PLATENUMBER"]);
                    carTemp.CarType = Convert.ToString(dt.Rows[i]["TYPE"]);
                    carTemp.Color = Convert.ToString(dt.Rows[i]["COLOR"]);
                    carTemp.StoreId = Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    carTemp.UserId = Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    carTemp.Status = (CarInfo.CarStatus)Convert.ToInt32(dt.Rows[i]["STATUS"]);
                    carInfos.Add(carTemp);
                }
                return carInfos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 根据用户Id获取车辆信息
        public List<CarInfo> GetCarByUserId(int userId)
        {
            string sql = "SELECT_CAR_BY_USER_ID";
            List<CarInfo> carInfos = new List<CarInfo>();
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@USER_ID", SqlDbType.Int),
                };
                para[0].Value = userId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CarInfo carTemp = new CarInfo();
                    carTemp.CarId = Convert.ToInt32(dt.Rows[i]["ID"]);
                    carTemp.CarPlateNumber = Convert.ToString(dt.Rows[i]["PLATENUMBER"]);
                    carTemp.CarType = Convert.ToString(dt.Rows[i]["TYPE"]);
                    carTemp.Color = Convert.ToString(dt.Rows[i]["COLOR"]);
                    carTemp.StoreId = Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    carTemp.UserId = Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    carTemp.Status = (CarInfo.CarStatus)Convert.ToInt32(dt.Rows[i]["STATUS"]);
                    carInfos.Add(carTemp);
                }
                return carInfos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region 根据店铺Id获取当前可用车辆信息
        public List<CarInfo> GetCarEnable(int storeId)
        {
            string sql = "SELECT_CAR_ENABLE";
            List<CarInfo> carInfos = new List<CarInfo>();
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@STORE_ID", SqlDbType.Int),
                };
                para[0].Value = storeId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    CarInfo carTemp = new CarInfo();
                    carTemp.CarId = Convert.ToInt32(dt.Rows[i]["ID"]);
                    carTemp.CarPlateNumber = Convert.ToString(dt.Rows[i]["PLATENUMBER"]);
                    carTemp.CarType = Convert.ToString(dt.Rows[i]["TYPE"]);
                    carTemp.Color = Convert.ToString(dt.Rows[i]["COLOR"]);
                    carTemp.StoreId = Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    carTemp.UserId = Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    carTemp.Status = (CarInfo.CarStatus)Convert.ToInt32(dt.Rows[i]["STATUS"]);
                    carInfos.Add(carTemp);
                }
                return carInfos;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
