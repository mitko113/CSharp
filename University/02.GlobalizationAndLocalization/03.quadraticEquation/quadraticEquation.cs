using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.quadraticEquation
{
    class Program
    {
        static void Main()
        {
            Task1 tt1 = new Task1();
            Console.WriteLine("Enter the value of 'a' ");
            tt1.a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'b' ");
            tt1.b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 'c' ");
            tt1.c = double.Parse(Console.ReadLine());          
            tt1.ExecuteTask();

      
        }
    }
}
