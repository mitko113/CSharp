using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class PinExtractinfo
{    
    static void Main()
    {

        //Validate pin length and numeric
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter your pin ");
        string myPin = Console.ReadLine();
        long validPin;
        bool isDigitsOnly = long.TryParse(myPin, out validPin);

        //validate month
        var month = int.Parse(myPin.Substring(2, 2));
        bool monthValidation = ((month > 0 && month < 13) || (month > 20 && month < 33) || (month > 40 && month < 53));
        if (!monthValidation)
        {
            monthValidation = false;
        }

        //validate day
        var day = int.Parse(myPin.Substring(4, 2));
        bool dayValidation = (day > 0 && day < 32);
        if (!dayValidation)
        {
            dayValidation = false;
        }

        //validate last digit
        bool lastDigitValidation;
        int[] validationWeight = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
        long[] arrayDigits = new long[myPin.Length];
        long sum = 0;
        long result = 0;
        long validationNum = 0;
        for (int i = 0; i < validationWeight.Length; i++)
        {
            sum = sum + (arrayDigits[i] * validationWeight[i]);
        }
        result = sum / 11;
        if (sum > 10)
        {
            validationNum = 0;
        }
        else
        {
            validationNum = sum / 11;
        }
        lastDigitValidation = (validationNum == arrayDigits[9]);
    
    
        if (isDigitsOnly && (myPin.Length == 10) && monthValidation && dayValidation && lastDigitValidation)
        {
            Console.WriteLine("Correct input !");
        }
        else
        {
            Console.WriteLine("Wrong input ! Try again.");
        }
        Console.WriteLine(new string('-',35));

        //Extract date of birth
        int year = int.Parse(myPin.Substring(0, 2));
           
            

        if (month > 20 && month < 33)
        {
            month = month - 20;
            year += 1800;
        }
        else if (month > 40 && month < 53)
        {
            month = month - 40;
            year += 2000;
        }
        else if (month > 0 && month < 13)
        {
            year += 1900;
        }
        else
        {
            Console.WriteLine("Wrong input !");
        }
         
        DateTime dateOfBirth = new DateTime(year, month, day);
        Console.WriteLine("Your birth date is : {0}", dateOfBirth.ToString("dd/MM/yyyy"));
        Console.WriteLine(new string('-',35));

        // Extract gender
        int index = int.Parse(myPin.Substring(8, 1));
        string gender = "";
        if (index % 2 == 0)
        {
            gender = "Male";
        }
        else
        {
            gender = "Female";
        }
        Console.WriteLine("Your gender is: {0}", gender);
        Console.WriteLine(new string('-',35));

        //Calculate age
        DateTime today = DateTime.Now;
        int age = today.Year - dateOfBirth.Year;         
        if (dateOfBirth > today.AddYears(-age)) age--;
        Console.WriteLine("You are {0} years old.", age);
        Console.WriteLine(new string('-',35));

        //Calculate time to next birthday

        DateTime currentDate = DateTime.Today;
        DateTime nextBirthDay = new DateTime(currentDate.Year, dateOfBirth.Month, dateOfBirth.Day);
        if (nextBirthDay < currentDate)
            nextBirthDay = nextBirthDay.AddYears(1);
        int numDays = (nextBirthDay - currentDate).Days;
        Console.WriteLine("There are {0} days remaining to your next birthday.", numDays);
        Console.WriteLine(new string('-',35));           
    }      
}

