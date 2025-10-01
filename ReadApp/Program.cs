namespace ReadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            float f = 0.0f;
            double d = 0d;

            Console.WriteLine("Παρακαλώ εισάτε δύο δεκαδικούς:");
            f = float.Parse(Console.ReadLine()!);
            d = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"f = {f:N2}\td = {d:N2}");
        }
    }
}