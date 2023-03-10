using CustomerAPI.Data;
using Microsoft.EntityFrameworkCore;
//using WebApiCustomers.Data;
//using WebApiCustomers.Repositories;
//using AutoMapper;
using System.Reflection;





var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CustomerDemoDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CustomerDbContext")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
