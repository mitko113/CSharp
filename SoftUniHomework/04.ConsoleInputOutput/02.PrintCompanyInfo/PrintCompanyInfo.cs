using System;

namespace _02.PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.WriteLine("Enter the name of the company: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the address of the company: ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the phone number of the company: ");
            int phoneNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fax number of the company: ");
            int faxNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the website of the company ");
            string webAddress = Console.ReadLine();
            Console.WriteLine(new string('-',35));

            Console.WriteLine("Enter manager's first name ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter manager's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the age of the manager");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the phone number of the manager ");
            int managerNum = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',35));

            Console.WriteLine("Company information: ");
            Console.WriteLine("1.Name - {0}",name);
            Console.WriteLine("2.Address - {0}",address);
            Console.WriteLine("3.Phone number - {0}",phoneNum);
            Console.WriteLine("4.Fax number - {0}",faxNum);
            Console.WriteLine("5.Web site - {0}",webAddress);
            Console.WriteLine(new string('-',35));

            Console.WriteLine("Manager information: ");
            Console.WriteLine("1.Full name - {0}", firstName + " " + lastName);
            Console.WriteLine("2.Age - {0}",age);
            Console.WriteLine("3.Phone number - {0}",phoneNum);
            Console.WriteLine(new string('-',35));

        }
    }
}
