﻿using gapdolls.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using gapdolls.Models;
using MvcDolls.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<gapdollsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("gapdollsContext") ?? throw new InvalidOperationException("Connection string 'gapdollsContext' not found.")));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<gapdollsContext>();
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<gapdollsContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    //SeedData.Initialize(services);
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
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
app.MapRazorPages();

//using (var scope = app.Services.CreateScope())
//{
    //var rolemanager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    //var roles = new[] { "Admin", "User" };

    //foreach (var role in roles)
    //{
        //await rolemanager.CreateAsync(new IdentityRole(role));
    //}
//}
//using (var scope = app.Services.CreateScope())
//{
    //var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

    //string email = "GAPDOLLS@gmail.com";
    //string password = "Dolls@123";

    //var adminUser = new IdentityUser
    //{
        //Email = email,
        //UserName = email,
        //EmailConfirmed = true,
    //};

    //await userManager.CreateAsync(adminUser, password);

    //await userManager.AddToRoleAsync(adminUser, "Admin");
//}


app.Run();
