using MudBlazor.Services;
using LirmiChallenge.Client.Pages;
using LirmiChallenge.Components;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMudServices();


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

/* app.UseHttpsRedirection(); */

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(LirmiChallenge.Client._Imports).Assembly);

app.Run();
