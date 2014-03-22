using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.quadraticEquation
{
    class Task
    {
        protected double diskriminante;
        public virtual void ExecuteTask()
        { 
        }

        public void ShowResult(double resultText)
        {
            Console.WriteLine("Diskriminante = " + resultText);
        }
    }
}
