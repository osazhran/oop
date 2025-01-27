using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP_06
{
    public class Point3D
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public Point3D(int x, int y, int z) 
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D()
        {
            
        }

        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }
       

    }
}
