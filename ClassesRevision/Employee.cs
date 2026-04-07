using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesRevision
{
    class Employee(string lastName, string firstName) : Person(lastName, firstName)
    {
        public decimal Salary { get; set; }
        public override void GetMail(string message)
        {
            Console.WriteLine($"Message for employee {FirstName} {LastName}: {message}");
        }
    }
}
