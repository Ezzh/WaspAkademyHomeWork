class Store
{
    string? storeName{get;set;}
    string? address{get;set;}
    public List<Audio> audios = new List<Audio>();
    public List<DVD> dvds = new List<DVD>();

    Store(string storeName, string address)
    {
        this.storeName = storeName;
        this.address = address;
    }
    public override string ToString()
    {
        string res = "";
        res += "DVD: ";
        foreach(DVD i in dvds)
        {
            res += $"{i.name}, ";
        }
        res += "\nAudios: ";
        foreach(Audio i in audios)
        {
            res += $"{i.name}, ";
        }
        return res;
    }

}