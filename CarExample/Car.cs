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

    // Це буде створено за лаштунками, ми ж моржемо користуватись Влас
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
    public string Color { get; set; } 


    private string model;
    private DateTime year;
    private string vin;
    private double engineCapacity;
    private double currentSpeed;

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
        :this(mark, model)
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
        this.currentSpeed += delta;
    }
    #endregion
}
