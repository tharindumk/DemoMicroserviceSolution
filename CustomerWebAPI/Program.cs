using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//--------------------
var dbHost = Environment.GetEnvironmentVariable("DB_HOST"); // builder.Configuration["DB_HOST"];
var dbName = Environment.GetEnvironmentVariable("DB_NAME"); // builder.Configuration["DB_NAME"];
var user = Environment.GetEnvironmentVariable("DB_USER"); // builder.Configuration["DB_USER"];
var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD"); //builder.Configuration["DB_PASSWORD"];
var connectionString = $"Server={dbHost};Database={dbName};User Id={user};Password={dbPassword};Trust Server Certificate=False;"; //"Data Source=(localdb)\\MSSQLLocalDB;User ID=admin;Password=qazwsx;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";// "Server={dbHost};Database={dbName};User Id={user};Password={dbPassword};";

builder.Services.AddDbContext<CustomerDbContext>(options => options.UseSqlServer(connectionString));
//-------------------

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
