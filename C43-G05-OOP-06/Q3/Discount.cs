using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP_06.Q3
{
    public abstract class Discount
    {
        public string Name { get; set; }


        public abstract decimal CalculateDiscount(decimal price, int quantity);
        




    }

 
  




  


}
