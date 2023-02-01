using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Headquarter : IEnumerable<Employee>
    {
        List<Employee> internalemployee;

        public Headquarter()
        {
            internalemployee = new List<Employee>();
        }
        public void Add(Employee employee)
        {
            this.internalemployee.Add(employee);
        }


        public IEnumerable<Employee> Find(string name, string Lastname)
        {
            foreach (Employee emp in this)
            {
                if (emp.Name == name && emp.LastName == Lastname)
                {
                    yield return emp;
                }
            }
        }
        public IEnumerable<Employee> FindbyDep(string dep)
        {
            foreach (Employee emp in this)
            {
                if (emp.Department == dep)
                {
                    yield return emp;
                }
            }
        }
        public void Remove(string name, string Lastname)
        {
            List<Employee> employee = new List<Employee>();
            foreach (Employee emp in internalemployee)
            {
                if (emp.Name == name && emp.LastName == Lastname)
                    continue;
                employee.Add(emp);
            }
            internalemployee = employee;
            Console.WriteLine("Record Removed");
        }
        public void ShowAll(Headquarter headquarter)
        {
            foreach (Employee employee in headquarter)
            {
                Console.WriteLine(employee);
                Console.WriteLine();
            }

        }

        public IEnumerator<Employee> GetEnumerator()
        {
            foreach (Employee employee in internalemployee)
            {
                yield return employee;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
