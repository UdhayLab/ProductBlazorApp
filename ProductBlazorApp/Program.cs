using ProductBlazorApp.Components;
using ProductBlazorApp.Model;
using ProductBlazorApp.services;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddAutoMapper(typeof(ProductMapperProfile));
builder.Services.AddRazorComponents().AddInteractiveServerComponents();

builder.Services.AddHttpClient<IProductServices, ProductServices>(client =>
    {
        client.BaseAddress = new Uri("http://localhost:5049/"); 
    }); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
