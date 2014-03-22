using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTask
{
    class Task
    {
        protected string taskName = "";

        public virtual void ExecuteTask()
        { 
        }

        public void ShowResult(string resultText)
        {
            Console.WriteLine(resultText);
        }
    }
}
