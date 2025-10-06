namespace StringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;              // non-nullable
            string? s2 = null;             // nullable     implies to static analyzer that this could be null
            string s3 = "AUEB";     // immutable
            string s4 = "AUEB";     // interning, more like scp in java
            string s5 = new string("AUEB");
        }
    }
}