using Microsoft.EntityFrameworkCore;
using MySite.Data;

var builder = WebApplication.CreateBuilder(args);

var cookingConnection = builder.Configuration
    .GetConnectionString("CookingDbConnection");
var codingConnection = builder.Configuration
    .GetConnectionString("CodingDbConnection");
var travelConnection = builder.Configuration
    .GetConnectionString("TravelDbConnection");
var mindConnection = builder.Configuration
    .GetConnectionString("MindDbConnection");

var cookingServer = ServerVersion.AutoDetect(cookingConnection);
var codingServer = ServerVersion.AutoDetect(codingConnection);
var travelServer = ServerVersion.AutoDetect(travelConnection);
var mindServer = ServerVersion.AutoDetect(mindConnection);

builder.Services.AddDbContext<CookingDbContext>(db =>
    db.UseMySql(cookingConnection, cookingServer));
builder.Services.AddDbContext<TravelDbContext>(db =>
    db.UseMySql(travelConnection, travelServer));
builder.Services.AddDbContext<MindDbContext>(db =>
    db.UseMySql(mindConnection, mindServer));
builder.Services.AddDbContext<CodingDbContext>(db =>
    db.UseMySql(codingConnection, codingServer));

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();