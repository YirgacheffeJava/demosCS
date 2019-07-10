using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.services
{
    public class QueryAdressFromIP

    {
        private long IPToNumber(string ip)
        {
            try
            {
                char[] separator = new char[] { '.' };//定义分割数组
                string[] items = ip.Split(separator);//分割数组
                return (  long.Parse(items[0]) << 24 
                        | long.Parse(items[1]) <<16
                        | long.Parse(items[2])  <<8
                        | long.Parse(items[3]) );
            }
            catch
            {
                return 0;
            }
        }
    }
}