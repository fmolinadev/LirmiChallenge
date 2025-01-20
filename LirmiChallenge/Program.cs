using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using LirmiChallenge.Client.Pages;
using LirmiChallenge.Client.Services;
using LirmiChallenge.Components;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddMudServices();
builder.Services.AddScoped<HomeService>();
builder.Services.AddScoped<CourseService>();
builder.Services.AddScoped<SubjectService>();
builder.Services.AddScoped<StudentService>();


builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    
    app.UseHsts();
}

app.UseHttpsRedirection(); 

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(LirmiChallenge.Client._Imports).Assembly);

app.Run();
