class Banda
{
    private List<Album> _albuns = new List<Album>();
    public string Name { get; }

    public Banda(string name)
    {
        Name = name;
    }

    public void AddAlbum(Album album)
    {
        _albuns.Add(album);
    }

    public void ShowDiscography()
    {
        System.Console.WriteLine($"Discografia da banda {Name}");
        foreach (var album in _albuns)
        {
            System.Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
        }
    }
}