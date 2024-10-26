using System.Text.Json.Serialization;
using InnoNum.Model;
using InnoNum.Model.Services;

var builder = WebApplication.CreateSlimBuilder(args);

var corsApiPolicy = "InnoNum Api Policy";

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(
        0,
        PerfectNumberContext.Default);
});
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsApiPolicy,
        policy =>
        {
            policy
                .WithOrigins("http://localhost:4200")
                .WithMethods("GET");
        });
});
builder.Services.AddTransient<IPerfectNumberService, PerfectNumberService>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

app.UseCors();

var perfectNumberApi = app.MapGroup("/api/v1/perfectNumber");

perfectNumberApi.MapGet("/",
    (int min, int max, IPerfectNumberService perfectNumberService) =>
        perfectNumberService.CountPerfectNumbersBetween(min, max))
    .RequireCors(corsApiPolicy);

app.Run();

[JsonSerializable(typeof(PerfectNumberCount))]
internal partial class PerfectNumberContext : JsonSerializerContext
{
}

