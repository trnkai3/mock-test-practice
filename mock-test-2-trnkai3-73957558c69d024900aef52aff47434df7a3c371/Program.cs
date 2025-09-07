using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PPA2025Mock.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PPA2025MockContextConnection") ?? throw new InvalidOperationException("Connection string 'PPA2025MockContextConnection' not found.");

builder.Services.AddDbContext<PPA2025MockContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<PPA2025MockUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<PPA2025MockContext>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
