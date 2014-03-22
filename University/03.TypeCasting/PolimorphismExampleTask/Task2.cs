using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTask
{
    class Task2:Task
    {
        public string text = "";
        public string keyword = "";
        private char[] separators = new char[0];
        private string[] textArr = new string[0];

        public Task2()
        {   
        
        }

        public override void ExecuteTask()
        {
            separators = new char[] { '.' };
            textArr = text.Split(separators);
            Console.WriteLine("The result is: ");
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Contains(keyword))
                {
                    ShowResult(textArr[i]);
                }
            }           
        }
    }
}
