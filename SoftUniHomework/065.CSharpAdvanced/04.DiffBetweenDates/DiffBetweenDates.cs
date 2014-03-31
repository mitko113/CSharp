/*Problem 04.
 * Write a program that enters two dates in format dd.MM.yyyy
 * and returns the number of days between them. 
 */

using System;
using System.Collections.Generic;
using System.Globalization;

namespace _04.DiffBetweenDates
{
    class DiffBetweenDates
    {
        static void Main()
        {       
            Console.WriteLine("Enter first date in format dd.MM.yyyy");
            string inputDate1 = Console.ReadLine();
            string format = "dd.MM.yyyy";
            DateTime firstDate = DateTime.ParseExact(inputDate1, format, System.Globalization.CultureInfo.InvariantCulture);


            Console.WriteLine("Enter second date in format dd.MM.yyyy");
            string inputDate2 = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(inputDate2, format, System.Globalization.CultureInfo.InvariantCulture);
     
            TimeSpan span = secondDate - firstDate;
            int diff = span.Days;

            Console.WriteLine("There are {0} days between {1} and {2}", diff, firstDate.ToString("dd.MM.yyyy"),secondDate.ToString("dd.MM.yyyy"));          
        }
    }
}
