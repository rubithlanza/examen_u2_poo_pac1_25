using ExamenPooUnidad2.API.DataBase;
using ExamenPooUnidad2.API.Helpers;
using ExamenPooUnidad2.API.Services;
using ExamenPooUnidad2.API.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

//Conexion de la base

builder.Services.AddDbContext<PagoPlanillasDbContext>(options => options.UseSqlite(builder.Configuration
    .GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

//Inyeccion 
builder.Services.AddTransient<IEmpleadosService,EmpleadosService>();
builder.Services.AddTransient<IPlanillasService, PlanillaService>();
builder.Services.AddTransient<IDetallesPlanillaService, DetallesPlanillaService>();

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // Habilitar Scalar en la ruta /scalar/v1
    app.MapScalarApiReference("scalar/v1");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
