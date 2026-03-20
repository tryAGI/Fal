# Fal

[![Nuget package](https://img.shields.io/nuget/vpre/Fal)](https://www.nuget.org/packages/Fal/)
[![dotnet](https://github.com/tryAGI/Fal/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Fal/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Fal)](https://github.com/tryAGI/Fal/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Fal.ai OpenAPI specification](https://api.fal.ai/v1/openapi.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.

### Usage
```csharp
using Fal;

using var client = new FalClient(apiKey);
```

<!-- EXAMPLES:START -->
### Apps Get Meta Returns Platform Metadata
```csharp
var client = GetAuthorizedApi();

var response = await client.Meta.GetMetaAsync();
```

### Apps Get Pricing Returns Price For Endpoint
```csharp
var client = GetAuthorizedApi();

var response = await client.Models.GetPricingAsync(
    endpointId: "fal-ai/flux/dev");
```

### Apps Search Requests Returns Results
```csharp
var client = GetAuthorizedApi();

var response = await client.Models.SearchRequestsAsync(
    limit: 5);
```

### Billing Get Account Billing Returns Username
```csharp
var client = GetAuthorizedApi();

try
{
    var response = await client.Account.GetAccountBillingAsync();

}
catch (ApiException ex) when (ex.Message.Contains("Admin API key"))
{
}
```

### Billing Get Usage Returns Usage Data
```csharp
var client = GetAuthorizedApi();

try
{
    var response = await client.Models.GetUsageAsync(limit: 5);

}
catch (ApiException ex) when (ex.Message.Contains("Admin API key"))
{
}
```

### Secrets
```csharp
var client = GetAuthorizedApi();

try
{
    var response = await client.Keys.ListApiKeysAsync(limit: 10);

}
catch (ApiException ex) when (ex.Message.Contains("Admin API key"))
{
}
```
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Fal/issues
Priority place for ideas and general questions: https://github.com/tryAGI/Fal/discussions
Discord: https://discord.gg/Ca2xhfBf3v

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
