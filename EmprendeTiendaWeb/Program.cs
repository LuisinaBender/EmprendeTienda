using EmprendeTiendaWeb;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Service.Interfaces;
using Service.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://dataemprendetienda.azurewebsites.net/api/")

});

builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

await builder.Build().RunAsync();
