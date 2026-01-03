namespace CarExample
{
    internal class Program
    {
        static void Main()
        {
            // створення об'єкта класу Car
            var myCar = new Car("Toyota", "Corolla")
            {
                Color = "White",
                Vin = "234325345efrdg45435645"
            };

            myCar.Color = "Red";

            myCar.Mark = "BMW";    
            Console.WriteLine(myCar.Mark);

            myCar.Color = "Blue";
            Console.WriteLine(myCar.Color);

            // створення об'єкта класу Car
            var anotherCar = new Car("Honda", "Civic")
            {
                Vin = "3254345346"
            };
            // створення об'єкта класу Car
            Car newCar = new Car("Renault", "Megan")
            {
                Vin = "3245353456"
            };
            // створення об'єкта класу Car
            var car = new Car("Ford", "Focus", new DateTime(2024, 12, 1))
            {
                Vin = "34t34t345t435"
            };

           car.Start();

           car.Accelerate(50);
           car.Accelerate(30);

           car.Stop();


            Car a = new Car("Renault", "Zoi")
            {
                Vin = "4325345345"
            };

            Console.WriteLine(a.Color);

            Car b = a;

            b.Color = "Red";

            Console.WriteLine(a.Color);

            Car c = new Car("Renault", "Zoi")
            {
                Vin = "4325345345"
            };


            SportCar sportCar1 = new SportCar("Volkswagen", "Geo", "Red")
            { 
                Vin = "3425345345" 
            };

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());

            Console.ReadLine();
        }
    }
}
