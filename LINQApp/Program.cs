namespace LINQApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



        }

        // Query Syntax     -- Expression-bodied Members
        public static IEnumerable<int> GetAllNumbers(int[] numbers) =>
            from num in numbers select num;  // SELECT * FROM NUMBERS
        /*{
            return from num in numbers select num;  // SELECT * FROM NUMBERS
        }*/

        // Method Syntax    -- Lambda
        public static IEnumerable<int> GetAllItems(int[] numbers) =>
            numbers.Select(num => num);

        // Filtering == WHERE
        public static int[] FilterToArray(int[] numbers)
        {
            //      Query Syntax

            //return (from num in numbers where (num % 2 == 0) select num).ToArray();
            // Collection Expression
            // If compiler can infer the return data type, it's converted to the declared data type (int[]  in our case)
            //return [.. (from num in numbers where (num % 2 == 0) select num)];


            //      Method Syntax
            //return numbers.Where(num => num % 2 == 0).ToArray();
            return [.. numbers.Where(num => num % 2 == 0)];
        }

        public static List<int> FilterToList(int[] numbers)
        {
            //      Query Syntax

            //return (from num in numbers where (num % 2 == 0) select num).ToList();
            //return [.. (from num in numbers where (num % 2 == 0) select num)];

            //      Method Syntax
            //return numbers.Where(num => num % 2 == 0).ToList();
            return [.. numbers.Where(num => num % 2 == 0)];
        }


        // Mapping == SELECT
        public static int[] MapToOddToDoubleArray(int[] numbers)
        {
            //      Query Syntax
            //return [.. (from num in numbers where (num % 2 != 0) select num * 2)];
            //return (from num in numbers where (num % 2 != 0) select num * 2).ToArray();

            //      Method Syntax
            //return numbers.Where(n => n % 2 != 0).Select(n => n * 2).ToArray();
            return [.. numbers.Where(n => n % 2 != 0).Select(n => n * 2)];
        }

        public static List<int> MapToOddToDoubleList(int[] numbers)
        {
            //      Query Syntax
            //return [.. (from num in numbers where (num % 2 != 0) select num * 2)];
            //return (from num in numbers where (num % 2 != 0) select num * 2).ToList();//return (from num in numbers where (num % 2 != 0) select num * 2).ToArray();

            //      Method Syntax
            //return numbers.Where(n => n % 2 != 0).Select(n => n * 2).ToList();
            return [.. numbers.Where(n => n % 2 != 0).Select(n => n * 2)];
        }

        
        // Reduction
        public static int SumAll(int[] numbers)
        {
            //      Query Syntax
            //return (from num in numbers select num).Sum();

            //      Method Syntax
            return numbers.Sum();
        }

        public static double AverageAll(int[] numbers)
        {
            //return (from num in numbers select num).Average();
            return numbers.Average();
        }

        public static int CountAll(int[] numbers)
        {
            //return (from num in numbers select num).Count();
            return numbers.Count();
        }

        public static int FinMin(int[] numbers)
        {
            //return (from num in numbers select num).Min();
            return numbers.Min();
        }

        public static int FinMax(int[] numbers)
        {
            //return (from num in numbers select num).Max();
            return numbers.Max();
        }

        public static int[] SortAsc(int[] numbers)
        {
            //return (from num in numbers orderby num ascending select num).ToArray();
            return numbers.OrderBy(n => n).ToArray();
        }

        public static int[] SortDesc(int[] numbers)
        {
            //return (from num in numbers orderby num descending select num).ToArray();
            return numbers.OrderByDescending(n => n).ToArray();
        }

        public static int[] ReverseArray(int[] numbers)
        {
            return numbers.Reverse().ToArray();
        }

        public static int[] DistinctArray(int[] numbers)
        {
            return numbers.Distinct().ToArray();
        }

        public static bool AllGreaterThanFive(int[] numbers)
        {
            //return (from num in numbers select num).All(n => n > 5);
            return numbers.All(n => n > 5);
        }

        public static bool AnyGreaterThanFive(int[] numbers)
        {
            //return (from num in numbers select num).Any(n => n > 5);
            return numbers.Any(n => n > 5);
        }

        public static int FindFirstOrDefault(int[] numbers)
        {       // int default is 0
            //return (from num in numbers select num).FirstOrDefault(n => n > 5);
            return numbers.FirstOrDefault(n => n > 5);
        }
    }
}