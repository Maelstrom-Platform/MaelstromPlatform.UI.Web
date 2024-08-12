using MaelstromPlatform.UI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using MaelstromPlatform.UI.Common;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var API_URL = string.Empty;
if (builder.HostEnvironment.IsEnvironment("LOCAL"))
{
    API_URL = UrlStore.API_LOCAL_DEV;
}
else
{
    API_URL = UrlStore.API_AZURE_DEV;
}

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<DialogService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(API_URL) });

await builder.Build().RunAsync();
