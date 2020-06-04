using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class CarInfo
    {
        public enum CarStatus
        {
            在库,
            借出,
            挂失,
        }
        // 车辆ID
        int carId;
        // 车牌号码
        string carPlateNumber;
        // 型号
        string carType;
        // 颜色
        string color;
        // 所在商店
        int storeId;
        // 目前借用者
        int userId;
        // 车辆状态
        CarStatus status;
        bool isDelete;

        public int CarId { get => carId; set => carId = value; }
        public string CarPlateNumber { get => carPlateNumber; set => carPlateNumber = value; }
        public int StoreId { get => storeId; set => storeId = value; }
        public int UserId { get => userId; set => userId = value; }
        public CarStatus Status { get => status; set => status = value; }
        public string CarType { get => carType; set => carType = value; }
        public string Color { get => color; set => color = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
    }
}
