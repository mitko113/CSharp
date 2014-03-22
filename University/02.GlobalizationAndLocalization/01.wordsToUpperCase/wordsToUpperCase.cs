using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.wordsToUpperCase
{
    class wordsToUpperCase
    {
        static void Main()
        {
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            string wordToUpperCase = "";
            string openTag = "<up>";
            string colseTag = "</up>";
            while (text.Contains(openTag) && text.Contains(colseTag))
            {
                int indexStart = text.IndexOf(openTag);
                int indexEnd = text.IndexOf(colseTag);
                wordToUpperCase = text.Substring(indexStart + 4, indexEnd - (indexStart + 4));
                text = text.Replace("<up>" + wordToUpperCase + "</up>", wordToUpperCase.ToUpper());                            
            }
            Console.WriteLine("The result without tags is: " + text); 
                      
        }
    }
}
