using Microsoft.EntityFrameworkCore;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Business.Implementations;
using RestWithASPNETUdemy.Data;
using RestWithASPNETUdemy.Repository;
using RestWithASPNETUdemy.Repository.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning();   
builder.Services.AddScoped<IPersonBusiness, PersonBusinessImplementation>();
builder.Services.AddScoped<IPersonRepository, PersonRepositoryImplementation>();
//builder.Services.AddScoped<ISeedingService, SeedingService>();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));


var app = builder.Build();

// Configure the HTTP request pipeline.

// SeedDataBase();

app.UseHttpsRedirection();
 
app.UseAuthorization();

app.MapControllers();

app.Run();

/*

void SeedDataBase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInicializer = scope.ServiceProvider.GetRequiredService<ISeedingService>();
        dbInicializer.Seed();
    }
}
*/