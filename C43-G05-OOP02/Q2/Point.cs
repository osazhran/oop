

namespace C43_G05_OOP02.Q2
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y {  get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static double ClacDist(Point p1,Point p2)
        {
            double Dx = (p1.X - p2.X);
            double Dy= (p1.Y - p2.Y);
            return Math.Sqrt(Dx * Dx + Dy * Dy);

        }
        public static Point GetPointFromUser(string pointorder)
        {
            Console.WriteLine($"Enter coordinates of the {pointorder} point:");
            Console.Write("X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            return new Point(x, y);
        }

    }

}
