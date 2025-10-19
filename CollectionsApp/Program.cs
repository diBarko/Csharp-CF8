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
            foreach (int i in intList)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
