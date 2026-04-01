namespace ClassesRevision
{
    internal class Program
    {
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
        }
    }
}
