using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace CRSCOMMON
{
    public class OtherHelper
    {
        /// <summary>
        /// 获得本机物理地址
        /// </summary>
        /// <returns></returns>
        public string getMacAddrLocal()
        {
            string macAddr = null;
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc2 = mc.GetInstances();
            foreach (ManagementObject mo in moc2)
            {
                if (Convert.ToBoolean(mo["IPEnabled"]) == true)
                {
                    macAddr = mo["MacAddress"].ToString();
                    macAddr = macAddr.Replace(':', '-');
                }
                mo.Dispose();
            }
            Console.WriteLine(macAddr);
            if (macAddr != null)
            {
                return macAddr.ToUpper();
            }
            else
            {
                return "00-00-00-00-00-00";
            }
        }
    }
}
