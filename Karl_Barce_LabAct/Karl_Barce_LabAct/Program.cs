using Karl_Barce_LabAct.Services;
using Microsoft.EntityFrameworkCore;
using Karl_Barce_LabAct.Data;

using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<IMyFakeDataService, MyFakeDataService>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();
context.Database.EnsureCreated();
app.UseStaticFiles();


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
