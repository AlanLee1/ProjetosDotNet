using Microsoft.EntityFrameworkCore;
using Person.Data;
using Person.Models;

namespace Person.Routes;

public static class PersonRoute
{
    public static void PersonRoutes(this WebApplication app)
    {

        // MapGroup é uma forma de agrupar rotas, ou seja, 
        // todas as rotas que começarem com "person" vão ser agrupadas,
        // e eu posso aplicar middlewares específicos para esse grupo de rotas
        var route = app.MapGroup("person");

        route.MapPost("", async (PersonRequest req, PersonContext context) =>
        {
            var person = new PersonModel(req.name);
            // AddAsync é um método do Entity Framework que adiciona uma 
            // entidade ao contexto do banco de dados
            await context.AddAsync(person);
            // SaveChangesAsync é um método do Entity Framework que 
            // salva as alterações feitas no contexto do banco de dados
            await context.SaveChangesAsync();
        });

        route.MapGet("", async (PersonContext context) =>
        {
            // ToListAsync é um método do Entity Framework que retorna 
            // uma lista de entidades do banco de dados
            var people = await context.People.ToListAsync();
            return Results.Ok(people);
        });

        route.MapPut("{id:guid}", async (Guid id, PersonRequest req, PersonContext context) =>
        {
            var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

            if (person == null)
                return Results.NotFound();

            person.ChangeName(req.name);

            await context.SaveChangesAsync();
            return Results.Ok(person);
        });

        route.MapDelete("{id:guid}", async (Guid id, PersonContext context) =>
        {
            // Hard delete
            // Soft delete

            var person = await context.People.FirstOrDefaultAsync(x => x.Id == id);

            if (person == null)
                return Results.NotFound();

            person.SetInactive();
            await context.SaveChangesAsync();
            return Results.Ok(person);
        });

        // app.MapGet("person", () => new PersonModel("Alan"));
        // app.MapPost("person", () => new PersonModel("Alan"));
        // app.MapDelete("person", () => { });
    }
}

