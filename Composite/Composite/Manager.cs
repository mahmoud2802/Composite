using System;
using System.Collections.Generic;
using Composite.Component;

namespace Composite.Composite
{
    public class Manager:Container,Employee 
    {
        public Manager(int salary, string name)
        {
            this.Salary = salary;
            this.Name = name;
        }

        private int Salary { get; set; }
        private string Name { get; set; }
        public int getSalary()
        {
            return Salary;
        }

        public override string getName()
        {
            return Name;
        }
    }
}