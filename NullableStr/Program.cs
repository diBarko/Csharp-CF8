namespace NullableStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //string s1 = null!;  // non-nullable warning      - to ignore this we could add null forgiving operator
            string? s1 = null;  // null-conditional operator
            string? s2 = null;  // nullable                  - can still get null reference exception
            string s3 = null!;  // null forgiving operator   - JUST to supress warning @ compile time

            s1 = Console.ReadLine();
            s2 = Console.ReadLine();

            //if (s1.Equals("Coding") && s2!.Equals("Coding"))
            if ((s1 != null) && s1.Equals("Coding") && (s2 != null) && s2.Equals("Coding"))
            {
                Console.WriteLine("Bingo");
            }
        }

        public static string? GetUpperString(string? s)
        {
            return s?.ToUpper();
        }

        public static string GetUpperString2(string? s)
        {
            return s?.ToUpper() ?? "NULL";  //  null-coalescing operator
        }
    }
}
