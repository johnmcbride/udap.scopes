using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;
using Radzen;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMudServices();
builder.Services.AddRazorPages();
builder.Services.AddScoped<Radzen.DialogService>();
builder.Services.AddScoped<Radzen.NotificationService>();
builder.Services.AddScoped<Radzen.TooltipService>();
builder.Services.AddScoped<Radzen.ContextMenuService>();
builder.Services.AddServerSideBlazor();
//add environment variables
//set using a custom preview
builder.Configuration.AddEnvironmentVariables("POCSCOPES");

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
