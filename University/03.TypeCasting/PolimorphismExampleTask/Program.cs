using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the task you wish to perform: \n1.Words to upper case \n2.Extract sentences");
            Console.WriteLine(new string('-',35));
            string input = Console.ReadLine();
                           
            if (input == "1")
            {
                Task1 tt1 = new Task1();
                Console.WriteLine("Enter your text here: ");
                tt1.text = Console.ReadLine();
                tt1.ExecuteTask(); 
            }
            else if (input == "2")
            {
                Task2 tt2 = new Task2();
                Console.WriteLine("Enter your text here: ");
                tt2.text = Console.ReadLine();
                Console.WriteLine("Enter keyword: ");
                tt2.keyword = Console.ReadLine();
                tt2.ExecuteTask();
            }
            else
            {
                Console.WriteLine("Wrong input ! Please select 1 or 2");
            }                      
        }
    }
}
