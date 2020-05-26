using System;
using System.Collections.Generic;
using System.Text;
using DayOffTheWeekApp.Core;
using DayOffTheWeekApp.Core.Enums;

namespace DayOffTheWeek
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOdBirth { get; set; }

        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApplication()
        {
            Console.WriteLine("Hey, potrafię wyliczyć dzień tygodnia na podstawie Twojej daty urodzenia. ");
            Calculator = new DayCalculator();
        }

        public void AskUserForTheirDateOfBirth()
        {
           Console.WriteLine("Podaj datę urodzenia");
           var userDate = Console.ReadLine();

           var succeded = DateTimeOffset.TryParse(userDate, out var date );

            if (succeded)
            {
                UserDateOdBirth = date;
                return;
            }

            Console.WriteLine("Błędny format daty. Prawidłowy to dd/mm/yyyy");
            AskUserForTheirDateOfBirth();


        }

        public void CalculateDayOfTheWeek()
        {
            if(UserDateOdBirth == null)
            {
                Console.WriteLine("starano się obliczyć dzień tygodnia bez podania daty urodzenia");
            }

            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOdBirth);

        }

        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to: "+ UserDayOfTheWeek);
        }

    }
}
