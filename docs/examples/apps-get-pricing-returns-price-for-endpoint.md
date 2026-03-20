# Apps Get Pricing Returns Price For Endpoint



This example assumes `using Fal;` is in scope and `apiKey` contains your Fal API key.

```csharp
var client = GetAuthorizedApi();

var response = await client.Models.GetPricingAsync(
    endpointId: "fal-ai/flux/dev");
```