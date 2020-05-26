using DayOffTheWeekApp.Core.Enums;
using System;
using System.Collections.Generic;

namespace DayOffTheWeekApp.Core
{
    public class DayCalculator
    {        
        public DayOfTheWeek CalculateDayOfTheWeek(DateTimeOffset data)
        {

            var day = data.Day;
            var month = data.Month;
            var year = data.Year;

                var listOfParameters = new List<int> { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
                year -= month < 3? 1: 0;
                var calculatedValue = (year + year / 4 - year / 100 + year / 400 + listOfParameters[month - 1] + day) % 7;
            //Console.WriteLine(calculatedValue);
            return (DayOfTheWeek)(calculatedValue - 1);
        }
    }
}
