namespace ClassesRevision
{
    internal class Program
    {
        static void GetInfo(Person p)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.FirstName);
        }

        static void Main(string[] args)
        {
           Person person = new Person("John", "Travolta");

            person.Address = new Address
            {
                City = "New York",
                Number = "123",
                PostCode = "10001",
                Street = "Main Street"
            };

            person.Address = new Address
            {
                City = "Los Angeles",
                Number = "456",
                PostCode = "90001",
                Street = "Second Street"
             };

            Console.WriteLine(person.FullName);

            person.GetMail("Hello, this is a message for you!");

            Employee employee = new Employee("Mark", "Shiller");

            employee.GetMail("Hello");

            GetInfo(person);
            GetInfo(employee);


            Person[] people = [employee, person ];

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].Id);
                if (people[i] is Employee emp)
                {
                    Console.WriteLine(emp.Salary);
                }

                Employee emp1 = people[i] as Employee;
                if (emp1 is not null)
                {
                    emp1.Salary = 50000;
                }
            }       
        }
    }
}
