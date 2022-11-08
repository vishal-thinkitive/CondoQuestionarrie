using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Condo_Questionnaire.Client;
using MudBlazor.Services;
using Condo_Questionnaire.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddScoped<IUserService, UserService>()
    .AddScoped<IHttpService, HttpService>()
    .AddScoped<ILocalStorageService, LocalStorageService>();

builder.Services.AddScoped(x => {
    var apiUrl = new Uri("https://localhost:7182/api/1/");

    // use fake backend if "fakeBackend" is "true" in appsettings.json
    
    return new HttpClient() { BaseAddress = apiUrl };
});

builder.Services.AddMudServices();

var host = builder.Build();

var accountService = host.Services.GetRequiredService<IUserService>();
await accountService.Initialize();

await host.RunAsync();
