namespace CarExample
{
    public class SportCar(string mark, string model, string colorButton) : Car(mark, model)
    {
        //public SportCar()
        //    :base("Fiat", "Ferrari")
        //{

        //}

        public string ColorButton { get; set; } = colorButton; // значення яке лежить в параметрі colorButton присвоюється полю яке створено автоматично і працює з цією властивістю 

        public void Stabilization()
        {
            if (seatCount > 2)

            Console.WriteLine("The car has stabilized");
        }
    }
}
