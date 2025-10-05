namespace CharReadDoWhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charCode;
            char inputChar;

            do
            {
                charCode = Console.Read();
                inputChar = (char)charCode;
                Console.WriteLine($"char: {inputChar} - charCode: {charCode}");
            } while (charCode != 10);// || charCode != 13); // Enter key (CR or LF)
        }
    }
}
