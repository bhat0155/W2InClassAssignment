namespace InClassAssignment;

public class Car
{
    private string model;
    private Engine engine;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }
    public string Describe()
    {
        return $"Model: {model}\nEngine Horsepower: {engine.HorsePower}";

    }
}