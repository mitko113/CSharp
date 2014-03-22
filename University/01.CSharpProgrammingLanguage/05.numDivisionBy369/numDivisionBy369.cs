using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.numDivisionBy369
{
    class numDivisionBy369
    {
        static void Main()
        {
            Console.WriteLine("Enter your number: ");
            int myNum = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',30));

            Console.WriteLine("Make your choice: \n1.Division by 3 \n2.Division by 4 \n3.Divisio by 9");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',30));

            Console.WriteLine("Enter beginning of interval: ");
            int beginning = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end of the interval: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',30));
            int divisionBy = 1;

            switch (choice)
            {
                case 1: divisionBy = 3; break;
                case 2: divisionBy = 4; break;
                case 3: divisionBy = 9; break;

                default: Console.WriteLine("Wrong input !");
                    break;
            }

            for (int i = beginning; i < end; i++)
            {
                if (i % divisionBy == 0)
                {
                    Console.WriteLine(i);  
                }
            }



        }
    }
}
