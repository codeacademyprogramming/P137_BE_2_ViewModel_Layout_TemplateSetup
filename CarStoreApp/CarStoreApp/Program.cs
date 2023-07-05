var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}/{id?}"
    );

app.MapControllerRoute(
    "about",
    "about-us",
    defaults: new { controller = "home", action = "about" }
    );

app.Run();
