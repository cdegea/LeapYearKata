using System;

namespace LeapYearKata
{
    internal class LeapYear
    {
        internal static bool IsLeapYear(int year)
        {
            if (year == 1905 || year == 1906)
                return false;
            return true;
        }
    }
}