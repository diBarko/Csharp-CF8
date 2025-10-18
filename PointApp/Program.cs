using PointApp.Model;

namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new() { X = 10 };
            Point2D point2 = new() { X = point.X, Y = 20 };
            Point3D point3 = new() { X = point.X, Y = point2.Y, Z = 30 };
            Point point4 = new Point3D() { X = 100, Y = 200, Z = 300};  // Type polymorphism
            Point2D point5 = new Point3D() { X = 1, Y = 2, Z = 3};

            Console.WriteLine($"point: ${point}");
            Console.WriteLine($"point2: ${point2}");
            Console.WriteLine($"point3: ${point3}");
            Console.WriteLine($"point4: ${point4}");
            Console.WriteLine($"point5: ${point5}");
        }

        // Polymorphic method, because param is polymorphic so @runtime any param IS-A Point.
        // Because parameters reference is resolved @runtime, it knows which Move5() to call.
        public static void DoMove5(Point p)
        {
            p.Move5();
        }

        public static void DoPrint(Point p)
        {
            Console.WriteLine(p);   // ToString() is invoked due to WriteLine being contextual method waiting string.
        }
    }
}