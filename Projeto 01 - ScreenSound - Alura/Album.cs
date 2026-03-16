class Album
{
    private List<Musica> musics = new List<Musica>();

    public string Name { get; }

    public int TotalDuration => musics.Sum(m => m.Duration);

    public Album(string name)
    {
        Name = name;
    }

    public void AddMusic(Musica music)
    {
        musics.Add(music);
    }

    public void ShowMusicWithAlbum()
    {
        System.Console.WriteLine($"Lista de musics do album: {Name}\n");
        foreach (var music in musics)
        {
            System.Console.WriteLine($"Musica: {music.Name}");
        }
        System.Console.WriteLine($"O album completo possui a duracao de {TotalDuration} segundos");
    }
}