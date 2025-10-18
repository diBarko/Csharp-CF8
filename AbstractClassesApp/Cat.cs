using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesApp
{
    internal class Cat : AbstractAnimal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says meow!");
        }

        public override string ToString()
        {
            return $"Id: {id}, Name: {Name}, Age: {Age}";
        }
    }
}
