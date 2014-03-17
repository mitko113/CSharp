using System;
using System.Collections.Generic;
using System.Text;


namespace _06.ReverseDigits
{
class ReverseDigits
{
    static void Main()
    {
        int[] numArr = new int[4] {1,2,3,4};
                 
        //calc sum
        int sum = 0;
        for (int i = 0; i < numArr.Length; i++)
        {
            sum += numArr[i];
        }
        Console.WriteLine("The sum of the digits is: {0} ",sum);
            
        //print reversed
        Console.Write("Digits in reversed Order: ");
        for (int i = numArr.Length; i > 0; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        //change first and last digit
        Console.Write("Changed first and last digits: ");
        for (int i = 0; i < numArr.Length; i++)
        {
            Console.WriteLine("{0}{1}{2}{3}", numArr[3], numArr[1], numArr[2], numArr[0]); break;          
        }
       
        //change second and third digit
        Console.Write("Changed second and third digits: ");
        for (int i = 0; i < numArr.Length; i++)
        {
            Console.WriteLine("{0}{1}{2}{3}", numArr[0], numArr[2], numArr[1], numArr[3]); break;           
        }          
    }
}
}
