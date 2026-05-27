using Microsoft.EntityFrameworkCore;
using OrbitalAlert.API.Data;
using OrbitalAlert.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// NASA Service
builder.Services.AddHttpClient<NasaService>();

var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI();

// HTTPS
app.UseHttpsRedirection();

// Authorization
app.UseAuthorization();

// Controllers
app.MapControllers();

app.Run();