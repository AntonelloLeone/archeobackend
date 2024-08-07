global using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using WebApplication1.Controllers;
using WebApplication1.Mappings;
using WebApplication1.Models;
using WebApplication1.Repositories;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Aggiungi servizi al container
builder.Services.AddControllers();
builder.Services.AddLogging();

//mapper
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title="N's API",
        Version="v1"
    });
});

// Configura il contesto del database
builder.Services.AddDbContext<Dek9s8aheu55lvContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


//Configura Repositories
builder.Services.AddScoped<IDrawTypeRepository, DrawTypeRepository>();
builder.Services.AddScoped<ILocusComponentRepository, LocusComponentRepository>();



//Configura Services
builder.Services.AddScoped<IDrawTypeService, DrawTypeService>();
builder.Services.AddScoped<ILocusComponentService, LocusComponentService>();





// Configurazione dell'autenticazione JWT
var key = Encoding.ASCII.GetBytes(builder.Configuration["JwtSettings:Secret"]);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = false,
            ClockSkew = TimeSpan.FromMinutes(5)
        };

        // Aggiungi log per debug
        options.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                Console.WriteLine($"Token ricevuto: {token}");
                return Task.CompletedTask;
            },
            OnAuthenticationFailed = context =>
            {
                Console.WriteLine($"Autenticazione fallita: {context.Exception.Message}");
                return Task.CompletedTask;
            }
        };
    });


builder.Services.AddAuthorization();









var app = builder.Build();

// Abilita CORS
app.UseCors(builder => builder
    .WithOrigins("http://localhost:4200") // Sostituisci con il dominio del tuo frontend Angular
    .AllowAnyHeader()
    .AllowAnyMethod()
);

// Configura la pipeline delle richieste HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint(
        "/swagger/v1/swagger.json",
        "v1")

    );
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
