using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.extensions
{
    public static class DateTimeExtensions
    {

        public static int CalculateAge(this DateTime birthDate)
        {
            DateTime now = DateTime.Now;

            int age = now.Year - birthDate.Year;

            if (birthDate > now.AddYears(-age))
                age--;
            return age;
        }
    }
}
