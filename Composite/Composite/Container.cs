using System;
using System.Collections.Generic;
using Composite.Component;

namespace Composite.Composite
{
    public class Container:Employee
    {
        private List<Employee> _subordinates=new List<Employee>();

        public virtual string getName()
        {
            throw new NotImplementedException();
        }

        public void AddSubordinate(Employee emp) 
 
        { 
 
            _subordinates.Add(emp); 
 
        } 
 
        public void RemoveSubordinate(Employee emp) 
 
        { 
 
            _subordinates.Remove(emp); 
 
        }

        public int getSalary()
        {
            int sumSalary = 0;
            Console.WriteLine("//////////////////////////////////");
            Console.Write("Salary of =>  ");
            foreach (Employee employee in _subordinates)
            {
             sumSalary += employee.getSalary();
             Console.Write(employee.getName() +" - ");
            }
            
            Console.Write($" => {sumSalary}");
            Console.WriteLine($"----Managed By {getName()}");
            
            Console.WriteLine("//////////////////////////////////");
            return sumSalary;
        }

        

    }
}