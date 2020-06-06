using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class RentalOrder
    {
        public enum RentalType
        {
            时租,日租,周租,月租,季租,年租
        }
        public enum OrderStatus
        {
            租借中,到期未还,已还,已完成
        }
        int orderID;
        int userID;
        int carID;
        int storeID;
        int userLevel;
        RentalType orderType;
        DateTime startTime;
        DateTime endTime;
        int actualTime;
        decimal orderCost;
        OrderStatus status;

        public int OrderID { get => orderID; set => orderID = value; }
        public int UserID { get => userID; set => userID = value; }
        public int CarID { get => carID; set => carID = value; }
        public int StoreID { get => storeID; set => storeID = value; }
        public int UserLevel { get => userLevel; set => userLevel = value; }
        public RentalType OrderType { get => orderType; set => orderType = value; }
        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public int ActualTime { get => actualTime; set => actualTime = value; }
        public decimal OrderCost { get => orderCost; set => orderCost = value; }
        public OrderStatus Status { get => status; set => status = value; }
    }
}
