using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGradeCalc
{
    class AverageGradeCalc
    {
        static void Main()
        {  
                Console.WriteLine("Enter student's name: ");
                string studName = Console.ReadLine();
                Console.WriteLine("Enter student's grade: ");
                string grade = Console.ReadLine();
                string empty = "";
                double validNum = 0;
                double averageGradeSum = 0;
                double averageGrade = 0;
                int counter = 0;

                while (double.TryParse(grade, out validNum))
                {
                    
                    if (double.Parse(grade) >= 2 && double.Parse(grade) <= 6)
                    {
                        Console.WriteLine("Correct input !");
                        counter++;
                        averageGradeSum += double.Parse(grade);
                        grade = Console.ReadLine();

                    }
                    else 
                    {
                        Console.WriteLine("Wrong input");
                        break;
                    }
                    if (grade.ToString() == empty)
                    {
                        Console.WriteLine("End of program");
                        averageGrade = averageGradeSum / counter;
                        Console.WriteLine("The average grade of the student is: {0:F2}", averageGrade);              
                        break;
                    }                                     
                }
        }
    }
}
