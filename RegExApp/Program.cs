using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace RegExApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "This is CF!";
            string s2 = @"CF";
            bool isMatch = TestCF(s);
            bool isMatch2 = TestCF(s2);
            //Console.WriteLine($"Search line for match: {isMatch}");
            //Console.WriteLine($"Search exact line match: {isMatch2}");
            //Console.WriteLine($"Search first match: {TestMatch(s)}");

            string s3 = "1980-05-12 1987-11-06";

            TestGroups(s3);
        }

        public static bool TestCF(string? s)
        {
            string? pattern = @"^CF$";

            bool isMatch = Regex.IsMatch(s!, pattern);
            return isMatch;
        }

        public static string TestMatch(string? s)
        {
            string? pattern = @"CF";
            Match match = Regex.Match(s!, pattern);

            if (match.Success)
            {
                return ($"Found match: {match.Value} at index {match.Index}.");
            }
            else
            {
                return("No match found.");
            }
        }

        public static void TestMatches(string? s)
        {
            string? pattern = @"\d+"; // Match sequences of digits

            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Found match: {match.Value} at index {match.Index}.");
            }
        }

        public static void TestGroups(string? s)
        {
            string? pattern = @"(\d{4})-(\d{2})-(\d{2})";   // Match date in YYYY-MM-DD format
            MatchCollection matches = Regex.Matches(s!, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Full Match: {match.Value}");
                for (int i = 1; i < match.Groups.Count; i++)
                {
                    Console.WriteLine($"Group {i}: {match.Groups[i].Value}.");
                }
            }
        }
    
        public static bool TestPassword(string? input)
        {
            return Regex.IsMatch(input, @"(?=.*?[a-z])(?=.*?[A-Z])(?=.*?\d)(?=.*?[@$!%*?&])^.{8,}$");
        }
    }
}