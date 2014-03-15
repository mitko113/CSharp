using System;

namespace _07.StringConcatenation
{
    class StringConcatenation
    {
        static void Main()
        {
            string first = "Hello";
            string second = "Wordl !";
            object concatenation = first + " " + second;
            string result = (string)concatenation;
            Console.WriteLine(result);
        }
    }
}
