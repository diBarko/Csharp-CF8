namespace StrEqualsAndCompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "AUEB";
            string s2 = "AUEB";

            Console.WriteLine($"{s1.Equals(s2)}");  // context equality
            Console.WriteLine($"{s1 == s2}");       // context equality, not reference
            Console.WriteLine($"Reference check: {Object.ReferenceEquals(s1, s2)}");    // reference equality

            int result = s1.CompareTo(s2);                // lexical equality -- prone to null reference exception
            int result2 = string.Compare(s1,s2, true);    // lexical equality -- null reference safe


        }
    }
}