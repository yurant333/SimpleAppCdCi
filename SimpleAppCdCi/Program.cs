var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", ()=>"Hi, Maxxx! Do you remember me?");

app.Run();