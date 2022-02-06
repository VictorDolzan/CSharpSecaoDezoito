using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pomelo.EntityFrameworkCore.MySql;
using CSharpSecaoDezoito.Models;
using CSharpSecaoDezoito.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); 
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();   
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
// var contextOptions = new DbContextOptions<CSharpSecaoDezoitoContext>()
//     .UseSqlServer(@"server=localhost;userid=root;password=root;database=CSharpSecapDezoitoDb")
//     .Options;

// using var context = new DbContextOptions(contextOptions);
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
