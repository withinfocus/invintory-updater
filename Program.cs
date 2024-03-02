using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net.Http.Json;

const string GoogleApiKey = "***REMOVED***";
var httpClient = new HttpClient();

var hostBuilder = Host.CreateApplicationBuilder(args);
hostBuilder.Configuration.AddUserSecrets<Program>();

using var host = hostBuilder.Build();
using var scope = host.Services.CreateScope();

var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

var token = await RetrieveTokenAsync();
if (token == null)
    return -1;

if (args.Length == 0)
{
    logger.LogError("No operations specified.");
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

async Task<string?> RetrieveTokenAsync()
{
    var refreshToken = hostBuilder.Configuration["RefreshToken"];
    if (string.IsNullOrEmpty(refreshToken) || refreshToken == "SECRET")
    {
        logger.LogError("No refresh token secret provided.");
        return null;
    }

    try
    {
        using HttpResponseMessage response = await httpClient.PostAsync(
            $"https://securetoken.googleapis.com/v1/token?key={GoogleApiKey}",
            new FormUrlEncodedContent(new Dictionary<string, string>
            {
                ["grant_type"] = "refresh_token",
                ["refresh_token"] = refreshToken
            }));
        response.EnsureSuccessStatusCode();

        var tokenResponse = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
        if (tokenResponse == null || tokenResponse["access_token"] == null)
        {
            return null;
        }

        return tokenResponse["access_token"];
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Failed to authorize.");
        return null;
    }
}

void UpdateCollectionPrices()
{
    // TODO
}
