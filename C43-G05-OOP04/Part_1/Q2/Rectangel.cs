using System.Drawing;

/*
 Q2) Create a class named Rectangle with the following constructors:
A parameterless constructor that sets the width and height to 0.
A constructor that accepts width and height as integers.
A constructor that accepts a single integer and sets both width and height to that value.
*/

namespace C43_G05_OOP03.Part_1.Q2
{
    internal class Rectangel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //A parameterless constructor that sets the width and height to 0.
        public Rectangel()
        {

        }
        //A constructor that accepts width and height as integers.
        public Rectangel(int width, int height)
        {


        }
        //A constructor that accepts a single integer and sets both width and height to that value.
        public Rectangel(int width)
        {
            Width = width;
            Height = width;
        }
    }
}
