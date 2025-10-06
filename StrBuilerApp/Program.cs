using System.Text;

namespace StrBuilerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(DateTime.Now);
            sb.Append("Number: ");

            for (int i = 0; i < 100_000_000; i++)
            {
                sb.Append(i);
            }

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(sb.ToString().Substring(0, 128));
        }
    }
}