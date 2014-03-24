using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAsWords
{
    class NumbersAsWords
    {
        static void PrintNumbersFrom1UpTo9(int number)
        {
            switch (number)
            {
                case 1:
                    Console.Write("one ");
                    break;
                case 2:
                    Console.Write("two ");
                    break;
                case 3:
                    Console.Write("three ");
                    break;
                case 4:
                    Console.Write("four ");
                    break;
                case 5:
                    Console.Write("five ");
                    break;
                case 6:
                    Console.Write("six ");
                    break;
                case 7:
                    Console.Write("seven ");
                    break;
                case 8:
                    Console.Write("eight ");
                    break;
                case 9:
                    Console.Write("nine ");
                    break;            
            }
        }

        static void PrintNumbersFrom10UpTo19(int number)
        {
            switch (number)
            {
                case 0:
                    Console.Write("ten ");
                    break;
                case 1:
                    Console.Write("eleven ");
                    break;
                case 2:
                    Console.Write("twelve ");
                    break;
                case 3:
                    Console.Write("thirteen ");
                    break;
                case 4:
                    Console.Write("fourteen ");
                    break;
                case 5:
                    Console.Write("fifteen ");
                    break;
                case 6:
                    Console.Write("sixteen ");
                    break;
                case 7:
                    Console.Write("seventeen ");
                    break;
                case 8:
                    Console.Write("eighteen ");
                    break;
                case 9:
                    Console.Write("nineteen ");
                    break;
            }
        }

        static void PrintNumbersFrom20UpTo90(int number)
        {
            switch (number)
            {
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("forty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
               
            }
        }


        static void Main()
        {
            Console.WriteLine("Enter a number form 0 to 99 ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0 || num > 99)
            {
                Console.WriteLine("Wrong input !Number must be in range [0...99]");
            }
            if (num == 0)
            {
                Console.WriteLine("Zero");
            }
            if ((num % 100) > 0)
            {
                               
                int tens = (num % 100) / 10;
                if (tens == 1)
                {
                    PrintNumbersFrom10UpTo19((num % 100) % 10);
                    Console.WriteLine();
                    Console.ReadLine();
                    return;
                }
                else if (tens > 1)
                {
                    PrintNumbersFrom20UpTo90(tens);
                }
                int remainder = (num % 100) % 10;
                if (remainder > 0)
                {
                    PrintNumbersFrom1UpTo9(remainder);
                }
            }
            Console.WriteLine();                 
        }   
    }
}
    
