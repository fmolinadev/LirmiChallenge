using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using MudBlazor.Components;
using LirmiChallenge.Client.Services;
using System.ComponentModel;
using LirmiChallenge.Client.Layout;
using MudBlazor.Charts;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<HomeService>();
builder.Services.AddScoped<CourseService>();
builder.Services.AddScoped<SubjectService>();
builder.Services.AddScoped<StudentService>();



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

await builder.Build().RunAsync();
