using Microsoft.EntityFrameworkCore;
using SmartSchoolAPI.Data;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

//conexao com o Sqlite
var conectionString = builder.Configuration.GetConnectionString("Default");

builder.Services.AddDbContext<SmartContext>(context =>
    context.UseSqlite(conectionString)
    );


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
