using System;
using System.Collections.Generic;
using System.Linq;

namespace RosaDatabaseoperations
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Address { get; set; }
    }

    class Program3
    {
        /*static void Main(string[] args)
        {
            // Step 1: Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Salary = 60000, Address = "Kathmandu" },
                new Employee { Id = 2, Name = "Bob", Salary = 45000, Address = "Pokhara" },
                new Employee { Id = 3, Name = "Charlie", Salary = 70000, Address = "Kathmandu" },
                new Employee { Id = 4, Name = "Diana", Salary = 52000, Address = "Lalitpur" },
                new Employee { Id = 5, Name = "Edward", Salary = 48000, Address = "Kathmandu" }
            };

            // Step 2: Use LINQ to filter employees
            var filteredEmployees = employees
                                    .Where(e => e.Salary > 50000 && e.Address == "Kathmandu")
                                    .ToList();

            // Step 3: Display the filtered employees
            Console.WriteLine("Employees with salary greater than 50,000 and address Kathmandu:");
            foreach (var employee in filteredEmployees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Salary: {employee.Salary}, Address: {employee.Address}");
            }

            Console.ReadKey();
        }*/
    }
}
