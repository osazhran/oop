using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP01.Q3
{
    [Flags]
    internal enum Permissions
    {
        None = 0,          // No Peremesion
        Read = 1,          // 0001
        Write = 2,         // 0010
        Delete = 4,        // 0100
        Execute = 8        // 1000
    }
}
