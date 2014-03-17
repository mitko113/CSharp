using System;


namespace _13.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? a = null;
            double b = double.NaN;
            Console.WriteLine("First output: {0}\n2.Second output: {1}", a,b);
            Console.WriteLine(a + b); //no output
            Console.WriteLine(a + 10); // no output
            Console.WriteLine(b + 10); // NaN         
        }
    }
}
