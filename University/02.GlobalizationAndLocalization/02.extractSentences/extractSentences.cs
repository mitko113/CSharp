using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extractSentences
{
    class extractSentences
    {
        static void Main()
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            Console.WriteLine(new string('-',20));
            Console.WriteLine("Enter keyword: ");
            string keyword = Console.ReadLine();
            Console.WriteLine(new string('-',20));

            char[] separators = new char[] {'.' };
            string[] textArr = text.Split(separators);

            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Contains(keyword))
                {
                    Console.WriteLine(textArr[i]);
                }               
            }
        }
    }
}
