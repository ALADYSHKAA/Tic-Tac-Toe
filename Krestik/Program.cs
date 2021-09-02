using System;
using System.Collections.Generic;

namespace Krestik
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] list = new string[3, 6];
            list[0, 1] = "0";
            list[0, 2] = "|";
            list[0, 3] = "1";
            list[0, 4] = "|";
            list[0, 5] = "2";
            list[1, 1] = "3";
            list[1, 2] = "|";
            list[1, 3] = "4";
            list[1, 4] = "|";
            list[1, 5] = "5";
            list[2, 1] = "6";
            list[2, 2] = "|";
            list[2, 3] = "7";
            list[2, 4] = "|";
            list[2, 5] = "8";
            List<int> listOfInts = new List<int>();
            listOfInts.Add(0);
            listOfInts.Add(1);
            listOfInts.Add(2);
            listOfInts.Add(3);
            listOfInts.Add(4);
            listOfInts.Add(5);
            listOfInts.Add(6);
            listOfInts.Add(7);
            listOfInts.Add(8);
            Igra igra = new Igra();
            Console.WriteLine($"Welcome to my Game! The first move is for a cross, there is a field in front of you,{Environment.NewLine} just choose the number where you want to put a cross or a zero "); ;
            igra.Draw(list);
            for(int i = 0; i<9; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (!listOfInts.Contains(number))
                {
                    i--;
                    Console.WriteLine("This value is already used");
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine("The move of the cross");
                    listOfInts = igra.CheckOfNumbers(listOfInts, number);
                    Console.Clear();
                    String[,] newArray = igra.Draw(list, number, "X");
                    bool isWin = igra.WinnerCombination(newArray);
                    if (isWin)
                    {
                        Console.WriteLine("Please enter a symbol in console, if you want to repeat the game");
                        Console.ReadLine();
                        Main(args);
                    }
                       
                }
                else
                {
                    Console.WriteLine("The move of the zero");
                    listOfInts = igra.CheckOfNumbers(listOfInts, number);
                    Console.Clear();
                    String[,] newArray = igra.Draw(list, number, "O");
                    bool isWin = igra.WinnerCombination(newArray);
                    if (isWin)
                    {
                        Console.WriteLine("Please enter a symbol in console, if you want to repeat the game");
                        Console.ReadLine();
                        Main(args);
                    }
                        
                }
                
            }
            Console.WriteLine("The game ended in a draw");
            Console.WriteLine("Please enter a symbol in console, if you want to repeat the game");
            Console.ReadLine();
            Main(args);

        }
    }
}
