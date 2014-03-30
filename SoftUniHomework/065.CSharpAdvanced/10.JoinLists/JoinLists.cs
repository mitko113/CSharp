using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.JoinLists
{
    class JoinLists
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elemets of the first list separated by space: ");

            string numbersOne = Console.ReadLine();
            string[] numbersListOne = numbersOne.ToString().Split(' ');
            
            Console.WriteLine("Enter the elements of the second list separated by space: ");

            string numbersTwo = Console.ReadLine();
            string[] numbersListTwo = numbersTwo.ToString().Split(' ');

            List<string> firstList = new List<string>(numbersListOne);
            List<string> secondList = new List<string>(numbersListTwo);

            var intList1 = firstList.Select(s => Convert.ToInt32(s)).ToList();
            var intList2 = secondList.Select(s => Convert.ToInt32(s)).ToList();

            var mergedList = intList1.Union(intList2).ToList();
            mergedList.Sort();

            Console.WriteLine("The result list contains the following elements: ");
            foreach (var merge in mergedList)
            {
                Console.WriteLine(merge);
            }
        }
    }
}
