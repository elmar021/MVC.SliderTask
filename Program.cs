using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using OneFB.OneFBContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDBContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-480VF81\\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True");
});
var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
app.UseStaticFiles();
app.MapControllerRoute
    (
        name:"default",
        pattern: "{Controller=One}/{Action=Index}"
    );
app.Run();
