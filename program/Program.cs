var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "World World  Hello Hello");

app.Run();