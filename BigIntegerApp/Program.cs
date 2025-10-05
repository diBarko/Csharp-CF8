using System.Numerics;

namespace BigIntegerApp
{
    /// <summary>
    /// Υπολογίζει το γινόμενο 1*2*3*...*n
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            BigInteger result = 1;  // auto-boxing και υπερφόρτωση του = για BigInteger
            int i = 1;
            while (i <= n)
            {
                result *= i;
                i++;
            }

            Console.WriteLine($"Το 1*2*3*...*{n} ({n}!) = {result:n0}");
        }
    }
}
