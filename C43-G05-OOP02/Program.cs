using C43_G05_OOP02.Q1;
using C43_G05_OOP02.Q2;

namespace C43_G05_OOP02
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1
            Person[] people = new Person[3];
            people[0] = new Person("osama", 25);
            people[1] = new Person("djd", 25);
            people[2] = new Person("moh", 25);
            Console.WriteLine("all member is");
            foreach (var p in people)
            {
                p.Display();
            }
            #endregion
            #region Q2
            
            // إدخال النقطتين من المستخدم باستخدام الدالة المساعدة
            Point point1 =Point. GetPointFromUser("frist");
            Point point2 = Point.GetPointFromUser("secnd");

            // حساب المسافة بين النقطتين
            double distance = Point.ClacDist(point1, point2);
            Console.WriteLine(distance);
            #endregion
        }
    }
}
