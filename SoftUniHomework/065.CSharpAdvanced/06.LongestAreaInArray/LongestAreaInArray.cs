using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the sequence: ");
            int n = int.Parse(Console.ReadLine());

            string[] stringArr = new string[n];
            for (int i = 0; i < stringArr.Length; i++)
            {
                stringArr[i] = Console.ReadLine();
            }

            int length = 1;
            int Maxlength = 0;
            string element = null;
                      
            for (int i = 0; i < stringArr.Length - 1 ; i++)
            {
                if (stringArr[i].Equals(stringArr[i+1]))
                {
                    length++;
                }
                else
                {
                    length = 1;
                }

                if (Maxlength < length)
                {
                    Maxlength = length;
                    element = stringArr[i];
                }
                                                
            }
                    
            Console.WriteLine("The longest sequence of equal elements consists of {0} elements", length);
            
            for (int i = 0; i < Maxlength ; i++)
            {
                Console.WriteLine(element);
            }
        }
    }
}
