using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class DeviceInfo
    {
        // 设备ID
        int deviceId;
        // 店铺ID
        int storeId;
        // 设备Mac
        string deviceMac;
        // 所属商店
        public DeviceInfo()
        {
            storeId = 0;
        }
        public int DeviceId { get => deviceId; set => deviceId = value; }
        public string DeviceMac { get => deviceMac; set => deviceMac = value; }
        public int StoreId { get => storeId; set => storeId = value; }
    }
}
