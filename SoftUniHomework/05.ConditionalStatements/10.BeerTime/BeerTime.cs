using System;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            TimeSpan beerTimeStart = TimeSpan.Parse("13:00");
            DateTime startTime = DateTime.Today.Add(beerTimeStart);
            string displayStartTime = startTime.ToString("hh:mm tt");

            TimeSpan beerTimeEnd = TimeSpan.Parse("03:00");
            DateTime endTime = DateTime.Today.Add(beerTimeEnd);
            string displayEndTime = endTime.ToString("hh:mm tt");

            
            Console.WriteLine("Beer time is between {0} and {1}",displayStartTime,displayEndTime);
            Console.WriteLine("Enter the time in format (hh:mm tt): ");
            DateTime time = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", null);

            if (time >= startTime || time < endTime)
            {
                Console.WriteLine("Beeer Time !");
            }
            else
            {
                Console.WriteLine("Non-beer Time !");
            }
        }
    }
}
