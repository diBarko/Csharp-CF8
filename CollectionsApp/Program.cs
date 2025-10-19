using CollectionsApp.Model;

namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<T>

            var intList = new List<int>();
            intList.Add(item: 1);               // adds item at the end
            intList.AddRange(collection: new int[] { 2, 3, 4 });    // add from an array to the end
            intList.Insert(index: 0, item: 0);  // insert item at index
            intList.Remove(item: 1);            // removes item if found. requires Equals() to be implemented.
            intList.RemoveAt(index: 2);         // removes item at index 2
            intList.Reverse();                  // reverses the items in list
            intList.Sort();                     // natural sort
            int listLength = intList.Count();   // counts elements

            int num = intList[1];               // read data
            intList[1] = 10;                    // direct update using indexer

            //Console.Write($"Array of {listLength} : ");
            //foreach (int i in intList) Console.Write($"{i} "); Console.WriteLine();
            //intList.ForEach(item => Console.Write($"{item} ")); Console.WriteLine();

            // LinkedList
            var list = new LinkedList<string>();
            var item1 = list.AddFirst("CF1");
            list.AddAfter(item1, "CF2");
            var item8 = list.AddLast("CF8");
            list.AddBefore(item8, "CF7");
            list.Last!.Previous!.Previous!.Value = "AUEB";
            list.First!.Next!.Next!.Value = "Coding Factory";

            //foreach (string s in list) Console.Write($"{s} "); Console.WriteLine();

            // Dictionaries <K,V>
            var words = new Dictionary<int, string>();
            words.Add(1, "Hello");
            words[2] = "AUEB";
            words[2] = "Coding-Factory";
            words.Remove(1);

            //foreach (var keyValue in words) Console.WriteLine($"Key:{keyValue.Key}, Value:{keyValue.Value}");

            // Stack -- LIFO
            var stack = new Stack<string>();
            stack.Push("ABC-1234");
            stack.Push("ABC-2345");
            stack.Push("ABC-3456");
            stack.Push("ABC-4567");
            var lastCar = stack.Pop();

            //foreach (var item in stack) Console.WriteLine(item);

            // Queue -- FIFO
            var queue = new Queue<string>();
            queue.Enqueue("ABC-1234");
            queue.Enqueue("ABC-2345");
            queue.Enqueue("ABC-3456");
            queue.Enqueue("ABC-4567");
            var firstCar = queue.Dequeue();

            //foreach (var item in queue) Console.WriteLine(item);

            // Set
            var s1 = new SortedSet<string>() { "Coding", "Factory", "AUEB" };   // Collection initializer
            var s2 = new HashSet<string>() { "Coding", "Hello", "World" };

            s1.Add("Hello");
            s2.Add("World");    // this will fail because sets are unique
            s2.Add("AUEB");

            s1.ExceptWith(s2);  // removes from s1, elements matched from s2
            s1.UnionWith(s2);

            //foreach (string word in s1) Console.Write($"{word} ");

            // Products
            List<Product> products = new() {
                new Product() { Description = "Milk", Price = 10, Quantity = 20 },
                new Product() { Description = "Honey", Price = 20.5, Quantity = 18 },
                new Product() { Description = "Eggs", Price = 4.5, Quantity = 50 }
            };

            products.Sort();
            products.ForEach(Console.WriteLine);

            products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            products.ForEach(Console.WriteLine);

            products.Sort((p1, p2) => p1.Quantity - p2.Quantity);
            products.ForEach(Console.WriteLine);
        }
    }
}