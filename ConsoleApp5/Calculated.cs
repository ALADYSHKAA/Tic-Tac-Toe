using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    static class Calculated
    {
        public static bool CheckOfNumber(short choose)
        {
            if (choose == 1)
                return true;
            else if (choose == 2) 
                return false;
            else
                throw new ArgumentException("Invalid type of the game, please enter 1 or 2");
        }

        public static void CheckOfAttemps(short attemps)
        {
            if (attemps >= 2 && attemps <= 15)
                return;
            else
                throw new ArgumentException("Invalid count of attemps");
        }

        public static void CheckHiddenNumber(int hiddenNumber, int maxLimitNumber)
        {
            if (hiddenNumber > 0 && hiddenNumber <= maxLimitNumber)
                return;
            else
                throw new ArgumentException("The Hidden Number is not included in the specified parameters ");
        }

        public static int GuessTheNumber(int maxValue)
        {
            Random random = new Random();
            int value = random.Next(0, maxValue);
            return value;
        }
       public static void FindByMen(int hiddenNumber, int maxValue, int countOfAttemps)
        {
            Console.WriteLine("Please enter a number:");
            for (int i = 0; i<=countOfAttemps; i++)
            {
                int findNumber = int.Parse(Console.ReadLine());
                
                
                if(findNumber < hiddenNumber)
                {
                    Console.WriteLine("Hidden number is a more then your number");
                }
                else if(findNumber > hiddenNumber)
                {
                    Console.WriteLine("Hidden number is a less then your number");
                }
                else if(findNumber == hiddenNumber)
                {
                    Console.WriteLine("Great! your a won!!!");
                    Console.WriteLine($"Hidden number is a {hiddenNumber} you nedeed {countOfAttemps} attemps");
                }
                
            }
            Console.WriteLine($"Sorry you you didn't make it! Hidden number is a {hiddenNumber}");
        }
        public static void FindByComputer(int hiddenNumber, int maxValue, int countOfAttemps)
        {
            int lastGuess = -1;
            int minValue = 0;
            int maxValueInto = maxValue ;
            int tries = 0;

            while (lastGuess != hiddenNumber && tries != countOfAttemps)
            {
                lastGuess = (minValue + maxValueInto) / 2;
                Console.WriteLine($"The computer assumed that this is a number {lastGuess}");
                Console.WriteLine("If yes enter - 'y', if you number is greate enter - 'g' if less enter - 'l'");
                string answer = Console.ReadLine();
                if(answer == "y")
                {
                    Console.WriteLine("Yes, I am a SUPER");
                    break;
                }
                else if(answer == "g")
                {
                    minValue = lastGuess;
                }
                else 
                {
                    maxValueInto = lastGuess;
                }
                if (lastGuess == hiddenNumber)
                {
                    Console.WriteLine("Dont cheat MEN!");
                }
                tries++;
                    if(tries == countOfAttemps)
                {
                    Console.WriteLine("No tries anymore, i am lose :(");
                }
            }

            
        }
    }
}
