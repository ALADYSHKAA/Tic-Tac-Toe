using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Please select the maximum limit for the reference number");
            int maxValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select of a type game");
            Console.WriteLine("If you want to play with a men, please enter 1, or you want to play with a Robot, plese enter 2");
            short choose = short.Parse(Console.ReadLine());
            bool menOrComputer = Calculated.CheckOfNumber(choose);
            Console.WriteLine("Please enter a count of attemps between 2 and 15 ");
            short countOfAttemps = short.Parse(Console.ReadLine());
            Calculated.CheckOfAttemps(countOfAttemps);

            int hiddenNumber = 0;
            if (menOrComputer == true)
            {
                Console.WriteLine("Please, hide the number");
                 hiddenNumber = int.Parse(Console.ReadLine());
                Calculated.CheckHiddenNumber(hiddenNumber, maxValue);
            }
            else
            {
                hiddenNumber = Calculated.GuessTheNumber(maxValue);
                Calculated.CheckHiddenNumber(hiddenNumber, maxValue);
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
          
           
            Console.WriteLine($"The number is hidden in the range between 0 and {maxValue} you have a {countOfAttemps} ,attemps enter a number there:");
            if (menOrComputer == false)
            {
                Calculated.FindByMen(hiddenNumber, maxValue, countOfAttemps);
            }
            else
            {
                Calculated.FindByComputer(hiddenNumber, maxValue, countOfAttemps);
            }

        }
       
    }
}
