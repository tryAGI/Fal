namespace Fal;

public partial class FalClient
{
    // Fal API uses 'Authorization: Key <api_key>' instead of 'Authorization: Bearer <api_key>'.
    // Keep the generated Bearer authorization name for endpoint security matching, then
    // rewrite the outbound header scheme at request time.
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        foreach (var auth in Authorizations)
        {
            if (auth.Type == "Http" && auth.Name == "Bearer")
            {
                client.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Key", auth.Value);
            }
        }
    }

    partial void PrepareRequest(
        System.Net.Http.HttpClient client,
        System.Net.Http.HttpRequestMessage request)
    {
        if (Authorizations.Count >= 0 && request.Headers.Authorization?.Scheme == "Bearer")
        {
            request.Headers.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue(
                    "Key",
                    request.Headers.Authorization.Parameter);
        }
    }
}
