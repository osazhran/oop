using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV01
{
    public class Range<T> where T : IComparable<T>

    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                throw new ArgumentException("Minimum cannot be greater than Maximum.");
            }
            Min = min;
            Max = max;
        }


        public bool IsInRange(T value)
        {

            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;


        }

        public dynamic Length()
        {
            try
            {
                return (dynamic)Max - (dynamic)Min;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Cannot calculate length for type {typeof(T)}. Ensure it supports subtraction.", ex);
            }
        }
        public override string ToString()
        {
            return $"Range: [{Min}, {Max}]";
        }

    }
}
