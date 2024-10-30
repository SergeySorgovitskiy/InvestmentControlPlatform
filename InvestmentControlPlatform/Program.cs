using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using InvestmentControlPlatform.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<InvestmentControlPlatformDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("InvestmentControlPlatform"),
    new MySqlServerVersion(new Version(8, 0, 0))));

builder.Services.AddAuthorization();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();  

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  
    app.UseSwaggerUI();  
}

app.UseHttpsRedirection();

app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();


//ss