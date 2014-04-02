/*Problem 16.
 * Write a program that counts how many times a given word occurs in given text.
 * Matching should be case-insensitive.
 */ 

using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _16.CountWordIntext
{
    class CountWordIntext
    {
        static void Main()
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a keayword to be searched for: ");
            string keyword = Console.ReadLine();
            string[] source = text.Split(new char[] {'!',' ', '.', ',', '(', ')', '"', '/','@'},StringSplitOptions.RemoveEmptyEntries);

            var matchQuery = from word in source
                             where word.ToLowerInvariant() == keyword.ToLowerInvariant()
                             select word;

            int wordCount = matchQuery.Count();

            Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, keyword);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();                      
        }
    }
}
