namespace Fal.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static FalClient GetAuthorizedApi()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("API_KEY") is { Length: > 0 } apiKeyValue ? apiKeyValue :
            Environment.GetEnvironmentVariable("FAL_API_KEY") is { Length: > 0 } falKeyValue ? falKeyValue :
            throw new AssertInconclusiveException("FAL_API_KEY environment variable is not found.");

        var client = new FalClient(apiKey);

        return client;
    }
}
