/*Problem 09.
 * Write a program that takes as input two lists of names 
 * and removes from the first list all names given in the second list. 
 * The input and output lists are given as words, separated by a space,
 * each list at a separate line. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RemoveNames
{
    class RemoveNames
    {
        
        static void Main()
        {
            Console.WriteLine("Enter the elements of the first list separated by space: ");          
            string inputListOne = Console.ReadLine();
            string[] inputsOne = inputListOne.Split(' ');
            Console.WriteLine(new string('-',60));
       
            Console.WriteLine("Enter the elements of the second list separated by space: ");
            string inputListTwo = Console.ReadLine();
            string[] inputsTwo = inputListTwo.Split(' ');
            Console.WriteLine();
            Console.WriteLine(new string('-', 60));

            List<string> firstNames = new List<string>(inputsOne);
            List<string> secondName = new List<string>(inputsTwo);

            Console.WriteLine("The first list contains the following names: ");
            foreach (var name in firstNames)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',60));
                            
            Console.WriteLine("The second list contains the following names: ");
            foreach (var name in secondName)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 60));

            Console.WriteLine("The result list contains the following names: ");
            List<string> result = firstNames.Except(secondName).ToList();
            foreach (var name in result )
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-',60));           
        }
    }
}
