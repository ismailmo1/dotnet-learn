var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddCors(optionas => { });
app.UseCors("unique string");

app.MapGet("/", () => "Hello World!");

app.Run();