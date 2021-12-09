using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance);

            // account.Balance = 200; // Não está disponível para classes fora do assembly.
        }
    }
}
