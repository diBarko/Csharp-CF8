namespace GradesApp
{
    /// <summary>
    /// Λαμβάνει ως είσοδο το άροισμα της βαθμολογίας και το πλήθος
    /// των μαθημάτων και εκτυπώνει τον μέσο όρο χαρακτηρίζοντάς τον.
    /// (ΑΡΙΣΤΑ, ΠΟΛΥ ΚΑΛΑ, ...)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double average = 0;
            Console.WriteLine("Παρακαλώ εισάγετε το άθροισμα της βαθμολογίας και το πλήθος των μαθημάτων:");
            if (!int.TryParse(Console.ReadLine(), out int gradesSum) || gradesSum < 0)
            {
                Console.WriteLine("Σφάλμα κατά την εισαγωγή.");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out int numberOfCourses) || numberOfCourses < 0)
            {
                Console.WriteLine("Σφάλμα κατά την εισαγωγή.");
                return;
            }

            average = gradesSum / (double)numberOfCourses;

            if (average > 10)
            {
                Console.WriteLine("Λάθος δεδομένα. Ο μέσος όρος δεν μπορεί να είναι μεγαλύτερος από 10.");
                return;
            }
            
            Console.Write($"Μέσος Όρος [{average}] : ");
            switch (average)
            {
                case >= 8: Console.WriteLine("Άριστα"); break;
                case >= 6: Console.WriteLine("Πολύ καλά"); break;
                case >= 5: Console.WriteLine("Καλά"); break;
                default: Console.WriteLine("Ανεπαρκώς"); break;
            }
        }
    }
}