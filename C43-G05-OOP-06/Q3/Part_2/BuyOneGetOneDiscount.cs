using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP_06.Q3.Part_2
{
    public class BuyOneGetOneDiscount : Discount
    {
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            var Amount = 0m;
            if (quantity > 1)
                Amount = price / 2 * (quantity / 2);
            return Amount;
        }
    }
}
