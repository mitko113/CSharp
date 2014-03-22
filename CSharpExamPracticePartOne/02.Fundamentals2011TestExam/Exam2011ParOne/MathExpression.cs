using System;
using System.Text;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal upper = (n * n) + (1 / (m * p)) + 1337;
        decimal divider = n - (128.523123123M * p);
        decimal mathFunct = (decimal)Math.Sin((double)Math.Truncate(m % 180));

        decimal expression = (upper / divider) + mathFunct;
        Console.WriteLine("{0:F6}", expression);

    }
}
