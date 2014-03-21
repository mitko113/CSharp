using System;

namespace _04.SignOfProduct
{
    class SignOfProduct
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            int counter = 0;

            if (firstNum > 0)
            {
                counter += 1;
            }
            if (secondNum > 0)
            {
                counter += 1;
            }
            if (thirdNum > 0)
            {
                counter += 1;
            }
           
            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                Console.WriteLine("The product = 0");
            }
            
            else if (counter == 1 || counter == 3)
            {
                Console.WriteLine("The sign of the product is (+)");
            }
            else
            {
                Console.WriteLine("The sign of the product is (-)");
            }
        }
    }
}
