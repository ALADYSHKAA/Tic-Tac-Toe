using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krestik
{
    public class Igra
    {
        
        public Igra()
        {
           
        }

        public void Draw(String[,] list)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{list[i, j]} \t ");
                }
                Console.WriteLine();
            }
        }
        public bool Check(int number)
        {
            if (number > 8 || number < 0)
                return false;
            else
                return true;
        }
        public List<int> CheckOfNumbers(List<int> list, int number)
        {
           
            
                if (list.Contains(number))
                {
                list.Remove(number);
                    return list;
                }
                else
                {
                Console.WriteLine("This number has already been used");
                return list;
                }
           
        }
        public String[,] Draw(String[,] list,int number, string krestikOrNolik)
        {
            switch (number)
            {
                case 0:
                    list[0, 1] = krestikOrNolik;
                    break;
                case 1:
                    list[0, 3] = krestikOrNolik;
                    break;
                case 2:
                    list[0, 5] = krestikOrNolik;
                    break;
                case 3:
                    list[1, 1] = krestikOrNolik;
                    break;
                case 4:
                    list[1, 3] = krestikOrNolik;
                    break;
                case 5:
                    list[1, 5] = krestikOrNolik;
                    break;
                case 6:
                    list[2, 1] = krestikOrNolik;
                    break;
                case 7:
                    list[2, 3] = krestikOrNolik;
                    break;
                case 8:
                    list[2, 5] = krestikOrNolik;
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"{list[i, j]} \t ");
                }
                Console.WriteLine();
            }
            return list;
        }

        public bool WinnerCombination(String[,] list)
        {
            if (list[0, 1] == "X" && list[0, 3] == "X" && list[0, 5] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[0, 1] == "O" && list[0, 3] == "O" && list[0, 5] == "O")
            {
                Console.WriteLine("Great zero is the winner!");
                return true;
            }
            else if (list[1, 1] == "O" && list[1, 3] == "O" && list[1, 5] == "O")
            {
                Console.WriteLine("Great zero is the winner!");
                return true;
            }
            else if (list[1, 1] == "X" && list[1, 3] == "X" && list[1, 5] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[2, 1] == "X" && list[2, 3] == "X" && list[2, 5] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[2, 1] == "O" && list[2, 3] == "O" && list[2, 5] == "O")
            {
                Console.WriteLine("Great zero is the winner!");
                return true;
            }
            else if (list[0, 1] == "O" && list[1, 1] == "O" && list[2, 1] == "O")
            {
                Console.WriteLine("Great zero is the winner!");
                return true;
            }
            else if (list[0, 1] == "X" && list[1, 1] == "X" && list[2, 1] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[0, 3] == "X" && list[1, 3] == "X" && list[2, 3] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[0, 3] == "O" && list[1, 3] == "O" && list[2, 3] == "O")
            {
                Console.WriteLine("Great zero is the winner!");
                return true;
            }
            else if (list[0, 5] == "O" && list[1, 5] == "O" && list[2, 5] == "O")
            {
                Console.WriteLine("Great zero is the winner!");
                return true;
            }
            else if (list[0, 5] == "X" && list[1, 5] == "X" && list[2, 5] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[0, 1] == "X" && list[1, 3] == "X" && list[2, 5] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[0, 1] == "O" && list[1, 3] == "O" && list[2, 5] == "O")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[0, 5] == "X" && list[1, 3] == "X" && list[2, 1] == "X")
            {
                Console.WriteLine("Great cros is the winner!");
                return true;
            }
            else if (list[0, 5] == "O" && list[1, 3] == "O" && list[2, 1] == "O")
            {
                Console.WriteLine("Great zero is the winner!");
                return true;
            }

            else
            {
                return false;
            }
        }
            
    }
}
