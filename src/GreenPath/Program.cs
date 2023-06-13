using GreenPath.Data;
using GreenPath.Helpers;
using GreenPath.Interfaces;
using GreenPath.Models;
using GreenPath.Repository;
using GreenPath.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILocationService, LocationService>();

// Cloudinary e photoservice
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));

//Add SQL Db connection, DefaultConnection esta em appsettings.json
builder.Services.AddDbContext<BancoContexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Add Identity Framework AppUser, Roles e cookie authentication
builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<BancoContexto>();
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
       .AddCookie();

var app = builder.Build();

// Popular a tabela login com dados iniciais alocados no Seed
//if (args.Length == 1 && args[0].ToLower() == "seeddata")
//{
//    await Seed.SeedUsersAndRolesAsync(app);
//    //Seed.SeedData(app);
//}

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

// Redirecionar usuário quando ele não tem acesso à uma página
app.UseStatusCodePages(context =>
{
    if (context.HttpContext.Response.StatusCode == 403 || context.HttpContext.Response.StatusCode == 404 || context.HttpContext.Response.StatusCode == 401)
    {
       context.HttpContext.Response.Redirect("/Home/Index");
    }

    return Task.CompletedTask;
});

app.Run();


public static class Global
{
    /// <summary>
    /// Global variable storing important stuff.
    /// </summary>
    static string? _userRole;
    
    /// <summary>
    /// Get or set the static important data.
    /// </summary>
    public static string UserRole
    {
        get
        {
            return _userRole;
        }
        set
        {
            _userRole = value;
        }
    }

    public static AppUser? CurrentUser { get; set;}
};
