using System;
using System.IO;

namespace CurrencyConvertor
{
    class CurrencyConvertor
    {
        static void Main()
        {
            Console.WriteLine("Enter currency for BG :");
            double bgCurrency = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter your convert currency :\n1 - for Euro\n2 - for USD\n3 - for GBP");
            byte choise = byte.Parse(Console.ReadLine());
            double bgEuro = bgCurrency * 1.959;
            double bgUsd = bgCurrency * 1.424;
            double bgGbp = bgCurrency * 2.34;
            switch (choise)
            {
                case 1: Console.WriteLine("Your choise is BG - Euro : {0} lv. for {1} euro !", bgCurrency, bgEuro); break;
                case 2: Console.WriteLine("Your choise is BG - USD : {0} lv. for {1} usd !", bgCurrency, bgUsd); break;
                case 3: Console.WriteLine("Your choise is BG - GBP : {0} lv. for {1} gbp !", bgCurrency, bgGbp); break;

                default:
                    break;
            }
            string path = @"D:\Text.txt";
            StreamWriter text = new StreamWriter(path);
            using (text)
            {
                text.WriteLine("BG - Euro : {0} - {1}", bgCurrency, bgEuro);
                text.WriteLine("BG - USD : {0} - {1}", bgCurrency, bgUsd);
                text.WriteLine("BG - GBP : {0} - {1}", bgCurrency, bgGbp);
            }
            StreamReader read = new StreamReader(path);
            using (read)
            {
                Console.WriteLine("The contents of the file is :");
                Console.WriteLine(new string('-', 25));
                Console.WriteLine(read.ReadToEnd());
            }
        }
    }
}
