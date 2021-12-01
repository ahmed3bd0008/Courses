using System;

namespace Core.Comman.ExtensionMethod
{
    public static class CalculatDateExtension{

        public static int claculateAgeExtention(this DateTime BirthDate)
        {
               var DateNow=DateTime.Today;
               var age=DateNow.Year-BirthDate.Year;
               if(DateNow<BirthDate.AddYears(age)) --age;
                return age;
        }
    }
}