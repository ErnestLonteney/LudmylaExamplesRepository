namespace CarExample;

class Car
{
    #region СТАН ОБ'ЄКТА (ПОЛЯ)


    public float VolumeOfEngeine { get; set; } = 1.6f;

    // Коли потрібна валідаційна логіка це виглядає так
    //  private string mark;
    public string Mark
    {
        get { return field; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                field = value;
            }
        }
    }

    // Це буде створено за лаштунками, ми ж моржемо користуватись Властивістю
    //public string GetMark()
    //{
    //    return this.mark.Replace("a", "*");
    //}

    //public void SetMark(string value)
    //{
    //    if (!string.IsNullOrEmpty(value))
    //       this.mark = value;
    //}


    // Коли нам не потрібна валідаційна логіка використовуємо авто-властивість
    // В майбутньому вона може бути розширена у звичайну властивість

    private string model;
    private DateTime year;
    private double engineCapacity;
    public string Color { get; set; }

    public string Model
    {
        get => model;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model cannot be null or empty");
            }

            {
                // обрізати пробіли і зробити першу літеру великою
                var trimmed = value.Trim();
                model = char.ToUpper(trimmed[0]) + trimmed.Substring(1);
            }
        }
    }

    public DateTime Year
    {
        get { return year; }
        set
        {
            if (value == DateTime.MinValue)
            {
                year = DateTime.Now;
            }
            else
            {
                year = value;
            }
        }
    }
    public required string Vin { get; init; }

    public double EngineCapacity
    {
        get { return engineCapacity; }

        set
        {
            if (value <= 0)
                throw new ArgumentException("EngineCapacity cannot be negative");

            engineCapacity = value;
        }
    }

    public double CurrentSpeed { get; private set; }

    #endregion

    #region Коструювання об'єкта (КОНСТРУКТОРИ)
    // Конструктор приймає 2 параметри

    public Car(string mark, string model)
    {
        Mark = mark;
        Model = model;
        CurrentSpeed = 10;
    }

    // Конструктор приймає 3 параметри
    public Car(string mark, string model, DateTime year)
        : this(mark, model)
    {
        this.year = year;
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
        Console.WriteLine($"Car speed increased by {delta}. Current speed: {this.CurrentSpeed}");
    }
    #endregion
}
