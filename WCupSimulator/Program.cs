var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/teams", async () =>
{

});

app.MapPost("/teams", async () =>
{

});

app.MapPut("/teams", async () =>
{

});

app.MapDelete("/teams", async () =>
{

});

app.Run();

public class Team 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Img { get; set; }
}