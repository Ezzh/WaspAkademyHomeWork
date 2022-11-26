class Autopark
{
    public string name {get; set;}
    public List<Car> cars = new List<Car>();
    public Autopark(string name)
    {
        this.name = name;
    }
    public void AddCar(Car car)
    {
        cars.Add(car);
    }
    public override string ToString()
    {
        string ln = "";
        ln += name + "\n\n";
        foreach (var item in cars)
        {
            ln += item.ToString();
            ln += "\n\n";
        }
        return ln;
    }

}