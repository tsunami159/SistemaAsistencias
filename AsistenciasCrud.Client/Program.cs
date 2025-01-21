using AsistenciasCrud.Client;
using AsistenciasCrud.Client.Services;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5280") });

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IAsistenciaService, AsistenciaService>();


builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
