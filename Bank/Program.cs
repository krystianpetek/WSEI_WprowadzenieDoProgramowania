using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var accou1nt = new Account(null, 100.0m);
                Console.WriteLine(accou1nt);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Name is null");
            }

            var account = new Account("John");
            account.Deposit(100.00m);
            Console.WriteLine(account.Withdrawal(10.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(100.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(0.00m));
            Console.WriteLine(account);
            Console.WriteLine(account.Withdrawal(-10.00m));
            Console.WriteLine(account);
            account.Block();
            Console.WriteLine(account.Withdrawal(10.4999m));
            Console.WriteLine(account);

        }
    }
}
