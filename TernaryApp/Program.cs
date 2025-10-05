namespace TernaryApp
{
    /// <summary>
    /// Τριαδικός τελεστής μέσα σε WriteLine.
    /// Επιστρέφει το απόλυτο ενός ακεραίου
    /// που δίνει ο χρήστης
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Παρακαλώ εισάγετε έναν ακέραιο:");
            if (!int.TryParse(Console.ReadLine(), out int inputNum))
            {
                Console.WriteLine("Σφάλμα κατά την εισαγωγή.");
                return;
            }
            Console.WriteLine("Το απόλυτο του {0} = {1}", inputNum, (inputNum >= 0) ? inputNum : -inputNum);
        }
    }
}