﻿using System.Text;

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
            const decimal RATE = 1.07m;
            
            Console.WriteLine("Εισάγετε ποσό σε € :");
            if (!decimal.TryParse(Console.ReadLine(), out decimal euros))
            {
                Console.WriteLine("Error in input.");
                return;
            }

            decimal converted = euros * RATE;
            int totalCents = (int)Math.Round(converted * 100, MidpointRounding.AwayFromZero);
            int dollars = totalCents / 100;
            int cents = totalCents % 100;

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"\u20AC{euros:F2} αντιστοιχούν σε \u0024{dollars:N0},{cents,2:N0}cents");
        }
    }
}