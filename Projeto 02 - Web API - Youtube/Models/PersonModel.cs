namespace Person.Models;

public class PersonModel
{
    public PersonModel(string name)
    {
        Name = name;
        // Toda vez que eu criar uma pessoa, ela já vai ter um Id único, gerado automaticamente
        Id = Guid.NewGuid();
    }

    // init significa que a propriedade só pode ser setada no momento da criação do objeto, ou seja, no construtor
    public Guid Id { get; init; }

    public string Name { get; private set; }

    public void ChangeName(string name)
    {
        Name = name;
    }

    public void SetInactive()
    {
        Name = "Inativo";
    }
}
