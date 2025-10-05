namespace IgnoreNegativesApp
{
    internal class Program
    {
        /// <summary>
        /// Μετράει το πλήθος των θετικών
        /// όσο το input δεν είναι μηδέν.
        /// </summary>
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Παρακαλώ εισάγετε έναν ακέραιο:");
            if (!int.TryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("Invalid input for number of integers.");
                return;
            }

            while (num != 0)
            {
                if (num > 0) count++;

                Console.WriteLine("Παρακαλώ εισάγετε έναν ακέραιο:");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input for number of integers.");
                    return;
                }
            }

            Console.WriteLine($"Το πλήθος των θετικών είναι {count}.");
        }
    }
}