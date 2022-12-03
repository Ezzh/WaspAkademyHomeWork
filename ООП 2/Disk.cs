class Disk: IStoreItem
{
    public string? name {get; set;}
    public string? genre{get; set;}
    public double Price { get; set; }
    public int burnCount = 0;

    public Disk(string name, string genre)
    {
        this.name = name;
        this.genre = genre;
    }

    public void DiscountPrice(int percent)
    {
        this.Price = this.Price - (this.Price * (percent / 100.0));
    }

    public virtual int DiskSize{get; set;}

    public virtual void Burn(params string[] values)
    {

    }

}