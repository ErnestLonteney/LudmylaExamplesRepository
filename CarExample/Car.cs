namespace CarExample;

class Car
{
    #region СТАН ОБ'ЄКТА (ПОЛЯ)


    // Коли потрібна валідаційна логіка це виглядає так
    private string mark;
    public string Mark
    {
        get { return this.mark; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.mark = value;
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
    private string vin;
    private double engineCapacity;
    public string Color { get; set; }

    public string Model
    {
        get => this.model;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model cannot be null or empty");
            }

            {
                // обрізати пробіли і зробити першу літеру великою
                var trimmed = value.Trim();
                this.model = char.ToUpper(trimmed[0]) + trimmed.Substring(1);
            }
        }
    }

    public DateTime Year
    {
        get { return this.year; }
        set
        {
            if (value == DateTime.MinValue)
            {
                this.year = DateTime.Now;
            }
            else
            {
                this.year = value;
            }
        }
    }
    public string Vin
    {
        get { return vin; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Vin cannot be null or empty");

            vin = value;
        }
    }

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

    public double CurrentSpeed { get; set; }

    #endregion

    #region Коструювання об'єкта (КОНСТРУКТОРИ)
    // Конструктор приймає 2 параметри
    public Car(string mark, string model)
    {
        this.mark = mark;
        this.model = model;
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

    public void Accelerate(byte delta)
    {
        this.CurrentSpeed += delta;
        Console.WriteLine($"Car speed increased by {delta}. Current speed: {this.CurrentSpeed}");
    }
    #endregion
}
