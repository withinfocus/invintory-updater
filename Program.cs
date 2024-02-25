using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

var hostBuilder = Host.CreateApplicationBuilder(args);
hostBuilder.Configuration.AddUserSecrets<Program>();

using var host = hostBuilder.Build();
using var scope = host.Services.CreateScope();

var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

if (args.Length == 0)
{
    logger.LogError("No operations specified.");
    return -1;
}

var token = hostBuilder.Configuration["AuthorizationToken"];
if (string.IsNullOrEmpty(token) || token == "SECRET")
{
    logger.LogError("No authorization token secret provided.");
    return -1;
}

foreach (var arg in args)
{
    try
    {
        switch (arg)
        {
            case "ucp":
                UpdateCollectionPrices();
                break;
        }
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Failed to execute operation '{arg}'.", arg);
    }
}

return 0;

void UpdateCollectionPrices()
{
    // TODO
}