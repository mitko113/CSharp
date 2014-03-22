using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.countLectures
{
    class countLectures
    {
        static void Main()
        {
             
            
            var chosenDay = "Monday";
            string[] DaysOfTheWeek;
           
            Console.WriteLine("Enter beginning of the semester in dd/MM/yyyy format: ");
            var startDate = DateTime.Parse(Console.ReadLine());           
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Enter end date of the semester in dd/MM/yyyy format: ");
            var endDate = DateTime.Parse(Console.ReadLine());                      
            Console.WriteLine(new string('-', 30));
                         
            Console.WriteLine("Choose day of the week: ");
            chosenDay = Console.ReadLine();
            DaysOfTheWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            for (int i = 0; i < DaysOfTheWeek.Length; i++)
            {
                if (DaysOfTheWeek.Contains(chosenDay))
                {
                    Console.WriteLine("You have chosen: {0}", chosenDay); break;
                }
                else
                {
                    Console.WriteLine("Wrong input !"); break;
                }
            }
            Console.WriteLine(new string('-', 30));

            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), chosenDay);

            int maxDays = 0;
            while (startDate <= endDate)
            {
                if (startDate.DayOfWeek == day)
                {
                    maxDays++;
                }
                startDate = startDate.AddDays(1);
            }
            Console.WriteLine("The chosen day {0} consits {1} times in the period from {2} to {3} ", chosenDay, maxDays, startDate.ToString("dd/MM/yyyy"),endDate.ToString("dd/MM/yyyy"));
        }
    }
}
