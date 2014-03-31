/*Problem 14.
 * Write a program to find the longest word in a text. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _14.LongestWordInAText
{
    class LongestWordInAText
    {
        static void Main()
        {
            Console.WriteLine("Enter your text.");
            string input = Console.ReadLine();
            string[] buffer = input.Split(' ');
            var sorted = buffer.OrderBy(n => n.Length);
            var longest = sorted.LastOrDefault();
            Console.WriteLine("The longest word is: {0} with length: {1} ",longest, longest.Length.ToString());  
        }
    }
}
