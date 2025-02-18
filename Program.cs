var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Root path");
app.MapGet("/download", () => "This is Yeji.");
app.MapPut("/", () => "This is a Put request.");
app.MapDelete("/", () => "Delete!!!!!!!!");
app.MapPost("/", () => "Post me");


app.Run();
