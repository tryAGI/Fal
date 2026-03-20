# Apps Search Requests Returns Results



This example assumes `using Fal;` is in scope and `apiKey` contains your Fal API key.

```csharp
var client = GetAuthorizedApi();

var response = await client.Models.SearchRequestsAsync(
    limit: 5);
```