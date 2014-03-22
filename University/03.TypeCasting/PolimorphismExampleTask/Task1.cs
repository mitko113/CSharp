using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTask
{
    class Task1:Task
    {
        public string text = "";
        private string wordToUpperCase = "";
        private string openTag = "";
        private string closeTag = "";
        private int indexStart = 0;
        private int indexEnd = 0;
    

        public Task1()
        {
            
        }

        public override void ExecuteTask()
        {
            openTag = "<up>";
            closeTag = "</up>";

            while (text.Contains(openTag) && text.Contains(closeTag))
            {

                int indexStart = text.IndexOf(openTag);
                int indexEnd = text.IndexOf(closeTag);
                wordToUpperCase = text.Substring(indexStart + 4, indexEnd - (indexStart + 4));
                text = text.Replace("<up>" + wordToUpperCase + "</up>", wordToUpperCase.ToUpper());         
            }
            ShowResult("The result is: " +  text);                   
        }
    }
}
