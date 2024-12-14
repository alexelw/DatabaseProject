using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using MyProject.Data.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register the DbContext with Npgsql
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// Register the DbSeeder service
builder.Services.AddTransient<IDbSeeder, DbSeederService>();

var app = builder.Build();

// Seed the database on application startup
using (var scope = app.Services.CreateScope())
{
    var dbSeeder = scope.ServiceProvider.GetRequiredService<IDbSeeder>();
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbSeeder.Seed(dbContext); // Call the Seed method to populate the database
}

app.MapGet("/", () => "Hello World!");

app.Run();
