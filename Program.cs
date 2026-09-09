using Microsoft.EntityFrameworkCore;
using Projecttitle.Data;
using Projecttitle.Models;
using Projecttitle.Services;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


 builder.Services.AddDbContext<ApplicationDbContext>(opt =>
         opt.UseMySql(builder.Configuration.GetConnectionString("HosConnection"), new MySqlServerVersion(new Version())));
         
builder.Services.AddDbContext<MyApplicationDbContext>(opt =>
         opt.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version())));



builder.Services.AddScoped<CustomerService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();