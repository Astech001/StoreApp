
using StoreApp.Infrastructure.Extensions;
using StoreApp.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.ConfigureDbContext(builder.Configuration);

builder.Services.ConfigureSession();


builder.Services.ConfigureRepositoryRegistration();

builder.Services.ConfigureServiceRegistration();
builder.Services.ConfigureRouting();




builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();

app.UseStaticFiles();
app.UseSession();
app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
       name: "Admin",
       areaName: "Admin",
       pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
   );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapRazorPages();
});
app.ConfigureAndCheckMigration();
app.ConfigureLocalization();

    

app.Run();
