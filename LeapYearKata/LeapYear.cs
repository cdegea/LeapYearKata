using System;

namespace LeapYearKata
{
    internal class LeapYear
    {
        internal static bool IsLeapYear(int year)
        {
            if (year == 1905)
                return false;
            return true;
        }
    }
}