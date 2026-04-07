using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesRevision
{
    class Manager(string lastName, string firstName) : Employee(lastName, firstName)
    {
        public string Department { get; set; }

        public override void GetMail(string message)
        {
            Console.WriteLine($"Message for manager {FirstName} {LastName}: {message}");
        }

        public void HireEmployee(Employee employee)
        {
            Console.WriteLine($"Manager {FirstName} {LastName} hired employee {employee.FirstName} {employee.LastName}");
        }
    }
}
