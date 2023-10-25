using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using StudentUI;
using StudentUI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7205") });

//builder.Services.AddScoped<IJSRuntime>(sp => sp.GetRequiredService<IJSRuntime>());
//builder.Services.AddLogging();

await builder.Build().RunAsync();

