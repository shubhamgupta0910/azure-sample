using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// ensure the runtime binds to localhost:8080
Environment.SetEnvironmentVariable("ASPNETCORE_URLS", "http://localhost:8080");

var builder = WebApplication.CreateBuilder(args);
// ✅ MVC support
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.MapFallbackToFile("index.html");

app.Run();