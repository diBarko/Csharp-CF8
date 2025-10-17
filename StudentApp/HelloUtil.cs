using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    // describing a class as static, no constructor is available making it utility class
    internal static class HelloUtil
    {

        public static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}