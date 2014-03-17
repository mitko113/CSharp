using System;


namespace _12.BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your middle name: ");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            string fullName = string.Concat(firstName," ", middleName, " ", lastName);
            Console.WriteLine(new string('-',35));

            Console.WriteLine("Enter the value of your account balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine(new string('-',35));

            Console.WriteLine("Enter the number of associated credit cards: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your unique credit card numbers: ");
            string[] cardId = new string [n];
            for (int i = 0; i < cardId.Length; i++)
            {
                cardId[i] = Console.ReadLine(); 
            }
            Console.WriteLine(new string('-',35));

            Console.WriteLine("1.Fullname: {0}\n2.Ballance: {1}\n3.Credit cards: ",
                fullName, balance);
            for (int i = 0; i < cardId.Length; i++)
            {
                Console.WriteLine("- {0}", cardId[i]);
            }                     
        }
    }
}
