using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Models;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container, using the environment variable for the connection string
var connectionString = Environment.GetEnvironmentVariable("MVCMOVIE_CONNECTIONSTRING");

builder.Services.AddDbContext<MvcMovieContext>(options =>
    options.UseNpgsql(connectionString ?? builder.Configuration.GetConnectionString("MvcMovieContext")));

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Ensure migrations are applied and seed the database
await using (var scope = app.Services.CreateAsyncScope())
{
    var services = scope.ServiceProvider;

    var db = services.GetRequiredService<MvcMovieContext>();
    await db.Database.MigrateAsync();

    // Seed the database with initial data
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
