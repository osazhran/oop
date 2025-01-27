using C43_G05_OOP_06.Q3.Part_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP_06.Q3.Part_3
{
    internal class RealUser : User
    {
        public override Discount GetDiscount(string name)
        {
            switch (UserTypes )
            {
                case UserTypes.RegularUser:
                    
                    break;

                case UserTypes.PremiumUser:
                    
                    break;

                case UserTypes.GuestUser:
                    
                    break;

                
            }
        }
    }
}
