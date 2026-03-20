# Apps Get Meta Returns Platform Metadata



This example assumes `using Fal;` is in scope and `apiKey` contains your Fal API key.

```csharp
var client = GetAuthorizedApi();

var response = await client.Meta.GetMetaAsync();
```