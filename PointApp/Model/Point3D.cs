using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointApp.Model
{
    internal class Point3D : Point2D
    {
        public int Z { get; set; }

        public override void Move5()
        {
            base.Move5();
            Z += 5;
        }

        public override string? ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}