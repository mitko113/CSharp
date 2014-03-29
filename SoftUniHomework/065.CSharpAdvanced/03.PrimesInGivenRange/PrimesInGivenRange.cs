using System;
using System.Collections;
using System.Collections.Generic;

namespace _03.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        public static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            List<long> returnList = new List<long>();
            for (long i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                var n = Math.Floor(Math.Sqrt(i));

                if (startNum == 1)
                {
                    returnList.Remove(startNum);
                }
                if (startNum == 0)
                {
                    returnList.Remove(startNum);
                    returnList.Remove(startNum + 1);
                }
                for (int j = 2; j <= n; j++)
                {
                    
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    returnList.Add(i);
                }                              
            }
            return returnList;
        }

        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            long firstNum = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            long secondNum = long.Parse(Console.ReadLine());

            List<long> primes = FindPrimesInRange(firstNum, secondNum);
            Console.Write("Primes: ");
            foreach (var l in primes)
            {
                Console.Write(l.ToString() + ", ");
            }
            Console.WriteLine();          
        }
    }
}
