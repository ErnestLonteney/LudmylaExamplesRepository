namespace CarExample;

public class Car
{
    #region СТАН ОБ'ЄКТА (ПОЛЯ)
    protected byte seatCount; 

    public float VolumeOfEngeine { get; private set; } = 1.6f;

    public string Mark
    {
        get { return field.Replace("a", "*"); }
    }

 
    public string Color { get; set; }

    public string Model { get; }

    public DateTime Year
    {
        get;     
    }
    public required string Vin { get; init; }

    public double EngineCapacity
    {
        get { return field; }

        set
        {
            if (value <= 0)
                throw new ArgumentException("EngineCapacity cannot be negative");

            field = value;
        }
    }

    public double CurrentSpeed { get; private set; }

    #endregion

    #region Коструювання об'єкта (КОНСТРУКТОРИ)

    public Car(string mark, string model)
    {
        if (string.IsNullOrEmpty(mark))
        {
            throw new ArgumentException("Mark cannot be null or empty");
        }

        if (string.IsNullOrEmpty(model))
        {
            throw new ArgumentException("Model cannot be null or empty");
        }

        Mark = mark;
        Model = model;
        CurrentSpeed = 10;
    }

    public Car(string mark, string model, DateTime year)
        : this(mark, model)
    {
        Year = year;
    }

    #endregion

    #region ПОВЕДІНКА ОБ'ЄКТА (МЕТОДИ)
    public void Start()
    {
        Console.WriteLine("Car is started");
    }

    public void Stop()
    {
        Console.WriteLine("Car is stopped");
    }

    public Car GetUpdatedCar()
    {
        VolumeOfEngeine = 2.0f;
        return this;
    }

    public void Accelerate(byte delta)
    {
        CurrentSpeed += delta;
        Console.WriteLine($"Car speed increased by {delta}. Current speed: {CurrentSpeed}");
    }
    #endregion
}
