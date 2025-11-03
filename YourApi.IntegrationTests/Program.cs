


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple endpoint that adds two numbers
app.MapGet("/api/Donation/{a}/{b}", (int a, int b) => (a + b).ToString());

app.Run();

// Must be partial for WebApplicationFactory
public partial class Program
{
    private class WebApplication
    {
    }
}
