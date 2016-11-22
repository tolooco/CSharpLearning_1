using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace IPInfo
{
    /// <summary>
    /// کلاس آی پی
    /// </summary>
    class IP
    {
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public IP()
        {

        }

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="localIp"></param>
        /// <param name="localName"></param>
        public IP(string localIp,string localName)
        {
            this.LocalIP = localIp;
            this.LocalName = LocalName;
        }

        /// <summary>
        /// سازنده با ورودی آی پی هاست
        /// </summary>
        /// <param name="ipHost"></param>
        public IP(IPHostEntry ipHost)
        {
            this.IPHost = ipHost;
        }

        /// <summary>
        /// پراپرتی آی پی هاست
        /// </summary>
        public IPHostEntry IPHost { get; set; }

        /// <summary>
        /// پراپرتی لوکال آی پی
        /// </summary>
        public string  LocalIP { get; set; }

        /// <summary>
        /// پراپرتی لوکال نیم
        /// </summary>
        public string  LocalName { get; set; }

        /// <summary>
        /// متد دریافت  هاست انتری
        /// </summary>
        /// <returns></returns>
        public IPHostEntry GetHostEntry()
        {
            return Dns.GetHostEntry(Dns.GetHostName());
        }


    }
}
