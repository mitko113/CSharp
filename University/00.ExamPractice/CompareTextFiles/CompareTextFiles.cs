using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CompareTextFiles
{
    class CompareTextFiles
    {
        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        static void Main()
        {
            string ffile = "";
            string sfile = "";
            Console.WriteLine("Enter the name of the first file: ");
            ffile = Console.ReadLine();
            StreamWriter firstFile = new StreamWriter(@"D:\" + ffile + ".txt");
            Console.WriteLine("Enter the name of the second file: ");
            sfile = Console.ReadLine();
            StreamWriter secondFile = new StreamWriter(@"D:\" + sfile + ".txt");

           

            using (firstFile) 
            {
                Console.WriteLine("Press any key to begin and 'Esc' to exit: ");
                Console.ReadKey(true);

                while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                {
                    firstFile.WriteLine(Console.ReadLine());
                }
            }
            firstFile.Close();

            

            using (secondFile) 
            {
                Console.WriteLine("Press any key to begin and 'Esc' to exit: ");
                Console.ReadKey(true);

                while (Console.ReadKey(true).Key != ConsoleKey.Escape)
                {
                    secondFile.WriteLine(Console.ReadLine());
                }
            }
            secondFile.Close();

            StreamReader ff = new StreamReader(@"D:\" + ffile + ".txt");
            StreamReader sf = new StreamReader(@"D:\" + sfile + ".txt");

            using (ff) 
            {
                Console.WriteLine("First file content: ");
                Console.WriteLine(new string('-',40));
                Console.WriteLine(ff.ReadToEnd());
            }

            using (sf) 
            {
                Console.WriteLine("Second file content: ");
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(sf.ReadToEnd());
            }


            bool isEqual = FileEquals(@"D:\" + ffile + ".txt", @"D:\" + sfile + ".txt");
            if (isEqual == true)
            {
                Console.WriteLine("The two files are equal !");
            }
            else
            {
                Console.WriteLine("The two files are not equal !");
            }         
        }
    }
}
