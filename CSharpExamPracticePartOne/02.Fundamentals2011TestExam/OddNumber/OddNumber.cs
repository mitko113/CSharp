using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class OddNumber
    {
        public static long getNumberOfOdd(long[] arr, long arrSize)
        {
            long result = 0;
            for (int i = 0; i < arrSize; i++)
            {
                result = result ^ arr[i];
            }
            return result;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] numArr = new long[n];
            for (int i = 0; i < numArr.Length; i++)
            {
                numArr[i] = long.Parse(Console.ReadLine());
            }

            Console.WriteLine(getNumberOfOdd(numArr,numArr.Length));

        }
    }
}
