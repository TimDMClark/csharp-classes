using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("The Bat Cave", new DateTime(2000, 1, 1));

            // Create three employees
            Employee employee1 = new Employee("The", "Batman", "Manager", new DateTime(2010, 5, 10));
            Employee employee2 = new Employee("Robin", "(Whipping Boy)", "Sidekick", new DateTime(2015, 3, 23));
            Employee employee3 = new Employee("Bat", "Mobile", "Vehicle", new DateTime(2018, 9, 1));

            // Assign the employees to the company
            myCompany.AddEmployee(employee1);
            myCompany.AddEmployee(employee2);
            myCompany.AddEmployee(employee3);

            // Iterate the company's employee list and generate the simple report
            myCompany.ListEmployees();
        }
    }
}
