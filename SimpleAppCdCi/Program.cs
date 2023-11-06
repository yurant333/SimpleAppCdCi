var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", ()=>"Hi, Max! Do you remember me?");

app.Run();