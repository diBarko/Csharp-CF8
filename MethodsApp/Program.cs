using System.Text;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine($"x: {x}, y: {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x: {x}, y: {y}");

            DateTime date = GetDateTime(day: 15, month: 8);
            DateTime date2 = GetDateTime(2026, 12, 25, 10, 30, 0);
            Console.WriteLine($"{date}");
            Console.WriteLine($"{date:D}");
            Console.WriteLine($"{date:F}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        public static void Swap(ref int x, ref int y)
        {
            // (y, x) = (x, y); // tuples alternative
            int tmp = x;
            x = y;
            y = tmp;
        }

        // java varargs
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        // Optional parameters
        public static DateTime GetDateTime(int year = 2025, int month = 1, int day = 1,
                                            int hour = 0, int minute = 0, int second = 0)
        {
            return new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
        }

        public static void PrintMessage(string message = "Hello, World!")
        {
            Console.WriteLine(message);
        }

        public static void PrintMessage(string prefix = "Message:", string message = "Hello, World!")
        {
            Console.WriteLine($"{prefix} {message}");
        }

        public static void PrintMessage(int inputNum)
        {
            Console.WriteLine($"{inputNum}");
        }

        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool isOdd(int number)
        {
            //return number % 2 != 0;
            return !isEven(number);
        }

        //public static int GetMax(int a, int b) => a > b ? a : b;      // lambda
        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static double CelciusToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }

        // StringBuilder
        public static string StrRepeat(string s, int count)
        {
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                newStr.Append(s);
            }

            return newStr.ToString();
        }

        public static bool IsPalindromeIgnoreCase(string s)
        {
            string newStr = s.ToLower();

            for (int i = 0, j = newStr.Length; i < j; i++, j--)
            {
                if (newStr[i] != newStr[j])
                {
                    return false;
                }
            }
            return true;
        }

        public static string RandomPinFourDigits()
        {
            Random random = new Random();
            int pin = random.Next(1000, 100000);    // Generates a number between 1000 and 9999
            return pin.ToString();
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap with tuples
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i+= 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // Greatest Common Divisor
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static int Fibonacci(int n)      // looping
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        public static int Fibonacci2(int n)      // recursively
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            
            return Fibonacci2(n - 1) + Fibonacci2(n - 2);

            
        }
}