class Audio : Disk
{

    string? artist { get; set; }
    string? recordingStudia { get; set; }
    int songsNumber { get; set; }
    public override int DiskSize { get { return songsNumber * 8; } }
    public Audio(string name, string genre, string artist, string recordingStudia, int songsNumber) : base(name, genre)
    {
        this.artist = artist;
        this.recordingStudia = recordingStudia;
        this.songsNumber = songsNumber;
    }
    public override void Burn(params string[] values)
    {

        burnCount++;
    }
    public override string ToString()
    {
        return $"Название: {name}\nЖанр: {genre}\nИсполнитель: {artist}\nСтудия: {recordingStudia}\nКол-во песен: {songsNumber}\n]Кол-во прожигов: {burnCount}";
    }
}