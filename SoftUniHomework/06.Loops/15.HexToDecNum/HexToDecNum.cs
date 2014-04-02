/* Problem 15.
 * Using loops write a program that converts a hexadecimal integer number to its decimal form.
 * The input is entered as string. 
 * The output should be a variable of type long. 
 */

using System;
using System.Text;
using System.Collections;
using System.Linq;

namespace _15.HexToDecNum
{
    class HexToDecNum
    {
        static void Main()
        {
            Console.WriteLine("Enter a hexdecimal number: ");
            string hexInput = Console.ReadLine();
            long num = 0;
            int power = 0;
        
            for (int i = hexInput.Length -1; i > -1; i--)
            {
                power = hexInput.Length - (i + 1);
                switch (hexInput[i])
                {
                    case 'A': num = num + (10 * (int)Math.Pow(16, power)); break;
                    case 'B': num = num + (11 * (int)Math.Pow(16, power)); break;
                    case 'C': num = num + (12 * (int)Math.Pow(16, power)); break;
                    case 'D': num = num + (13 * (int)Math.Pow(16, power)); break;
                    case 'E': num = num + (14 * (int)Math.Pow(16, power)); break;
                    case 'F': num = num + (15 * (int)Math.Pow(16, power)); break;
                    default: num = num + long.Parse(hexInput[i].ToString()) * (uint)Math.Pow(16, power); break;
                }              
            }
            Console.WriteLine(num);
        }
    }
}
