using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using MySql.Data.MySqlClient;

namespace C969
{
    public static class User
    {

        public static string userName { get; set; }
        public static string password { get; set; }
        public static int userID { get; set; }


        public static string getUserTime()
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            DateTime currentDate = DateTime.Now;
            int currentYear = currentDate.Year;

            string userLocalZone = localZone.ToString();

            return userLocalZone;
        }
    }
}
