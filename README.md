# Invintory Updater

Utility for various operations on an [Invintory](https://invintory.com/) account.

## Setup

Two .NET user secrets must be set (`dotnet user-secrets set`):

-   `RefreshToken`: OAuth refresh token.
-   `GoogleApiKey`: Firebase API key for token exchange.

Both secrets can be seen in use via developer tools on their website.

Build the application (`dotnet build`) and then pass a parameter for the operation to perform.

## Capabilities

-   `ucp`: Update collection prices. Takes bottles in your collection that don't have a purchase price set and uses the known average price.
