namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type    | Size     | MinValue".PadRight(60) + "| MaxValue");
            Console.WriteLine("--------|----------|---------".PadRight(60) + "|---------");
            Console.WriteLine($"int     | {sizeof(int) * 8} bits  | {int.MinValue:N0}".PadRight(60) + $"| {int.MaxValue:N0}");
            Console.WriteLine($"byte    | {sizeof(byte) * 8} bits  | {byte.MinValue}".PadRight(60) + $"| {byte.MaxValue}");
            Console.WriteLine($"short   | {sizeof(short) * 8} bits  | {short.MinValue:N0}".PadRight(60) + $"| {short.MaxValue:N0}");
            Console.WriteLine($"long    | {sizeof(long) * 8} bits  | {long.MinValue:N0}".PadRight(60) + $"| {long.MaxValue:N0}");
            Console.WriteLine($"float   | {sizeof(float) * 8} bits  | {float.MinValue:E2}".PadRight(60) + $"| {float.MaxValue:E2}");
            Console.WriteLine($"double  | {sizeof(double) * 8} bits | {double.MinValue:E2}".PadRight(60) + $"| {double.MaxValue:E2}");
            Console.WriteLine($"decimal | {sizeof(decimal) * 8} bits | {decimal.MinValue:N0}".PadRight(60) + $"| {decimal.MaxValue:N0}");
        }
    }
}