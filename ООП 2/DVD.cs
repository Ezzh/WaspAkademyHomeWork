class DVD : Disk
{
    string? producer{get;set;}
    string? filmCompany{get;set;}
    int minutesCount{get;set;}
    public DVD(string name, string genre, string producer, string filmCompany, int minutesCount) : base(name, genre)
    {
        this.producer = producer;
        this.filmCompany = filmCompany;
        this.minutesCount = minutesCount;
    }
    public override int DiskSize { get{return (minutesCount / 64) * 2;} }
    public override void Burn(params string[] values)
    {
        this.name = values[0];
        this.genre = values[1];
        this.producer = values[2];
        this.filmCompany = values[3];
        this.minutesCount = Convert.ToInt32(values[4]);
        this.burnCount++;
    }
    public override string ToString()
    {
        return $"Название: {name}\nЖанр: {genre}\nРежисер: {producer}\nКомпания: {filmCompany}\nДлительность: {minutesCount}\nКол-во прожигов: {burnCount}";
    }
}