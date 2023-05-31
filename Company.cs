using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employee> Employees { get; }

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}");
            }
        }
    }
}
