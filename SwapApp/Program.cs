namespace SwapApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 2;
            Console.WriteLine($"Initial: (a[{a}], b[{b}])");
            Swap(a, b);
            Console.WriteLine($"Swap: (a[{a}], b[{b}])");
            SwapWithTuple(a, b);
            Console.WriteLine($"Swap with tuple: (a[{a}], b[{b}])");
        }

        public static void SwapWithTuple(int a, int b)
        {
            (a, b) = (b, a);
        }

        public static void Swap(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
