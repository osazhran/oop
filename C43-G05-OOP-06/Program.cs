using C43_G05_OOP_06.Q3.Part_3;
using System.Net;

namespace C43_G05_OOP_06
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            #region Q1
            ///Point3D point3D = new Point3D(10,10,10);
            ///Console.WriteLine(point3D.ToString());
            int a, b, c;
            // Point3D P1 = new Point3D();U Need Fun To Recive Input From User
            Point3D P1 = ReadPoint();
            //Console.WriteLine($"Enter Point 1 {P1}");


            //{enter x ={x},y={y},z={z}}
            //point1=(x,y,z)
            Point3D P2 = ReadPoint();
            //Console.WriteLine($"Enter Point 2 {P2} ");
            //{enter x ={x},y={y},z={z}}
            //point1=(x,y,z)
            static Point3D ReadPoint()
            {
                int x, y, z;
                return new Point3D();


            }
            #endregion
            #region Q2
            //Console.WriteLine(Math.Add(5, 7));
            //Console.WriteLine(Math.Subtract(5, 7));
            //Console.WriteLine(Math.Multiyply(5, 7));
            //Console.WriteLine(Math.divid(5, 7));

            #endregion
            #region Q3
            Console.WriteLine("Enter your user type (RegularUser, PremiumUser, GuestUser):");

            var userInput = Console.ReadLine();

            if (Enum.TryParse(userInput, out UserTypes userType))
            {
                switch (userType)
                {
                    case UserTypes.RegularUser:
                        Console.WriteLine("You are a Regular User. A 5% discount will be applied.");
                        break;

                    case UserTypes.PremiumUser:
                        Console.WriteLine("You are a Premium User. A $100 discount will be applied.");
                        break;

                    case UserTypes.GuestUser:
                        Console.WriteLine("You are a Guest User. No discount will be applied.");
                        break;

                    default:
                        Console.WriteLine("Invalid user type.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid user type.");
            }

            Console.WriteLine("Enter your Product Details (Price, Quantity):");

            User userInfo = Console.ReadLine();

            #endregion

        }
    }
}
