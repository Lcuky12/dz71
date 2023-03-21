using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSumNumbers = "1";
            const string CommandIsOpens = "2";

            int[] arrayNumbers = new int[0];
            int sum = 0;
            bool isOpen = true;
            string userInput;
            int numbers;

            while (isOpen)
            {
                Console.WriteLine(CommandSumNumbers + "  - вывести сумму введенных чисел ");
                Console.WriteLine(CommandIsOpens + "  - выход из программы ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSumNumbers:
                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            sum += arrayNumbers[i];
                        }
                        Console.WriteLine(" Число сум равно " + sum);
                        break;

                    case CommandIsOpens:
                        isOpen = false;
                        break;

                    default:
                        numbers = Convert.ToInt32(userInput);
                        int[] tempNumbers = new int[arrayNumbers.Length + 1];

                        for (int i = 0; i < arrayNumbers.Length; i++)
                        {
                            tempNumbers[i] = arrayNumbers[i];
                        }

                        tempNumbers[arrayNumbers.Length - 1] = numbers;
                        arrayNumbers = tempNumbers;
                        break;
                }
            }
        }
    }
}