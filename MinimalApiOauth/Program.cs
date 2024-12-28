using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "Cookies";
    options.DefaultChallengeScheme = "Google";
    options.DefaultSignInScheme = "Cookies";
})
.AddCookie("Cookies")
.AddGoogle("Google", options =>
{
    options.ClientId = "34818343915-o3ar8v5affj6aoe1clga26qu4vkr5d8d.apps.googleusercontent.com";
    options.ClientSecret = "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";
    options.CallbackPath = "/signin-google"; // Default path or your custom one
    options.Events = new OAuthEvents()
    {
        OnCreatingTicket = async create =>
        {
            await Console.Out.WriteLineAsync(create?.AccessToken?.ToString());
           
        }
    };
});




var app = builder.Build();

app.UseAuthentication();


app.MapGet("/", async context =>
{
    if (context.User.Identity?.IsAuthenticated ?? false)
    {
        await context.Response.WriteAsync($"Hello {context.User.Identity.Name}");
    }
    else
    {
        context.Response.Redirect("/login");
    }
});

app.MapGet("/login", async context =>
{
    await context.ChallengeAsync("Google", new AuthenticationProperties
    {
        RedirectUri = "/"
    });
});

app.Run();