using Corona.Pageant.Web.Components;
using Corona.Pageant.Web.Database;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("PageantDb") ?? "Data Source=pageant.db";
builder.Services.AddSqlite<PageantDb>(connectionString)
    .AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

WebApplication app = builder.Build();

await using PageantDb db = app.Services.CreateScope().ServiceProvider.GetRequiredService<PageantDb>();
await db.Database.MigrateAsync();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run("http://*:8080");