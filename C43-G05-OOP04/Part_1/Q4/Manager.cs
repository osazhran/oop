using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP03.Part_1.Q4
{
    internal class Manager : EmployeeBase
    {
        public new void Work_as()
        {
            Console.WriteLine("Manager is managing");
        }
    }
}
