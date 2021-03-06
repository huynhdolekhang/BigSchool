using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace B3_L4_HuynhDoLeKhang.ViewModels
{
    public class FutureDate
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/M/yyyy", 
            CultureInfo.CurrentCulture,
            DateTimeStyles.None,
            out dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}