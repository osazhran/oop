using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP_06.Q3.Part_2
{
    public class FlatDiscount(int fixedamount) : Discount
    {


        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            var Amount = fixedamount * quantity;
            return Amount;


        }
    }
}
