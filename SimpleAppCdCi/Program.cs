var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", ()=>"Hi, Maxx! Do you remember me?");

app.Run();