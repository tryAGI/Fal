namespace Fal;

public partial class FalClient
{
    // Fal API uses 'Authorization: Key <api_key>' instead of 'Authorization: Bearer <api_key>'.
    // Override the generated Bearer auth to use Key scheme after construction.
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        for (var i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth.Type == "Http" && auth.Name == "Bearer")
            {
                Authorizations[i] = new EndPointAuthorization
                {
                    Type = auth.Type,
                    Location = auth.Location,
                    Name = "Key",
                    Value = auth.Value,
                };
            }
        }
    }
}
