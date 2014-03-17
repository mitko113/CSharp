using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrintSequenceOneToN
{
    class PrintSequenceOneToN
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of 'n' ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',40));

            Console.WriteLine("The numbers from 1 to 'n' are: ");
            for (int i = 1; i <= n; i++)
			{
                Console.WriteLine(i);			 
			}
            Console.WriteLine(new string('-',40));
        }
    }
}
