/* Problem 15.
 * Write a program that extracts
 * and prints all URLs from given text. 
 */

using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _15.ExtractURLfromText
{
    class ExtractURLfromText
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string rawString = Console.ReadLine();
            Console.WriteLine(new string('-',60));

            Regex parser = new Regex(@"\b(?:http://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Console.WriteLine("Extracted URLs: ");
            Console.WriteLine();
            foreach (Match m in parser.Matches(rawString))
            {
                Console.WriteLine(m.Value);
            }
            Console.WriteLine(new string('-',60));
        }
    }
}
