using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Asistencias2Crud.Client;
using Asistencias2Crud.Client.Services;
using CurrieTechnologies.Razor.SweetAlert2;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5253") });

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IAsistenciaService, AsistenciaService>();

builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();

