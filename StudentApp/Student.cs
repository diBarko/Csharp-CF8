using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    /// <summary>
    /// POCO ( Plain Old CLR Object)
    /// </summary>
    internal class Student
    {
        private readonly int id;
        private readonly string? firstname;
        private readonly string? lastname;
        // Expression-body memmbers, simplified logic of public properties
        public int Id { get => id; }
        public string? Firstname { get => firstname; }
        public string? Lastname { get => lastname; }

        // Public properties
        //public int Id { get { return id; } set { id = value; } }
        //public string Firstname { get { return firstname; } set { firstname = value; } }
        //public string Lastname { get { return lastname; } set { lastname = value; } }

        // Expression-body memmbers, simplified logic of public properties
        //public int Id { get => id; set => id = value; }
        //public string? Firstname { get => firstname; set => firstname = value; }
        //public string? Lastname { get => lastname; set => lastname = value; }

        // We can set the setter private, not allowing anything to edit the property (obj. initers included).
        //public int Id { get { return id; } private set { id = value; } }
        //public string Firstname { get { return firstname; } private set { firstname = value; } }
        //public string? ImmutableLastname { get { return lastname; } private set { lastname = value; } }

        // Or not having setter at all. No obj. initer can set and not even class can set properties.
        // Can be combined with expressive declaration of properties usin readonly keyword.
        //public readonly int Id { get => id; }
        //public string Firstname { get => firstname; }
        //public string? ImmutableLastname { get => lastname; }

        // Post c# 9 we can initialize a property, but not change it later (making it immutable), can be used by OL-constr and\or obj. initers
        //public int Id { get { return id; } init { id = value; } }
        //public string Firstname { get { return firstname; } init { firstname = value; } }
        //public string? ImmutableLastname { get { return lastname; } init { lastname = value; } }

        public Student() { }

        public Student(int id, string? firstname, string? lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}