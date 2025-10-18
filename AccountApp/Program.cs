using AccountApp.Exceptions;
using AccountApp.Model;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new()
            {
                Id = 1,
                Iban = "GR123",
                Firstname = "Denis",
                Lastname = "Barko",
                Ssn = "A12345",
                Balance = 1000
            };

            try
            {
                account.deposit(100);
                account.withdraw(200, "A12345");
                account.withdraw(2000, "A12345");
                account.deposit(-10);
            }
            catch (Exception e)
            {
                if (e is NegativeAmountException || e is InsufficientAmountException || e is InvalidSsnException) {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine($"Account: {account}.");
        }
    }
}