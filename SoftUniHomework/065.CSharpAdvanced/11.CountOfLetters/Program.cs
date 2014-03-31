/*Problem 11.
 * Write a program that reads a list of letters 
 * and prints for each letter how many times it
 * appears in the list.
 * The letters should be listed in alphabetical order.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _11.CountOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the values separated by a space: ");
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');

            List<string> firstList = new List<string>(inputs);

            var grouped = firstList.GroupBy(s => s)                       
                                   .Select(g => new { Symbol = g.Key, Count = g.Count() });

            var tokens = firstList.OrderBy(l => l.ToLower()).ToList();
            foreach (var item in grouped)
            {
                var symbol = item.Symbol;
                var count = item.Count;
                Console.WriteLine("{0} ----> {1}", symbol,count);
            }          
        }
    }
}
