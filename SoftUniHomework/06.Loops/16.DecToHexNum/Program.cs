/* Problem 16.
 * Using loops write a program that converts an integer number to its hexadecimal representation.
 * The input is entered as long.
 * The output should be a variable of type string. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecToHexNum
{
    class Program
    {
        static void ConvertToHex(long n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                long num = n % 16;
                n = n / 16;


                switch (num)
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                    default:
                        Console.Write(num);
                        break;
                }
            }
            ConvertToHex(n);
        }

        static void Main()
        {
            Console.WriteLine("Enter the number you wish to convert to hexadecimal: ");
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine("Decimal number: {0}  ", num);
            Console.Write("Hexdecimal number: ");
            ConvertToHex(num);
            Console.WriteLine();
        }
    } 
}
