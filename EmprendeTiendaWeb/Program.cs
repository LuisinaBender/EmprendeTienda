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
    BaseAddress = new Uri("https://54.175.74.81:5001/")

});

builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));

await builder.Build().RunAsync();
