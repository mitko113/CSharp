using System;

namespace AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {

            Console.WriteLine("Enter your year of birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - yearOfBirth;
            int ageAfter = age + 10;
            Console.WriteLine("Your age is: {0} years old.", age);
            Console.WriteLine("After 10 years you will be {0} years old.", ageAfter);
        }
    }
}
