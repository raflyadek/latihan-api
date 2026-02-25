using Controller;
using dotenv.net;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Repository;
using Services;

var builder = WebApplication.CreateBuilder(args);

//connetion db
var con = builder.Configuration["db:conn"];
Console.WriteLine("abc");
Console.WriteLine(con);
builder.Services.AddDbContext<AppDbContext>(opt =>
opt.UseSqlServer(con));
// controller
builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.PropertyNamingPolicy = 
            System.Text.Json.JsonNamingPolicy.SnakeCaseLower;
    });

builder.Services.AddScoped<IPatientService, PatientService>();
//repo
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
//service
builder.Services.AddEndpointsApiExplorer();
//controller
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapControllers();

app.Run();

