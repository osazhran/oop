using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP_06.Q3.Part_3
{
    internal abstract class User
    {
        public string Name { get; set; }
        public abstract Discount  GetDiscount(string name);
    }

    public enum UserTypes
    {
        RegularUser,//0 --Applies a PercentageDiscount of 5%
        PremiumUser,//1--Applies a FlatDiscount of $100.
        GuestUser//2 --No discount is applied
    }
}
