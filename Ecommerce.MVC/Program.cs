using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models;
using Reository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore; // Added this namespace for AddEntityFrameworkStores

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.  
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDBContext>(
  i => i.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("MyDB")));
builder.Services.AddIdentity<AppUser, IdentityRole>()
  .AddEntityFrameworkStores<ApplicationDBContext>() // Ensure this extension method is available
  .AddDefaultTokenProviders(); // Added this to complete the Identity setup

builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddScoped<Microsoft.AspNetCore.Identity.UI.Services.IEmailSender, EmailSender>();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.  
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
name: "default",
pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
