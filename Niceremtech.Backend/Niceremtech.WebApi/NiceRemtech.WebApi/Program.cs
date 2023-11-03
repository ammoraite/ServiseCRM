using DbTests;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder (args);

// Add services to the container.

builder.Services.AddControllers ( );
builder.Services.AddDbContext<NiceremtechDbContext> (opt =>
{                 //host=localhost port=5432 dbname=postgres user=postgres password=xxxxxxx sslmode=prefer connect_timeout=10
    opt.UseNpgsql ("Host=localhost;Port=5433;dbname=postgres;user=postgres;password=kvs04031988");
    
    
} );
builder.Services.AddScoped<NiceremtechDbContext> ();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer ( );
builder.Services.AddSwaggerGen ( );

var app = builder.Build ( );

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment ( ))
{
    app.UseSwagger ( );
    app.UseSwaggerUI ( );
}

app.UseAuthorization ( );

app.MapControllers ( );

app.Run ( );
