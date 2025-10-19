using FileManagement.Model;

namespace FileManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<char> fileList = new();
            GenericNode<char>? node;
            int totalChars = 0;
            string filePath = @"D:\tmp\test.txt";
            char ch;
            int ordinal;

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found: {filePath}");
                    return;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while ((ordinal = reader.Read()) != -1)
                    {
                        ch = (char)ordinal;
                        if (ch is '\r' or '\n') continue;

                        node = fileList.FindNode(ch);
                        if (node == null)
                        {
                            fileList.InsertLast(ch);
                        }
                        else
                        {
                            fileList.IncreaseCount(ch);
                        }
                        totalChars++;
                    }
                }
                fileList.SortByCount();
                fileList.Traverse(totalChars);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}