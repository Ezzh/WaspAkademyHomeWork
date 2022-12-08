
class Store
{
    string? storeName{get;set;}
    string? address{get;set;}
    public List<Audio> audios;
    public List<DVD> dvds;

    public Store(string storeName, string address)
    {
        this.audios = new List<Audio>();
        this.dvds = new List<DVD>();
        this.storeName = storeName;
        this.address = address;
    }

    public override string ToString()
    {
        string res = "";
        res += "DVD: ";
        foreach(DVD i in dvds)
        {
            res += $"{i.name}; ";
        }
        res += "\nAudios: ";
        foreach(Audio i in audios)
        {
            res += $"{i.name}; ";
        }
        return res;
    }
    public static Store operator +(Store store, Audio aud)
    {
        store.audios.Add(aud);
        return store;
    }
    public static Store operator +(Store store, DVD dvd)
    {
        store.dvds.Add(dvd);
        return store;
    }

    public static Store operator -(Store store, Audio aud)
    {
        store.audios.Remove(aud);
        return store;
    }

    public static Store operator -(Store store, DVD dvd)
    {
        store.dvds.Remove(dvd);
        return store;
    }


}