class Musica
{
    // Propriedades
    public string Name { get; }
    public Banda Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public Gender Gender { get; set; }
    public string Description => $"A musica {Name} pertence a banda {Artist.Name}";

    // Construtor
    public Musica(Banda artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    // Método
    public void ShowTechnicalSpecifications()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Descricao: {Description}");
        System.Console.WriteLine($"Artista: {Artist.Name}");
        System.Console.WriteLine($"Duracao: {Duration}");
        System.Console.WriteLine($"Genero: {Gender.Name}");

        if (Available)
        {
            System.Console.WriteLine($"Diponivel");
        }
        else
        {
            System.Console.WriteLine($"Nao disponivel");
        }
    }
}

class Gender
{
    public string Name { get; set; }
}


