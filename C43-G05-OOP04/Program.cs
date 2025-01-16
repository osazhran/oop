
using C43_G05_OOP03.Part2;
using C43_G05_OOP03.Part_1.Q5;
using C43_G05_OOP03.Part_1.Q4;
using C43_G05_OOP03.Part_1.Q1;
using C43_G05_OOP03.Part_1.Q3;

namespace C43_G05_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            #region Q1 Calculator 
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5, 6));
            Console.WriteLine(calc.Add(7, 8, 7));
            Console.WriteLine(calc.Add(9.5, 10.5));
            #endregion
            #region Q3 Complex Number
            Complex_Number cn = new Complex_Number(5, 2);
            Complex_Number cn2 = new Complex_Number(7, 3);
            Complex_Number sum = (cn + cn2);
            Complex_Number diff = cn - cn2;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Diff: {diff}");
            #endregion
            #region Q4 Employee
            EmployeeBase emp = new EmployeeBase();
            emp.Work_as();

            Manager mgr = new Manager();
            mgr.Work_as();
            #endregion
            #region Q5 BaseClass 
            //Tha Same Ref and Obj
            BaseClass baseClass = new BaseClass();
            baseClass.DisplayMessage();

            ///Ref of BaseClass And Obj From DerivedClass1 
            ///Their I Ovverride With 1st Way By Ovverride So It Run Time ,late bindig,danamic
            ///And it Depend on Object so it Will Call Fun of DerivedClass1
            /// Itn Slow But More Flexable

            BaseClass baseClassobj = new DerivedClass1();
            baseClassobj.DisplayMessage();

            ///Ref of BaseClass And Obj From BaseClass
            ///And Ovverride With New Keyord So it Cpomplition Time Or Early Binding Or Static Bindig
            ///It Will Retun Fun Of Referenc Type 
            ///It Fast 
            BaseClass baseClassobj2 = new DerivedClass2();
            baseClassobj2.DisplayMessage();
            #endregion
            #endregion
            #region Part2

            Duration D = new Duration(4, 20, 50);
            Console.WriteLine("D            is " + D.ToString());

            Duration D1 = new Duration(3600);
            Console.WriteLine("D1           is " + D1.ToString());

            Duration D2 = new Duration(7800);
            Console.WriteLine("D2           is " + D2.ToString());

            Duration D3 = new Duration(666);
            Console.WriteLine("D3           is " + D3.ToString());

            D3 = D1 + D2; //D3=D1+D2
            Console.WriteLine("D3 = D1 + D2 is " + D3.ToString());

            D3 = D1 + 7800; //D3=D1 + 7800
            Console.WriteLine("D3 = D1+7800 is " + D3.ToString());

            D3 = 666 + D3;  //D3=666+D3
            Console.WriteLine("D3 =666+D3   is " + D3.ToString());

            D3 = ++D1; //(Increase One Minute)
            Console.WriteLine("D3 = ++D1    is " + D1.ToString());

            D3 = --D2; // (Decrease One Minute)
            Console.WriteLine("D3 = --D2    is " + D2.ToString());

            D1 = D1 - D2; // D1 = D1 - D2;
            Console.WriteLine("D1 = D1-D2   is " + D1.ToString());

            if (D1 > D2) //D1 > D2)

                Console.WriteLine("D1 > D2 ");

            else if (D1 < D2)
                Console.WriteLine("D1 < D2");
            else
                Console.WriteLine("D1 Equals D2");

            if (D1 >= D2)  //D1 >= D2

                Console.WriteLine("D1 >= D2 ");
            else
                Console.WriteLine(" D1 < D2 ");

            if (D1) //D1
            {
                Console.WriteLine($"D1 is {D1}");
            }

            //DateTime Obj = (DateTime)D1; //DateTime Obj = (DateTime) D1
            //Console.WriteLine(Obj.ToLongTimeString());

            #endregion

        }



    }
}
