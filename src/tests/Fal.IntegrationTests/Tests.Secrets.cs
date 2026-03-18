namespace Fal.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Secrets_ListApiKeys_ReturnsKeys()
    {
        var client = GetAuthorizedApi();

        var response = await client.Keys.ListApiKeysAsync(
            limit: 10);

        response.Should().NotBeNull();
        response.Keys.Should().NotBeNull();
        response.Keys.Should().NotBeEmpty();
    }

    [TestMethod]
    public async Task Secrets_ListApiKeys_WithCreatorInfoExpand()
    {
        var client = GetAuthorizedApi();

        var response = await client.Keys.ListApiKeysAsync(
            limit: 5,
            expand: "creator_info");

        response.Should().NotBeNull();
        response.Keys.Should().NotBeNull();
    }

    [TestMethod]
    public async Task Secrets_CreateAndDeleteApiKey_Succeeds()
    {
        var client = GetAuthorizedApi();

        // Create a test API key
        var createResponse = await client.Keys.CreateApiKeyAsync(
            alias: "integration-test-key");

        createResponse.Should().NotBeNull();
        createResponse.KeyId.Should().NotBeNullOrEmpty();
        createResponse.KeySecret.Should().NotBeNullOrEmpty();
        createResponse.Key.Should().NotBeNullOrEmpty();

        // Clean up: delete the key we just created
        await client.Keys.DeleteApiKeyAsync(keyId: createResponse.KeyId);
    }
}
