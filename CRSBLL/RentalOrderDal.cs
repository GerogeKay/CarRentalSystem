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
    public class RentalOrderDal
    {
        DataTable dt;
        #region 创建订单
        public bool MakeOrder(RentalOrder order)
        {
            string sql = "MAKE_ORDER";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@USER_ID", SqlDbType.Int),
                    new SqlParameter("@CAR_ID", SqlDbType.Int),
                    new SqlParameter("@STORE_ID", SqlDbType.Int),
                    new SqlParameter("@USER_LEVEL", SqlDbType.Int),
                    new SqlParameter("@ORDER_TYPE", SqlDbType.Int),
                    new SqlParameter("@START_TIME", SqlDbType.DateTime),
                    new SqlParameter("@END_TIME", SqlDbType.DateTime),
                    new SqlParameter("@ACTUAL_TIME", SqlDbType.Int),
                    new SqlParameter("@ORDER_COST", SqlDbType.Decimal),
                    new SqlParameter("@ORDER_STATUS", SqlDbType.Decimal),
                };
                para[0].Value = order.UserID;
                para[1].Value = order.CarID;
                para[2].Value = order.StoreID;
                para[3].Value = order.UserLevel;
                para[4].Value = (int)order.OrderType;
                para[5].Value = order.StartTime;
                para[6].Value = order.EndTime;
                para[7].Value = order.ActualTime;
                para[8].Value = order.OrderCost;
                para[9].Value = (int)order.Status;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region 更改订单
        public bool UpdateOrder(RentalOrder order)
        {
            string sql = "UPDATE_ORDER";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@USER_ID", SqlDbType.Int),
                    new SqlParameter("@CAR_ID", SqlDbType.Int),
                    new SqlParameter("@STORE_ID", SqlDbType.Int),
                    new SqlParameter("@USER_LEVEL", SqlDbType.Int),
                    new SqlParameter("@ORDER_TYPE", SqlDbType.Int),
                    new SqlParameter("@START_TIME", SqlDbType.DateTime),
                    new SqlParameter("@END_TIME", SqlDbType.DateTime),
                    new SqlParameter("@ACTUAL_TIME", SqlDbType.Int),
                    new SqlParameter("@ORDER_COST", SqlDbType.Decimal),
                    new SqlParameter("@ORDER_STATUS", SqlDbType.Decimal),
                    new SqlParameter("@ID", SqlDbType.Int),
                };
                para[0].Value = order.UserID;
                para[1].Value = order.CarID;
                para[2].Value = order.StoreID;
                para[3].Value = order.UserLevel;
                para[4].Value = (int)order.OrderType;
                para[5].Value = order.StartTime;
                para[6].Value = order.EndTime;
                para[7].Value = order.ActualTime;
                para[8].Value = order.OrderCost;
                para[9].Value = (int)order.Status;
                para[10].Value = order.OrderID;
                int result = SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para);
                return result > 0 ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region 根据订单ID获取订单的信息
        public RentalOrder GetOrder(int id)
        {
            string sql = "GET_ORDERS_BY_ID";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@ID", id)
                };
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                RentalOrder order = new RentalOrder();
                order.UserID= Convert.ToInt32(dt.Rows[0]["USER_ID"]);
                order.CarID= Convert.ToInt32(dt.Rows[0]["CAR_ID"]);
                order.StoreID= Convert.ToInt32(dt.Rows[0]["STORE_ID"]);
                order.UserLevel= Convert.ToInt32(dt.Rows[0]["USER_LEVEL"]);
                order.OrderType= (RentalOrder.RentalType)Convert.ToInt32(dt.Rows[0]["ORDER_TYPE"]);
                order.StartTime= Convert.ToDateTime(dt.Rows[0]["START_TIME"]);
                order.EndTime= Convert.ToDateTime(dt.Rows[0]["END_TIME"]);
                order.ActualTime= Convert.ToInt32(dt.Rows[0]["ACTUAL_TIME"]);
                order.OrderCost= Convert.ToDecimal(dt.Rows[0]["ORDER_COST"]);
                order.Status= (RentalOrder.OrderStatus)Convert.ToInt32(dt.Rows[0]["ORDER_STATUS"]);
                order.OrderID= Convert.ToInt32(dt.Rows[0]["ID"]);
                return order;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 获取全部订单的信息
        public List<RentalOrder> GetAllOrders()
        {
            string sql = "GET_ORDERS";
            List<RentalOrder> orders = new List<RentalOrder>();
            try
            {
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RentalOrder order = new RentalOrder();
                    order.UserID= Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    order.CarID= Convert.ToInt32(dt.Rows[i]["CAR_ID"]);
                    order.StoreID= Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    order.UserLevel= Convert.ToInt32(dt.Rows[i]["USER_LEVEL"]);
                    order.OrderType= (RentalOrder.RentalType)Convert.ToInt32(dt.Rows[i]["ORDER_TYPE"]);
                    order.StartTime= Convert.ToDateTime(dt.Rows[i]["START_TIME"]);
                    order.EndTime= Convert.ToDateTime(dt.Rows[i]["END_TIME"]);
                    order.ActualTime= Convert.ToInt32(dt.Rows[i]["ACTUAL_TIME"]);
                    order.OrderCost= Convert.ToDecimal(dt.Rows[i]["ORDER_COST"]);
                    order.Status= (RentalOrder.OrderStatus)Convert.ToInt32(dt.Rows[i]["ORDER_STATUS"]);
                    order.OrderID= Convert.ToInt32(dt.Rows[i]["ID"]);
                    orders.Add(order);
                }
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 根据车辆获取订单的信息
        public List<RentalOrder> GetOrders(CarInfo car)
        {
            string sql = "GET_ORDERS_BY_CAR_ID";
            List<RentalOrder> orders = new List<RentalOrder>();
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@CAR_ID", SqlDbType.Int)
                };
                para[0].Value = car.CarId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RentalOrder order = new RentalOrder();
                    order.UserID= Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    order.CarID= Convert.ToInt32(dt.Rows[i]["CAR_ID"]);
                    order.StoreID= Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    order.UserLevel= Convert.ToInt32(dt.Rows[i]["USER_LEVEL"]);
                    order.OrderType= (RentalOrder.RentalType)Convert.ToInt32(dt.Rows[i]["ORDER_TYPE"]);
                    order.StartTime= Convert.ToDateTime(dt.Rows[i]["START_TIME"]);
                    order.EndTime= Convert.ToDateTime(dt.Rows[i]["END_TIME"]);
                    order.ActualTime= Convert.ToInt32(dt.Rows[i]["ACTUAL_TIME"]);
                    order.OrderCost= Convert.ToDecimal(dt.Rows[i]["ORDER_COST"]);
                    order.Status= (RentalOrder.OrderStatus)Convert.ToInt32(dt.Rows[i]["ORDER_STATUS"]);
                    order.OrderID= Convert.ToInt32(dt.Rows[i]["ID"]);
                    orders.Add(order);
                }
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 根据用户获取订单的信息
        public List<RentalOrder> GetOrders(UserInfo user)
        {
            string sql = "GET_ORDERS_BY_USER_ID";
            List<RentalOrder> orders = new List<RentalOrder>();
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@USER_ID", SqlDbType.Int)
                };
                para[0].Value = user.UserId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RentalOrder order = new RentalOrder();
                    order.UserID= Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    order.CarID= Convert.ToInt32(dt.Rows[i]["CAR_ID"]);
                    order.StoreID= Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    order.UserLevel= Convert.ToInt32(dt.Rows[i]["USER_LEVEL"]);
                    order.OrderType= (RentalOrder.RentalType)Convert.ToInt32(dt.Rows[i]["ORDER_TYPE"]);
                    order.StartTime= Convert.ToDateTime(dt.Rows[i]["START_TIME"]);
                    order.EndTime= Convert.ToDateTime(dt.Rows[i]["END_TIME"]);
                    order.ActualTime= Convert.ToInt32(dt.Rows[i]["ACTUAL_TIME"]);
                    order.OrderCost= Convert.ToDecimal(dt.Rows[i]["ORDER_COST"]);
                    order.Status= (RentalOrder.OrderStatus)Convert.ToInt32(dt.Rows[i]["ORDER_STATUS"]);
                    order.OrderID= Convert.ToInt32(dt.Rows[i]["ID"]);
                    orders.Add(order);
                }
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 根据店铺获取订单的信息
        public List<RentalOrder> GetOrders(StoreInfo store)
        {
            string sql = "GET_ORDERS_BY_STORE_ID";
            List<RentalOrder> orders = new List<RentalOrder>();
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@STORE_ID", SqlDbType.Int)
                };
                para[0].Value = store.StoreId;
                dt = new DataTable();
                using (SqlDataReader dr = SqlHelper.ExecuteReader(SqlHelper.ConnectionStringShop, CommandType.StoredProcedure, sql, para))
                {
                    dt.Load(dr);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    RentalOrder order = new RentalOrder();
                    order.UserID= Convert.ToInt32(dt.Rows[i]["USER_ID"]);
                    order.CarID= Convert.ToInt32(dt.Rows[i]["CAR_ID"]);
                    order.StoreID= Convert.ToInt32(dt.Rows[i]["STORE_ID"]);
                    order.UserLevel= Convert.ToInt32(dt.Rows[i]["USER_LEVEL"]);
                    order.OrderType= (RentalOrder.RentalType)Convert.ToInt32(dt.Rows[i]["ORDER_TYPE"]);
                    order.StartTime= Convert.ToDateTime(dt.Rows[i]["START_TIME"]);
                    order.EndTime= Convert.ToDateTime(dt.Rows[i]["END_TIME"]);
                    order.ActualTime= Convert.ToInt32(dt.Rows[i]["ACTUAL_TIME"]);
                    order.OrderCost= Convert.ToDecimal(dt.Rows[i]["ORDER_COST"]);
                    order.Status= (RentalOrder.OrderStatus)Convert.ToInt32(dt.Rows[i]["ORDER_STATUS"]);
                    order.OrderID= Convert.ToInt32(dt.Rows[i]["ID"]);
                    orders.Add(order);
                }
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
