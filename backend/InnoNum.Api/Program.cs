using System.Text.Json.Serialization;
using InnoNum.Model;
using InnoNum.Model.Services;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(
        0,
        PerfectNumberContext.Default);
});
builder.Services.AddTransient<IPerfectNumberService, PerfectNumberService>();

var app = builder.Build();

var perfectNumberApi = app.MapGroup("/api/v1/perfectNumber");

perfectNumberApi.MapGet("/",
        (int min, int max, IPerfectNumberService perfectNumberService) =>
            perfectNumberService.CountPerfectNumbersBetween(min, max));

app.Run();

[JsonSerializable(typeof(PerfectNumberCount))]
internal partial class PerfectNumberContext : JsonSerializerContext
{
}

