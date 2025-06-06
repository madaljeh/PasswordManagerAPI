using EmailServicePackage;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
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
builder.Services.AddScoped<IUserProfile,UserProfileService>();
builder.Services.AddScoped<IProvider,ProviderService>();
builder.Services.AddScoped<IAccountInterface,AccountService>();

builder.Services.AddSmtpService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Uploads")),
    RequestPath = "/uploads" 
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
