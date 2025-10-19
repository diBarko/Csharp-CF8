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

            Console.Write($"Array of {listLength} : ");
            //foreach (int i in intList) Console.Write($"{i} ");
            intList.ForEach(item => Console.Write(item));
            Console.WriteLine("\n=============");

            // LinkedList
            var list = new LinkedList<string>();
            var item1 = list.AddFirst("CF1");
            list.AddAfter(item1, "CF2");
            var item8 = list.AddLast("CF8");
            list.AddBefore(item8, "CF7");
            list.Last!.Previous!.Previous!.Value = "AUEB";
            list.First!.Next!.Next!.Value = "Coding Factory";

            foreach (string s in list) Console.WriteLine(s);
        }
    }
}