//using System;  // Not necessary in Visual Studio, it is done 

namespace HelloWorld
{
    /// <summary>
    /// My first C# Program!
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");
            Console.WriteLine("");
            string s = "World!";
            Console.WriteLine("Hello {0}", s);

            Console.WriteLine($"Hello {s}");
        }
    }
}