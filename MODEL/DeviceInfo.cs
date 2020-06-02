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
        int dpId;
        // 设备Mac
        string deviceMac;
        // 所属商店
        string deviceStore;
        // 商店地址
        string deviceAddress;

        public int DeviceId { get => deviceId; set => deviceId = value; }
        public int DpId { get => dpId; set => dpId = value; }
        public string DeviceMac { get => deviceMac; set => deviceMac = value; }
        public string DeviceStore { get => deviceStore; set => deviceStore = value; }
        public string DeviceAddress { get => deviceAddress; set => deviceAddress = value; }
    }
}
