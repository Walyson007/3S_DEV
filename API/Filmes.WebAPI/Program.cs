using Filmes.WebAPI.BdContextFilme;
using Filmes.WebAPI.Interfaces;
using Filmes.WebAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

//Adiciona o contexto do banco de dados (exemplos com SQL Server)
builder.Services.AddDbContext<FilmeContext>(Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
