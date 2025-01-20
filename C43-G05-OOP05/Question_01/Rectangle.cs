using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP05.Question_01
{
    internal class Rectangle : IRectangle
    {
        public Rectangle(int area)
        {
            Area = area;
        }

        public int Area { get ; set ; }

        public  void DisplayShapeInfo()
        {
            Console.WriteLine("it is rectangle");
        }
    }
}
