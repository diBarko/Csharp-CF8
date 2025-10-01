using System.Globalization;

namespace WriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Δήλωση κι αρχικοποίηση Μεταβλητών

            int num1 = 10_000_000;
            int num2 = 20_000_000;
            int result = 0;

            // Εντολές
            result = num1 + num2;

            // Εμφάνιση αποτελέσματος
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("el-GR");
            
            Console.WriteLine("Το άθροισμα των " + num1 + " και " + num2 + " είναι: " + result);
            Console.WriteLine("Το άθροισμα των {0,6:C2} και {1,6:C2} είναι: {2,10:C2}", num1, num2, result);
            Console.WriteLine($"Το άθροισμα των {num1,6:N2} και {num2,6:N2} είναι: {result,10:N2}");
        }
    }
}