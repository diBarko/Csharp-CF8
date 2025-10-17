namespace StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student alice = new Student();
            Student bob = new ();
            var kostas = new Student();
            
            
            // default constructor
            Student student = new Student();
            // overloaded constructor
            Student student1 = new Student(1, "Denis", "Barko");
            // object initializer
            Student student2 = new Student() { Id = 2, Firstname = "Γιάννης", Lastname = "Γεωργίου" };
            // object initializers can used with var args, thus more flexible
            Student student3 = new Student() { Id = 3, Lastname = "Ιωάννου"};
            Console.WriteLine($"Id= {student.Id}, Firstname= {student.Firstname}, Lastname= {student.Lastname}, Hashcode= {student.GetHashCode()}");
            Console.WriteLine($"Id= {student1.Id}, Firstname= {student1.Firstname}, Lastname= {student1.Lastname}, Hashcode= {student1.GetHashCode()}");
            Console.WriteLine($"Id= {student2.Id}, Firstname= {student2.Firstname}, Lastname= {student2.Lastname}, Hashcode= {student2.GetHashCode()}");
            Console.WriteLine($"Id= {student3.Id}, Firstname= {student3.Firstname}, Lastname= {student3.Lastname}, Hashcode= {student3.GetHashCode()}");
            Console.WriteLine("\n=======================\n");
            Teacher teacher = new() { Id = 1, Firstname = "Atha.", Lastname = "Androutsos" };
            Console.WriteLine($"Id= {teacher.Id}, Firstname= {teacher.Firstname}, Lastname= {teacher.Lastname}, Hashcode= {teacher.GetHashCode()}");
            teacher.Id = 2;
            teacher.Firstname = "Athanasios";
            teacher.Lastname = "Androutsopoulos";

            Console.WriteLine($"Id= {teacher.Id}, Firstname= {teacher.Firstname}, Lastname= {teacher.Lastname}, Hashcode= {teacher.GetHashCode()}");
        }
    }
}