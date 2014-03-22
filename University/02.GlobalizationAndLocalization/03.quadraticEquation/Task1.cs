using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.quadraticEquation
{
    class Task1:Task
    {
        public double a;
        public double b;
        public double c;
        public double diskriminante;

        public override void ExecuteTask()
        {
            diskriminante = b * b - 4 * a * c;
            if (diskriminante > 0)
            {
                double x1 = (-b + Math.Sqrt(diskriminante) / (2 * a));
                double x2 = (-b + Math.Sqrt(diskriminante) / (2 * a));
                Console.WriteLine("There are two real solutions: x1 = {0} and x2 = {1}", x1,x2);
            }
            else if (diskriminante == 0)
            {
                double x12 = (-b / (2 * a));
                Console.WriteLine("There is only one real solution: x12 = {0}", x12);
            }
            else
            {
                Console.WriteLine("There are no real solutions !");
            }
            ShowResult(diskriminante);
        }
    }
}
