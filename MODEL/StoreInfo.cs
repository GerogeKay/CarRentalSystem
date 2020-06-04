using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class StoreInfo
    {
        int storeId;
        string storeName;
        string storeAddress;
        bool isDelete;
        public int StoreId { get => storeId; set => storeId = value; }
        public string StoreName { get => storeName; set => storeName = value; }
        public string StoreAddress { get => storeAddress; set => storeAddress = value; }
        public bool IsDelete { get => isDelete; set => isDelete = value; }
    }
}
