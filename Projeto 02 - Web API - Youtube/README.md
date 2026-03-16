# API CRUD completa com C# e .NET 8 do Zero | Passo a Passo

Iniciado: 03/03
Finalizado: 05/03
[Link do video](https://www.youtube.com/watch?v=UXMKOgmQ7zI&t=587s)

---
#### Stacks:
- .NET 8
- Minimal API
- Swagger
- Entity Framework (EF) - é um mapeador objeto-relacional (ORM)
- SQLite

---
#### Etapas

1. Criar um projeto
2. Criar um endpoint
3. Criar uma pasta Routes e classe PersonRoute que será responsável por ter todos os endpoints
4. Criar uma pasta Models e classe Person com propriedades
5. Instalar mapeador objeto-relacional (ORM)
	1. Criar um manifest local
	2. Instalar o Entity Framework (ferramenta CLI)
	3. Instalar o Entity Framework Core (biblioteca do projeto)
	4. Instalar o Entity Framework Design
	5. Instalar o provider do banco SQLite
6. Criar uma pasta Data e classe PersonContext
7. Injetar o serviço PersonContext no container (program.cs) 
8. Criar uma migration do DB
9. Atualizar o schema do DB
10. Para rodar o database é preciso de um SGDB (VS Code)
	1. Extensão SQLTools
	2. Extensão SQLTools SQLite Driver
	3. Node.js
	4. sqlite3@5.1.7
11. Conectar no DB
12. Criar classe PersonRequest em Models
13. Configurar as rotas com o CRUD em PersonRoute
	1. Post
	2. Get
	3. Put
	4. Delete

---
#### Dicas e Comandos

Fazer com que o swagger utilize sempre a mesma aba

> Properties/launchSettings.json
>	"launchBrowser": false,


Criar um novo projeto
```bash
dotnet new webapi --name {nome} -minimal -f net8.0
```

Crie o arquivo de manifesto
```bash
dotnet new tool-manifest
```

Instalar o Entity Framework (ferramenta CLI)
```bash
dotnet tool install --global dotnet-ef --version 8.*
```

Instalar o Entity Framework Core (biblioteca do projeto)
```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.*
```

Instalar o Entity Framework Design 
```bash
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.*
```

Instalar o Entity Framework Core SQLite (Provider do DB)
```bash
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.*
```

Criar uma migration
```bash
dotnet ef migrations add "{Initial}"
```

Atualizar o schema do banco de dados 
```bash
dotnet ef database update
```