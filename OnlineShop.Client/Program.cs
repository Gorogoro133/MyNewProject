using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OnlineShop.Client;
using ShopOnline.Client.Services;
using ShopOnline.Client.Services.Contracts;
 

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7108/") });
builder.Services.AddScoped<IProductService, ProductService>();



await builder.Build().RunAsync();
