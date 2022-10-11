using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar_events
{
    public static class DateTimeUtils
    {
        public static DateTime validateDate(string dateStr)
        {
            string[] validFormats = new[]
            {
            "dd/MM/yyyy","dd-MM-yyyy", "yyyy-MM-dd", "MM-dd-yyyy", "MM/dd/yyyy", "yyyy/MM/dd",
            "MM/dd/yyyy HH:mm:ss", "MM/dd/yyyy hh:mm tt", "yyyy-MM-dd HH:mm:ss, fff"
        };

            CultureInfo culture = new CultureInfo("pt-BR");
            DateTime validDate = DateTime.ParseExact(dateStr, validFormats, culture);
            return validDate;


        }
    }
}
