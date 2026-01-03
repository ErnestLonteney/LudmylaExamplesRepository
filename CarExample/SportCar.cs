namespace CarExample
{
    public class SportCar : Car
    {
        public SportCar(string mark, string model, string colorButton)
            : base(mark, model)
        {
            ColorButton = colorButton;
        }

        //public SportCar()
        //    :base("Fiat", "Ferrari")
        //{

        //}

        public string ColorButton { get; set; } // null

        public void Stabilization()
        {
            if (seatCount > 2)

            Console.WriteLine("The car has stabilized");
        }
    }
}
