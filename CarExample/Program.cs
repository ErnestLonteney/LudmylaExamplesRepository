namespace CarExample
{
    internal class Program
    {
        static void Main()
        {
            // створення об'єкта класу Car
            var myCar = new Car("Toyota", "Corolla");
            myCar.Color = "Red";

            myCar.Mark = "BMW";    
            Console.WriteLine(myCar.Mark);

            myCar.Color = "Blue";
            Console.WriteLine(myCar.Color);

            // створення об'єкта класу Car
            var anotherCar = new Car("Honda", "Civic");
            // створення об'єкта класу Car
            var newCar = new Car("Renault", "Megan");
            // створення об'єкта класу Car
            var car = new Car("Ford", "Focus", new DateTime(1, 1, 2024));

           car.Start();

           car.Accelerate(50);
           car.Accelerate(30);

           car.Stop();

        }
    }
}
