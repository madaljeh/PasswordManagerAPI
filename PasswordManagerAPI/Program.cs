using Microsoft.EntityFrameworkCore;
using PasswordManagerAPI.Context;
using PasswordManagerAPI.Interfaces;
using PasswordManagerAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PasswordManagerDbContext>(opt => opt.UseSqlServer("Data Source=LAPTOP-QGFR6N5D;Initial Catalog=PassMangeDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"));
builder.Services.AddScoped<ILookupItem,LookupItemService>();
builder.Services.AddScoped<IUserAuthentication,UserAuthenticationService>();
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
