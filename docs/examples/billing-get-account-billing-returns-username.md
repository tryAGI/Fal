# Billing Get Account Billing Returns Username



This example assumes `using Fal;` is in scope and `apiKey` contains your Fal API key.

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