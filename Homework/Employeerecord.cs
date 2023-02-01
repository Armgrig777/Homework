using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Employee
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Department;

        public string getname()
        {
            return Name;
        }
        public string getLast()
        {
            return LastName;
        }


        public Employee()
        {

        }
        public Employee(string department, string name, string lastname, decimal salary)
        {

            Department = department.AddSpaceBetween();
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastname;

            Salary = salary;
        }
        public static Employee Parse(string str)
        {
            string[] strs = str.Split(',');

            if (strs.Length != 5)
            {
                throw new ArgumentException("Invalid input format");
            }

            Guid id = Guid.Parse(strs[0].Trim());
            string name = strs[1].Trim();
            string lastname = strs[2].Trim();
            string Department = strs[3].Trim();
            decimal salary = decimal.Parse(strs[4].Trim());

            return new Employee()
            {
                Department = Department,
                Id = id,
                Name = name,
                LastName = lastname,
                Salary = salary
            };
        }
        public override string ToString()
        {
            return $"----Employee---- \nID:{Id} \nName:{Name} \nLastName:{LastName} \nDepartment: {Department} \nSalary:{Salary}$";
        }
        public string ToFilestring()
        {
            return $"{Id},{Name},{LastName},{Department},{Salary}";
        }
    }
}
