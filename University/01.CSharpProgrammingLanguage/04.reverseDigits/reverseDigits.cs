using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.reverseDigits
{
    class reverseDigits
    {
        static void Main()
        {
            Console.WriteLine("Enter your number in format 'abcd' here: ");
            string myNum = Console.ReadLine();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Enter your choice: \n1.Print sum of the numbers \n2.Print the number reversed \n3.Change first and last digit" + 
                " \n4.Change second and third digit");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',30));

            //Print sum of the numbers
            if (choice == 1)
            {
                int currentNum = 0;
                int sum = 0;
                for (int i = 0; i < myNum.Length; i++)
                {
                    currentNum = int.Parse(myNum[i].ToString());
                    sum += currentNum;

                }
                Console.WriteLine("The sum of the numbers is: {0}",sum);
            }
            else if (choice == 2)
            {
                
                for (int i = myNum.Length - 1; i >= 0; i--)
                {
                    Console.Write(myNum[i]);  
                }
                Console.WriteLine();
                
            }
            else if (choice == 3)
	        {
                int firstDigit = int.Parse(myNum[0].ToString());
                int secondDigit = int.Parse(myNum[1].ToString());
                int thirdDigit = int.Parse(myNum[2].ToString());
                int fourthDigit = int.Parse(myNum[3].ToString());

                Console.WriteLine("The result is: {0}{1}{2}{3}", fourthDigit,secondDigit,thirdDigit,firstDigit);
		 
	        }
            else if (choice == 4)
            {
                int firstDigit = int.Parse(myNum[0].ToString());
                int secondDigit = int.Parse(myNum[1].ToString());
                int thirdDigit = int.Parse(myNum[2].ToString());
                int fourthDigit = int.Parse(myNum[3].ToString());

                Console.WriteLine("The result is: {0}{1}{2}{3}", firstDigit,thirdDigit,secondDigit,fourthDigit);              
            }
            else
            {
                Console.WriteLine("Wrong input ! Please choose from 1 to 4 !");
            }
        }
    }
}
