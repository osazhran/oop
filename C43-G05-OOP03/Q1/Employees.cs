using C43_G05_OOP03.Q2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C43_G05_OOP03.Part_01
{
    internal class Employees
    {


        public int ID { get; set; }
        public string Name { get; set; }
        public Securitylevel securitylevel { get; set; }
        public decimal salary { get; set; }
        public Hire_date hire_date { get; set; }
        public Gender gender { get; set; }
        public Employees(int iD, string name, Securitylevel securitylevel, decimal salary, Hire_date hire_date, Gender gender)
        {
            ID = iD;
            Name = name;
            this.securitylevel = securitylevel;
            this.salary = salary;
            this.hire_date = hire_date;
            this.gender = gender;
        }

        public override string ToString()
        {

            return $"idd = {ID},Name = {Name},securitylevel = {securitylevel},salary = {string.Format("{0:C}", salary)},hire_date = {hire_date},gender = {gender}";
        }

    }

    public enum Gender
    {
        Male, Famale
    }
    public enum Securitylevel
    {
        guest, Developer, secretary, DBA
    }



}
