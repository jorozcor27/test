using Microsoft.AspNetCore.Components.Web;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using TiendaOnline.WASM;

using TiendaOnline.WASM.Services;



var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped(sp => new HttpClient

{

    BaseAddress = new Uri("http://localhost:5059/")

});



builder.Services.AddScoped<ClienteService>();



await builder.Build().RunAsync();