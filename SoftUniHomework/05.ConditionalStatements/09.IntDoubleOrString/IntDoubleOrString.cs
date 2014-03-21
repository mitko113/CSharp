using System;

namespace _09.IntDoubleOrString
{
    class IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: ");
            Console.WriteLine("1. --> Int\n2. --> Double\n3. --> String");
            Console.WriteLine(new string('-',40));

            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Please enter an Int: ");
                    int inputInt = int.Parse(Console.ReadLine());
                    inputInt += 1; 
                    Console.WriteLine(inputInt); break;
                case 2:
                    Console.WriteLine("Please enter a Double: ");
                    double inputDouble = double.Parse(Console.ReadLine());
                    inputDouble += 1; 
                    Console.WriteLine(inputDouble); break;
                case 3:
                    Console.WriteLine("Please enter a String : ");
                    string inputString = Console.ReadLine();
                    inputString += "*";
                    Console.WriteLine(inputString);break;
                default: Console.WriteLine("Wrong input !");
                    break;
            }


        }
    }
}
