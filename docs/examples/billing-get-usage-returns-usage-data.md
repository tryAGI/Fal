# Billing Get Usage Returns Usage Data



This example assumes `using Fal;` is in scope and `apiKey` contains your Fal API key.

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