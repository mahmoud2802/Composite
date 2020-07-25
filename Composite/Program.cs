using System;
using Composite.Component;
using Composite.Composite;

namespace Composite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            ///Plase Follow me on Instagram
            /// @Mahmoud2802
            
            Employee employee1=new JuniorEmployee(100,"Hassan");
            Employee employee2=new JuniorEmployee(200,"Hosein");
            Employee employee3=new JuniorEmployee(300,"Ali");
            Employee employee4=new JuniorEmployee(400,"Zahra");
            Employee employee5=new JuniorEmployee(500,"Fateme");
            
            
            Container manager1=new Manager(70000,"Mahmoud");
            manager1.AddSubordinate(employee1);
            manager1.AddSubordinate(employee2);
            manager1.AddSubordinate(employee3);
            
            
            Container manager2=new Manager(80000,"Saeed");
            manager2.AddSubordinate(employee4);
            manager2.AddSubordinate(employee5);

           manager1.getSalary();

            manager2.getSalary();

           printInstagram();
        }
        static void printInstagram()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Please follow me on Instagram @mahmoud2802");
            Console.WriteLine("************************");
        }
    }
}