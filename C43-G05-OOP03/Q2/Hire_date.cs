﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP03.Q2
{
    internal class Hire_date
    {
       

        public int Year {  get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Hire_date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }


    }
}
