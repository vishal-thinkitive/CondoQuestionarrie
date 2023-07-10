using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CondoQuestionnaire.Client;
using MudBlazor.Services;
using CondoQuestionnaire.Client.Services;
using Stripe;

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

StripeConfiguration.ApiKey = "sk_test_51LqHWLAgaROme1HUs5rQLuxQdgnHOk8vCaCPiBdB6y4mtIwSC0ruEu4mkMsNjJ3ks6eH2qTYPd4JOH0aGoOcZo7O00ueF6weem";

var accountService = host.Services.GetRequiredService<IUserService>();
await accountService.Initialize(); await accountService.Initialize();

await host.RunAsync();
