using System;

namespace _11.EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Pesho";
            string lastName = "Ivanov";
            int age = 20;
            char gender = 'm';
            string idNum = "9009203468";
            string uniqueId = "275600000";

            Console.WriteLine("1.Fullname: {0}\n2.Age:{1}\n3.Gender: {2}\n4.PIN: {3}\n5.ID: {4}",
                (firstName + " " + lastName),age,gender,idNum,uniqueId);
        }
    }
}
