using DataAccess;
using DataAccess.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//setupDatabase
builder.Services.AddDbContext<WearShopContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Database"),
    b => b.MigrationsAssembly(nameof(WearShop))));
//Configuring Database using EntityFrameworkCore

//set up IdentityService, including userRegistration, login, and roles
builder.Services.AddDefaultIdentity<User>(options =>
        options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<WearShopContext>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();