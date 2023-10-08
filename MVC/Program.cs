// Beginning part of the app, so put the connection string here!!!!
using DataAccess;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

//1: You need to add packages
//2: You need to add DataAccess Project Reference as well
// it says use this DB Context
// http://localhost:8888/phpMyAdmin5/
#region IoC (Inversion of Control) Container
// v1: server=127.0.0.1;database=test;user id=root;password=root;
// Server=localhost;Port=3306;Database=my_database;Uid=root;Pwd=my_password;
// datasource=localhost;port=3306;username=uid;password=1234
builder.Services.AddDbContext<Db>(options => options.UseMySQL("Server=127.0.0.1; Port=8889; Database=RMS; Uid=root; Pwd=root"));
#endregion 

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
