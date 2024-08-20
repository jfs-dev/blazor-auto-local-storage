using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<blazor_auto_local_storage.Client.Interfaces.ILocalStorageService, blazor_auto_local_storage.Client.Services.LocalStorageService>();

await builder.Build().RunAsync();
