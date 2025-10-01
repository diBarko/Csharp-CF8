using System.Text;

namespace EurosToDollars
{
    /// <summary>
    /// Διαβάζει από το std έναν ακέραιο αριθμό που αναπαριστά το ποσό σε ευρώ και μετατρέπει από ευρώ σε δολλάρια,
    /// με βάση μία ισοτιμία έστω 1 Ευρώ = 1.07 USD.    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const decimal RATE = 1.07654m;
            decimal totalCents = 0;
            decimal dollars = 0;
            decimal cents = 0;

            Console.WriteLine("Εισάγετε ποσό σε € :");
            if (!decimal.TryParse(Console.ReadLine(), out decimal euros))
            {
                Console.WriteLine("Error in input.");
                return;
            }
            totalCents = euros * RATE * 100;
            dollars = totalCents / 100;
            cents = totalCents % 100;

            Console.WriteLine($"\u20AC{euros:N2} αντιστοιχούν σε \u0024{dollars:N0},{cents,2:N0}cents");
        }
    }
}