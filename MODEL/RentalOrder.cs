using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class RentalOrder
    {
        enum RentalType
        {
            时租,日租,周租,月租,季租,年租
        }
        enum OrderStatus
        {
            预约,租借中,到期未还,已还,已完成
        }
        int orderID;
        int userID;
        int carID;
        int storeID;
        int userLevel;
        RentalType orderType;
        DateTime startTime;
        DateTime endTime;
        DateTime actualTime;
        decimal orderCost;
        OrderStatus status;

    }
}
