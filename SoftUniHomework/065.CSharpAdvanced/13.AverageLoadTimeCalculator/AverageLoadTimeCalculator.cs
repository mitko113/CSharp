/*Problem 13.
 * We have a report that holds dates,
 * web site URLs and load times (in seconds) 
 * Your tasks is to calculate the average load time for each URL. 
 * Print the URLs in the same order as they first appear in the input report.
 * Use double floating-point precision. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



namespace _13.AverageLoadTimeCalculator
{
    class AverageLoadTimeCalculator
    {
        static void Main()
        {
            Console.WriteLine("Write a line of text in format: date..url..average load time");
            string inputLine = Console.ReadLine();

            Dictionary<string, decimal> input = new Dictionary<string, decimal> { };
            while (inputLine != string.Empty)
            {
                string[] list = inputLine.Split(' ');
                string url = list[2];
                decimal loadTime = decimal.Parse(list[3]);
                if (!input.Keys.Contains(url))
                {
                    input[url] = loadTime;
                }
                else
                {
                    input[url] = (input[url] + loadTime) / 2;
                }
                inputLine = Console.ReadLine();
            }

            foreach (string link in input.Keys)
            {
                Console.WriteLine(link + "------->" + input[link]);
            }

           
        }
    }
}
