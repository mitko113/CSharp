using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ReadDateTime
{
    class ReadDateTime
    {
        static void Main()
        {
            Console.WriteLine("Enter date in format dd/MM/yyyy");
            string inputDate = Console.ReadLine();

            string empty = "";
            
            DateTime validDate = new DateTime();
            while (true)
            { 
                if (DateTime.TryParse(inputDate.ToString(), out validDate))
                {
                    Console.WriteLine("Correct input");
                    Console.WriteLine(Convert.ToDateTime(inputDate).ToString("dddd", new CultureInfo("bg-BG")));
                    Console.WriteLine(Convert.ToDateTime(inputDate).ToString("dddd", CultureInfo.InvariantCulture));
                    inputDate = Console.ReadLine();                              
                }
                else if (inputDate.ToString() == empty.ToString())
                {
                    Console.WriteLine("Wrong input !"); break;                   
                }
                else
                {
                    Console.WriteLine("Wrong Input! Try again !"); 
                    inputDate = Console.ReadLine();
                }                          
            }
        }
    }
}
