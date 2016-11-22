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
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //#################################################

            //Solution On Class IP

            //ایجاد یک شی از کلاس آی پی
            IP oIP =new IP ();
            
            //مقدار دهی پراپرتی های استرینگ کلاس
            oIP.LocalIP = string.Empty;
            oIP.LocalName = string.Empty;
            //مقدار دهی پراپرتی آی پی هاست با متد گت هاست انتری کلاس آی پی
            oIP.IPHost = oIP.GetHostEntry();

            //حلقه فورایچ که در آن به ازای تمامی آی پی آدرس های موجود در شبکه نام و هاست را برمیگرداند
            foreach (IPAddress IP in oIP.IPHost.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                {
                    oIP.LocalIP = IP.ToString();
                    oIP.LocalName = oIP.IPHost.HostName;
                }
            }

            //نمایش آی پی و هاست
            Console.WriteLine("IP Address = {0}\r\n Host Name = {1} ,", oIP.LocalIP,oIP.LocalName);
            Console.ReadKey();

            //End Solution On Class IP

            //#################################################

        }
    }
}
