using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class Teacher
    {
        // auto-implemented properties
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Teacher teacher &&
                   Id == teacher.Id &&
                   Firstname == teacher.Firstname &&
                   Lastname == teacher.Lastname;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Firstname, Lastname);
        }

        //public override string ToString()
        //{
        //    return $"{Id}, {Firstname}, {Lastname}";
        //}

        public override string ToString() => $"{Id}, {Firstname}, {Lastname}";
    }
}