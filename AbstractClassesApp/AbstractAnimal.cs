using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesApp
{
    internal abstract class AbstractAnimal
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public double Age{ get; set; }

        // using abstract keyword, we force derived classes to implement these methods.
        public abstract override string ToString();

        public abstract void Speak();

        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
}