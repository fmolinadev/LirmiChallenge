using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using LirmiChallenge.Client.Services;



var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<HomeService>();
builder.Services.AddScoped<CourseService>();
builder.Services.AddScoped<SubjectService>();
builder.Services.AddScoped<StudentService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

await builder.Build().RunAsync();
