using Microsoft.EntityFrameworkCore;
using Person.Models;

namespace Person.Data;

// O DbContext é a representação do banco de dados na aplicação, ele é responsável por gerenciar as entidades e as operações de acesso aos dados
public class PersonContext : DbContext
{
    //Tabela
    public DbSet<PersonModel> People { get; set; }

    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=person.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}