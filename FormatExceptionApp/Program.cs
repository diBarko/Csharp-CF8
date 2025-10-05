namespace FormatExceptionApp
{
    /// <summary>
    /// Διαβάζει ένα string εισόδου και προσπαθεί
    /// να το μετατρέψει σε int κι ελέγχει με try/catch
    /// για FormatException.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            while (true)
            {
             
                try
                {
                    Console.Write("Δώσε έναν ακέραιο αριθμό (0 για έξοδο) : ");
                    num = int.Parse(Console.ReadLine()!);
                    if (num == 0) break;
                    Console.WriteLine($"Εισάγατε τον ακέραιο: {num}");
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"Σφάλμα: {e.Message}\nΜη έγκυρη μορφή αριθμού. Προσπάθησε ξανά.");
                }
            }
        }
    }
}
