using Composite.Component;

namespace Composite.Composite
{
    public class JuniorEmployee:Employee
    {
        public JuniorEmployee(int salary, string name)
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

        public string getName()
        {
            return Name;
        }
    }
}