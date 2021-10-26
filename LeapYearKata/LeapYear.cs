﻿using System;

namespace LeapYearKata
{
    internal class LeapYear
    {
        internal static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                    return false;
                return true;
            }                
            return false;
        }
    }
}