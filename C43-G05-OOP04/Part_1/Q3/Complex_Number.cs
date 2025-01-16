/*Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
     *Note: Overload the +, - operator to add and subtract two complex numbers.
 */


//Example of complex Number 
// 3 + 4i
// 3 - 4i

//4+5i + 8+12i

using System.Linq.Expressions;
using System.Numerics;

namespace C43_G05_OOP03.Part_1.Q3
{

    internal class Complex_Number
    {
        //(5+2i)+(4-1i)= (5+4)+(2i-1i)
        public double Real { set; get; }
        public double Imaginary { set; get; }
        public Complex_Number(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static Complex_Number operator +(Complex_Number a, Complex_Number b)
        {
            //(5+2i)+(4-1i)= (5+4)+(2i-1i)
            return new Complex_Number(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
        public static Complex_Number operator -(Complex_Number a, Complex_Number b)
        {
            return new Complex_Number(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }

    }
}
