﻿using DayOffTheWeekApp.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayOffTheWeekApp.Core
{
    public static class EnumExtentions
    {

        public static string ToPolishString(this DayOfTheWeek dayOfTheWeek)
        {
            switch(dayOfTheWeek)
            {
                case DayOfTheWeek.Monday:
                    return "Poniedziałek";
                case DayOfTheWeek.Tuesday:
                    return "Wtorek";
                case DayOfTheWeek.Wednesday:
                    return "Środa";
                case DayOfTheWeek.Thursday:
                    return "Czwartek";
                case DayOfTheWeek.Friday:
                    return "Piątek";
                case DayOfTheWeek.Saturday:
                    return "Sobota";
                case DayOfTheWeek.Sunday:
                    return "Niedziela";

                default:
                    return "default";
            }
        }
    }
}
