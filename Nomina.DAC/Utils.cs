using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nomina.DAC
{
    public static class Utils
    {

        public static Object NullDate(this string s)
        {
            object dateTimeValue;
            var str = s;
            if (null != str) { str = str.Trim(); }

            if (string.IsNullOrEmpty(str) || DateTime.Parse(s) == DateTime.MinValue)
            {
                dateTimeValue = DBNull.Value;
            }
            else
            {
                dateTimeValue = DateTime.Parse(str);
            }

            return dateTimeValue;
        }
    }
}
