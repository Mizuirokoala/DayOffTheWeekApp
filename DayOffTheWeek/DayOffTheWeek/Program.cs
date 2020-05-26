using DayOffTheWeekApp.Core;
using System;

namespace DayOffTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {           
            var guesser = new DayGuesser();
            guesser.IntroduceTheApplication();
            guesser.AskUserForTheirDateOfBirth();
            guesser.CalculateDayOfTheWeek();
            guesser.PrintDayOfTheWeek();
        }
    }
}
