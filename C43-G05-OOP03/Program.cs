using C43_G05_OOP03.Part_01;
using C43_G05_OOP03.Q2;

namespace C43_G05_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hire_date hireDate1 = new Hire_date(10, 5, 2020);
            Employees employees = new Employees(1,"osamm",Securitylevel.DBA,50000, hireDate1, Gender.Male);
            Console.WriteLine(employees);
        }
    }
}
