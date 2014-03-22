using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintOneDimensionalArray
{
    class PrintOneDimensionalArray
    {
        static void Main()
        {        
            int[] numArr = new int [20] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            Console.WriteLine(new string('-',35));

            Console.WriteLine("Output: ");
            for (int i = 0; i < numArr.Length; i++)
            {              
                numArr[i] *= 5;
                Console.WriteLine("Elemetn {0} = {1}", i, numArr[i]);      
            }                    
        }
    }
}
