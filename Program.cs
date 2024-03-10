using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http.Json;

const string GoogleApiKey = "***REMOVED***";
var httpClient = new HttpClient();

var hostBuilder = Host.CreateApplicationBuilder(args);
hostBuilder.Configuration.AddUserSecrets<Program>();

using var host = hostBuilder.Build();
using var scope = host.Services.CreateScope();

var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

User? user;
try
{
    user = await AuthorizeAsync();
}
catch (Exception ex)
{
    logger.LogError(ex, "Failed to authorize.");
    return -1;
}

if (user == null)
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
                await UpdateCollectionPricesAsync(user.CollectionId);
                break;
        }
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Failed to execute operation '{arg}'.", arg);
    }
}

return 0;

async Task<User?> AuthorizeAsync()
{
    var refreshToken = hostBuilder.Configuration["RefreshToken"];
    if (string.IsNullOrEmpty(refreshToken) || refreshToken == "SECRET")
    {
        logger.LogError("No refresh token secret provided.");
        return null;
    }

    using HttpResponseMessage tokenResponse = await httpClient.PostAsync(
        $"https://securetoken.googleapis.com/v1/token?key={GoogleApiKey}",
        new FormUrlEncodedContent(new Dictionary<string, string>
        {
            ["grant_type"] = "refresh_token",
            ["refresh_token"] = refreshToken
        }));
    tokenResponse.EnsureSuccessStatusCode();

    var auth = await tokenResponse.Content.ReadFromJsonAsync<FirebaseAuthResponse>();
    if (auth == null || auth.AccessToken == null || auth.UserId == null)
    {
        return null;
    }

    httpClient.DefaultRequestHeaders.Authorization = new(auth.AccessToken);

    using HttpResponseMessage profileResponse = await httpClient.GetAsync(
        $"https://api.invintorywines.com/v2/profiles/{auth.UserId}");
    profileResponse.EnsureSuccessStatusCode();

    var profile = await profileResponse.Content.ReadFromJsonAsync<ProfileResponse>();
    if (profile == null || profile.CollectionId == null)
    {
        return null;
    }

    return new User
    {
        AccessToken = auth.AccessToken,
        CollectionId = profile.CollectionId.Value
    };
}

async Task UpdateCollectionPricesAsync(int collectionId)
{
    using HttpResponseMessage collectionResponse = await httpClient.GetAsync(
        $"https://api.invintorywines.com/v2/collections/{collectionId}?list_type=in_collection");
    collectionResponse.EnsureSuccessStatusCode();

    var collection = await collectionResponse.Content.ReadFromJsonAsync<CollectionResponse>();
    if (collection == null || collection.Labels == null || !collection.Labels.Any())
    {
        logger.LogInformation("Nothing in collection to update.");
        return;
    }

    foreach (var label in collection.Labels)
    {
        if (label.Bottles == null || !label.Bottles.Any())
        {
            continue;
        }

        foreach (var bottle in label.Bottles)
        {
            if (!bottle.PurchasePrice.HasValue && label.PriceAverageConverted.HasValue)
            {
                using HttpResponseMessage bottleUpdateResponse = await httpClient.PatchAsJsonAsync(
                    $"https://api.invintorywines.com/v2/collections/{collectionId}/bottles",
                    new
                    {
                        bottle_ids = new[] { bottle.Id },
                        purchase_price = label.PriceAverageConverted
                    });
                bottleUpdateResponse.EnsureSuccessStatusCode();
            }
        }
    }
}

class User
{
    public string? AccessToken { get; set; }
    public int CollectionId { get; set; }
}
