using System;
using System.Collections.Generic;
using System.Text;
using DayOffTheWeekApp.Core;

namespace DayOffTheWeek
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public void IntroduceTheApplication()
        {
            Console.WriteLine("Hey, potrafię wyliczyć dzień tygodnia na podstawie Twojej daty urodzenia. ");
        }

        public void AskUserForTheirDateOfBirth()
        {
            Console.WriteLine("Podaj datę urodzenia");
            var userDate = Console.ReadLine();
            

        }

        public void CalculateDayOfTheWeek()
        {

        }

        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to: "+ "test");
        }

    }
}
