using CarOLiner.UI.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using CarOLiner.UI.Data.Products;
using CarOLiner.UI.Data.Items;
using CarOLiner.UI.Data.Variants;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager _configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBootstrapProviders()
    .AddFontAwesomeIcons();

var apiUrl = new Uri("https://localhost:7071/");
builder.Services.AddHttpClient<IProductDataService, ProductDataService>(client =>
{
    client.BaseAddress = apiUrl;
});

builder.Services.AddHttpClient<IItemDataService, ItemDataService>(client =>
{
    client.BaseAddress = apiUrl;
});

builder.Services.AddHttpClient<IVariantDataService, VariantDataService>(client =>
{
    client.BaseAddress = apiUrl;
});

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
