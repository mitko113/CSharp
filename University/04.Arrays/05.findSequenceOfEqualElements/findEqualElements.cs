using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.findEqualElements
{
    class findEqualElements
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array ");
            int n = int.Parse(Console.ReadLine());
            int[] numbersArr = new int[n];
            Console.WriteLine(new string('-',20));

            Console.WriteLine("Enter the values: ");
            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersArr[i] = int.Parse(Console.ReadLine());               
            }
            Console.WriteLine(new string('-', 20));

            int length = 1;
            int MaxLength = 0;
            int elements = 0;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                for (int j = i + 1; j < numbersArr.Length; j++)
                {
                    if (numbersArr[i] == numbersArr[j])
                    {                      
                        length++;
                    }
                    if (length > MaxLength)
                    {
                        MaxLength = length;
                        elements = numbersArr[i];         
                    }
                                                      
                }
                length = 1;
            }
           
            Console.Write("The max sequence of equal numbers is: ");
            for (int i = 0; i < MaxLength; i++)
            {
                Console.Write("{0}, ", elements);
            }
            Console.WriteLine();
        }
    }
}
