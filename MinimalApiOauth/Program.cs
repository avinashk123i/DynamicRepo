using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Web;
using System.Reflection.Metadata;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

//builder.Services.AddAuthentication(options =>
//{
//    options.DefaultAuthenticateScheme = "Cookies";
//    options.DefaultChallengeScheme = "Google";
//    options.DefaultSignInScheme = "Cookies";
//})
//.AddCookie("Cookies")
//.AddGoogle("Google", options =>
//{
//    options.ClientId = "34818343915-o3ar8v5affj6aoe1clga26qu4vkr5d8d.apps.googleusercontent.com";
//    options.ClientSecret = "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";
//    options.CallbackPath = "/signin-google"; // Default path or your custom one
//    options.Events = new OAuthEvents()
//    {
//        OnCreatingTicket = async create =>
//        {
//            await Console.Out.WriteLineAsync(create?.AccessToken?.ToString());

//        }
//    };
//});


builder.Services.AddAuthentication()
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));



var app = builder.Build();

app.UseAuthentication();


app.MapGet("/", async context =>
{

    await context.Response.WriteAsync($"Hello {context?.User?.Identity?.Name}");


}).RequireAuthorization();


app.Run();