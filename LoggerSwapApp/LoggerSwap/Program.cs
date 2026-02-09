using LoggerSwap;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

//builder.Services.AddSingleton<ILogger, ConsoleLogger>();
builder.Services.AddTransient<ILogger, ConsoleLogger>(); //Get new guid for each log message 
//builder .Services.AddSingleton<ILogger, FileLogger>();
builder.Services.AddTransient<OrderService>();

using IHost host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var myService = services.GetRequiredService<OrderService>();
        myService.ProcessOrder("Order-123");
        myService.ProcessOrder("Order-456");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}