using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP_06.Q3.Part_2
{
    public class PercentageDiscount(decimal Percentage) : Discount
    {

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            var Amount = price * quantity * (Percentage / 100);
            return Amount;
        }
    }
}
