using InterfacesApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionApp
{
    internal class MovingSpace
    {
        public IMovable? Movable { get; set; }

        public MovingSpace(IMovable? movable)
        {
            Movable = movable;
        }

        public void MakeMove5() => Movable!.Move5();
    }
}
