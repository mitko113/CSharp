/*Problem 12.
 * Write a program that reads a list of names and
 * prints for each name how many times it appears in the list. 
 * The names should be listed in alphabetical order.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.CountNames
{
    class CountNames
    {
        static void Main()
        {
            Console.WriteLine("Enter a list of names separated by a space: ");
            string input = Console.ReadLine();
            string[] sepInput = input.Split(' ');

            List<string> namesList = new List<string>(sepInput);
            namesList.Sort();
            var grouped = namesList.GroupBy(s => s)
                                   .Select(g => new { Name = g.Key, Count = g.Count() });
            
            foreach (var item in grouped)
            {                
                var name = item.Name;
                var count = item.Count;
                Console.WriteLine("{0} ----> {1}", name, count);
            }          
        }
    }
}
