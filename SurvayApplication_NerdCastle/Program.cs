using Microsoft.EntityFrameworkCore;
using SurvayApplication_NerdCastle.DataContext;
using SurvayApplication_NerdCastle.Interface;
using SurvayApplication_NerdCastle.Models;
using SurvayApplication_NerdCastle.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SurveyDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SurvayApplication")));
builder.Services.AddScoped<IRepository<Survey>, SurveyRepository>();
builder.Services.AddScoped<IRepository<Question>, QuestionRepository>();
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
