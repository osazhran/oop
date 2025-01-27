using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01
{
    internal  class FixedSizeList<T>
    {
        public int Capacity { get; set; }

        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
        }
        public  void Add(T element, List<T> list)
        {
            if(list?.Count>0&&list.Count<Capacity)
            {
                list.Add(element);
            }
            else
                Console.WriteLine("it is full");
           
        }

        public void Get(int index, List<T> list)
        {
            if(index < Capacity)
            {
                Console.WriteLine(list[index]);
            }
            throw new Exception(" invalid indices");
        }
    }
}
