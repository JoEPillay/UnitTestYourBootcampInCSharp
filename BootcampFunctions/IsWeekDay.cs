using System;

namespace BootcampFunctions
{
    public class IsWeekDay
    {
        public static bool WhatDay(string day)
        {
            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                return true;     
            }
            return false;
        }
    }
}
