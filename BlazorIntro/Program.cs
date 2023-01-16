using BlazorAnimate;

using BlazorIntro;
using BlazorIntro.Services;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddIgniteUIBlazor();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<IApiService, MyApi>();
builder.Services.Configure<AnimateOptions>(options =>
{
    options.Animation = Animations.FadeDown;
    options.Duration = TimeSpan.FromMilliseconds(1000);
});
builder.Services.Configure<AnimateOptions>("my", options =>
{
    options.Animation = Animations.FadeDown;
    options.Duration = TimeSpan.FromSeconds(2);
});

await builder.Build().RunAsync();
